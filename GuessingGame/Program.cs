using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game!");
            bool winningGuess = false;
            int guessTrys = 0;

            Random random = new Random();
            int secretNumber = random.Next(1, 10);

            Console.WriteLine(secretNumber);
            while (winningGuess == false & guessTrys < 2)
            {
                Console.WriteLine(" Enter a guess.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == -1)
                {
                    Console.WriteLine("GAME EXITED by user.");
                    guessTrys = 2;
                }
                else if (userGuess == 0)
                {
                    Console.WriteLine("Enter an number between 1-10.");
                }
                else if (userGuess == secretNumber)
                {
                    Console.WriteLine("You guessed right!");
                    winningGuess = true;
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    if (userGuess > secretNumber)
                    {
                        Console.WriteLine("You guessed to high");
                    }
                    else
                    {
                        Console.WriteLine("You guessed to low");
                    }
                }
                guessTrys = guessTrys + 1;
            }
        }

    }
}
