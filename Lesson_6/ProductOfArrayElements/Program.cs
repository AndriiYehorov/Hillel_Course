using System;

namespace ProductOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            FillArrayRandom(arr, 26);
            DisplayMessage("Собственно массив: ", arr);
            int num = EnterANumber();
            int res = ProductOfArrayElements(arr, num);
            Console.WriteLine("Произведение чисел, которые больше введенного = {0}", res);
        }

        private static int EnterANumber()
        {
            bool res = false;
            int num = 0;
            while (!res)
            {
                Console.WriteLine("Числа меньше этого перемножены не будут!: ");
                string input = Console.ReadLine();
                res = int.TryParse(input, out num);
            }
            return num;
        }

        private static int ProductOfArrayElements(int[] arr, int num)
        {
            int prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > num)
                {
                    prod *= arr[i];
                }
            }
            return prod;
        }

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
            Console.WriteLine();
        }

    }
}