using System;
using System.Collections.Generic;

class ListExample
{
    public static void Run()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        fruits.Remove("Banana");

        Console.WriteLine("Fruits List:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(fruits.Contains("Apple") ? "Apple is in the list." : "Apple is not in the list.");
    }
}
