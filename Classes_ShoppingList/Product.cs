namespace Shopping
{
    class Product
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private static Random Rand = new Random();

        // Constructor
        public Product(string aName)
        {
            Id = Rand.Next(1000, 100000);
            Name = aName;
            Price = Math.Round(Rand.NextDouble() * 100, 2);
        }

        // Methods

    }
}
