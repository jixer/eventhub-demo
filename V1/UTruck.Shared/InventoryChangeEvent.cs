using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTruck.Shared
{
    public class InventoryChangeEvent
    {
        public InventoryChangeType ChangeType { get; set; }
        public InventoryTruck Truck { get; set; }
    }
}
