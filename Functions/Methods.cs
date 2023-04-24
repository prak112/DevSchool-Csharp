using System;
using System.Linq;

//class definition
// class HEADER
namespace Functions
{
    class Methods
    {
        #region Mean
        // Mean calculation method
        public static double Mean(int[] numbers)
        {
            Console.WriteLine("\nThis method calculates Mean from given Numbers");
            int totalCount = numbers.Count();
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double mean = sum/totalCount;         
            return mean;
        }
        #endregion


        #region SaySomething
        // SaySomething method
        public static void SaySomething(string message)
        {
            Console.WriteLine($"\nThis method is called from Main\n{message.ToUpper()}\n");
        }
        #endregion


        #region TriangleArea
        // Area of Triangle method
        public static double TriangleArea(double width, double height)
        {
            double area = 0.5 * width * height;
            return area;

        }
        #endregion


        #region TaxCalculator
        // Tax Calculator method
        public static (double, double) TaxCalculator(double grossSalary, double taxRate)
        {
            // define return output Tuple 
            (double, double) taxAndSalary = (0, 0);

            // convert taxRate to percentage
            taxRate = taxRate / 100d;
            double paidTax = grossSalary * taxRate;

            // calculation and assignment to result Tuple
            taxAndSalary.Item1 = Math.Round((grossSalary - paidTax), 2);
            taxAndSalary.Item2 = Math.Round(paidTax, 2);

            return taxAndSalary;
        }
        #endregion


        #region CaloriesAndJoules
        public static (double, string) CaloriesAndJoules(double value, string valueUnit)
        {
            // define return output Tuple
            (double, string) conversion = (0, "");

            // calculation using Ternary operator, pack Tuple with results
            conversion.Item1 = (valueUnit == "c") ? Math.Round((value * 0.2390), 2) : Math.Round((value * 4.184), 2);
            conversion.Item2 = (valueUnit == "c") ? "Calories" : "Joules";

            return conversion;

        }
        #endregion

        #region FuelConsumption

        public static double FuelConsumption(double distance) 
        {
            // ASSUMPTION - every vehicle provides a mileage (distance/fuel) of 100km for 1 litre
            // Fuel Cost - 2.163 € / 1 litre
            double fuelCost = Math.Round((2.163 * distance)/100, 2);
            return fuelCost;
        }

        public class TravelCost     // class to define structure of 2D list
        {
            public double distance { get; set; }    // enabling the ability to add and retrieve data - set & get, respectively
            public double fuelCost { get; set; }
        }

        #endregion


    }
}
