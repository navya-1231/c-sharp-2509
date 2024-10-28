using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Account
    {
        public int AccountNumber {  get; set; }
        public string Name { get; set; }

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Insufficient Balance");
                }
                balance = value;
            }
        }
        public Account(int accountNumber,string name) { 
            AccountNumber = accountNumber;
            Name = name;
            balance = 0;

        }
        public void Deposit(decimal Amount) { 
            if (Amount > 0)
            {
                Balance += Amount;
                Console.WriteLine($"Account Number: {AccountNumber} \nName:{Name} \nDeposit Amount: {Amount} \nAvailable Balance:{Balance}\n");
            }
            
        }
        public void Withdraw(decimal Amount)
        {
            if (Amount <= Balance) {
                Balance -= Amount;
                Console.WriteLine($"Account Number: {AccountNumber} \nName:{Name}\n Withdraw Amount: {Amount} \nAvailable Balance:{Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount");
            }
            
        }


    }
}
