using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Productss
    {
        // Properties
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        // 1. Constructor initialization
        public Productss(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        // 6. Default values in constructors
        public Productss()
        {
            Name = "Default Product";
            Price = 10.0;
            Category = "General";
        }

        // 3. Static factory method
        public static Productss CreateProduct(string name, double price, string category)
        {
            return new Productss(name, price, category);
        }

        // Method to display product details
        public void DisplayProduct()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price:C}, Category: {Category}");
        }
    }
}
