using System;
using System.Reflection;

namespace RemoveArrayElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            FillArrayRandom(nums, 101);
            DisplayMessage("Исходный массив: ", nums);
            int a = PositionRemove(nums);
            if (a == -1) 
            {
                return;
            }
            int[] tmpArr = new int[nums.Length - 1];
            DeleteSelectedElem(a, nums, tmpArr);
            DisplayMessage("Результирующий массив: ", tmpArr);
            Console.ReadKey();
        }

        private static void DeleteSelectedElem(int a, int[] arr, int[] tmpArr)
        {
            
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i != a)
                {
                    tmpArr[j] = arr[i];
                    j++;
                }
            }
        }

        private static int PositionRemove(int[] nums)
        {
            Console.WriteLine("\nВведите индекс элемента для удаления!");
            string input = Console.ReadLine();
            bool res = int.TryParse(input, out int result);

            if (res)
            {
                if (result >= 0 && result < nums.Length)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Нет данного элемента в массиве!");
                    return -1;
                }

            }
            else
            {
                Console.WriteLine("Необходимо вводить цыфру!");
                return -1;
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

        private static void DisplayMessage(string message, int[] arr)
        {
            Console.WriteLine(message);
            foreach (var el in arr)
            {
                Console.Write(el + "\t");
            }
        }
    }
}
