using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTruck.Main.Dal
{
    public class Sale
    {
        [Key]
        public Guid Id { get; set; }
        public Truck TruckSold { get; set; }
        public string CustomerName { get; set; }
        public double SaleAmount { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
