using System.Drawing;

namespace IMovable
{
    public class Vehicle : IMovable
    {
		private Point position;

		public Point Position
		{
			get { return position; }
			set { position = value; }
		}

		public override void Move()
		{

		}

	}
}
