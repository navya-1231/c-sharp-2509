using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<double> Grades= new List<double>();

        public Student(string name, int id)
        {
            Name = name;
            ID = id;
           
        }

        public void AddGrade(double grade)
        {
            if (grade > 0 || grade<=100) {
                Grades.Add(grade);
            }
            
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
            {
                Console.WriteLine("No grades available.");
               
            }

            double sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }

            return sum / Grades.Count;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}, ID: {ID}, ");
            foreach (var grade in Grades)
            {
               Console.WriteLine("Mark "+grade.ToString());
            }
            Console.WriteLine($"Average Grade: {CalculateAverageGrade():F2}");

        }
    }
}

