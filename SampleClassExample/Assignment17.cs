using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    class Products
    {
        private string name;
        private decimal price;
        private decimal discount;

        // Constructor that initializes only the name
        public Products(string name)
        {
            this.name = name;
            this.price = 0;
            this.discount = 0;
        }

        // Constructor that initializes name and price
        public Products(string name, decimal price)
        {
            this.name = name;
            this.price = price;
            this.discount = 0;
        }

        // Constructor that initializes name, price, and discount
        public Products(string name, decimal price, decimal discount)
        {
            this.name = name;
            this.price = price;
            this.discount = discount;
        }

        // Method to calculate the final price after applying discount
        public decimal CalculateFinalPrice()
        {
            decimal finalPrice = price - (price * (discount / 100));
            return finalPrice;
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Price: {price:C}");
            Console.WriteLine($"Discount: {discount}%");
            Console.WriteLine($"Final Price: {CalculateFinalPrice():C}");
            Console.WriteLine();
        }
    }
}
