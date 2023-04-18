using System;
using System.Linq;

//class definition
// class HEADER
namespace Functions
{
    class Methods
    {
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


        // SaySomething method
        public static void SaySomething(string message)
        {
            Console.WriteLine($"\nThis method is called from Main\n{message.ToUpper()}\n");
        }


        // Area of Triangle method
        public static double TriangleArea(double width, double height)
        {
            double area = 0.5 * width * height;
            return area;

        }


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


        public static (double, string) CaloriesAndJoules(double value, string valueUnit)
        {
            // define return output Tuple
            (double, string) conversion = (0, "");

            // calculation using Ternary operator, pack Tuple with results
            conversion.Item1 = (valueUnit == "c") ? Math.Round((value * 0.2390), 2) : Math.Round((value * 4.184), 2);
            conversion.Item2 = (valueUnit == "c") ? "Calories" : "Joules";

            return conversion;

        }

    }
}
