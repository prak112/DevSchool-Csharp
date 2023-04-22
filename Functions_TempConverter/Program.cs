using Converter;

namespace Functions
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("---Welcome to Temperature Converter by Functions---");

                // option to exit
                bool userExit = false;

                while(!userExit)
                {
                    Console.WriteLine("Choose conversion unit :\r\n- 'c' converts To Celsius\r\n- 'f' converts To Fahrenheit\n");
                    // read user input
                    string convertTo = Console.ReadLine();
                    Console.Write("Enter value to convert : ");
                    double conversionValue = Convert.ToDouble(Console.ReadLine());

                    // call method, pass parameters
                    double convertedValue = Methods.TemperatureConverter(convertTo, conversionValue);
                    // display output
                    Console.WriteLine($"Converted Temperature value : {convertedValue}");

                    // option to exit
                    Console.WriteLine("Press 'q' to Exit or Enter to Continue");
                    userExit = Console.ReadLine() == "q" ? true : false;
                }
            }
            catch (Exception ex) { Console.WriteLine("ERROR : " + ex.Message); }
        }
    }    
}