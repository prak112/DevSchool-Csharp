namespace FuelConsumption
{
    class MainProgram
    {
    public static void Main(string[] args)
    {
        Console.WriteLine(@"
---Welcom to Trip Cost Calculator (only Fuel cost)---
Summary:
- <PROGRAM_SUMMARY_POINT1>
- <PROGRAM_SUMMARY_POINT2>...
");
        // initialize variables
        bool userExit = false;

        // application loop, until userExit = true        
        try
        {
            while (!userExit)
            {
                // PROGRAM_CODE BELOW



                // option for user to exit
                Console.WriteLine("\nPress 'q' to exit or Enter to continue");
                if (Console.ReadLine() == "q") { userExit = true; }
            }
            Console.WriteLine("\n---End <program_name>---\n");
        }
        catch (Exception ex) { Console.WriteLine($"ERROR : {ex.Message}\n---Terminate Program---\n"); }
    }
}
}

