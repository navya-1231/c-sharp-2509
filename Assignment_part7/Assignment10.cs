using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part7
{
    public class Calculations
    {
        // Define a delegate that takes two integers and returns an integer
        public delegate int CalculationDelegate(int x, int y);

        // Method for addition
        public int Addition(int x, int y)
        {
            return x + y;
        }

        // Method for subtraction
        public int Subtraction(int x, int y)
        {
            return x - y;
        }

        // Method that accepts two integers and a delegate to perform the calculation
        public int Calculate(int a, int b, CalculationDelegate operation)
        {
            return operation(a, b); // Invoke the delegate with the provided integers
        }
    }
}
