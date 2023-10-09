namespace Vehicles
{
    class Car : Transport
    {
        int quantityOfDoors;
        public Car(int quantityOfDoors, string name, int maxSpeed) : base(name, maxSpeed)
        {
            this.quantityOfDoors = quantityOfDoors;
        }
        public void Message()
        {
            Console.WriteLine($"Автомобиль: Количество дверей = {quantityOfDoors}, Название = {name}, Макскимальная скорость = {maxSpeed}");
        }
    }
}
