using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmnet
{
    public class MultiplyOperations
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply two integers: " + a*b);
        }

        public void Multiply(int a, int b, int c)
        {
            Console.WriteLine("Multiply three integers: " + a*b*c);
        }
        public void Multiply(double a, double b)
        {
            Console.WriteLine("Multiply two doubles: " + a * b );
        }
        public void Multiply(double a, int b)
        {
            Console.WriteLine("Multiply two doubles: " + a * b);
        }

    }
}
