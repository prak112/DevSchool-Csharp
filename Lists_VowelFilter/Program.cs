namespace Lists;

internal class VowelFilter
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
---Welcom to Vowel Filter using LIST---
Summary:
- same as the previous, enter a word
- output prints only vowels
");
        // initialize variables
        bool userExit = false;
        // initialize loop for continuos usage until userExit = True
        try
        {
            while (!userExit)
            {
                // user input
                Console.WriteLine("Enter a word: ");
                string word = Console.ReadLine().ToLower();
                int vowelCount = 0;         // track total vowels

                // initialize vowelList
                List<char> vowelList = new List<char>();
                // iterate characters of word
                for (int i = 0; i < word.Length; i++)
                {
                    // filter vowels
                    switch (word[i])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'ä':
                        case 'ö':
                        case 'y':       // Finnish vowels
                            vowelList.Add(word[i]);     // add vowel to vowelList
                            vowelCount++;
                            break;

                        default:
                            break;
                    }
                }
                Console.WriteLine($"Total Vowels : {vowelCount}");
                // print vowels to display
                foreach (char c in vowelList)
                {
                    Console.Write($"-{c.ToString().Trim()}");         // remove nulls, print Hangman style
                }

                // option for user to exit
                Console.WriteLine("\nPress 'q' to exit or Enter to continue");
                if (Console.ReadLine() == "q") { userExit = true; }
            }
            Console.WriteLine("\n---End Vowel Filter using LIST---\n");
        }
        catch (Exception ex) { Console.WriteLine("ERROR : " + ex.Message); }

    }
}