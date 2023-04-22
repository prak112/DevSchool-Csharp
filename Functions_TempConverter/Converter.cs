using System;

namespace Converter
{
	public class Methods
	{
        public static double TemperatureConverter(string convertTo, double conversionValue)
        {
            double convertedValue = 0;
            // convert user input to Upper case
            convertTo = convertTo.ToUpper();

            // calculation based on user input
            if (convertTo == "C") { convertedValue = ((5d / 9d) * (conversionValue - 32d)); }
            else if (convertTo == "F") { convertedValue = ((conversionValue * 9d / 5d) + 32); }
            else
            {
                convertedValue = 0;
                Console.WriteLine("Enter a valid choice.\n");
            }
            return Math.Round(convertedValue, 2);
        }
    }
}
