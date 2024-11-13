using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part7
{
   public class StringOperation
    {
        // Convert the string to uppercase
        public string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        // Reverse the string
        public string ReverseString(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        // Add a prefix to the string
        public string AddPrefix(string input)
        {
            return "Miss. " + input;
        }
    }
}
