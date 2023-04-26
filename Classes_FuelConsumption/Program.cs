namespace TripCalculator
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"
---Welcom to Trip Cost Calculator (only Fuel cost)---
Summary:
- Enter Trip Destination
- Enter Trip Distance
- Output will list Fuel expenses for each Trip
    ");
            // initialize variables
            bool userExit = false;

            // application loop, until userExit = true        
            try
            {
                while (!userExit)
                {
                    // user input
                    Console.Write("Enter Total number of Trips : ");
                    int totalTrips = int.Parse(Console.ReadLine());

                    Console.Write("Enter Fuel Price per litre (in euros) : ");
                    double fuelPrice = double.Parse(Console.ReadLine());

                    Console.Write("Enter Car Mileage (Kms / 1 litre) : ");
                    double mileage = double.Parse(Console.ReadLine());

                    // initialize tripInputList
                    List<TripInput> tripInputList = new List<TripInput>();
                    Console.WriteLine("Enter the following details -");

                    // add user input
                    for (int i = 0; i < totalTrips; i++)
                    {
                        Console.Write("\nEnter Trip Destination : ");
                        string destination = Console.ReadLine();

                        Console.Write("Enter Trip Distance (in Km) : ");
                        double distance = double.Parse(Console.ReadLine());

                        TripInput data = new TripInput();
                        data.Location = destination;
                        data.Distance = distance * 2;   // round trip calculation
                        tripInputList.Add(data);
                    }

                    // intialize tripOutputList object
                    List<TripOutput> tripOutputList = new List<TripOutput>();
                    double totalFuelCost = 0;
                    double totalDistance = 0;

                    // call FuelConsumption.TripExpenses method, pass tripInputList
                    tripOutputList = FuelConsumption.TripExpenses(tripInputList, fuelPrice);

                    // display output from tripOutputList
                    Console.WriteLine("--Trip Details--");
                    foreach(var item in  tripOutputList)
                    {
                        totalFuelCost += item.FuelCost;
                        totalDistance += item.Distance;

                        Console.WriteLine($@"
Trip Destination : {item.Location.ToUpper()}
Total Distance (RoundTrip) : {item.Distance} Kms
Fuel Cost (for {fuelPrice} euro/ litre) : {item.FuelCost} euros
");
                    }
                    double fuelVolume = Math.Round(totalDistance / mileage, 2);
                    Console.WriteLine($"Total Fuel Volume : {fuelVolume} liters\nTotal Fuel Cost : {totalFuelCost} euros\nTotal Trips Distance : {totalDistance} Kms");
                
                    // option for user to exit
                    Console.WriteLine("\nPress 'q' to exit or Enter to continue");                
                    if (Console.ReadLine() == "q") { userExit = true; }
                }
            }
            catch (Exception ex) { Console.WriteLine($"ERROR : {ex.Message}\n---Terminate Program---\n"); }
        }
    }
}

