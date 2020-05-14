using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game!");
            for (int i = 0; i < 2; i++)
            {
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
            }
           

            //Console.WriteLine("Try a second guess");
            //string secondGuess = Console.ReadLine();
            //int i = Convert.ToInt32(secondGuess);
            //number2 = Convert.ToBoolean(i);

            //if (secondGuess == "7")
            //{
            //    Console.WriteLine("Great job!");
            //}
            //else if (0 < secondGuess < 11; != "7")
            //{
            //    Console.WriteLine("Sorry, You Lose!");
            //}
           
            // ( i = ""; 0 < i < 11)
            //{
            //   Console.WriteLine() ;
            //}

        }

    }
}
