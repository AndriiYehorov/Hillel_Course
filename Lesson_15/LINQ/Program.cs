namespace LINQ;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("1) Відфільтруйте всі числа, які більше 10. { 2, 5, 8, 12, 15, 18, 22 }");

       int[] numbers = { 2, 5, 8, 12, 15, 18, 22 };
        var filteredNumbers = numbers.Where(number => number > 10);

        foreach (var number in filteredNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
        Console.WriteLine("2) Відсортуйте цей список в алфавітному порядку.{ \"Яблуко\", \"Апельсин\", \"Банан\", \"Ківі\" }");
        string[] fruits = { "Яблуко", "Апельсин", "Банан", "Ківі" };
        var sortFruits = fruits.OrderBy(fruit => fruit);
        foreach (var fruit in sortFruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine();
        Console.WriteLine("3) Видаліть всі дублікати і поверніть унікальні рядки. { \"А\", \"Б\", \"В\", \"А\", \"Г\", \"В\" }");
        string[] letters = { "А", "Б", "В", "А", "Г", "В" };
        var sortLetters = letters.GroupBy(letter => letter);
        foreach (var letter in sortLetters)
        {
            Console.WriteLine(letter.Key);
        }
        Console.WriteLine();
        Console.WriteLine("4) Порахуйте, скільки студентів отримали більше 90 балів. { 85, 92, 78, 95, 88, 90 }");
        int[] assessments = { 85, 92, 78, 95, 88, 90 };
        var quantity = assessments.Where(assessment => assessment>90).Count();
        Console.WriteLine(quantity);
        Console.WriteLine();
        Console.WriteLine("5) Фільтрація та сортування: Дано список об'єктів, які представляють товари і мають поля \"Назва\" і \"Ціна\".\n Відфільтруйте товари, які мають ціну менше 50 гривень і відсортуйте їх за зростанням ціни.");
        Dictionary<string, int> products = new Dictionary<string, int>()
        {
             {"Молоко",55},
             {"Хлеб",32},
             {"Чай",61},
             {"Сахар",51 },
             {"Гречка",49},
             {"Соль",30 }
        };
        var sortProducts = products.Where(product=>product.Value>50).OrderBy(product => product.Key);
        foreach (var product in sortProducts)
        {
            Console.WriteLine($"{product.Key} - {product.Value}");
        }
        Console.WriteLine();
        Console.WriteLine("6) Пошук максимального за індексом: Дано список цілих чисел {10, 25, 8, 45, 15, 30, 55, 5}. Знайдіть максимальне число за індексом (позицією) в списку.");
        int[] ints = { 10, 25, 8, 45, 15, 30, 55, 5 };
        var findInts = ints.Max(i => i);
        Console.WriteLine(findInts);


    }
}