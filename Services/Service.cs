using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entity;

namespace Services
{
    public class Service
    {
        private DbContext context;

        public Service(DbContext ctx) { context = ctx; }


        public void AddCategory(Category category)
        {
            if (category == null) throw new ArgumentNullException();
            context.Set<Category>().Add(category);
            context.SaveChanges();
        }
        public void DeleteCategory(Category category)
        {
            if (category == null) throw new ArgumentNullException();
            if (context.Set<Category>().Find(category) == null) throw new InvalidOperationException();

            context.Set<Category>().Remove(category);
            context.SaveChanges();
        }
        public IEnumerable<Category> GetAllCategories() => context.Set<Category>();


        public void AddOrder(Order order)
        {
            if (order == null) throw new ArgumentNullException();
            context.Set<Order>().Add(order);
            context.SaveChanges();
        }



        public void AddProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException();
            context.Set<Product>().Add(product);
            context.SaveChanges();
        }
        public void DeleteProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException();
            if (context.Set<Product>().Find(product) == null) throw new InvalidOperationException();

            context.Set<Product>().Remove(product);
            context.SaveChanges();
        }
        public void ChangePrice(Product product,decimal price)
        {
            if (product == null) throw new ArgumentNullException();
            if (context.Set<Product>().Find(product) == null) throw new InvalidOperationException();
            if (price < 0) throw new ArgumentException();

            context.Set<Product>().FirstOrDefault(x => x.ProductID == product.ProductID).Price = price;
            context.SaveChanges();
        }
        public IEnumerable<Product> GetAllProduct() => context.Set<Product>();



        public void AddPurchase(Purchase purchase)
        {
            if (purchase == null) throw new ArgumentNullException();
            context.Set<Purchase>().Add(purchase);
            context.SaveChanges();
        }
        public void AddOrdersToPurchase(Purchase purchase, params Order[] orders)
        {
            if (purchase == null) throw new ArgumentNullException();
            if (orders == null) throw new ArgumentNullException();
            if (context.Set<Purchase>().Find(purchase) == null) throw new InvalidOperationException();

            context.Set<Order>().AddRange(orders);
            foreach (var t in orders)
            {
                t.Purchase = purchase;
            }

            context.SaveChanges();
        }
        public IEnumerable<Purchase> GetAllPurchases() => context.Set<Purchase>();
    }
}
