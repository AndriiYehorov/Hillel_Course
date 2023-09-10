using System.ComponentModel.Design;

namespace GuessThePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            bool passTrue = PasswordCheck(false);
            if (passTrue)
            {
                Console.WriteLine("Добро пожаловать!");
            }
            Console.ReadKey();
        }

        static bool PasswordCheck(bool passTrue)
        {
            string pass;
            while (!passTrue) 
            {
                Console.WriteLine("Введи пароль: ");
                pass = Console.ReadLine();
                if (pass=="root") 
                    passTrue = true;
                else
                {
                    Console.WriteLine("Неправильний пароль!");
                }
            }
            return passTrue;
        }

    }
}