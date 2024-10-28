using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public interface IDriveable
    {
        void Drive();
    }
    public interface IRaceable : IDriveable
    {
        void Race();
    }
    public class Cars : IRaceable
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }

        public void Race()
        {
            Console.WriteLine("Car is racing");
        }
    }
    
}
