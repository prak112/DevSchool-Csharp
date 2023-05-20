namespace PracticeTest
{

    class Pizza
    {

        public enum Toppings
        {
            Pepperoni,      // index 0
            Mushroom,       // index 1
            Cheddar,        // index 2
            Chicken,        // index 3
            Olive,          // index 4
            Meat,           // index 5
            Tuna            // index 6
        }

        // Properties
        public static decimal BasePrice = 15;
        
        public Toppings Topping { get; set; }

        // Constructor
        public Pizza(Toppings aTopping)
        {
            Topping = aTopping;
        }

    }
}