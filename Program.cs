using System;

//Phase 7
//The program should be updated to...

//Prompt the user for a difficulty level before they are prompted to guess the number.
//The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
//Easy - this gives the user eight guesses.
//Medium - this gives the user six guesses.
//Hard - this gives the user four guesses.

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {


           
           int SetDifficulty()
           {
                int Difficulty = 0;
                Console.WriteLine("How difficult do you want this game to be?");
                Console.WriteLine("1) Easy");
                Console.WriteLine("1) Medium");
                Console.WriteLine("1) Hard");
                string userResponse = Console.ReadLine();
                int userResponseAsANumber = int.Parse(userResponse);
                if(userResponseAsANumber == 1){
                    Difficulty = 8;
                }
                else if(userResponseAsANumber == 2){
                    Difficulty = 6;
                }
                else if(userResponseAsANumber == 3){
                    Difficulty = 4;
                }else{
                    Console.WriteLine("That is not a valid option");
                }
                return Difficulty;
           }

            void GuessingGame(int DifficultyNumber)
            {
                int GameCounter = 1;
                Random r = new Random();
                int RandomSecretNumber= r.Next(1,100);

                Console.WriteLine("Guess the secret number:");
                string Guess = Console.ReadLine();
                int GuessAsANumber = int.Parse(Guess);

                while(GameCounter != DifficultyNumber)
                {
                    if(RandomSecretNumber == GuessAsANumber)
                    {
                        Console.WriteLine("Success you guessed the secret number!");
                        GameCounter= DifficultyNumber;
                        Console.WriteLine($"You finished in {GameCounter} guesses");
                    }
                    else
                    {
                        Console.WriteLine("Try Again, you failure.");
                        Console.WriteLine("");
                        Console.WriteLine($"You have made {GameCounter} guesses out of {DifficultyNumber}");
                        Console.WriteLine("");
                        GameCounter++;
                        if(GuessAsANumber > RandomSecretNumber){
                            Console.WriteLine("Hint, your guess was too high");
                        }
                        else
                        {
                            Console.WriteLine("Hint, your guess was too low");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Guess the secret number:");
                        string newGuess = Console.ReadLine();
                        GuessAsANumber = int.Parse(newGuess);
                    }     
                }
                
            }
            GuessingGame(SetDifficulty());

        }
    }
}
