using System;
namespace ConsoleApp1{
    public class UpiPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment of ${amount} made using UPI.");
        }
    }
}