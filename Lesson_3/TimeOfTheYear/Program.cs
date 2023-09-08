namespace TimeOfTheYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи номер месяца: ");
            string input = Console.ReadLine();
            int day = int.Parse(input);
            TimeOfTheYear(day);
        }

        static void TimeOfTheYear(int day)
        {
            switch (day)
            {
                case 1 or 2 or 12:
                    Console.WriteLine("Зима");
                    break;
                case 3 or 4 or 5:
                    Console.WriteLine("Весна");
                    break;
                case 6 or 7 or 8:
                    Console.WriteLine("Лето");
                    break;
                case 9 or 10 or 11:
                    Console.WriteLine("Осень");
                    break;

                default:
                    Console.WriteLine("Нет такого месяца на этой планете");
                    break;

            }
        }
    }
}