using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part7
{
    public class Calculator
    {
        //Defining the Delegate
        public delegate void CalculatorDelegate(double x, double y);

        public static void Addition(double number1, double number2)
        {
            double result = number1 + number2;
            Console.WriteLine($"Result: {result}");
        }

        public static void Substraction(double number1, double number2)
        {
            double result = number1 - number2;
            Console.WriteLine($"Result: {result}");
        }

        public static void Multiplication(double number1, double number2)
        {
            double result = number1 * number2;
            Console.WriteLine($"Result: {result}");
        }

        public static void Division(double number1, double number2)
        {
            if (number2 != 0)
            {
                double result = number1 / number2;
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero.");
            }
        }
    }
}
