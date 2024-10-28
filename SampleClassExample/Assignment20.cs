using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(string name, double price, int quantity)
        {
            products.Add(new Product(name, price, quantity));
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price * product.Quantity;
            }
            return total;
        }

        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }
    }

}
