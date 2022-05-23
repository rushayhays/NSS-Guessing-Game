using System;

//Phase 8
//The program should be updated to...

//Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {


           
           int SetDifficulty()
           {
                bool userResponseIsValid = false;
                int Difficulty = 0;
                Console.WriteLine("How difficult do you want this game to be?");
                Console.WriteLine("1) Easy");
                Console.WriteLine("2) Medium");
                Console.WriteLine("3) Hard");
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
                }else if(userResponseAsANumber == 4){
                     Difficulty = 33;
                }else{
                    while(userResponseIsValid == false){
                        Console.WriteLine("How difficult do you want this game to be?");
                Console.WriteLine("1) Easy");
                Console.WriteLine("2) Medium");
                Console.WriteLine("3) Hard");
                string userResponse = Console.ReadLine();
                int userResponseAsANumber = int.Parse(userResponse);
                    }
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

            void CheaterGame()
            {
                int GameCounter = 1;
                Random r = new Random();
                int RandomSecretNumber= r.Next(1,100);

                Console.WriteLine("Guess the secret number:");
                string Guess = Console.ReadLine();
                int GuessAsANumber = int.Parse(Guess);
                bool isNumberGuessed = false;

                while(isNumberGuessed == false)
                {
                    if(RandomSecretNumber == GuessAsANumber)
                    {
                        Console.WriteLine("Success you guessed the secret number!");
                        isNumberGuessed = true;
                        Console.WriteLine($"You finished in {GameCounter} guesses");
                    }
                    else
                    {
                        Console.WriteLine("Try Again, you failure.");
                        Console.WriteLine("");
                        Console.WriteLine($"You have made {GameCounter} guesses out of Infinity, you Cheater");
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


            int ChosenDifficulty = SetDifficulty();


            if(ChosenDifficulty == 33){
                CheaterGame();
            }
            else if(ChosenDifficulty == 1 || ChosenDifficulty ==2 || ChosenDifficulty==3){
                GuessingGame(ChosenDifficulty);
            }
            else{
                Console.WriteLine("Not a Valid Option");
            }

        }
    }
}
