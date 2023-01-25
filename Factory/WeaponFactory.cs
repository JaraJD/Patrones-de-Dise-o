using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	public class WeaponFactory
	{
		public const string espada = "Cuerpo a cuerpo";
		public const string arco = "A distancia";
		internal static IWeapon CreateWeapon(string arma)
		{
			switch (arma)
			{
				case espada:
					return new Sword();
				case arco:
					return new Bow();
				default: return null;
			}
		}
	}
}
