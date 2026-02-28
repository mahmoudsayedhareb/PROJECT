using System;

namespace MyGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game Setup
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // Random number between 1 and 100
            int userGuess = 0;
            int attempts = 0;

            Console.WriteLine("--- 🎮 Welcome to the Number Guessing Game! ---");
            Console.WriteLine("I have picked a number between 1 and 100. Can you guess it?");
            Console.WriteLine("----------------------------------------------------------");

            // Game Loop
            while (userGuess != targetNumber)
            {
                Console.Write("Enter your guess: ");
                string? input = Console.ReadLine();

                // Validation: Check if the input is a valid number
                if (!int.TryParse(input, out userGuess))
                {
                    Console.WriteLine("⚠️ Invalid input! Please enter a whole number.");
                    continue;
                }

                attempts++;

                // Give hints
                if (userGuess < targetNumber)
                {
                    Console.WriteLine("🔼 Too low! Try a higher number.");
                }
                else if (userGuess > targetNumber)
                {
                    Console.WriteLine("🔽 Too high! Try a lower number.");
                }
                else
                {
                    // Victory!
                    Console.WriteLine("\n🎉 Congratulations!");
                    Console.WriteLine($"You found the number {targetNumber} in {attempts} attempts.");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}