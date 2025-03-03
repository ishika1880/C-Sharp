using System;
using System.Collections.Generic;

class LinkedListExample
{
    public static void Run()
    {
        LinkedList<string> names = new LinkedList<string>();
        names.AddLast("Alice");
        names.AddLast("Bob");
        names.AddLast("Charlie");
        names.AddFirst("Zara");

        LinkedListNode<string> node = names.Find("Alice");
        if (node != null)
        {
            names.AddAfter(node, "David");
            names.AddBefore(node, "Eve");
        }

        names.Remove("Charlie");
        names.RemoveFirst();
        names.RemoveLast();

        Console.WriteLine("LinkedList Elements (Forward):");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("LinkedList Elements (Reverse):");
        for (LinkedListNode<string> revNode = names.Last; revNode != null; revNode = revNode.Previous)
        {
            Console.WriteLine(revNode.Value);
        }
    }
}
