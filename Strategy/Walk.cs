using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	internal class Walk : IMovement
	{
		public Walk() { }

		public void Move()
		{
			Console.WriteLine("Esta caminando. ");
		}
	}
}
