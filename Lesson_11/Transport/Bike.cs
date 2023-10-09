namespace Vehicles
{
    class Bike : Transport
    {
        string bikeType;
        public Bike(string bikeType, string name, int maxSpeed) : base(name, maxSpeed)
        {
            this.bikeType = bikeType;
        }
        public void Message()
        {
            Console.WriteLine($"Велдосипед: Тип велосипеда: {bikeType}, Название = {name}, Макскимальная скорость = {maxSpeed}");
        }
    }
}
