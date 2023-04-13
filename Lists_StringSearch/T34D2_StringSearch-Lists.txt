namespace Lists;

internal class StringSearch
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
---Welcom to String Search in LISTS---
Summary:
- program interprets repeating characters from 1st input with 2nd input 
- output shows how many times each character from 1st input appeared in 2nd input
");
        // initialize variables
        bool userExit = false;
        // initialize loop for continuos ply until userExit = True
        try
        {
            while (!userExit)
            {
                // initalize 2-D LIST, for reading characters and indices
                List<(char, int)> commonChars = new List<(char, int)>();
                string verifiedChars = "";  // track characters

                // user input                
                Console.Write("Enter the word to be checked : ");
                string word1 = Console.ReadLine();
                Console.Write("Enter the reference word : ");
                string word2 = Console.ReadLine();


                // iterate through word1
                for (int i = 0; i < word1.Length; i++)
                {
                    int charCount = 0;      // track character count
                    // iterate through word2
                    for (int j = 0; j < word2.Length; j++)
                    {
                        // verify word1 character
                        if (word1[i] == word2[j] && verifiedChars.Contains(word1[i]) == false)
                        {
                            charCount++;        // update character count
                            commonChars.Add((word1[i], charCount)); // assign values to commonChars List                            
                        }                     
                    }
                    verifiedChars += word1[i];      // update characters
                }
                Console.WriteLine($"Characters verified : {verifiedChars}\r\n");
                foreach((char c, int i) in commonChars)
                {
                    Console.WriteLine($"Character {c} of Word1 - Appears {i} time/s in Word2\n");
                }

                // option for user to exit
                Console.WriteLine("Press 'q' to exit or Enter to continue");
                if(Console.ReadLine() == "q") { userExit = true; }
            }
            Console.WriteLine("\n---End String Search in LISTS---\n");
        }
        catch (Exception ex) { Console.WriteLine("ERROR : " + ex.Message); }
    }
}