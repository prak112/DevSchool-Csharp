using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
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

        Console.WriteLine("---Loppuu Tehtävä---");
    }
}
