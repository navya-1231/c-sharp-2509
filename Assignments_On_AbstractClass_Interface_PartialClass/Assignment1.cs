using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    //abstract class Vehicle 
    public abstract class Vehicle
    {
        //abstract method StartEngine()
        public abstract void StartEngine();

        //concrete method   StopEngine().
        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    //derived classes Car 
    public class Car : Vehicle
    {
        //overriding startEngine() method
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }
    }

    //derived classes  Motorcycle
    public class Motorcycle : Vehicle
    {
        //overriding startEngine() method
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started.");
        }
    }
}
