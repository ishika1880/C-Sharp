using System;

namespace ConsoleApp1
{
    public class Amstrong
    {
        public static void amstrong(int n)
        {
            int m = n, sum = 0;
            int digits = n.ToString().Length;

            while (m > 0)
            {
                int d = (int)(m % 10);
                sum += (int)Math.Pow(d, digits);
                m /= 10;
            }

            if (sum == n)
                Console.WriteLine($"{n} is an Armstrong number");
            else
                Console.WriteLine($"{n} is not an Armstrong number");
        }
    }
}
