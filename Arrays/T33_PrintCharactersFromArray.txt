
#region T33_PrintCharacters-Forward-Backward
// Arrays initialization
Console.WriteLine("----Welcome to Arrays----\nEnter a string or a phrase :");
string userInput = Console.ReadLine();
string[] inputSplit = userInput.Split();

Console.WriteLine("\nx-Each Character Reversed-x");
foreach (string input in inputSplit)
{
    char[] chars = input.ToCharArray();
    Array.Reverse(chars);
    string reverseString = new string(chars);
    Console.Write(reverseString);
}

Console.WriteLine("\n\nx-Each String Reversed-x");
foreach (string input in inputSplit.Reverse())
{
    Console.Write(input);
}

Console.WriteLine("\n---End Program----\n");

#endregion
