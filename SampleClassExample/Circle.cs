using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    //q1
    public class Circle
    {
        private int radius;
        public int Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("radius cannot be negative");
                }
                radius = value;
            }
        }
    }




}
