using AutoMapper;
using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using UTruck.Main.Dal;
using UTruck.Shared;

namespace UTruck.Main.SalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var mapper = Mapper.CreateMap<Truck, InventoryTruck>();
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            var truck = new Truck()
            {
                Id = Guid.Parse(txtNewTruckId.Text),
                Make = txtNewTruckMake.Text,
                Model = txtNewTruckModel.Text,
                Year = int.Parse(txtNewTruckYear.Text),
                Msrp = double.Parse(txtNewTruckMsrp.Text)
            };
            var inventoryItem = new InventoryItem()
            {
                Id = Guid.NewGuid(),
                AvailableTruck = truck
            };
            using (var ctx = new MainContext())
            {
                ctx.Trucks.Add(truck);
                ctx.Inventory.Add(inventoryItem);
                ctx.SaveChanges();
            }

            var convertedTruck = Mapper.Map<InventoryTruck>(truck);
            var eventSender = new EventSender();
            eventSender.SendData(convertedTruck);
        }

        private void btnGenerateGuid_Click(object sender, EventArgs e)
        {
            txtNewTruckId.Text = Guid.NewGuid().ToString();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Guid truckGuid = Guid.Parse(txtTruckId.Text);
            Truck soldTruck;
            using (var ctx = new MainContext())
            {
                var inventoryQuery = ctx.Inventory.Where(x => x.AvailableTruck.Id == truckGuid);
                var inventoryItem = inventoryQuery.FirstOrDefault();
                soldTruck = inventoryQuery.Select(x => x.AvailableTruck).FirstOrDefault();
                if (inventoryItem != null && soldTruck != null)
                {
                    var sale = new Sale()
                    {
                        Id = Guid.NewGuid(),
                        CustomerName = txtName.Text,
                        SaleAmount = double.Parse(txtAmount.Text),
                        SaleDate = DateTime.Now,
                        TruckSold = soldTruck
                    };
                    ctx.Sales.Add(sale);
                    ctx.Inventory.Remove(inventoryItem);
                }
            }

            var convertedTruck = Mapper.Map<InventoryTruck>(soldTruck);
            var eventSender = new EventSender();
            eventSender.SendData(convertedTruck);
        }
    }
}
