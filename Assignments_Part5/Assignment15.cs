using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Part_5
{
    //File Reading with Exception Handling: 
    public class FileProcessor
    {
        public void ReadFileContent(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found: " + filePath);
            }
        }
    }

    //Math Operation with Exception Handling:
    public class MathOperations
    {
        public double Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                return double.NaN; // Return NaN to indicate an invalid result
            }
        }
    }

    //Custom Exception for Age Validation: 


    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { } //calls the constructor of the base class (Exception) and passes the custom message to it.

    }

    public class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public void SetAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException("Invalid age provided");
            }
            Age = age;
        }
    }



}
