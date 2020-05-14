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
            else if (userGuess == "0")
            {
                Console.WriteLine("Enter an number between 1-10.");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }
            //User puts in 0, provide instrucstions

        }

    }
}
