using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part7
{
    public class Async
    {
        public async static void AsyncMethod() 
        {
            Console.WriteLine("Async method start");
            await Task.Delay(1000);

            Console.WriteLine("Async method end");
        }
    }
}
