using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Car
    {
        private static int carCount;

        //Initialize counter using a static constructor. 
        static Car() 
        { 
            carCount = 0;   
        }
        //constructor to increment the car count
        public Car() 
        {
            carCount++;
        }
        public static int ShowCount()
        {
            return carCount;
        }
    }
}
