using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class produto
    {
        public long Sku { get; set; }
        public string Name { get; set; }
        public inventory Inventory { get; set; }
    }
}
