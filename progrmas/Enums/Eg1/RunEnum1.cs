using System;

namespace ConsoleApp1
{
    public class RunEnum1
    {
        public static void Run()
        {
            Order order1 = new Order(101, OrderStatus.Pending);
            Order order2 = new Order(102, OrderStatus.Shipped);
            Order order3 = new Order(103, OrderStatus.Delivered);

            order1.DisplayOrderDetails();
            order2.DisplayOrderDetails();
            order3.DisplayOrderDetails();
        }
    }
}
