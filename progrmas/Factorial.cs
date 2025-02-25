using System;

namespace ConsoleApp1
{
    class Factorial{
       internal static long factorial(int n)
    {
        return (n == 0 || n == 1) ? 1 : n * factorial(n - 1);
    }

    }
}

