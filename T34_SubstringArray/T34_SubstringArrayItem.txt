/*TASK
 * 1 - Using Arrays split user input (string) into userArray
 * 2 - Ask userInput for startIndex and endIndex
 * 3 - Loop userInput for indexes until valid inputs are given, i.e., startIndex > 0 and endIndex < Array.Length
 * 4 - Output subset of userArray
 */


Console.WriteLine("----Welcome to Substrings----\n--Substring using SubString method--\nEnter a string or a phrase :");
string userString = Console.ReadLine();
string[] userArray = userString.Split();

// initialize subset indices
int startIndex = 0;
int endIndex = 0;

#region option1 - Substring

// iterate user input for substring indices
try
{
    do
    {
        Console.WriteLine("Enter starting index to remove :");
        startIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter ending index to remove :");
        endIndex = int.Parse(Console.ReadLine());

    } while (startIndex < 0 && endIndex >= userArray.Length);
}
catch(Exception ex)
{
    Console.WriteLine("ERROR : " + ex.Message);
}
// substring user input
string subString = userArray[0].Substring(startIndex, endIndex);
Console.WriteLine($"Current String : {userArray[0]}\nChosen substring : {subString}\n---End Substring---\n");

#endregion


#region option2 - Loop Arrays

// iterate string until required region of substring acquired
Console.WriteLine("--Substring using FOR loop--\n");
string loopResult = "";
for (int i = startIndex; i <= endIndex; i++)
{
    loopResult += userArray[0][i];
}
Console.WriteLine($"Current String : {userArray[0]}\nChosen Substring : {loopResult}\n---End Loop---\n");

#endregion


#region option3 - LINQ
// ask user input for which array item to substring
// split the specific array item -> Array[userChoice].ToCharArray()
// use LINQ -> Array.Skip(startIndex).Take(endIndex)

#endregion


