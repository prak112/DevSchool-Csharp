namespace Classes;


// define class HEADER
public class BankAccount
{   
    // define Class Members

    public string ID 
    { 
        get 
        {
            // call and save Random method in a variable
            var random = new Random();
        
            // convert 10-digit random number to string
            string ID = random.Next().ToString();
            return ID;
        } 
    }
    public string Owner { get; set; }
    public decimal Balance 
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        } 
    }


    // define constructor (similar name as Class)
    public BankAccount (string name, decimal initialBalance)
    {      
        this.Owner = name;

        // need to understand
        MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");       
    }


    // define methods
    // create List in connection with Transaction Class
    private List<Transaction> allTransactions = new List<Transaction>();


    // deposit method
    public void MakeDeposit (decimal amount, DateTime date, string note)
    {   
        // define exceptions based on rules
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount cannot be Negative.");
        }

        // add transaction to allTransactions List
        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }


    // withdrawal method
    public void MakeWithdrawal (decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount cannot be Negative");
        }
        if (Balance < amount)
        {
            throw new InvalidOperationException("Insufficient Funds. Transaction not possible");
        }
         
        // add transaction to allTransactions List
        var withdrawal = new Transaction(-amount, date, note);
        allTransactions.Add(withdrawal);
    }

    // get account history as a string
    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();
        //decimal balance = 0;

        report.AppendLine("Date\tAmount\tNotes");
        foreach (var item in allTransactions)
        {
        //    balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortTimeString()}\t{item.Amount}\t{item.Notes}");
        }
        return report.ToString();

    }
}