namespace PracticeTest
{
    class PizzaOrder
    {
        static void Main()
        {
            try
            {
                // Customer Order
                List<Pizza> customerOrder = new List<Pizza>();
                bool userExit = false;
                while (!userExit)
                {
                    OrderDisplay(customerOrder);
                    userExit = (Console.ReadLine() != "a") ? true : false;
                }


                // Customer Order Confirmation          
                string userChoice = String.Empty;
                while (userChoice != "x")
                {
                    if (userChoice == "k")
                    {
                        Console.WriteLine("Please enter your Address below (example: Sesame Street 10, 2 A 14) : ");
                        string userAddress = Console.ReadLine();
                        OrderConfirmation(customerOrder, userAddress);
                    }
                    else if (userChoice == "m")
                    {
                        customerOrder.Clear();
                        Console.WriteLine("Let's restart your order!");
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Goodbye! See you soon :) ");
                    }
                    Console.WriteLine(@"
Done Choosing? 
Confirm : Press 'k' | Cancel : Press 'x' | Modify : Press 'm'
");
                    userChoice = Console.ReadLine();
                }               
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR : {ex.Message}\n---Terminate Program---\n");
            }

        }





        static void OrderDisplay(List<Pizza> customerOrder)
        {
            Console.Title = "Pizza Order";
            Console.WriteLine(@"
            ~---~ Pizza Order ~---~
Chosen Toppings:
                ");

            Console.WriteLine(@"
Topping Options:");
            foreach (Pizza.Toppings top in Enum.GetValues(typeof(Pizza.Toppings)))
            {
                int index = Array.IndexOf(Enum.GetValues(top.GetType()), top);
                Console.WriteLine($"{index + 1}. {top}");
            }

            Console.WriteLine(@"
Enter Topping choice (Enter a number between 1-7 to add Topping) :
            ");

            int option = int.Parse(Console.ReadLine()) - 1;     // adjust with index values
            Pizza.Toppings topping = (Pizza.Toppings)option;
            Customer.OrderDetails(customerOrder, topping);      // TO-DO: verify workflow, RESOLVED ISSUE: convert int to enum datatype by parsing 
            //string topping = Enum.GetName(typeof(Pizza.Toppings), option);    
            //customerOrder.Add(topping);

            Console.WriteLine(@"
Press 'a' to continue to add Toppings
Press 'any key' to continue to confirm, cancel or modify the order
                ");
            Console.Clear();
        }


        // User Interface for Order Confirmation
        static void OrderConfirmation(List<Pizza> customerOrder, string userAddress)
        {
            Console.Title = "Pizza Order Confirmation";
            decimal totalPrice = Customer.CalculatePrice(customerOrder);
            decimal basePrice = Pizza.BasePrice;
            int toppings = customerOrder.Count();

            Console.WriteLine($@"
			~---~ Pizza Order Confirmation ~---~
Order:
{string.Join("& ", customerOrder)} topped Pizza

Address:
{userAddress}
Price:
{totalPrice} Euro  = (Pizza, {basePrice} Euro + {toppings} Toppings, {basePrice-totalPrice} Euro)

		~----~ Thank you for your Order! See you soon :) ~----~
");
        }
    }
}