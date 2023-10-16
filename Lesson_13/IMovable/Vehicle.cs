using System.Drawing;

namespace IMovable
{
    public class Vehicle : IMovable
    {
		public Point Position;

		public void Move(int x, int y)=> Position = new Point(x, y);
	}
}
