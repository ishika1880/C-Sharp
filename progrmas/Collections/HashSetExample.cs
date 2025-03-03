using System;
using System.Collections.Generic;

class HashSetExample
{
    public static void Run()
    {
        HashSet<int> numbers = new HashSet<int> { 10, 20, 30, 10 };

        Console.WriteLine("Does 20 exist? " + numbers.Contains(20));

        Console.WriteLine("Numbers in HashSet:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
