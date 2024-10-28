using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public abstract class Vehicles
    { 
        public abstract void Drive();
    }
    public class Car : Vehicles
    {
        public override void Drive()
        {
            Console.WriteLine("Inside Car class");
        }
    }
    public class Bike : Vehicles
    {
        public override void Drive()
        {
            Console.WriteLine("Inside Bike class.");
        }
    }
}
