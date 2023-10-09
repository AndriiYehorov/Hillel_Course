namespace Figures
{
    class Circle : Figure
    {
        double radius;
        public Circle(double x, double y, double radius):base(x, y) 
        {
            this.radius = radius;    
        }

        public void Message()
        {
            Console.WriteLine($"Координаты точки начала круга: x = {x} y = {y}, \n Радиус круга = {radius}");
        }


    }
}
