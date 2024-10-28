using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class CarClass
    {
        public string Make;
        public string Model;
        public int Year;
        public int Price;

        public CarClass(string make)
        {
            Make = make;
            //Console.WriteLine($"A constructor that initializes only the make.");
        }
        public CarClass(string make,string model):this(make)
        {
            Model = model;
            //Console.WriteLine($"A constructor that initializes make and model.");
        }
        public CarClass(string make, string model,int year) : this(make,model)
        {
            Year = year;
            //Console.WriteLine("A constructor that initializes make, model, and year. ");
        }
        public CarClass(string make,string model,int year,int price) : this(make, model,year)
        {
            Price = price;
            //Console.WriteLine("A constructor that initializes all fields: make, model, year, and price.");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}");
        }


    }
}
