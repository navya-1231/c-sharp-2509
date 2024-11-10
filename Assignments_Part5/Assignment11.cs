using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Part_5
{
    class Validator
    {
        public static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentOutOfRangeException( "Age must be at least 18.");
            }
        }
    }
}
