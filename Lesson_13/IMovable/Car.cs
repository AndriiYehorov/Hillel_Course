namespace IMovable
{
    internal class Car : Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Двигун запущено");
        }
        public void StopEngine()
        {
            Console.WriteLine("Двигун зупинено");
        }

    }
}
