namespace T5_Keskiarvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calculate average of 3 integers
            // user input for 3 integers
            Console.WriteLine("Enter 3 integer values for an average :");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            double average = (num1 + num2 + num3) / 3d;
            Console.WriteLine($"Average of given numbers {num1}, {num2} & {num3} is :\n{average}");
            Console.ReadKey();
        }
    }
}