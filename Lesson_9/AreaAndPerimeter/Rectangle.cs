namespace AreaAndPerimeter
{
    internal class Rectangle
    {
        double side1;
        double side2;

        public double Area { get; }
        public double Perimeter { get; }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return this.side1*this.side2;
        }

        public double PerimeterCalculator()
        {
            return (this.side1+this.side2)*2;
        }
    }
}
