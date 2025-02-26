using System;

namespace ConsoleApp1
{
    public class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int orderId, OrderStatus status)
        {
            OrderId = orderId;
            Status = status;
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderId}, Status: {Status}");
        }
    }
}
