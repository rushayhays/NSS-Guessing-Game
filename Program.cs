using System;

//Phase 6
//The program should be updated to...

//Inform the user if their guess was too high or too low, when they guess incorrectly.

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {


           
           

            void GuessingGame()
            {
                int GameCounter = 1;
                Random r = new Random();
                int RandomSecretNumber= r.Next(1,100);

                Console.WriteLine("Guess the secret number:");
                string Guess = Console.ReadLine();
                int GuessAsANumber = int.Parse(Guess);

                while(GameCounter != 4)
                {
                    if(RandomSecretNumber == GuessAsANumber)
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
                        if(GuessAsANumber > RandomSecretNumber){
                            Console.WriteLine("Hint, your guess was too high");
                        }
                        else
                        {
                            Console.WriteLine("Hint, your guess was too low");
                        }
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
