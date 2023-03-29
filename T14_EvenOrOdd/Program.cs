using System.ComponentModel;

namespace T14_EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // initialize loop signal with no error
            string errorSignal = "green";

            // do-while loop to execute game atleast once
            do
            {
                try
                {
                    Console.WriteLine("\t\t---Begin Game----\n\nEnter a number to Check if it is Even or Odd: ");

                    // initialize variable and calculate even or odd
                    int num = int.Parse(Console.ReadLine());
                    int remainder = num % 2;

                    // verifiy remainder for even or odd identification
                    if (remainder == 0)
                    {
                        Console.WriteLine($"The number, {num}, is divisible by 2 and the remainder is {remainder}.\nHence, it is an EVEN number!\n");
                        errorSignal = "green"; // signal no error
                    }
                    else
                    {
                        Console.WriteLine($"The number, {num}, is NOT divisible by 2 and the remainder is {remainder}.\nHence, it is an ODD number!\n");
                        errorSignal = "green"; // signal no error
                    }
                }
                catch (Exception ex)        // catch decimal/longInt user entries and clarify instructions
                {
                    errorSignal = "red";      // signal yes error
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter number in Int32 format.");
                }

            } while (errorSignal == "red");   // repeat loop when signal yes error
            
            Console.WriteLine("\t\t---End of Game---");
            Console.ReadKey();
        }
    }
}