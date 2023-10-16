namespace IMovable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Car newCar = new Car();
            newCar.Move(0,0);
            Console.WriteLine("Поточна позиція об'єкту: "+ newCar.Position.ToString());
            newCar.StartEngine();
            newCar.Move(1, 1);
            Console.WriteLine("Нова позиція об'єкту: " + newCar.Position.ToString());
            newCar.StopEngine();
        }

    }
}