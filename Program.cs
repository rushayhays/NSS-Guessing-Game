using System;

//Phase 5
//The program should be updated to...

//Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
//The prompt should display the number of guesses the user has left.

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {


           
           

            void GuessingGame()
            {
                int GameCounter = 1;
                Random RandomSecretNumber = new Random();
                int genRand= RandomSecretNumber.Next(1,100);
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
                        Console.WriteLine($"You have made {GameCounter} guesses out of 4");
                        GameCounter++;
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
