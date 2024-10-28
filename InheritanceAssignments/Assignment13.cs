using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Personss
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Personss(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void DisplayInfo() 
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");

        }
    }
    public class Employeess : Personss 
    {
        public Employeess(string name, int age) : base(name, age)
        {
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }

    }
}
