using System;
using System.Diagnostics.Contracts;

namespace MergeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = CreateArray();
            int[] arr2 = CreateArray();
            DisplayArray(arr1, arr2);
            //int[] res = arr1.Concat(arr2).ToArray(); //метод конкатенации, на этом можно было бы закончить
            int[] res = new int[arr1.Length+ arr2.Length];
            RunCheck(res, arr1, arr2);
            DisplayArray(res);
        }

        private static void DisplayArray(int[] arr11, int[] arr12)
        {
            Console.WriteLine("Первый массив: ");
            foreach (int el1 in arr11) 
            {
                Console.Write(el1+"\t");
            }
            Console.WriteLine("\nВторой массив: ");
            foreach (int el2 in arr12)
            {
                Console.Write(el2 + "\t");
            }
            Console.WriteLine();
        }

        private static void DisplayArray(int[] arr)
        {
            Console.WriteLine("Массив результата: ");
            foreach (int el in arr)
            {
                Console.Write(el + "\t");
            }
            Console.WriteLine();
        }

        private static int[] CreateArray()
        {
            int[] tmp = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = rnd.Next(200);
            }
            return tmp;
        }

        private static void RunCheck(int[] nums, int[] arr1, int[] arr2)
        {
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (i >= arr1.Length)
                {
                    nums[i] = arr2[j];
                    j++;
                }
                else
                {
                    nums[i] = arr1[i];
                }
            }
        }
    }
}