namespace T28_SequenceEvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // user input for sequence 
                Console.WriteLine("\n\t\t---Begin Sequence Game---\nEnter last number of Sequence : ");
                int endNumber = int.Parse(Console.ReadLine());

                // user choice for even or odd sequence
                Console.WriteLine("Choose number sequence :\nOnly EVEN - Press 'e'\nOnly ODD - Press 'o'");
                string userChoice = Console.ReadLine();

                // initialize counter and iterate sequence
                int counter = 0;
                
                // calculate and print even numbers only
                if (userChoice == "e")
                {
                    while (counter != endNumber)
                    {
                        if (counter % 2 == 0)
                        {
                            Console.WriteLine(counter);
                            counter++;
                        }
                        else            // skip odd numbers
                        {
                            counter++;
                        }
                    }
                }
                // calculate and print odd numbers only
                else
                {
                    while (counter != endNumber)
                    {
                        if (counter % 2 != 0)
                        {
                            Console.WriteLine(counter);
                            counter++;
                        }
                        else            // skip even numbers
                        {
                            counter++;
                        }
                    }
                }
                Console.WriteLine("\n\t\t---End Sequence Game---");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter relevant input");
            }
             
        }
    }
}