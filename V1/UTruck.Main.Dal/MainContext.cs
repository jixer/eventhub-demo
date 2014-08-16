using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTruck.Main.Dal
{
    public class MainContext : DbContext
    {
        public MainContext()
            : base("MainDb")
        {
        }

        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<InventoryItem> Inventory { get; set; }
    }
}
