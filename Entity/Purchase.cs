using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Purchase
    {
        public int PurchaseID { get; set; }

        public List<Order> Orders { get; set; }
    }
}
