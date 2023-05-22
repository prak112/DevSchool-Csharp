namespace PracticeTest
{
    class Customer
    {
        // Properties
        public List<Pizza> OrderList { get; set; }

        // Constructor
        public Customer() 
        {
            OrderList = new List<Pizza>(); ;
        }

        // Methods
        public static List<Pizza> OrderDetails (List<Pizza> OrderList, Pizza.Toppings topping)
        {
            Pizza order = new Pizza(topping);
            OrderList.Add(order);
            return OrderList;
        } 


        public static decimal CalculatePrice(List<Pizza> customerOrder)
        {
            decimal price = 0;
            int toppings = customerOrder.Count();

            if (toppings > 3)           // increment price by 1 if toppings > 3
            {
                price = Pizza.BasePrice + (customerOrder.Count() - 3) ;
                return price;
            }
            else                        // base price 15, if toppings < 3
            {
                price = Pizza.BasePrice ;
                return price ;
            }
        }

    }
}