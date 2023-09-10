using System.ComponentModel.Design;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 146);
            CheckNum(secretNumber);
            Console.ReadKey();
        }

        static void CheckNum(int secretNumber)
        {   
            int iterator = 0;
            int chekNum = 0;
            Console.WriteLine("Угадай число от 1 до 146: ");
            do
            {
                if (iterator != 0)
                {
                    if (chekNum > secretNumber)
                    {
                        Console.WriteLine("Загаданное число меньше! Попробуй еще: ");
                    }
                    else
                    {
                        Console.WriteLine("Загаданное число больше! Попробуй еще: ");
                    }

                } else iterator = 1;
                
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out chekNum);
                if (!result)
                {
                    Console.WriteLine("Необходимо вводить числа от 1 до 146! Попробуй еще: ");
                    iterator = 0;   
                }
            }
            while (secretNumber != chekNum);
            Console.WriteLine("Молодец, ты угадал!");

        }

    }
}