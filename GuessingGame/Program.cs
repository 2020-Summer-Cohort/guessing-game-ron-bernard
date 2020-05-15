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

            //Console.WriteLine(secretNumber);

            while (winningGuess == false & guessTrys < 3)
            {
                Console.WriteLine("\nEnter a guess.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == -1)
                {
                    Console.WriteLine("\nGAME EXITED by user.");
                    guessTrys = 2;
                }
                else if (userGuess == 0)
                {
                    Console.WriteLine("\nEnter an number between 1-10.");
                }
                else if (userGuess == secretNumber)
                {
                    Console.WriteLine("\nYou guessed right!");
                    winningGuess = true;
                }
                else
                {
                    Console.WriteLine("\nTry Again!");
                    if (userGuess > secretNumber)
                    {
                        Console.WriteLine("\nYou guessed to high");
                    }
                    else
                    {
                        Console.WriteLine("\nYou guessed to low");
                    }
                }
                guessTrys = guessTrys + 1;
            }
        
            if (!winningGuess)
            {
                Console.WriteLine("\nYou Lose");
            }
        }

    }
}
