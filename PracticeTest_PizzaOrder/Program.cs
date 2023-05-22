using static PracticeTest.Pizza;

namespace PracticeTest
{
    class PizzaOrder
    {
        static void Main()
        {
            //TO-DO : record terminal output for README (Task Output)
            

            try
            {
                // Customer Order
                List<Pizza> customerOrder = new List<Pizza>();
                OrderDisplay(customerOrder);

                // Customer Order Confirmation          
                string userChoice = String.Empty;
                bool orderComplete = false;
                while (!orderComplete)
                {
                    Console.Title = "Pizza Order";

                    switch (userChoice)
                    {
                        case "k":
                            // ask delivery address and call OrderConfirmation method
                            OrderConfirmation(customerOrder);
                            orderComplete = true;
                            break;

                        case "a":
                            // user adds more toppings and returns to confirm order
                            OrderDisplay(customerOrder);
                            userChoice = String.Empty;
                            break;
                            
                        case "r":
                            // clear customerOrder list and return to Main()
                            customerOrder.Clear();
                            Console.WriteLine("Let's restart your order!");
                            orderComplete = true;
                            Main();
                            break;
                        
                        case "x":
                            // customer exits
                            Console.WriteLine("Goodbye! See you soon :) ");
                            orderComplete = true;
                            // display message until user presses any key
                            Console.WriteLine("...Press any key to exit...");
                            Console.ReadKey();
                            break;
                        
                        default:
                            // confirm order -iterate customerOrder
                            // list chosen toppings
                            Console.WriteLine(@"
        ~---~ Pizza Order ~---~

Chosen Toppings: ");
                            int index = 0;
                            foreach (Pizza top in customerOrder)
                            {
                                Console.WriteLine($"{index + 1}. {top.Topping}");
                                index++;
                            }
                            
                            // choices for customer to proceed
                            Console.WriteLine(@"
Done Choosing? 
Confirm : Press 'k' | Cancel : Press 'x' | Restart Order : Press 'r' | Add more Topping : Press 'a'
");
                            userChoice = Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR : {ex.Message}\n---Terminate Program---\n");
            }

        }



        // Static Methods for User Interface
        // User Interface for Order Menu -iterate customerOrder
        static void OrderDisplay(List<Pizza> customerOrder)
        {
            bool userExit = false;
            do
            {
                Console.Title = "Pizza Order";

                // user wants to add more toppings
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
Enter Topping choice (example: 2 3 5):");
                // user exits or chooses topping
                string options = Console.ReadLine();
                if (options == string.Empty)        // user redirected to Pizza Order Confirmation menu to exit
                { Console.Clear();  return; }         
                else                                // user chooses all toppings at once
                {
                    string[] choices = options.Split(' ');
                    foreach (string ch in choices)
                    {
                        int choice = Convert.ToInt32(ch) - 1;
                        // update user topping choices to List<Pizza> customerOrder
                        Toppings topping = (Toppings)choice;
                        Customer.OrderDetails(customerOrder, topping);      // convert int option to enum datatype
                    }
                }

                Console.WriteLine("Press 'enter' to continue to Order Wrap-Up");
                userExit = (Console.ReadLine() == string.Empty) ? true : false;      // user exits order menu  

                Console.Clear();

            } while (!userExit);
        }


        // User Interface for Order Confirmation
        static void OrderConfirmation(List<Pizza> customerOrder)
        {
            Console.Title = "Pizza Order Confirmation";

            if (customerOrder == null || customerOrder.Count == 0) 
            {
                Console.WriteLine("Press 'enter' to order or type '$' to give us free money :P ");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("\nPlease enter Address for delivery below (example: Sesame Street 10, 2 A 14) : ");
                string userAddress = Console.ReadLine();

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

Delivery Address:
{userAddress}

Price:
{totalPrice} Euro  = {basePrice} Euro (Pizza) + {totalPrice - basePrice} Euro ({totalToppings} Toppings)

		~----~ Thank you for your Order! See you soon :) ~----~
                ");

                // display message until user presses any key
                Console.WriteLine("...Press any key to exit...");
                Console.ReadKey();
            }
            
        }
    }
}