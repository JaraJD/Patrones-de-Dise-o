using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	internal class Fly : IMovement
	{
		public Fly() { }

		public void Move()
		{
			Console.WriteLine("Esta Volando. ");
		}
	}
}
