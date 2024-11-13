using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part7
{
    public class CalculatorTask
    {
        // Asynchronous method to calculate the sum of an integer array
        public static async Task<int> Sum(int[] numbers)
        {
            return await Task.Run(() =>
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                return sum;
            });
        }
    }
}
