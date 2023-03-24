namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare variables and then initialize to zero.
            double num1, num2;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = int.Parse(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = int.Parse(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tmod - Modulus");
            Console.Write("Your option? ");

            // Use a switch statement to do the math
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Sum of {num1} + {num2} = {(num1 + num2)}");
                    break;
                case "s":
                    Console.WriteLine($"Difference of {num1} - {num2} = {(num1 - num2)}");
                    break;
                case "m":
                    Console.WriteLine($"Product of {num1} * {num2} = {(num1 * num2)}");
                    break;
                case "d":
                    Console.WriteLine($"Divisor of {num1} / {num2} = {(num1 / num2)}");
                    break;
                case "mod":
                    Console.WriteLine($"Modulus of {num1} % {num2} = {(num1 % num2)}");
                    break;
                default:
                    Console.WriteLine("Enter valid input, please. Thank you!\n");
                    break;
            }

            // Wait for the user to respond before closing
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}