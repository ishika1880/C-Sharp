using System;

namespace ConsoleApp1
{
    public class Palindrom
    {
        public static void palindrom(int n)
        {
            int m, sum =0;
            int d=0;

            m =n;
            while(n>0){
                d = n % 10;
                sum = sum*10 +d;
                n = n/10;
            }

            if(sum == m)
            Console.WriteLine($"{m} is a Palindrom number");
            else
            Console.WriteLine($"{m} is not a Palindrom number");
        }
    }
}