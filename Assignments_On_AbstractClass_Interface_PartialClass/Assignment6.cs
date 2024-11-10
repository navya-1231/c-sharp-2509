using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    public static class ExtensionMethod
    {
        // Extension method for int type to check if it's even
        public static bool IsEven(this int number) 
        {
            return number % 2 == 0;
        }
    }
}
