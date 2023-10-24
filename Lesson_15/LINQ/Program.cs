using System.Collections;
using System.Text.Json;
using System.Xml.Linq;

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
        Console.WriteLine();
        List<ArrayList> students = new List<ArrayList>();
        InitialData(students);
        Console.WriteLine("- Фільтрація: Знайдіть усіх студентів, які мають оцінку більше або рівну 90.");
        var selecrGrade = students.Where(student => (int)student[1]>=90);
        foreach (var grade in selecrGrade)
        {
            Console.WriteLine($"{grade[0]},{grade[1]},{grade[2]}");
        }
        Console.WriteLine();
        Console.WriteLine("- Сортування: Відсортуйте студентів за оцінкою в спадаючому порядку.");
        var sortStudents = students.OrderBy(student => -(int)student[1]);
        foreach (var student in sortStudents)
        {
            Console.WriteLine($"{student[0]},{student[1]},{student[2]}");
        }

        Console.WriteLine();
        Console.WriteLine("- Групування: Згрупуйте студентів за курсами і виведіть список студентів на кожному курсі.");
        var groupStudents = from student in students
                            group student by student[2];
        foreach (var student in groupStudents)
        {
            Console.WriteLine($"Курс: {student.Key} - Студенты:");
            foreach(var student2 in student)
            {
                Console.WriteLine($"{student2[0]}");
            }
        }

        Console.WriteLine();
        Console.WriteLine("- Підрахунок: Порахуйте кількість студентів на кожному курсі.");
        var countStudents = from student in students
                            group student by student[2];
        foreach (var student in countStudents)
        {
            Console.WriteLine($"Курс: {student.Key} - количество студентов: { student.Count()}");
        }
        Console.WriteLine();


        Console.WriteLine("- Проекція: Створіть список рядків, які містять ім'я та оцінку кожного студента.");
        var nameAndGrade = students.Select(p => new
         {
             Name = p[0],
             Grade = p[1]
         });

        foreach (var student in nameAndGrade)
        {
            Console.WriteLine($"Имя: {student.Name}, Оценка: {student.Grade}");
        }
    }

    private static void InitialData(List<ArrayList> students)
    {
        students.Add(new ArrayList() { "Игорь", 92, "С#" });
        students.Add(new ArrayList() { "Андрей", 90, "С#" });
        students.Add(new ArrayList() { "Алина", 87, "Java" });
        students.Add(new ArrayList() { "Иван", 96, "С++" });
        students.Add(new ArrayList() { "Григорий", 75, "Java" });
        students.Add(new ArrayList() { "Олег", 99, "С" });
    }
}