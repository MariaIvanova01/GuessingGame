using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "rain";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 10;
            bool noGuesses = false;

            while (guess != secretWord && !noGuesses)
            {
                if ( guessCount < guessLimit)
                {
                    Console.Write("Enter word : ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    noGuesses = true;
                }
                
            }
            if (noGuesses)
            {
                Console.WriteLine(" Sorry. YOU LOSE!");
            }
            else
            {
                Console.WriteLine(" CONGRATULATIONS! ");

            }
           

        }
    }
}
