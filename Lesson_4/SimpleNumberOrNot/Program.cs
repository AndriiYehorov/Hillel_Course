using System;

namespace SimpleNumberOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string input= Console.ReadLine();
            bool result = int.TryParse(input, out num);
            if (!result) 
            {
                Console.WriteLine("Необходимо ввести число!");
                return;
            }
            Console.WriteLine(CheckNum(num));
            Console.ReadKey();
        }

        private static string CheckNum(int genNum)
        {
            for (int i = 2; i < genNum; i++)
            {
                if (genNum % i == 0)
                {
                    return "Not simple!";
                }
            }
            return "Simple!";
        }
    }
}