using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    //static class MathOperations with a static method Add() and Multiply()
    public static class MathOperations 
    {
        public static void Add (int a, int b)
        {
            Console.WriteLine ($"Addition result { a + b}");
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiplication result {a * b}");
        }
    }
}
