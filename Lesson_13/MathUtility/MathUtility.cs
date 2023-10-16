using static System.Net.Mime.MediaTypeNames;

namespace MathUtility
{
    internal static class MathUtility
    {
        public static void Addition(int x,int y)
        {
            Console.WriteLine($"Результат суммы чисел {x} и {y} равен: {x + y}");
        }
        public static void Subtraction(int x, int y) 
        {
            Console.WriteLine($"Результат разности чисел {x} и {y} равен: {x - y}");
        }
        public static void Multiplication(int x, int y) 
        {
            Console.WriteLine($"Результат умножения чисел {x} и {y} равен: {x * y}");
        }
        public static void Division(float x, float y) 
        {
            try
            {
                if (y == 0)
                {
                    throw new DivideByZeroException();
                }
                Console.WriteLine($"Результат деления чисел {x} и {y} равен: {x / y}");
            }
            catch
            {
                Console.WriteLine("Деление на ноль!");
            }
         }
    }
}
