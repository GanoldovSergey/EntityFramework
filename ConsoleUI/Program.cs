using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Entity;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ProductContext())
            {
                Product products = new Product() { Name = "Apple" };

                ctx.Products.Add(products);
                ctx.SaveChanges();
            }
        }
    }
}
