using System;


// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {

            GetAppInfo();
            GreetUser();

            while (true)
            {
                // Init correct number
                // int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 11);

                // Init guess variable
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    bool isNumber = int.TryParse(input, out guess);
                    if (!isNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");
                    }

                    if (isNumber && (guess != correctNumber))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!!");

                Console.WriteLine("Press enter to play again");
                ConsoleKeyInfo replay = Console.ReadKey();
                if (replay.Key != ConsoleKey.Enter)
                {
                    break;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ross Baker";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app information
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game.", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Write out app information
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }

}
