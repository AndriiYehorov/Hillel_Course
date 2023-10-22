namespace ManagingDictionaryContacts
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,string> dict = new Dictionary<string,string>();//номер телефона "string", т.к. существует возможность ввести "+380"
            do
            {
                Console.WriteLine((byte)Menu.AddContact + ". Добавить контакт в справочник.");
                Console.WriteLine((byte)Menu.RemoveContact + ". Удалить контакт из справочника по имени.");
                Console.WriteLine((byte)Menu.FindContact + ". Найти контакт по имени.");
                Console.WriteLine((byte)Menu.ShowAllConacts + ". Показать все контакты.");
                Console.WriteLine((byte)Menu.Exit + ". Завершить работу.");
                Console.WriteLine("Что вы хотите сделать?");
                byte elMenu = ReadChoice();
                if ((Menu)elMenu == Menu.AddContact)
                {
                    Console.Clear();
                    AddContact(dict);
                }
                else if ((Menu)elMenu == Menu.RemoveContact)
                {
                    Console.Clear();
                    if (dict.Count == 0)
                    {
                        Console.WriteLine("Справочник пустой!");
                    }
                    else
                    {
                        DeleteContactByName(dict);
                    }                    
                }
                else if ((Menu)elMenu == Menu.FindContact)
                {
                    Console.Clear();
                    if (dict.Count == 0)
                    {
                        Console.WriteLine("Справочник пустой!");
                    }
                    else
                    {
                        string number = FindContactByName(dict);
                        Console.WriteLine(number);
                    }
                    
                    
                }
                else if ((Menu)elMenu == Menu.ShowAllConacts)
                {
                    Console.Clear();
                    foreach (var item in dict)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
                else
                {
                    break;
                }

            } while (true);
        }

        private static string FindContactByName(Dictionary<string, string> dict)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            foreach (var item in dict)
            {
                if (item.Value == name)
                {
                   return $"Номер телефона контакта: {name} - {item.Key}";
                }
            }
            return "Номер телефона не найден";
        }

        private static void DeleteContactByName(Dictionary<string, string> dict)
        {
            Console.WriteLine("Введите имя: ");
            string nameDelete = Console.ReadLine();
            foreach (var item in dict)
            {
                if (item.Value == nameDelete)
                {
                    dict.Remove(item.Key);
                }
            }            
        }

        private static void AddContact(Dictionary<string, string> dict)
        {
           Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите номер телефона: ");
            string phoneNumber = Console.ReadLine();
            if(!(phoneNumber == null) || !(phoneNumber == ""))
            {
                dict.Add(phoneNumber, name);
            }
            else
            {
                Console.WriteLine("Номер телефона должен быть заполнен!");
            }
            

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
            } while (!isInputRight || choice < (byte)Menu.Exit || choice > (byte)Menu.ShowAllConacts);
            return choice;
        }
    }
}