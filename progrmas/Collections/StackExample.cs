using System;
using System.Collections.Generic;

class StackExample
{
    public static void Run()
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("Alice");
        stack.Push("Bob");
        stack.Push("Charlie");

        Console.WriteLine("Popped: " + stack.Pop());
        Console.WriteLine("Top of Stack: " + stack.Peek());

        Console.WriteLine("Remaining in Stack:");
        foreach (var person in stack)
        {
            Console.WriteLine(person);
        }
    }
}
