using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CoadFirstDemoProg
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext Context = new ProductDBContext();
            var product = Context.Products;

            var Product1 = product.Add(new Product()
            {
                ProductID = 1,
                Name = "BadamMilk",
                Price = 99.99,
                Quantity = "500 ml",
                CategoryID = 1
            });

            var Product2 = product.Add(new Product()
            {
                ProductID = 2,
                Name = "Coffee Drinks",
                Price = 59.99,
                Quantity = "250 ml",
                CategoryID = 1
            });

            var Product3 = product.Add(new Product()
            {
                ProductID = 3,
                Name = "Cool Drinks",
                Price = 199.99,
                Quantity = "500 ml",
                CategoryID = 1
            });

            var Product4 = product.Add(new Product()
            {
                ProductID = 4,
                Name = " Drinks",
                Price = 19.99,
                Quantity = "500 ml",
                CategoryID = 1
            });
            Context.SaveChanges();
        }
    }

    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("name=ProductDBContext")
        { }

        public DbSet<Product> Products { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        public int CategoryID { get; set; }

        public class Category
        {
            public int CategoryID { get; set; }
            public string Name { set; get; }
        }

    }
}
