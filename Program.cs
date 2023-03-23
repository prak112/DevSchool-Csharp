// See https://aka.ms/new-console-template for mo+re information
using System;
using System.Diagnostics.CodeAnalysis;

namespace Datatypes
{

    class Program
    {
        static void Main(string[] args)
        {
            // koodi alhaalla--
            //Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Terve Maailmaa!");

            // Datatypes - datatyppit
            // Numbers - Numeroita
            // 35 - kokonaisluku - integer
            // 13.5 - liukuluku - float
            // Char / String - Merkkejä / Merrkijono
            // Bool - True/False - 1/0
            // Literals
            // variable syntax - muuttuja syntaksi
            // <data_type> <variable name>

            // integer
            int year = 2000;
            year += 23;
            Console.WriteLine($"Ohjelmistokehittäjä koulutus aloitta vuonna {year}\n");

            // double
            double piValue = Math.PI;
            piValue = Math.Round(piValue);
            Console.WriteLine($"Area of a circle = {piValue} * (radius of circle) squared\n");

            // char & string
            char myChar = 'S';
            string myCats = "Sally-Suridu";
            Console.WriteLine($"Both {myCats} names start with {myChar}");

            // bool
            bool vastaus = true;
            Console.WriteLine($"Kun kissa soitta, täytyy mennä leikkimaan - True or False\n{vastaus}\n");
            

            Console.WriteLine("---End of Nonsense---");

            // waits for user input
            Console.ReadKey();

            // clears the output window
            Console.Clear();


            // awaits user input
            //string userInput = Console.ReadLine();
            //string date = DateTime.Now.Date;
            //string day = DateTime.Now.Date.DayOfWeek;
            //Console.WriteLine($"Hello, {userInput}! Today is {date} and the day is {day}!");
            //Console.WriteLine("Hello, "+ userInput " ! Today is " + date + " and the day is "+ day +" !")


            #region 3 C# Perus- Ikä Tehtävä
            
            // Ikä 
            Console.WriteLine("---Aloitetaan Tehtävät---");

            Console.WriteLine("\n\nAnna jokaisen ikä alhaalla-");
            int userAge = int.Parse(Console.ReadLine()); 
            Console.WriteLine($"Olet {userAge} vuotias");

            // Ikä kuukausina
            int ageInMonths = userAge * 12;
            Console.WriteLine($"Olet {userAge} vuotias, eli {ageInMonths} kuukausina!");
            Console.ReadKey();
            Console.Clear();

            #endregion

        }
    }

}