using System;
namespace ConsoleApp1{
    class Guess{
        internal static void GuessingGame()
    {
        Random rand = new Random();
        int number = rand.Next(1, 100);
        int guess;

        Console.WriteLine("Guess a number between 1 and 100!");

        do
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > number)
                Console.WriteLine("Too High! Try Again.");
            else if (guess < number)
                Console.WriteLine("Too Low! Try Again.");
        } while (guess != number);

        Console.WriteLine("Congrats! You guessed the right number.");
    }
    }
}
