using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Part_5
{
    // Define a Circle struct to represent a circle as a value type
    public struct Circle
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    //Shape class to represent a reference type.
    public class Shape
    { 
        public int NoOfSides {  get; set; }

        public Shape(int noOfSides) 
        {
            NoOfSides = noOfSides;
        }
    }
}
