namespace ProduseStore
{
    public class Product
    {
        private static int id=1;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }
        public Product(string name, double price)
        {
            Id = id++;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Price = {Price}";
        }
    }
}
