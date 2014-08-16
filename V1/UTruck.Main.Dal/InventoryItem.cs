using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTruck.Main.Dal
{
    public class InventoryItem
    {
        [Key]
        public Guid Id { get; set; }

        public Truck AvailableTruck { get; set; }
    }
}
