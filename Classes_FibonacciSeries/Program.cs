
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(@"
---Welcome to BiDirectional Fibonacci Series---
Summary:
- Enter a direction :
    - '+' for Positive Fibonacci Series
    - '-' for Negative Fibonacci Series
- Enter total numbers to be in series
                                 ");

                bool userExit = false;
                while (!userExit)
                {
                    // user choice for forward or backward Fibonacci series
                    Console.Write("Direction : ");
                    string direction = Console.ReadLine();

                    // total numbers in Fibonacci series
                    Console.Write("Total Numbers in Series : ");
                    int totalNumbers = int.Parse(Console.ReadLine());

                    // create FibonacciNumbers object and pass variable
                    FibonacciNumbers userSeries = new FibonacciNumbers(totalNumbers);

                    // create Long format resultList series
                    List <long> resultList = new List <long>();

                    // choose FibonacciNumber method by direction
                    Console.WriteLine("Resulting Fibonacci Series : "); 
                    switch (direction)
                    {
                        case "+":
                            resultList = userSeries.ForwardSeries();
                            break;

                        case "-":
                            resultList = userSeries.BackwardSeries();
                            break;

                        default:
                            userExit = true;
                            break;
                    }
                    foreach (int item in resultList)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Press 'q' to Exit or Enter to Continue");
                    userExit = Console.ReadLine() == "q" ? true : false;
                }           
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : " + ex.Message);
            }
        }
    }

}