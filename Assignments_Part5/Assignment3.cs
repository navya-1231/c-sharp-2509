using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Part_5
{
    //define enum
    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered
    }

    //Define an Order class with an OrderStatus property
    public class Orders
    { 
        public OrderStatus Status { get; set; }
        public int OrderId { get; set; }

        public Orders(int orderId, OrderStatus status) 
        { 
            OrderId = orderId;
            Status = status;
        }
        public static void Display(Orders order)
        {
            Console.WriteLine($"Order ID: {order.OrderId}");

            switch (order.Status) 
            
            { 
                case OrderStatus.Pending:
                    Console.WriteLine("Status:Pending");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("Status:Delivered");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine("Status:Shipped");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
        }
    }
}
