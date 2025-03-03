using System;
using System.Collections.Generic;

class QueueExample
{
    public static void Run()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Alice");
        queue.Enqueue("Bob");
        queue.Enqueue("Charlie");

        Console.WriteLine("Dequeued: " + queue.Dequeue());
        Console.WriteLine("Next in line: " + queue.Peek());

        Console.WriteLine("Remaining in Queue:");
        foreach (var person in queue)
        {
            Console.WriteLine(person);
        }
    }
}
