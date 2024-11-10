using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Part_5
{
    public class Divide
    {
        public void PerformDivision() 
        {
            int numerator = 0;
            int denominator = 0;
            try
            {
                Console.WriteLine("Enter the numerator:");
                numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the denominator:");
                denominator = Convert.ToInt32(Console.ReadLine());

                int result=numerator / denominator;

                Console.WriteLine(result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter valid integers. " + ex.Message);
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed. " + ex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
                Console.ReadLine();
            }

        }
    }
}
