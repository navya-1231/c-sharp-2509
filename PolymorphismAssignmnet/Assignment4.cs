using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmnet
{
    public class Payment 
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Method inside Payment class");
        }
    }
    public class CreditCardPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Method inside CreditCardPayment class");
        }
    }
    public class PayPalPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Method inside PayPalPayment class");
        }
    }
}
