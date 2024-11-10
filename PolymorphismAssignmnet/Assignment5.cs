using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmnet
{
    public class Employee
    {
        private static int EmployeeCount=0;

        public Employee() 
        {
            EmployeeCount++;
        }
        public static void DisplayEmployeeCount()
        {
            Console.WriteLine($"Total number of employees: {EmployeeCount}");
        }
        public  virtual void Work() 
        {
            Console.WriteLine("Employee is working");
        }
    }
    public class Manager:Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is working");
        }

    }
    public class Developer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Developer is working");
        }
    }
}
