namespace T6_Kolmion_Pinta_ala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
----Area of Triangle calculation----

Enter Width (kanta) and Height (korkeus) of the Triangle (Kolmio):");
            Console.WriteLine("Enter Width of Triangle (whole number/decimal) = ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height of Triangle (whole number/decimal) = ");
            double height = double.Parse(Console.ReadLine());
            double area = (width * height) / 2d;
            Console.WriteLine($@"Area of Triangle with width = {width} and height = {height} is {area} square units

---End of Calculation---");
        }
    }
}