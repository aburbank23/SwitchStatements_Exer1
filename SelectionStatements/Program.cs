using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Guess my favorite number. Go!");

            var favNumber = 23;

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"To low...");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"Too high...");
            }
            else
            {
                Console.WriteLine($"You guessed my number!");
            }
        }
    }
}

    