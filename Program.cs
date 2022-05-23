using System;

//Phase 1
//Display a message to the user asking them to guess the secret number.
//Display a prompt for the user's guess.
//Take the user's guess as input and save it as a variable.
//Display the user's guess back to the screen.

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Secret Number:");
            string Guess = Console.ReadLine();
            Console.WriteLine(Guess);
        }
    }
}
