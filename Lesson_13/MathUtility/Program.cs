namespace MathUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            GetData(out x,true);
            GetData(out y,false);

            MathUtility.Addition(x, y);
            MathUtility.Subtraction(x, y);
            MathUtility.Multiplication(x, y);
            MathUtility.Division(x, y);
        }

        private static void GetData(out int num, bool firstNum)
        {
            string text = firstNum ? "Введите первое число: " : "Введите второе число: ";
            bool res;
            do
            {
                Console.WriteLine(text);
                res = int.TryParse(Console.ReadLine(), out num);
            }
            while (!res);
            Console.Clear();
        }
    }
}