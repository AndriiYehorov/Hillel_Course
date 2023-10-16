namespace MathUtility
{
    internal static class MathUtility
    {
        public static int Addition(int x,int y)
        {
            return x+y;
        }
        public static int Subtraction(int x, int y) 
        {  
            return x-y; 
        }
        public static int Multiplication(int x, int y) 
        {  
            return x*y; 
        }
        public static double Division(int x, int y) 
        {
            try
            {
                return x/y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
                return 0;
            }
            catch
            {
                Console.WriteLine("Возникло исключение");               
            }
            return 0;
        }


    }
}
