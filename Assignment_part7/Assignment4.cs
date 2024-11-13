using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part7
{
    // Delegate definition
    public delegate void Notify();
    public class Process
    {
        public event Notify ProcessCompleted; // // Event definition

        public void StartProcess()
        {
            Console.WriteLine("Process started...");
            // Simulating a process by printing numbers from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(500); // Short delay between prints for demonstration
            }
            OnProcessCompleted();  // Trigger the event
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke(); // Raise the event        }
        }
    }
}
