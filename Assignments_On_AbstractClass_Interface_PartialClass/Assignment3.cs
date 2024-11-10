using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    //interface IDrive with a method Drive()
    interface IDrive 
    {
        void Drive();
    }
    //derived class car
    public class Cars : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }
    //derived class truck
    public class Truck : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Truck is driving");
        }
    }
}
