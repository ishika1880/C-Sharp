// See https://aka.ms/new-console-template for more information
using System;
//using static ConsoleApp1.Palindrom;
using static ConsoleApp1.Factorial;
using static ConsoleApp1.Guess;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a no.");
            int n = Convert.ToInt32(Console.ReadLine());
            Palindrom.palindrom(n);
            Amstrong.amstrong(n);

            Console.WriteLine("Enter a number to calculate the factorial!!");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {num} is {factorial(num)}");

            Console.WriteLine("\t \t \t Let's Guess");
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
            GuessingGame();

            Console.WriteLine("\nRunning Inheritance Example:");
            Run.Execute();

            Console.WriteLine("\nRunning Polymorphism Example:");
            Run2.run2();

            Console.WriteLine("\nRunning Abstraction Example:");
            RunAbstraction.Run();

            Console.WriteLine("\nRunning Interface Example:");
            RunInterface.Run();

            Console.WriteLine("\nRunning Order Status Enum Example:");
            RunEnum1.Run();

            Console.WriteLine("\nRunning Weekdays Enum Example:");
            RunEnum2.Run();

            Console.WriteLine("\nRunning Collection Example:");

            Console.WriteLine("Choose a collection to run:");
            Console.WriteLine("1. List");
            Console.WriteLine("2. Dictionary");
            Console.WriteLine("3. HashSet");
            Console.WriteLine("4. Queue");
            Console.WriteLine("5. Stack");
            Console.WriteLine("6. LinkedList");

            int choice = int.Parse(Console.ReadLine() ?? "1");

            switch (choice)
            {
                case 1: ListExample.Run(); break;
                case 2: DictionaryExample.Run(); break;
                case 3: HashSetExample.Run(); break;
                case 4: QueueExample.Run(); break;
                case 5: StackExample.Run(); break;
                case 6: LinkedListExample.Run(); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }

    }
}
