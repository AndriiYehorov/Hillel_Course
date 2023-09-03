internal class Program
{
    private static void Main(string[] args)
    {
        float num;
        Console.WriteLine("Введите число для возведения в квадрат: ");
        string input = Console.ReadLine();
        float EnteredNumber = float.Parse(input);
        Console.WriteLine("Квадрат числа равен: " + EnteredNumber * EnteredNumber);
    }
}