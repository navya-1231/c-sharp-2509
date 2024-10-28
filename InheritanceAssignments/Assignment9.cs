using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Persons
    {
        public string Name;

        public Persons(string name)
        {
            Name = name;
            
        }
        
    }
    public class Employees : Persons
    {
        public int EmployeeId;
        public Employees(string name, int employeeId) : base(name) 
        {
            EmployeeId = employeeId;
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"EmployeeId: {EmployeeId}");
        }
    }
}
