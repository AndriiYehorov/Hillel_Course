using System;

namespace AddElementBeforeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            FillArrayRandom(nums, 101);
            Random random = new Random();
            int a = random.Next(1,101);
            int[] resultArray = new int[nums.Length + 1];
            resultArray[0] = a;
            AddElementBeforeArray(resultArray, nums, a);
            DisplayMessage(nums, a, resultArray);
            Console.ReadKey();
    }
        /// <summary>
        /// Выводит результат на дисплей
        /// </summary>
        /// <param name="resultArray"></param>
        private static void DisplayMessage(int[] arr,int a,int[] resultArray)
        {
            Console.WriteLine("Массив исходный: ");
            foreach (var eleOld in arr)
            {
                Console.Write(eleOld + "\t");
            }
            Console.WriteLine($"\nЭлемент, добавленный в начало: {a}");
            Console.WriteLine("Результат: ");
            foreach (var elem in resultArray)
            {
                Console.Write(elem+"\t");
            }
        }
        /// <summary>
        /// Добавление элемента в начало массива
        /// </summary>
        /// <param name="resultArray">Выходной массив</param>
        /// <param name="nums">Исходный массив</param>
        /// <param name="a">Элемент будет добавлен в начало массива</param>
        private static void AddElementBeforeArray(int[] resultArray, int[] nums, int a)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                resultArray[i + 1] = nums[i];
            }
        }
        /// <summary>
        /// Наполняет массив рандомными числами
        /// </summary>
        /// <param name="nums">Исходный массив</param>
        /// <param name="maxRand">Максимальная граница рандома</param>
        private static void FillArrayRandom(int[] nums, int maxRand)
        {
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(maxRand);
            }
        }
    }
}
