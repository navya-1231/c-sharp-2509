using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Part_5
{
    public class CustomNumberException : Exception
    {
        public CustomNumberException(string message) {
            Console.WriteLine(message);
        }
    }
    public class NumberChecker { 
        public void CheckNumber(int number) 
        {
            if (number < 0) { 
                throw new CustomNumberException("number should not be negative");
            }
            Console.WriteLine("number is valid");
        }
    }
}
