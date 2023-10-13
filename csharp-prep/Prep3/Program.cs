using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            Random random = new Random();

            while (playAgain)
            {
                int magicNumber = random.Next(1, 101);
                int guess;
                int numberOfGuesses = 0;
                bool guessedCorrectly = false;

                Console.WriteLine("Welcome to the Number Guessing Game!");
                Console.WriteLine("I'm thinking of a number between 1 and 100.");
                
                while (!guessedCorrectly)
                {
                    Console.Write("Enter your guess: ");
                    if (int.TryParse(Console.ReadLine(), out guess))
                    {
                        numberOfGuesses++;

                        if (guess < magicNumber)
                        {
                            Console.WriteLine("Higher");
                        }
                        else if (guess > magicNumber)
                        {
                            Console.WriteLine("Lower");
                        }
                        else
                        {
                            Console.WriteLine($"You guessed it! The magic number was {magicNumber}.");
                            guessedCorrectly = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }

                Console.WriteLine($"It took you {numberOfGuesses} guesses to find the magic number.");
                Console.Write("Do you want to play again? (yes/no): ");
                string playAgainResponse = Console.ReadLine().ToLower();
                playAgain = (playAgainResponse == "yes");
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
