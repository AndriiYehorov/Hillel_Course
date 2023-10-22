namespace ProduseStore
{
    public class Shop
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int productId)
        {
            Product productRemove = GetProductById(productId);
            int idProduct = products.FindIndex(product => product == productRemove);
            try
            {
                products.RemoveAt(idProduct);
            }
            catch(ArgumentOutOfRangeException) 
            {
                Console.WriteLine("Не найден данный товар в магазине!");
            }
        }

        public Product GetProductById(int productId)
        {
            Product product = products.Find(prod => prod.Id==productId);
            return product;
        }

        public List<Product> GetAllProduct()
        {
            return products;
        }
    }
}
