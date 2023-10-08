using System.Runtime.CompilerServices;

namespace Vehicles
{
    internal class Transport
    {
        protected string name;
        protected int maxSpeed;

    }

    class Сar : Transport
    {
        int quantityOfDoors;

    }

    class Bike : Transport
    {
        string bikeType;
        
    }
}
