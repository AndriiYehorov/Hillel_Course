namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, radius;
            x = 3;
            y = 5;
            radius = 5;
            double width, height, a, b;
            width = 6;
            height = 2;
            a = 8;
            b = 9;
            Circle circle = new Circle(x, y, radius);
            circle.Message();
            Rectangle rect = new Rectangle(width, height, a, b);
            rect.Message();
        }
    }
}