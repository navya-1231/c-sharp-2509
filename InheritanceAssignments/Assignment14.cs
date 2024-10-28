using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Personn
    {
        public string Name { get; set; }
        public Personn(string name)
        {
            Name = name;
        }
    }

    public class Students : Personn
    {
        public new string Name {  get; set; }
        public Students(string name):base(name) 
        {
            base.Name = name;
        }

        public void ShowNames()
        {
            Console.WriteLine("Base Name: " + base.Name);
            Console.WriteLine("Derived Name: " + Name);
        }
    }

}
