using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class PrintClass
    {

        //method overloading, multiple methods can have the same name with different parameters:
        public void Display(string Name) 
        { 
            Console.WriteLine(Name);
        }
        public void Display(int age) 
        {
            Console.WriteLine(age);
        
        }
        public void Display(int[] array) 
        {
            foreach (int i in array) 
            {
                Console.Write(i+" ");
            }
        }
    }
}
