using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    //q2
    public class Employee
    {
        private string Name;
        private int Salary;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int salary
        {
            get { return Salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("salary cannot be negative");
                }
                Salary = value;
            }
        }
    }
}
