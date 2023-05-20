using static PracticeTest.Pizza;

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
                    Console.WriteLine("Press 'a' to go back to Ordering, or\nPress 'enter' to continue");
                    userExit = (Console.ReadLine() != "a") ? true : false;

                    Console.Clear();
                }


                // Customer Order Confirmation          
                string userChoice = String.Empty;
                bool orderStatus = false;
                while (!orderStatus)
                {
                    switch (userChoice)
                    {
                        case "k":
                            Console.WriteLine("Please enter your Address below (example: Sesame Street 10, 2 A 14) : ");
                            string userAddress = Console.ReadLine();
                            OrderConfirmation(customerOrder, userAddress);
                            orderStatus = true;
                            break;
                        case "m":
                            customerOrder.Clear();
                            Console.WriteLine("Let's restart your order!");
                            orderStatus = true;
                            Main();
                            break;
                        case "x":
                            Console.WriteLine("Goodbye! See you soon :) ");
                            orderStatus = true;
                            break;
                        default:
                            Console.WriteLine(@"
Done Choosing? 
Confirm : Press 'k' | Cancel : Press 'x' | Modify : Press 'm'
");
                            userChoice = Console.ReadLine();
                            break;
                    }
                }
             //   Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR : {ex.Message}\n---Terminate Program---\n");
            }

        }




        // User Interface for Order Menu -iterate customerOrder
        static void OrderDisplay(List<Pizza> customerOrder)
        {
            Console.Title = "Pizza Order";

            // list chosen toppings
            if (customerOrder.Count != 0)
            {
                Console.WriteLine(@"
            ~---~ Pizza Order ~---~
Chosen Toppings: ");
                int index = 0;
                foreach (Pizza top in customerOrder)
                {
                    Console.WriteLine($"{index + 1}. {top.Topping}");
                    index++;
                }
            }
            
            // Pizza Topping Menu -iterate enum Toppings values
            Console.WriteLine(@"
            ~---~ Pizza Order ~---~

Topping Options (Press 'enter' to exit menu):");
            foreach (Toppings top in Enum.GetValues(typeof(Toppings)))
            {
                int index = Array.IndexOf(Enum.GetValues(top.GetType()), top);
                Console.WriteLine($"{index + 1}. {top}");
            }
            Console.WriteLine(@"
Enter Topping choice (Enter a number between 1-7 to add Topping) :");
             // user exits or chooses topping
            var option = Console.ReadLine();
            if (option == string.Empty) { return; }         // user exits order menu
            else            // user chooses topping         // TO-DO: User chooses all toppings at once
            { 
                int choice = int.Parse(option) - 1;
                // update user topping choices to List<Pizza> customerOrder
                Toppings topping = (Toppings)choice;
                Customer.OrderDetails(customerOrder, topping);      // convert int option to enum datatype
            }    

            Console.WriteLine(@"
Press 'a' to continue to add Toppings
Press 'enter' to continue to Wrap-Up or Wrap-Down Order");
            if (Console.ReadLine() == string.Empty) { return; }     // user exits order menu  
        }


        // User Interface for Order Confirmation
        static void OrderConfirmation(List<Pizza> customerOrder, string userAddress)
        {
            Console.Title = "Pizza Order Confirmation";

            decimal totalPrice = Customer.CalculatePrice(customerOrder);
            decimal basePrice = Pizza.BasePrice;
            int totalToppings = customerOrder.Count();
            string orderedToppings = string.Empty;
            foreach (Pizza p in customerOrder)
            {
                orderedToppings += p.Topping.ToString() + " & ";
            }

            Console.WriteLine($@"
			~---~ Pizza Order Confirmation ~---~
Order:
Pizza topped with {orderedToppings}Awesomeness!

Address:
{userAddress}

Price:
{totalPrice} Euro  = (Pizza - {basePrice} Euro,  {totalToppings} Toppings - {totalPrice-basePrice} Euro)

		~----~ Thank you for your Order! See you soon :) ~----~
");
        }
    }
}