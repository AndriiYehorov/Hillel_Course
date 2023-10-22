namespace ProduseStore
{
    public class Cart
    {
        private List<Product> cart = new List<Product>();
        public void AddToCart(Product product)
        {
            cart.Add(product);
        }
        public void RemoveFromCart(int productId)
        {
            try
            {
                cart.RemoveAll(prod=>prod.Id == productId);
                Console.WriteLine($"Товар с ИД {productId} удален из корзины!");
            }
            catch(ArgumentOutOfRangeException) 
            {
                Console.WriteLine("Не найден данный товар в корзине!");
            }

                
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product prod in cart)
            {
                totalPrice += prod.Price;
            }
            return totalPrice;
        }
        public void ItemsInCart()
        {
            Console.WriteLine("Товары в корзине: ");
            foreach (Product prod in cart)
            {
                Console.WriteLine($"Id = {prod.Id}, Name = {prod.Name}, Price = {prod.Price}");
            }
        }
    }
}
