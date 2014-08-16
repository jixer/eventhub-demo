using AutoMapper;
using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UTruck.Offsite.Dal;
using UTruck.Shared;

namespace UTruck.Offsite.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialization
            SiteState state = StateManager.LoadState();
            Mapper.CreateMap<InventoryTruck, InventoryItem>();

            // obtain the consumer
            EventHubReceiver receiver = GetEventHubReceiver(state);                
                

            bool continueProcessing = true;
            while (continueProcessing)
            {
                // retreive a batch of data
                var data = receiver.Receive(10, TimeSpan.FromSeconds(10));

                // iterate through events
                foreach (EventData item in data)
                {
                    // deserialize the InventoryChangeEvent from the message body
                    var bodyStream = item.GetBodyStream();
                    InventoryChangeEvent changeEvent = SerializationHelper.TryExtractInventoryChangedEvent(bodyStream);

                    // verify that deserialization was successful
                    if (changeEvent != null)
                    {
                        // update inventory depending on type of change
                        if (changeEvent.ChangeType == InventoryChangeType.Refresh)
                        {
                            var mergeTruck = Mapper.Map<InventoryItem>(changeEvent.Truck);
                            MergeInventory(mergeTruck);
                            Console.WriteLine("Merged 1 truck into inventory");
                        }
                        else if (changeEvent.ChangeType == InventoryChangeType.Sold)
                        {
                            RemoveInventory(changeEvent.Truck.Id);
                            Console.WriteLine("Removed 1 truck into inventory");
                        }
                    }

                    // update the saved state with the new offset
                    state.Offset = item.Offset;
                }

                // save state on each round
                StateManager.WriteState(state);

                // management of the console host
                Console.WriteLine("Press any key to continue or 'q' to quit...");
                var keyPress = Console.ReadKey(false);
                continueProcessing = keyPress.KeyChar != 'q';
            }
        }

        private static EventHubReceiver GetEventHubReceiver(SiteState state)
        {
            // Create the EventHubClient and retrieve the default consumer group
            EventHubClient eventHubClient = EventHubClient.Create("contoso-trucks");
            EventHubConsumerGroup defaultConsumberGroup = eventHubClient.GetDefaultConsumerGroup();
            
            // if state ontains an offset, then use it; otherwise use the default (beginning of stream)
            if (string.IsNullOrEmpty(state.Offset))
                return defaultConsumberGroup.CreateReceiver("1");
            else
                return defaultConsumberGroup.CreateReceiver("1", state.Offset);
        }

        private static void RemoveInventory(Guid truckId)
        {
            using (var ctx = new OffsiteContext())
            {
                // if truck is found then remove it; otherwise, nothing to see here
                var truckInventory = ctx.Inventory.Where(x => x.Id == truckId).FirstOrDefault();
                if (truckInventory != null)
                {
                    ctx.Inventory.Remove(truckInventory);
                    ctx.SaveChanges();
                }
            }
        }

        private static void MergeInventory(InventoryItem mergeTruck)
        {
            using (var context = new OffsiteContext())
            {
                // if truck already exists, then perform an update
                if (context.Inventory.Any(x => x.Id == mergeTruck.Id))
                {
                    context.Inventory.Attach(mergeTruck);
                }
                // otherwise, insert the new truck
                else
                {
                    context.Inventory.Add(mergeTruck);
                }
                context.SaveChanges();
            }
        }
    }
}
