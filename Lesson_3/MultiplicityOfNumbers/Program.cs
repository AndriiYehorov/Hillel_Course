using System.ComponentModel.Design;

namespace MultiplicityOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = GettingDataFromUser();
            Calculate(result);
            Console.ReadKey();
        }

        static int GettingDataFromUser()
        {
            Console.WriteLine("Введи число от 1 до 100: ");

            string input = Console.ReadLine();
            int num = int.Parse(input);
            return num;
        }

        static void Calculate(int num)
        {
            if (num % 15==0)
            {
                Console.WriteLine("FizzBuzz");   
            }
            else if(num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine("У меня нет ответа на этот вопрос!");
            }
        }
    }
}
