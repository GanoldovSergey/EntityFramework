using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Order
    {
        public int OrderID { get; set; }
        public int Count { get; set; }

        public Product Product { get; set; }
        public Purchase Purchase { get; set; }
    }
}
