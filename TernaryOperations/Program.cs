using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TernaryOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TernaryOperator-test
            
            Console.WriteLine("Hello, World!\nEnter Number : ");
            int num = int.Parse(Console.ReadLine());

            // ternary operator
            // syntax -> variable = (condition) ? (if true) : (if false)
            string message = (num % 2 == 0) ? $"Number is EVEN" : $"Number is ODD";
            Console.WriteLine($"This is Amazing MeNtAL!\n{message}");

            #endregion


            #region T16-KUUKAUDET
            // T16 - identify season
            //using do-while and switch

            // initialize month
            int month;

            // repeat loop until user inputs between 1-12
            do
            {
                Console.WriteLine(@"
----Aloita Tehtävä 16 : Kuukaudet----
Enter month number to identify season : ");
                month = int.Parse(Console.ReadLine());

                // print based on user input
                switch (month)
                {
                    case 11:
                    case 12:
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("Talvi Tulossa! Brrr!");
                        break;
                    case 4:
                    case 5:
                        Console.WriteLine("Keväääääätt...");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Kesääää!!");
                        break;
                    case 9:
                    case 10:
                        Console.WriteLine("Syksy Nukkuuu...");
                        break;
                    default:
                        Console.WriteLine("\nEnter number between 1 - 12 : ");
                        break;
                }
            }
            while (month > 12 || month < 1); // repeat if user input invalid


            //using class and ternary operator
            Console.WriteLine(@"
T16 using ternary operator ""(condition) ? (if true) : (if false) ""
Testing with Ternary.
---Enter a number between 1 - 12 : ");
            int monthNum = int.Parse(Console.ReadLine());
            string seasonMsg = month >= 11 && month <= 12 ? "Keväääätt..." : 
                                month >= 6 && month <= 10 ? "Kesäää" : 
                                month >= 5 && month <= 1 ? "Tälvi" : "Myös Tälvi";
            Console.WriteLine(seasonMsg);

            Console.WriteLine("----Loppuu Tehtävä----");

            #endregion
        }
    }
}