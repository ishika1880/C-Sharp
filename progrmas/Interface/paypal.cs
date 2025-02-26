using System;
namespace ConsoleApp1{
    public class PayPalPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment of ${amount} made using PayPal.");
        }
    }
}