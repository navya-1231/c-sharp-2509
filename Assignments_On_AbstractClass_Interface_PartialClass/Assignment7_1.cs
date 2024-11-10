using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    //partial class with property Name
    partial class PartialClass
    {
        public string Name { get; set; }

        public PartialClass(string name) 
        { 
            Name = name;
        }
    }
}

