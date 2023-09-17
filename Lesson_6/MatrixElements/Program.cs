namespace MatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = FillFromRandom(5,5);
            PrintArray(matrix);
            CountElements(matrix);
            Console.ReadKey();
        }

        private static void CountElements(int[,] matrix)
        {
            int positive = 0;
            int negative = 0;
            for (int i = 0; i < matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1); j++)
                {
                    if (matrix[i,j] > 0) 
                    {
                        positive++; 
                    }else if (matrix[i,j] < 0)
                    {
                        negative++;
                    }
                }
            }
            Console.WriteLine("Положительных чисел в матрице: {0}, отрицательных: {1}",positive,negative);
        }

        private static int[,] FillFromRandom(int bound0, int bound1)
        {
            int[,] res = new int[bound0, bound1];
            Random rand = new Random();
            for (int i = 0; i < res.GetUpperBound(0); i++)
            {
                for (int j = 0; j < res.GetUpperBound(1); j++)
                {
                    res[i, j] = rand.Next(-25, 26);
                }
            }
            return res;
        }

        private static void PrintArray(int[,] nums)
        {
            for (int i = 0; i < nums.GetUpperBound(0); i++)
            {
                for (int j = 0; j < nums.GetUpperBound(1); j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}