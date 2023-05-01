namespace Program
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"
---Welcom to Length Conversion from Meter to other Length Units---
Summary:
- Enter Length in Metres
- Program displays converted units in one of chosen Length Units, i.e.,
    -Centimeter
    -Decimetre
    -Kilometer
    -Inch
    -Foot
    -Yard
");
            // initialize variables
            bool userExit = false;

            // application loop, until userExit = true        
            try
            {
                while (!userExit)
                {
                    // user input
                    Console.Write("\nEnter any length (in Metres): ");
                    double length = double.Parse(Console.ReadLine());
                    Console.WriteLine(@"
Select unit to convert to :
    -'c' for Centimeter
    -'d' for Decimetre
    -'k' for Kilometer
    -'i' for Inch
    -'f' for Foot
    -'y' for Yard
");
                    string convertTo = Console.ReadLine();

                    // create LengthConverter class object, pass length
                    LengthConverter lengthConverter = new LengthConverter(length);

                    // switch block for calling method based on convertTo
                    switch (convertTo)
                    {
                        case "c":
                            Console.WriteLine($"{length} Meters = {lengthConverter.ToCentimeter()} Centimeters");
                            break;
                        case "d":
                            Console.WriteLine($"{length} Meters = {lengthConverter.ToDecimeter()} Decimeters");
                            break;
                        case "k":
                            Console.WriteLine($"{length} Meters = {lengthConverter.ToKilometer()} Kilometers");
                            break;
                        case "i":
                            Console.WriteLine($"{length} Meters = {lengthConverter.ToInch()} Inches");
                            break;
                        case "f":
                            Console.WriteLine($"{length} Meters = {lengthConverter.ToFoot()} Feet");
                            break;
                        case "y":
                            Console.WriteLine($"{length} Meters = {lengthConverter.ToYard()} Yards");
                            break;
                        default:
                            break;
                    }

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