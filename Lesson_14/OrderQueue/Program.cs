namespace OrderQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Order> queue = new Queue<Order>();
            List<Order> processedOrders = new List<Order>();
            //начально заполнил для теста
            queue.Enqueue(new Order("Игорь", 123.23));
            queue.Enqueue(new Order("Галина", 140.0));
            queue.Enqueue(new Order("Афанасий", 215.3));
            queue.Enqueue(new Order("Илья", 146.0));
            queue.Enqueue(new Order("Альберт", 12));

            do
            {
                Console.WriteLine((byte)Menu.ShowQueue + ". Показать очередь заказов.");
                Console.WriteLine((byte)Menu.ProcessTheOrder + ". Обработать следующий в очереди.");
                Console.WriteLine((byte)Menu.ShowProcessedOrders + ". Показать обработанные заказы.");
                Console.WriteLine((byte)Menu.AddOrder + ". Добавить заказ в очередь.");
                Console.WriteLine((byte)Menu.Exit + ". Завершить работу.");
                Console.WriteLine("Что вы хотите сделать?");
                byte elMenu = ReadChoice();
                if ((Menu)elMenu == Menu.ShowQueue)
                {
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item.ToString());
                    }

                }
                else if ((Menu)elMenu == Menu.ProcessTheOrder)
                {
                    Console.Clear();
                    processedOrders.Add(queue.Dequeue());
                }
                else if ((Menu)elMenu == Menu.ShowProcessedOrders)
                {
                    Console.Clear();
                    foreach (var item in processedOrders)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else if ((Menu)elMenu == Menu.AddOrder)
                {
                    Console.Clear();
                    AddOrderInQueue(queue);
                }
                else
                {
                    break;
                }

            } while (true);
        }

        private static void AddOrderInQueue(Queue<Order> queue)
        {
            double choice;
            bool isInputRight;
            Console.WriteLine("Введите данные заказа(имя клиента, сумма заказа): ");
            Console.WriteLine("Имя клиента: ");
            string name = Console.ReadLine();
            do
            {
                Console.WriteLine("Сумма заказа: ");
                string enter = Console.ReadLine();
                isInputRight = double.TryParse(enter, out choice);
            } while (!isInputRight);
            queue.Enqueue(new Order(name, choice));
            Console.WriteLine("Заказ создан!");
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
            } while (!isInputRight || choice < (byte)Menu.Exit || choice > (byte)Menu.AddOrder);
            return choice;
        }
    }
}