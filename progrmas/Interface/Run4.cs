using System;

namespace ConsoleApp1
{
    public class RunInterface
    {
        public static void Run()
        {
            IPayment payment1 = new CreditCardPayment();
            IPayment payment2 = new PayPalPayment();
            IPayment payment3 = new UpiPayment();

            payment1.MakePayment(1000);
            payment2.MakePayment(500);
            payment3.MakePayment(750);
        }
    }
}
