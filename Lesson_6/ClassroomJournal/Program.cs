
namespace ClassroomJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] physics = InitializeData(10);
            int[] history = InitializeData(10);
            int[] mathematic = InitializeData(10);
            while (true)
            {
                Console.WriteLine("\n1. Заполнить оценки\n2. Получить среднюю оценку\n3. Показать текущие оценки\n4. Exit\nChoose an option: ");
                string input = Console.ReadLine();
                bool res = int.TryParse(input, out int result);
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Выбрана команда заполнения оценок!");
                        GradeInput(SelectLesson(physics, history, mathematic,0));
                        break;
                    case 2:
                        Console.WriteLine("Выбрана команда получения средней оценки!");
                        AverageGrade(SelectLesson(physics, history, mathematic,1));
                        break;
                    case 3:
                        Console.WriteLine("Выбрана команда просмотра текущих оценок!");
                        DisplayArray(SelectLesson(physics, history, mathematic, 1));
                        break;
                    case 4:
                        Console.WriteLine("Программа завершается");
                        return;
                    default:
                        Console.WriteLine("Неверная команда!");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static int[] SelectLesson(int[] physics, int[] history, int[] mathematic, byte option)
        {
            Console.Clear();
            while (true)
            {
                string text = (option == 0 ? "Выберите предмет для заполнения: \n1. Математика\n2. История\n3. Физика\n" : "По какому предмету вывести среднюю оценку?: \n1. Математика\n2. История\n3. Физика\n");
                Console.WriteLine(text);
                string input = Console.ReadLine();
                bool res = int.TryParse(input, out int result);
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Математика выбрана!");
                        return mathematic;
                    case 2:
                        Console.WriteLine("История выбрана!");
                        return history;
                    case 3:
                        Console.WriteLine("Физика выбрана!");
                        return physics;
                    default:
                        Console.WriteLine("Неверная команда!");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void AverageGrade(int[] arr)
        {
            DisplayArray(arr);
            int count = 0;
            float avrg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    avrg += arr[i]; 
                    count++;
                }
                else
                { 
                    break;
                }
            }
            Console.WriteLine("Средняя оценка равна: {0}", avrg /= count);
        }

        private static void GradeInput(int[] arr)
        {
            DisplayArray(arr);
            string input = Console.ReadLine();
            bool res = int.TryParse(input,out int result);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = result; 
                    break;
                }
            }
            DisplayArray(arr);
            if (ContinueInputingData())
            {
                GradeInput(arr);
            } else
            {
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static bool ContinueInputingData()
        {
            Console.WriteLine("Продолжить ввод данных?\n1.Да\t2.Нет");
            string input = Console.ReadLine();
            bool res = int.TryParse(input,out int result);
            switch (result)
            {
                case 1:
                    return true;
                case 2:
                    return false;
                default: ContinueInputingData();
                    break;
            }
            return false;
        }

        private static void DisplayArray(int[] arr)
        {
            Console.WriteLine("Текущая успеваемость: ");
            foreach (int el in arr)
            {
                Console.Write(el + "\t");
            }
            Console.WriteLine();
        }

        private static int[] InitializeData(int lenght)
        {
            Random rnd = new Random();
            int[] arr = new int[lenght];
            for (int i = 0; i <= 3; i++)
            {
                arr[i] = rnd.Next(1,12);
            }
            return arr;
        }
    }
}
