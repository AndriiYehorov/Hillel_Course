namespace EvenOrOdd
{
class Program
    {
        static void Main(string[] args)
        {
            int result = GettingDataFromUser();
            
            CalculateEvenOdd(result);
            Console.ReadKey();
        }

    static int GettingDataFromUser()
    {
        Console.WriteLine("Введи число: ");
        
        string input = Console.ReadLine();
        if (input == "")
        {
            Console.WriteLine("Ты что-то делаешь не так!");
            GettingDataFromUser();
        }
        int num = int.Parse(input);
        return num;
    }

    static void CalculateEvenOdd(int num)
        {
            int result = num % 2;

            if (result == 0)
            {
                Console.WriteLine("Парне");
            }
            else
            {
                Console.WriteLine("Непарне");
            }
        }
    }
}
