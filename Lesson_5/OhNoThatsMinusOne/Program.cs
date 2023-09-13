using System;
using System.Diagnostics.Contracts;

namespace OhNoThatsMinusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {43, 6, 45, -4, 16, 2, -1, 8, 21, 15};
            RunCheck(nums);
        }

        private static void RunCheck(int[] nums)
        {
            foreach (int el in nums) 
            { 
                if (el != -1)
                {
                    Console.WriteLine(el);
                } else 
                {
                    Console.WriteLine("О нет!!! Минус один!");
                    break;
                }
            }
        }
    }
}
