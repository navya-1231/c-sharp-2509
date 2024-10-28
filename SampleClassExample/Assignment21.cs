using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Banks
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(string name)
        {
            customers.Add(new Customer(name));
        }

        public void AddAccount(string customerName, int accountNumber, double balance)
        {
            var customer = customers.Find(c => c.Name == customerName);
            if (customer != null)
            {
                customer.Accounts.Add(new Account(accountNumber, balance));
            }
        }

        public void DisplayCustomerDetails()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer: " + customer.Name);
                foreach (var account in customer.Accounts)
                {
                    Console.WriteLine($"  Account Number: {account.AccountNumber}, Balance: {account.Balance}");
                }
            }
        }

        public class Customer
        {
            public string Name { get; set; }
            public List<Account> Accounts { get; set; }

            public Customer(string name)
            {
                Name = name;
                Accounts = new List<Account>();
            }
        }

        public class Account
        {
            public int AccountNumber { get; set; }
            public double Balance { get; set; }

            public Account(int accountNumber, double balance)
            {
                AccountNumber = accountNumber;
                Balance = balance;
            }
        }
    }
}
