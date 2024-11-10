using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    //Creating a Custom Attribute Class
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]

    class DeveloperAttributes : Attribute
    { 
        public string Name { get; }
        public string Date { get; }

        public DeveloperAttributes(string name, string date)
        {
            Name = name;
            Date = date;
        }
    }
    //Applying the DeveloperAttribute to the Calculator Class and Add Method

    [DeveloperAttributes("navya", "2024-09-12")]
    class Calculator
    {
        [DeveloperAttributes("saju", "2024-09-16")]

        public int Add(int number1, int number2) 
        {
            return number1 + number2;
        }

    }
}
