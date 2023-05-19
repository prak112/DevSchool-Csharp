namespace Shopping
{
    class Program
    {
        /* Design
         * Features- 
         *  Where - shop to buy from -user input
         *  What - product -user input
         *  How Many - count of product -user input
         *  How Much - price of product -calculate
         *  
         * Display-
         *  Clear after user input
         *  Instructions to request on continuous display after every Console.Clear()
         *  Display (where, what, how many & how much) when requested
         */
        public static void Main(string[] args)
        {

            Console.WriteLine("\n---Welcome to your Personal Shopping List---\n");
            Console.Clear();
            HowTo.Use();

        }


        // to be called after every Console.Clear() statement
        static class HowTo
        {
            public static void Use()
            {
                Console.WriteLine(@"
To view Listed items so far and their prices, type :
    'show list'
at the next input request
");
            }
        }
    }
}