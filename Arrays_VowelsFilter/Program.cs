namespace Arrays;

internal class VowelsFilter
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
---Welcome To Vowel Filter---
Summary :
- Enter a word when asked
- Output will provide a list of vowels present in the word
");
        // initialize variables
        bool userExit = false;

        // initialize loop for continous use, till userExit = true
        try
        {
            while (!userExit)
            {
                Console.Write("Enter a word : ");
                string word = Console.ReadLine();
                int vowelCount = 0;

                // initialize Array to store vowels
                char[] vowelArray = new char[word.Length];
                // iterate word to assign vowels to vowelArray
                for (int i = 0; i < word.Length ; i++)
                {
                    switch (word[i])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'y':
                        case 'ä':     // Finnish vowels
                            vowelArray[i] = word[i];
                            vowelCount++;
                            break;

                        default: break;
                    }
                }
                Console.WriteLine($"Total Vowels : {vowelCount}\nVowels :");
                // iterate vowelArray and print only vowels
                foreach (char vowel in vowelArray)
                {
                    Console.Write($"-{vowel.ToString().Trim()}");
                }

                //option to exit
                Console.WriteLine("\nPress 'q' to exit or Enter to continue");
                if (Console.ReadLine() == "q") { userExit = true; }
            }
            Console.WriteLine("\n---End Vowel Filter---\n");
        }
        catch (Exception ex) { Console.WriteLine("ERROR : " + ex.Message); }
    }
}