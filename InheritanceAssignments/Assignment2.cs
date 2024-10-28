using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
    public class Dog : Animal 
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }

    }
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Puppy is weeping.");
        }
    }
}
