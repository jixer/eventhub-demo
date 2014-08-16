using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTruck.Shared;

namespace UTruck.Main.SalesApp
{
    public class EventSender
    {
        private EventHubSender _sender;
        public EventHubSender Sender 
        { 
            get
            {
                if (_sender == null)
                    _sender = CreatePartitionedSender();
                return _sender;
            }
        }

        public void SendData(InventoryTruck item)
        {
            // overload
            SendData(Sender, item);
        }

        private static EventHubSender CreatePartitionedSender()
        {
            // EventHubClient model (uses implicit factory instance, so all links on same connection)
            EventHubClient eventHubClient = EventHubClient.Create("contoso-trucks");

            // return sender for partition '1'
            return eventHubClient.CreatePartitionedSender("1");
        }

        private static void SendData(EventHubSender partitionedSender, InventoryTruck item)
        {
            // create the change event
            var changeEvent = new InventoryChangeEvent() { ChangeType = InventoryChangeType.Refresh, Truck = item };

            // create a memory stream with the XML serialized data and use to create event data object
            var strm = SerializationHelper.SerializeToMemoryStream(changeEvent);
            EventData data = new EventData(strm);

            // send event data to Event Hub
            partitionedSender.Send(data);
        }
    }
}
