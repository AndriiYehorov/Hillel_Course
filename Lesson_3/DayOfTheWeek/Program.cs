namespace DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи день недели: ");
            string input = Console.ReadLine();
            int day = int.Parse(input);
            DayOfTheWeek(day);
        }

        static void DayOfTheWeek(int day)
        {
            switch (day) 
            {
                case 1:                 
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default: Console.WriteLine("Нет такого дня");
                    break;

            }
        }
    }
}