namespace Figures
{
    class Rectangle : Figure
    {
        double width;
        double height;
        public Rectangle(double width, double height, double x, double y): base(x, y) 
        {
            this.width = width;
            this.height = height;
        }

        public void Message()
        {
            Console.WriteLine($"Координаты точки начала прямоугольника: x = {x} y = {y}, \n Ширина = {width}, Высота = {height}");
        }
    }
}
