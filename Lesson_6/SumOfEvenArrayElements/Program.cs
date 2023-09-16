using System;

namespace SumOfEvenArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            FillArrayRandom(nums,151);
            DisplayMessage("Собственно массив: ",nums);
            int res = SumOfEvenArrayElements(nums);
            Console.WriteLine("Сумма значений по положительным индексам = {0}",res);
        }

        private static int SumOfEvenArrayElements(int[] nums)
        {
            int Summ = 0;
            for (int i = 0; i< nums.Length; i++)
            {
                if (i%2 == 0)
                {
                    Summ += nums[i];
                }
            }
            return Summ;
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