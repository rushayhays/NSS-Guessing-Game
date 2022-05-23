using System;

//Phase 3 
//The program should be updated to...

//Give the user four chances to guess the number.
//Continue to display the success or failure messages as in phase 2

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int SecretNumber = 42;

            for(int x=4; x>0;x--){
                GuessingGame();
            }

            void GuessingGame(){
                Console.WriteLine("Guess the Secret Number:");
                string Guess = Console.ReadLine();
                int GuessAsANumber = int.Parse(Guess);
                if(SecretNumber == GuessAsANumber)
                {
                    Console.WriteLine("Success you guessed the secret number!");
                }
                else
                {
                    Console.WriteLine("Try Again, you failure.");
                }
            }

        }
    }
}
