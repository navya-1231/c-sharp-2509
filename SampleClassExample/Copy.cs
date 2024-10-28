using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SampleClassExample
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name,int age)
        {
            Name = name;    
            Age = age;
        }
        //copy constructor
        public Person(Person TestPerson) 
        {
            Name = TestPerson.Name;
            Age = TestPerson.Age;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name},Age: {Age}");
        }
    }
}
