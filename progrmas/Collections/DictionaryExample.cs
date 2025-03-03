using System;
using System.Collections.Generic;

class DictionaryExample
{
    public static void Run()
    {
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };

        Console.WriteLine("Student with ID 2: " + students[2]);
        students.Remove(1);

        Console.WriteLine("Student List:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }
    }
}
