using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTruck.Offsite.Dal
{
    public class OffsiteContext : DbContext
    {
        public OffsiteContext()
            : base("InventoryDb")
        {

        }

        public DbSet<InventoryItem> Inventory { get; set; }
    }
}
