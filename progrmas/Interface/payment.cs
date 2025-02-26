using System;

namespace ConsoleApp1
{
    public interface IPayment
    {
        void MakePayment(double amount);
    }

    public class CreditCardPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment of ${amount} made using Credit Card.");
        }
    }
}