using Functions; // namespace label of Practice class

namespace MainProgram
{
    class Program
    {        
        // Main method
        public static void Main(string[] args)
        {

            try
            {
                #region Mean
                
                // user input for Mean method
                // totalNumbers given as user input
                Console.WriteLine(" Enter total numbers to calculate Mean : ");
                int totalNumbers = int.Parse(Console.ReadLine());

                // initialize array
                int[] numArray = new int[totalNumbers];

                // iterate for user input based on totalNumbers
                Console.WriteLine($"Please enter {totalNumbers} integers");
                for (int i = 0; i < totalNumbers; i++)
                {
                    Console.Write($"Integer {i+1} : ");
                    numArray[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Mean of given numbers : " + Methods.Mean(numArray));

                #endregion

                #region SaySomething

                // user input for SaySomething method
                Console.Write("\n\nSay Something to call method and display : ");
                string message = Console.ReadLine();
                Methods.SaySomething(message);

                #endregion

                #region TriangleArea

                Console.WriteLine("\n---Area of Trianlge---\nEnter base length of Triangle : ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter height of Triangle : ");
                double height = double.Parse(Console.ReadLine());
                double area = Methods.TriangleArea(width, height);
                Console.WriteLine($"Area of Triange : {area} sq. units");

                #endregion

                #region TaxCalculator
                
                // user input for gross taxAndSalary and tax rate
                Console.WriteLine("\n---Welcome to Tax Calculator---\nEnter Gross Salary : ");
                double grossSalary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Tax Percentage: ");
                double taxRate = double.Parse(Console.ReadLine());

                // call function with a double Tuple
                (double, double) taxAndSalary = Methods.TaxCalculator(grossSalary, taxRate);
                Console.WriteLine($"Your Net Salary : {taxAndSalary.Item1}\nTax Paid : {taxAndSalary.Item2}");

                #endregion

                #region CaloriesAndJoules

                // user input
                Console.WriteLine("\n---Welcome to Calorie-Joules converter---\nEnter energy value : ");
                double value = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter value Units :\n-'c' for Calories\n-'j' for Joules: ");
                string valueUnit = Console.ReadLine();

                // call function
                (double, string) conversion = Methods.CaloriesAndJoules(value, valueUnit);
                // unpack Tuple items
                double convertedValue = conversion.Item1;
                string unitType = conversion.Item2;
                Console.WriteLine($"Converted {value} to {unitType}\nAfter Conversion : {convertedValue} {unitType}");


                #endregion
            }
            catch (Exception ex) { Console.WriteLine("ERROR : " + ex.Message); }
        }
    }

}



