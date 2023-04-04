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

var account = new BankAccount("Du-Fart", 1000);

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);

Console.WriteLine(
$@"New account opened.
Account ID : {account.ID}
Owner Name : {account.Owner}
Account Balance : {account.Balance}");


