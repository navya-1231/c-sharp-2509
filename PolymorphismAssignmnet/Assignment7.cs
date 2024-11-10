using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmnet
{
    //early binding(compile-time polymorphism) using method overloading

    public class Calculation
    {
        public void Add(int a,int b) 
        {
            Console.WriteLine("result "+a+b);
        }
        public void Add(int a, int b,int c)
        {
            Console.WriteLine("result " + a + b + c);
        }
    }
    //late binding(runtime polymorphism) using method overriding.
    public class Animal
    {
        public virtual void Sound() 
        {
            Console.WriteLine("Animal making sounds");
        }
    }
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}