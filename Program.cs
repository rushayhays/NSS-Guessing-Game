using System;

//Phase 2
//Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
//No longer display the user's guess. They know what they guessed, right?
//Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int SecretNumber = 42;
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
