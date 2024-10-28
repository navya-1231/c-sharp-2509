﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }
    public class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is working");
        }
    }

}
