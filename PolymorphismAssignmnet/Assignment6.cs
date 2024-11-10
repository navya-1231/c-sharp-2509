using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmnet
{
    public class Employees
    {
        public String[] Task;

        public Employees(string[] task)
        {
            Task = task;
        }
        public virtual void ShowTask()
        {
            Console.WriteLine("Employee Task");
            foreach (var item in Task) 
            {
                Console.WriteLine(item);
            }
        }


    }
    public class Managers : Employees
    {

        public Managers(string[] task) : base(task) {  }
        public override void ShowTask()
        {
            Console.WriteLine("Manager Task");
            foreach (var item in Task)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Developers : Employees
    {
        public Developers(string[] task) : base(task)
        {

        }

        public override void ShowTask()
        {
            Console.WriteLine("Developer Task");
            foreach (var item in Task)
            {
                Console.WriteLine(item);
            }
        }
    }
}
