namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike("Трехколесный", "Аист",30);
            bike.Message();
            Car car = new Car(5, "Седан", 200);
            car.Message();
        }
    }
}