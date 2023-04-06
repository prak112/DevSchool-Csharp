using Classes;
using System.Security.Principal;
using System.Xml.Linq;


// Tutorial soource : Microsoft Learn 
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes


// Main method
/*void Main(string[] args)
{

    var customer = new object[3] { account.ID, account.Owner, account.Balance };
    Console.WriteLine(customer);
$@"New account opened.
Account ID : {account.ID}
Owner Name : {account.Owner}
Account Balance : {account.Balance}");
  
}
*/


// create new customer account
var account = new BankAccount("DuFart", 1000);

// customer account overview -- HARDCODED, to create an array
Console.WriteLine($@"
New account opened.
Account ID : {account.ID}
Owner Name : {account.Owner}
Account Balance : {account.Balance}
");

// add transactions
account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Owner + "-" + account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Owner + "-" + account.Balance + "\n");

// test - account statement
try
{
    string accountStatement = account.GetAccountHistory();
    Console.WriteLine($"Account Statement April 2023 :\n{accountStatement}\n");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message + "\n");
}


// test - initial balance must be positive
BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("testAccount", -200);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("\nERROR : Account created with Negative Balance.\nDetails : " + ex.Message+"\n");
}

// test - withdraw amount exceeds Balance
try
{
    account.MakeWithdrawal(10200, DateTime.Now, "Test to withdraw amount exceed balance");
}
catch(InvalidOperationException ex)
{
    Console.WriteLine("\nERROR : Withdraw amount exceeds Balance.\nDetails : "+ex.Message+"\n");
    return;
}

