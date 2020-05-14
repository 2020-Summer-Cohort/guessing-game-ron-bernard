using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game!");

            Console.WriteLine(" Enter a guess.");
            string userGuess = Console.ReadLine();
            if (userGuess == "7")
            {
                Console.WriteLine("You guessed right!");

            }
            else
            {
                Console.WriteLine("You Lose!");
            }
        }

    }
}
