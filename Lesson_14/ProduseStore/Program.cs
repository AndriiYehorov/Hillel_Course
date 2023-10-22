namespace ProduseStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            InitialFilling(shop);
            Cart cart = new Cart();
            do
            {
                Console.WriteLine((byte)Menu_Cart.AddCart + ". Добавить товар в корзину.");
                Console.WriteLine((byte)Menu_Cart.Remove + ". Удалить товар из корзины.");
                Console.WriteLine((byte)Menu_Cart.GetTotalPrice + ". Посмотреть сумму покупки.");
                Console.WriteLine((byte)Menu_Cart.Exit + ". Завершить работу.");
                Console.WriteLine("Что вы хотите сделать?");
                byte elMenu = ReadChoice();
                if ((Menu_Cart)elMenu == Menu_Cart.AddCart)
                {
                    int id = GetIdFromeUser(shop,null,false);
                    Product prod = shop.GetProductById(id);
                    if (!(prod == null))
                    {
                        cart.AddToCart(prod);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("По выбранному ИД нет доступного товара!");
                    }
                    
                }
                else if ((Menu_Cart)elMenu == Menu_Cart.Remove)
                {
                    Console.Clear();
                    int id = GetIdFromeUser(null,cart, true); 
                    cart.RemoveFromCart(id);
                }
                else if ((Menu_Cart)elMenu == Menu_Cart.GetTotalPrice)
                {
                    Console.Clear();
                    Console.WriteLine($"Стоимость товаров в корзине = {cart.GetTotalPrice()}");
                }
                else
                {
                    break;
                }

            } while (true);
        }

        public static void InitialFilling(Shop shop)
        {
            shop.AddProduct(new Product("Молоко", 15.75));
            shop.AddProduct(new Product("Хлеб", 12.00));
            shop.AddProduct(new Product("Чай", 17.50));
            shop.AddProduct(new Product("Сахар", 21.00));
            //shop.GetAllProduct().ForEach(product => Console.WriteLine(product));
        }

        static byte ReadChoice()
        {
            string enter;
            bool isInputRight;
            byte choice;
            Console.WriteLine("");
            do
            {
                enter = Console.ReadLine();
                isInputRight = byte.TryParse(enter, out choice);
            } while (!isInputRight || choice < (byte)Menu_Cart.Exit || choice > (byte)Menu_Cart.GetTotalPrice);
            return choice;
        }

        static int GetIdFromeUser(Shop shop, Cart cart, bool thisCart) 
        {
            string input;
            int id;
            bool res = false;
            do
            {
                Console.WriteLine("Выберите товар: ");
                if (!thisCart)
                {
                    shop.GetAllProduct().ForEach(product => Console.WriteLine(product));
                    input = Console.ReadLine();
                    res = int.TryParse(input, out id);
                }
                else 
                {
                    cart.ItemsInCart();
                    input = Console.ReadLine();
                    res = int.TryParse(input, out id);
                }
                    

            } while (!res);
            
            return id;
        }
    }
}