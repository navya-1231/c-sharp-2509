using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    //base class
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal making sounds");
        }
    }
    //derived class 1
    public class Dog : Animal
    {
        public override void MakeSound() 
        {
            Console.WriteLine("Dog making sounds");
        }
        
    }

    //derived class 2
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat making sounds");
        }
    }
}
