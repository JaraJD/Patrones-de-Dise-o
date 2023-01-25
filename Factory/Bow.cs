using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	internal class Bow : IWeapon
	{
		public Bow() { }
		public string Attack()
		{
			return "A distancia";
		}
	}
}
