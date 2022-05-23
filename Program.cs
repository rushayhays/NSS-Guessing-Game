using System;

//Phase 4
//The program should be updated to...

//Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
//End the loop early if the user guesses the correct number.

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {


           
           

            void GuessingGame()
            {
                int GameCounter = 0;
                int SecretNumber = 42;

                Console.WriteLine("Guess the secret number:");
                string Guess = Console.ReadLine();
                int GuessAsANumber = int.Parse(Guess);

                while(GameCounter != 4)
                {
                    if(SecretNumber == GuessAsANumber)
                    {
                        Console.WriteLine("Success you guessed the secret number!");
                        GameCounter= 4;
                        Console.WriteLine($"You finished in {GameCounter} guesses");
                    }
                    else
                    {
                        Console.WriteLine("Try Again, you failure.");
                        GameCounter++;
                        Console.WriteLine($"You have made {GameCounter} guesses out of 4");
                        Console.WriteLine("Guess the secret number:");
                        string newGuess = Console.ReadLine();
                        GuessAsANumber = int.Parse(newGuess);
                    }     
                }
                
            }
            GuessingGame();

        }
    }
}
