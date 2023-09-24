namespace PostalAddresses
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeCatalog = 5;
            Address[] arrAdr = new Address[sizeCatalog];
            var addr = new Address();

            do
            {
                Console.WriteLine((byte)Menu.Fill + ". Добавить адрес");
                Console.WriteLine((byte)Menu.Show + ". Показать адреса");
                Console.WriteLine((byte)Menu.Exit + ". Выход из программы");

                byte elMenu = ReadChoice();
                if (elMenu == (byte)Menu.Exit)
                {
                    return;
                }
                else if (elMenu == (byte)Menu.Fill)
                {
                    FillAdrresses(arrAdr, addr);
                    Console.Clear();
                }
                else
                {
                    if (arrAdr[0] == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Нет ни одного адреса!");
                    }
                    else
                    {
                        Console.Clear();
                        PringAdresses(arrAdr, addr);
                    }
                }
            }
            while (true);
        }

        private static void PringAdresses(Address[] arrAdr, Address addr)
        {
            for (int i = 0; (i < arrAdr.Length && arrAdr[i] != null); i++)
            {
                arrAdr[i].PrintAddress();     
            }
        }

        private static void FillAdrresses(Address[] arrAdr, Address addr)
        {
            for (int counter = 0; counter < arrAdr.Length; counter++)
            {
                Console.Clear();
                arrAdr[counter] = new Address();
                GetDataFromUser(arrAdr[counter]);
                if (ContinueFill() && counter < arrAdr.Length)
                {
                    continue;
                }
                else
                {
                    break;
                }              
            }
        }

        private static void GetDataFromUser(Address arrAdr)
        {
            bool res;
            int result;
            do
            {
                Console.WriteLine("Ведите индекс (формат 1001-9999): ");
                string index = Console.ReadLine();
                res = int.TryParse(index, out result);
            } while (!res);
            arrAdr.Index = result;
            Console.WriteLine("Ведите страну: ");
            arrAdr.Country = Console.ReadLine();
            Console.WriteLine("Ведите город: ");
            arrAdr.City = Console.ReadLine();
            Console.WriteLine("Ведите улицу: ");
            arrAdr.Street = Console.ReadLine(); ;
            Console.WriteLine("Ведите номер дома: ");
            arrAdr.House = Console.ReadLine(); ;
            Console.WriteLine("Ведите квартиру: ");
            arrAdr.Apartment = Console.ReadLine();
        }

        private static bool ContinueFill()
        {
            return false;
        }

        private static byte ReadChoice()
        {
            string enter;
            bool isInputRight;
            byte choice;
            Console.WriteLine("");
            do
            {
                enter = Console.ReadLine();
                isInputRight = byte.TryParse(enter, out choice);
            } while (!isInputRight || choice < (byte)Menu.Exit || choice > (byte)Menu.Show);
            return choice;
        }
    }
}