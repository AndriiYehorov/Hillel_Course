namespace ProduseStore
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Price = {Price}";
        }
    }
}
