using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	internal class Sword : IWeapon
	{
		public Sword() { }
		public string Attack()
		{
			return "Cuerpo a cuerpo";
		}
	}
}
