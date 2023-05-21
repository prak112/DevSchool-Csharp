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

            switch (toppings)
            {
                case  4:
                    price = Pizza.BasePrice + 1;
                    return price;

                case 5:
                    price = Pizza.BasePrice + 2;
                    return price;

                case 6:
                    price = Pizza.BasePrice + 3;
                    return price;

                case 7:
                    price = Pizza.BasePrice + 4;
                    return price;

                case > 7:
                    price = Pizza.BasePrice + 7;
                    return price;

                default:
                    price = Pizza.BasePrice;
                    return price;
            }
        }

    }
}