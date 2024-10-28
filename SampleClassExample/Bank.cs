using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Bank
    {
        public static double InterestRate;
        private double balance;

        //static constructor to initialize interest rate
        static Bank() 
        {
            InterestRate = 4.5;
            Console.WriteLine("Interest rate initialized.");

        }

        // constructor for balance 
        public Bank(double initialBalance)
        {
            balance = initialBalance;
            Console.WriteLine($"Balance Initialized to {balance}");
        }
        public void DisplayInfo() 
        {
            Console.WriteLine($"Account Balance:{balance}, Interest rate:{InterestRate}");
        
        }
    }
}
