using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base() { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

    }
}
