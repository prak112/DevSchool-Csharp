//import libraries
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures;

internal class DataStructures
{
    private static void Main(string[] args)
    {
        #region Arrays

        Console.WriteLine("\n---Welcome To Array Operations---\n\nArrays will save your inputs. Enter 3 numbers (press 'q' to Exit) : ");
        // initialize array
        int[] intsArray = new int[3];
        int result = 0;
        int userInput = 0;
        bool userExit = false;

        // save user input
        try
        {
            while (!userExit)
            {
                Console.WriteLine($"Sum of Numbers using FOR loop");
                for (int i = 0; i < intsArray.Length; i++)
                {
                    intsArray[i] = int.Parse(Console.ReadLine());
                    result += intsArray[i];
                }
                Console.WriteLine($"FOR loop result : {result}");
                // same operation using FOREACH
                Console.WriteLine($"Sum of Numbers using FOREACH loop");
                result = 0;
                foreach (int i in intsArray)
                {
                    userInput = int.Parse(Console.ReadLine());
                    result += userInput;
                }
                Console.WriteLine($"FOREACH loop result : {result}");
                // option for user to quit
                Console.WriteLine("Press 'q' to Exit");
                if (Console.ReadLine() == "q")
                {
                    userExit = true;
                }
            }
            Console.WriteLine($"Using Array Function for sum : {intsArray.Sum()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR : " + ex.Message);
        }
        // sum the inputs and print
        Console.WriteLine("\n---End Array Elements Sum---\n");
        #endregion


        #region Lists

        Console.WriteLine("\n---Welcome To LIST Operations---\n\nLIST will save your inputs. Enter numbers (Press 'q' to Exit) : ");
        // intialize List
        var numList = new List<int>();
        int listResult = 0;
        userExit = false;
        // read user inputs
        try
        {
            while (!userExit)
            {
                userInput = int.Parse(Console.ReadLine());
                numList.Add(userInput);
                listResult += userInput;
                // option for user to quit
                if (Console.ReadLine() == "q")
                {
                    userExit = true;
                }
            }
            //sum the inputs
            Console.WriteLine($"Sum of Numbers, manual: {listResult}\nUsing Array Function for sum : {numList.Sum()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR : " + ex.Message);
        }
        Console.WriteLine("\n---End LIST Elements Sum---\n");

        #endregion


        #region StringSearchInArrays

        Console.WriteLine("\n---Welcome To String Search in ARRAYS---\n\nARRAY will save your inputs.");
        try
        {
            // intialize exit option
            userExit = false;

            // concat all verified Characters
            string verifiedChars = "";

            // iterate user inputs
            while (!userExit)
            {
                Console.WriteLine("Enter 2 words (Press 'q' to Exit) : ");
                // user inputs
                Console.Write("Word 1: ");
                string word1 = Console.ReadLine();
                Console.Write("Word 2: ");
                string word2 = Console.ReadLine();

                // initialize 2-Dimensional Array with Char(for verifying Chars) and Int(for Char count) datatypes
                (char charValues, int charCounts)[] commonChars = new (char, int)[word1.Length];

                // iterate word1 characters
                for (int i = 0; i < word1.Length; i++)
                {
                    // track character count and assign to charCounts Array
                    int charCount = 0;
                    // iterate word2 characters
                    for (int j = 0; j < word2.Length; j++)
                    {
                        if (word1[i] == word2[j] && verifiedChars.Contains(word1[i])==false)
                        {
                            charCount++;        // update tracker
                            commonChars[i] = (word1[i], charCount); // assign character and count to Array
                        }
                        else
                        {
                            commonChars[i] = (word1[i], charCount); // assign character and count to Array
                        }
                    }
                    verifiedChars += word1[i];
                }

                // iterate each item in commonChars Array and display as a table
                foreach (var item in commonChars)
                {
                    if (item.charCounts == 0 | item.charValues == null)
                    {
                        Console.WriteLine($"Character '{item.charValues}' - Not Found in Word 2\n");
                    }
                    else
                    {
                        Console.WriteLine($"Character '{item.charValues}' - {item.charCounts} Time/s in Word 2\n");
                    }
                }
                // option for user to quit

                Console.WriteLine("Press 'q' to Exit or 'Enter' to Continue");
                if (Console.ReadLine() == "q")
                {
                    userExit = true;                
                }
            }
            Console.WriteLine("\n---End String Search using Arrays---\n");
        }
        catch (Exception ex) { Console.WriteLine("ERROR : " + ex.Message); }        

        #endregion
    }
}





