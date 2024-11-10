using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    //partial class with method ShowDetails()
    partial class PartialClass
    {
        public void ShowDetails() 
        {
            Console.WriteLine("Name: " + Name);
        }
    }
}
