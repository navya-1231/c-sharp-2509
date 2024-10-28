using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Rectangle
    {
        public void CalculateArea(int height,int width)
        {
            Console.WriteLine( "Area of Rectangle "+height * width);
        }
        public void CalculateArea(int side)
        {
            Console.WriteLine("Area of Square "+side * side);
        }
    }
}
