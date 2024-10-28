using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name,int age) {
            Name = name;
            Age = age;
        }
    }
    public class Student : Person
    {

        public string Grade;
        public Student(string name, int age,string grade) : base(name, age)
        {
            Grade=grade;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age},Grade: {Grade}");
            
        }
    }
}
