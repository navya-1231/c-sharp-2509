using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    partial class Employee
    {
        public int salaryPerHour { get; set; }
        public int TotalHour { get; set; }

        //partial method declaration
        partial void CalculateSalary();
    }

    partial class Employee
    {
        //partial method implementation
        partial void CalculateSalary()
        {
            int salary = salaryPerHour * TotalHour;
            Console.WriteLine($"Total Salary: {salary}");
            
        }
        public void Display() 
        {
            CalculateSalary();
        }
    }
}
