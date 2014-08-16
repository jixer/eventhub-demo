using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTruck.Offsite.Dal
{
    public class InventoryItem
    {
        [Key]
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool OnsiteInventory { get; set; }
        public double Msrp { get; set; }
    }
}
