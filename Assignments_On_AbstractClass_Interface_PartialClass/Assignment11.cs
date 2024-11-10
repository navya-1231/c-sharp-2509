using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    //enum for car types
    public enum CarType 
    {
        Sedan, 
        SUV, 
        Truck,
        Coupe
    }
    public class Carss
    {
        public CarType Type { get; set; }
        public Carss(CarType type)
        {
            Type = type;
        }
        // Method to display a specific message based on the car's type
        public void Display(CarType type) 
        {
            switch (Type) 
            { 
                case CarType.Sedan:
                    Console.WriteLine("Car model is sedan");
                    break;

                case CarType.SUV:
                    Console.WriteLine("Car model is SUV");
                    break;

                case CarType.Truck:
                    Console.WriteLine("Car model is truck");
                    break;

                case CarType.Coupe:
                    Console.WriteLine("Car model is coupe");
                    break;
                 default:
                    Console.WriteLine("unknown");
                    break;
            }
        }

    }
}
