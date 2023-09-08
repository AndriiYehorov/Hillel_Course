namespace MoreOrLess
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = ExecuteComparison();
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string ExecuteComparison()
        {
            int num1 = GettingDataFromUser("Введи первое число: ");
            int num2 = GettingDataFromUser("Введи второе число: ");

            string answer = CompareNumbers(num1,num2);

            return answer;
        }

        private static string CompareNumbers(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                Console.WriteLine($"число {firstNumber} меньше числа {secondNumber}");
            }
            else if (firstNumber > secondNumber)
            {
                Console.WriteLine($"число {firstNumber} больше числа {secondNumber}");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
            return "";
        }

        static int GettingDataFromUser(string messege)
    {
            Console.WriteLine(messege);
            string input = Console.ReadLine();
            int num = int.Parse(input);
            return num;
        }
    }
}