using System.Diagnostics;

namespace T15_GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize number to guess
            int num = 42;

            // choose game mode
            Console.WriteLine("\t\t---Begin 'Guess Number' Game---\n\nChoose game mode :\nPress 'h' - Hard Way\nPress 'e' - Easy Way\nPress 'x' for Exit");
            string gameMode = Console.ReadLine();
            
            // initialize user guess to null
            string userGuess = "";
            
            // try-catch block to catch Null Handling Exception
            try
            {
                // iterate game based on game mode
                do
                {
                    switch (gameMode)
                    {
                        case "h":
                            // wait for user to guess the number
                            Console.WriteLine("\t\t---This is Hard Way!---\nGuess the Number(an Integer): ");
                            userGuess = Console.ReadLine();

                            // user guess is correct
                            if (int.Parse(userGuess) == num) {
                                Console.WriteLine("That's it! You are wise! Now go rule your Universe!");   // userGuess is correct, break loop, exit game
                            }

                            // user guess is wrong
                            else {
                                // wait for user to choose from main menu
                                Console.WriteLine("\t\tNope!\nPress 'e' for Easy Way\nPress 'x' for Exit\nPress 'Enter' to Guess again");
                                gameMode = Console.ReadLine();
                            }
                            break;

                        case "e":
                            // wait for user to choose from sub-menu
                            Console.WriteLine("\t\t---Welcome to Easy Way---\nPress 'i' for Hint\nPress 'a' for Answer\nPress 'Enter' to Guess");
                            string userChoice = Console.ReadLine();

                            // user choice menu
                            switch (userChoice)
                            {
                                case "i":
                                    Console.WriteLine("HINT: The answer for everything in the universe");
                                    break;
                                case "a":
                                    Console.WriteLine("Duh! Answer is \"42\"!");
                                    break;
                                default:
                                    Console.WriteLine("Guess Einstein Guess! Time running out...");
                                    // wait for user to guess the number
                                    Console.WriteLine("\nGuess the Number(an Integer): ");
                                    userGuess = Console.ReadLine();
                                    break;
                            }
                            // user guess is correct
                            if (int.Parse(userGuess) == num) { 
                                Console.WriteLine("Yeah finally! You are not wise but you are okay!");   // userGuess is correct, break loop, exit game
                            }

                            // user guess is wrong
                            else {
                                // wait for user to choose from main menu
                                Console.WriteLine("\t\tNope!\nPress 'x' for Exit\nPress 'Enter' to Guess again");
                                gameMode = Console.ReadLine();
                            }
                            break;

                        case "x":
                            Console.WriteLine("After all, you are ONLY Human. Bye-Byee!");
                            break;

                        default:
                            Console.WriteLine("Well.. Time running out...\nChoose game mode :\nPress 'h' - Hard Way\nPress 'e' - Easy Way\nPress 'x' for Exit");
                            gameMode = Console.ReadLine();

                            break;
                    }
                }
                while (int.Parse(userGuess) != num || gameMode == "x"); //end loop, user wants to quit or user guess is correct

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("In short, you are Out!");

            }
            // exit game
            Console.WriteLine("\t\t---End Game---");
            Console.ReadKey();
        
        }
    }
}