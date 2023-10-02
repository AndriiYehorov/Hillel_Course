namespace AreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = SidesOfTheRectangle("Введите первую сторону прямоугольника: ");
            double b = SidesOfTheRectangle("Введите вторую сторону прямоугольника: ");
            Rectangle rectangle = new Rectangle(a, b);
            Console.WriteLine("Периметри прямоугольника равен: {0}, а площадь равна {1}", rectangle.PerimeterCalculator(),rectangle.AreaCalculator());
        }

        private static double SidesOfTheRectangle(string text)
        {
            double result;
            bool res = false;
            Console.WriteLine(text);
            do
            {
                string input = Console.ReadLine();
                res = double.TryParse(input, out result);
            } while (!res);
            return result;
        }
    }
}