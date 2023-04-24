using Functions; // namespace label of Practice class consisting of Methods
                 // Methods - only logic for all tasks

// MainProgram - usage of Methods and Presentation of outputs
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

                #region FuelConsumption-2DArray&2DList

                Console.WriteLine("\n---Welcome to Fuel Consumption Calculator---\nEnter total number of Trips : ");
                // user input for totalTrips
                int totalTrips = int.Parse(Console.ReadLine());


                // array to display - Trip Distance, Fuel Cost
                double[,] travelCostArray = new double[totalTrips, 2];      // 2D array with totalTrips rows and 2 columns

                // LIST -
                // 2D list to display - Trip Distance, Fuel Cost    -->    // 3 Ways -https://www.delftstack.com/howto/csharp/declare-a-multidimensional-list-in-csharp/
                // define class TravelCost to define structure of List
                // use class TravelCost to structure travelCostList
                List<Methods.TravelCost> travelCostList = new List<Methods.TravelCost>();


                // option to exit
                bool userExit = false;

                while (!userExit)
                {
                    Console.WriteLine("\n--Output with ARRAYS--\n");
                    for (int i = 0; i < totalTrips; i++)
                    {
                        // ARRAY - user trips entry
                        Console.Write($"Enter Trip {i+1} Distance : ");
                        double tripDistance = double.Parse(Console.ReadLine());
                        // assign tripDistance to output array
                        travelCostArray[i, 0] = tripDistance;
                        // assign fuelCost to outputArray
                        travelCostArray[i, 1] = Methods.FuelConsumption(tripDistance);
                    }
                    
                    // ARRAY - display travelCostArray items
                    for (int j = 0; j < totalTrips; j++)
                    {
                        Console.WriteLine($"Trip Distance : {travelCostArray[j, 0]} km\t\tFuel Cost : {travelCostArray[j, 1]} Euro");
                    }
                    Console.WriteLine();

                    Console.WriteLine("\n--Output with LISTS--\n");
                    // LIST - assign elements to List
                    for (int l = 0; l < totalTrips; l++)
                    {
                        // user trips entry
                        Console.Write($"Enter Trip {l+1} Distance : ");
                        double tripDistance = double.Parse(Console.ReadLine());

                        // create class TravelCost object
                        Methods.TravelCost travelObject = new Methods.TravelCost();
                        // pack data into travelObject members
                        travelObject.distance = tripDistance;
                        travelObject.fuelCost = Methods.FuelConsumption(tripDistance);
                        // pack travelObject into travelCostList
                        travelCostList.Add(travelObject);
                    }
                    Console.WriteLine();
                    // LIST - display travelCostList items
                    foreach(var item in travelCostList)
                    {
                        Console.WriteLine($"Trip Distance : {item.distance} km\t\tFuel Cost : {item.fuelCost} Euro");
                    }

                    // user choice to continue or exit
                    Console.WriteLine("\nPress 'q' to Exit or Enter to continue");
                    userExit = Console.ReadLine() == "q" ? true : false;
                }
                
                #endregion


            }
            catch (Exception ex) { Console.WriteLine("ERROR : " + ex.Message); }
        }
    }

}



