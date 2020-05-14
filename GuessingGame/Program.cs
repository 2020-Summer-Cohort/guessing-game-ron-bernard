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
            {
                //while (winningGuess == false & guessTrys < 2)
                //{
                //    Console.WriteLine(" Enter a guess.");
                //    string userGuess = Console.ReadLine();
                //    if (userGuess == "7")
                //    {
                //        Console.WriteLine("You guessed right!");
                //        winningGuess = true;
                //    }
                //    else if (userGuess == "0")
                //    {
                //        Console.WriteLine("Enter an number between 1-10.");
                //    }
                //    else if (userGuess == "-1")
                //    {
                //        Console.WriteLine("GAME EXITED by user.");
                //        guessTrys = 2;
                //        winningGuess = true;
                //    }
                //    else
                //    {
                //        Console.WriteLine("You Lose!");
                //    }
                //        guessTrys = guessTrys + 1;
                //}
            }
            while (winningGuess == false & guessTrys < 2)
            {
                Console.WriteLine(" Enter a guess.");
                string userGuess = Console.ReadLine();

                switch (userGuess)
                {
                    case "-1":
                        {
                            Console.WriteLine("GAME EXITED by user.");
                            guessTrys = 2;
                            break;
                        }
                    case "0":
                        {
                            Console.WriteLine("Enter an number between 1-10.");
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("You guessed right!");
                            winningGuess = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You Lose!");
                            break;
                        }
                }
                guessTrys = guessTrys + 1;

            }
        }

    }
}
