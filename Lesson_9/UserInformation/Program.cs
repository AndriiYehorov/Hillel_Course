namespace UserInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAndDisplayDataFromUser();
        }

        private static void GetAndDisplayDataFromUser()
        {
            string name, surname, login;
            int age;
            bool res;
            int result;
            Console.Write("Ведите свое имя: ");
            name = Console.ReadLine();
            Console.Write("Введите свою фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите логин: ");
            login = Console.ReadLine();
            do
            {
                Console.Write("Ведите свой возраст: ");
                string index = Console.ReadLine();
                res = int.TryParse(index, out result);
            } while (!res);
            age = result;
            User myUser = new User(login,name,surname,age);
            myUser.Messege();
        }

    }
}