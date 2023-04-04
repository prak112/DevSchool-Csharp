class Program
{
    static void Main(string[] args)
    {
        // initialize boolean for running app
        bool endApp = false;

        // display title of app
        Console.WriteLine("---Console Calculator in C#---\n");

        // while loop to iterate app operation
        while (!endApp)
        {
            // initialize variables to empty
            string userNum1 = " ";
            string userNum2 = "";
            double result = 0;

            // inner iteration for correct user input
            // first user input - double x
            Console.WriteLine("Enter a number for calculation : ");
            userNum1 = Console.ReadLine();

            double doubleNum1 = 0;
            while (!double.TryParse(userNum1, out doubleNum1))
            {
                Console.WriteLine("Invalid input! Enter a valid number");
                userNum1 = Console.ReadLine();
            }

            // second user input - double y
            Console.WriteLine("Enter another number for calculation : ");
            userNum2 = Console.ReadLine();

            double doubleNum2 = 0;
            while (!double.TryParse(userNum2, out doubleNum2))
            {
                Console.WriteLine("Enter a valid input");
                userNum2 = Console.ReadLine();
            }

            // user chooses arithmetic operation
            Console.WriteLine(@"
Choose an arithmetic operation from list below :
'a' - addition
's' - subtraction
'm' - multiplication
'd' - division

Your option : ");

            // read user input
            string op = Console.ReadLine();

            // try-catch block to access Calculator_logic Class for calculation
            try
            {
                result = Calculator.DoOperation(doubleNum1, doubleNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Given input leads to a zero-error operation.");
                }
                else Console.WriteLine("Result : {0:0.##}", result);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured for the given inputs.\nDetails: " + ex.Message);
            }
            Console.WriteLine("x---------------------x\n");

            // wait for user to end or continue app
            Console.WriteLine("Press 'q' for exit. Press any button to continue.\n");
            if (Console.ReadLine() == "q")
            {
                endApp = true;
            }

        }
        Console.WriteLine("Buh-bye! Thanks for using the calculator :-)\n");
    }
}