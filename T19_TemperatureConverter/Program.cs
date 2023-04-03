namespace T19_TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize user error
            bool userError = false;

            // iterate for user input if error = true
            do
            {
                #region basicConverter
                // convert given temperature to Celsius
                try
                {
                    Console.WriteLine(@"
        ---Basic Converter---
Enter today's temperature in Fahrenheit :");
                    decimal tempInFahrenheit = decimal.Parse(Console.ReadLine());
                    decimal tempInCelsius = (5m / 9m) * (tempInFahrenheit - 32m);
                    Console.WriteLine("Temperature in Celsius : " + Math.Round(tempInCelsius, 2));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occured. Please check, fix and continue\n" + ex.Message);
                }

                #endregion


                #region modifiedConverter
                // provide options to convert a given number to either Fahrenheit or Celsius
                try
                {
                    Console.WriteLine(@"
        ---Advanced Converter----
Enter temperature (and convert to either Fahrenheit or Celsius):");
                    decimal temp = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Choose any of following:\n'f' - convert to Fahrenheit\n'c' - convert to Celsius");
                    string userChoice = Console.ReadLine();

                    // calculate based on user choice
                    if (userChoice == "f")
                    {
                        decimal tempInFahrenheit = (9m / 5m) * (temp + 32);
                        Console.WriteLine("Temperature in Fahrenheit : " + Math.Round(tempInFahrenheit, 2));
                    }
                    else
                    {
                        decimal tempInCelsius = (5m / 9m) * (temp - 32m);
                        Console.WriteLine("Temperature in Celsius : " + Math.Round(tempInCelsius, 2));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occured. Please check, fix and continue\n" + ex.Message);
                }

                #endregion

            }
            while (userError == true);
            
        }
    }
}