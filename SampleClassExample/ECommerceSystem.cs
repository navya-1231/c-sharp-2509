using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Product
    {
        public string Name { get; set; }
        private int price;
        private int stock;

        public int Price
        {
            get { return price; }
            set {
                if (value < 0) {
                    throw new ArgumentException(" price cannot be negative");
                }
                price = value;
            }
        }
        public int Stock
        {
            get { return stock; }
            set {
                if (value < 0) {
                    throw new ArgumentException(" price cannot be negative");
                }
                stock = value;
            }
        }
        public Product(string name, int price, int stock) {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void PrintProductDetails()
        {
            Console.WriteLine($"Product Name: {Name}, Price: {Price}, Stock: {Stock}  ");
           
        }

        public void ReduceStock(int quantity) {
            if (quantity <= Stock)
            {
                Stock -= quantity;
            }
            else {
                Console.WriteLine("Quantity is more than stock");
            }
        }
    }
    public class Order
    {

        public List<(Product,int)> Orders = new List<(Product,int)>();

        public void AddOrder(Product product,int quantity)
        {
            product.ReduceStock(quantity);
            Orders.Add((product,quantity));

        }
        public void PrintOrderDetails()
        {
            foreach (var (product,quantity) in Orders)
            {
                Console.WriteLine($"Product: {product.Name}, Quantity: {quantity}");
            }
        }

    }
}
