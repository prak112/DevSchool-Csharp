namespace DataStructures;

internal class TemperatureMonitor
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
---Welcome to Temperature Monitor---
Summary :
- Enter temperatures (decimal/integer) for below categories for 4 timepoints
- Program will provide 2 output categories, with Array and List
- Final outputs will be Day High, Day Low and Day Average
");
        // initialize variables
        bool userExit = false;

        // application loop, until userExit = true
        try
        {
            while (!userExit)
            {
                // initialize timeArray and temperatureArray
                Console.WriteLine("--Using ARRAYS--");
                string[] timeArray = new string[4] { "0600", "1200", "1800", "2400" };
                decimal[] temperatureArray = new decimal[timeArray.Length];

                // user input for Array
                for (int i = 0; i < timeArray.Length; i++)
                {
                    Console.Write($"Enter Temperature for {timeArray[i]} : ");    // ask temperature for every time slot
                    decimal temp = decimal.Parse(Console.ReadLine());
                    temperatureArray[i] = temp;     // store user input
                }

                // temperature stats - maximum, minimum, average
                decimal minTemp = temperatureArray.Min();
                decimal maxTemp = temperatureArray.Max();
                decimal avgTemp = temperatureArray.Average();

                // display output
                Console.WriteLine($@"
Today's Temperature Update:
Day High - {maxTemp} Celsius
Day Low  - {minTemp} Celsius
Average Temperature - {avgTemp} Celsius
--End of Using ARRAYS--");


                // initialize timeList and temperatureList
                Console.WriteLine("\n--Using LISTS--");
                List<string> timeList = new List<string>() { "0600", "1200", "1800", "2400" };
                List<decimal> temperatureList = new List<decimal>();

                // user input for List
                for (int j = 0; j < timeArray.Length; j++)
                {
                    Console.Write($"Enter Temperature for {timeList[j]} : ");
                    decimal temp = decimal.Parse(Console.ReadLine());
                    temperatureList.Add(temp);
                }

                // display temperature stats - min, max, average             
                Console.WriteLine($@"
Today's Temperature Update:
Day High - {temperatureList.Max()} Celsius
Day Low  - {temperatureList.Min()} Celsius
Day Average - {temperatureList.Average()} Celsius
--End of Using LISTS--");

                // option to exit
                Console.WriteLine("\nPres 'q' to Exit or Enter to continue");
                if (Console.ReadLine() == "q") { userExit = true; }
            }
        }
        catch (Exception ex) { Console.WriteLine("ERROR : " + ex.Message); }
        Console.WriteLine("\n---End Temperature Monitor using Data Structures---\n");
    }
}