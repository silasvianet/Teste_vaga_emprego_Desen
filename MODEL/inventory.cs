using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   public class inventory
    {
        public int Quantity { get; set; }
        public List<warehouses> Warehouses { get; set; }
        public bool isMarketable { get; set; }
    }
}
