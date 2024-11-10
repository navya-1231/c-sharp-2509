using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    //abstract class Bird
    public abstract class Bird
    {
        //abstract method Fly()
        public abstract void Fly();

        //contain non-abstract method
        public void Eat()
        {
            Console.WriteLine("The bird is eating.");
        }
    }
    //interface ISwim with a  method Swim(). 
    interface ISwim 
    {
        void Swim();
    }

    //Derived class
    public class Parrot : Bird, ISwim
    {
        public override void Fly()
        {
            Console.WriteLine("Parrot is flying");
        }

        public void Swim()
        {
            Console.WriteLine("Parrot can't swim");
        }
    }
}
