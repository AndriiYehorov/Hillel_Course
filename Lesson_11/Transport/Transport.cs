using System.Runtime.CompilerServices;
namespace Vehicles
{
    internal class Transport
    {
        protected string name;
        protected int maxSpeed;
        public Transport(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }
    }
}
