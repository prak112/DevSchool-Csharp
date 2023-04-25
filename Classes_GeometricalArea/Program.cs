
using System.Diagnostics.Metrics;

namespace GeometricalArea
{
    class GeometricalArea
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"
---Welcome to Geometrical Area of Triangle and Square (in Classes)---
Summary :
- Choose a shape
- Enter dimensions
- Get Surface Area and Perimeter
            ");

            // user options to exit
            bool userExit = false;

            // iterate until userExit = true
            while (!userExit)
            {
                Console.WriteLine(@"
Choose a shape:
- 't' for Triangle
- 's' for Square

Press 'q' to Exit or Enter to Continue
                ");
                
                string userChoice = Console.ReadLine();
                // process userChoice
                switch (userChoice)
                {
                    // Triangle block
                    case "t":
                        // user input
                        Console.WriteLine("Enter dimensions of Triangle :\n1 - 'Base'\n2 - 'Height'");
                        double triangleBase = double.Parse(Console.ReadLine());
                        double triangleHeight = double.Parse(Console.ReadLine());

                        // create Triangle object
                        Triangle userTriangle = new Triangle(triangleBase, triangleHeight);
                        double triangleArea = userTriangle.Area(triangleBase, triangleHeight);
                        double trianglePerimeter = userTriangle.Perimeter(triangleBase);

                        // display results
                        Console.WriteLine($@"
Triangle Dimensions : Base = {triangleBase} and Height = {triangleHeight}
Triangle Surface Area : {triangleArea}
Triangle Perimeter : {trianglePerimeter}

Press 'q' to Exit or Enter to Continue
");

                        // user option to exit
                        userExit = Console.ReadLine() == "q" ? true : false;
                        break;

                    // Square block
                    case "s":
                        // user input
                        Console.WriteLine("Enter dimensions of Square :\n1 - 'Side'");
                        double squareSide = double.Parse(Console.ReadLine());

                        // create Triangle object
                        Square userSquare = new Square(squareSide);
                        double squareArea = userSquare.Area(squareSide);
                        double squarePerimeter = userSquare.Perimeter(squareSide);

                        // display results
                        Console.WriteLine($@"
Square Dimensions : Side = {squareSide}
Square Surface Area : {squareArea}
Square Perimeter : {squarePerimeter}

Press 'q' to Exit or Enter to Continue
");

                        // user option to exit
                        userExit = Console.ReadLine() == "q" ? true : false;
                        break;

                    // Valid input or Exit or Continue block
                    default: 
                        Console.WriteLine(@"
Please enter a valid input. 
Choose a shape :
- 't' for Triangle
- 's' for Square

Press 'q' to Exit or Enter to Continue");

                        // user option to exit
                        userExit = Console.ReadLine() == "q" ? true : false;
                        break;
                }
            }
            Console.WriteLine("\n---Terminate Program---\n");
        }
    }
}