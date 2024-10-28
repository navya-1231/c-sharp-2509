using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Time
    {
        public void CalculateTime(int hours,int minutes)
        {
            if (minutes >= 60)
            {
                hours += minutes / 60;
                minutes = minutes % 60;

            }
            
            Console.WriteLine($"Time:{hours:D2}:{minutes:D2}:00");
        }
        public void CalculateTime(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int RemainingSeconds = seconds % 60;
            Console.WriteLine($"Time:{hours:D2}:{minutes:D2}:{RemainingSeconds:D2}");
        }
    }
}
