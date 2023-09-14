using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SortedOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            bool res = FillArray(arr);
            if (!res)
            {
                return;
            }
            if (SortedAscending(arr)) 
            {
                Display("Массив отсортирован по возрастанию!");
            } else if (SortedDescending(arr))
            {
                Display("Массив отсортирован по убыванию!");
            }
            else
            {
                Display("Массив не отсортирован!");
            }
        }

        private static bool FillArray(int[] arr)
        {
            Display("Введите 5 значений элементов массива!");
            for (int i = 0; i < arr.Length; i++) 
            {
                string el = Console.ReadLine(); 
                bool res = int.TryParse(el, out arr[i]);
                if (!res)
                {
                    Display("Массив может состоять только из чисел!");
                    return false;
                }   
            }
            return true;
        }

        private static void Display(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// Истина, если массив отсортирован по возрастанию
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool SortedAscending(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Истина, если массив отсортирован по убыванию
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool SortedDescending(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
