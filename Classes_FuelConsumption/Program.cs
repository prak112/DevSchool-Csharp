namespace FuelConsumption
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
                    Console.Write("Enter Trip Destination : ");
                    string destination = Console.ReadLine();

                    Console.Write("Enter Trip Distance : ");
                    double distance = double.Parse(Console.ReadLine());

                    // initialize output list
                    List<Trip> tripExpenses = new List<Trip>();

                    // call method, pass destination and distance
                    
                
                    // option for user to exit
                    Console.WriteLine("\nPress 'q' to exit or Enter to continue");                
                    if (Console.ReadLine() == "q") { userExit = true; }
            }
        }
        catch (Exception ex) { Console.WriteLine($"ERROR : {ex.Message}\n---Terminate Program---\n"); }
    }
}
}

