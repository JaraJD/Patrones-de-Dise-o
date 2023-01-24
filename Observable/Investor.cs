using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
	internal class Investor: IObserver
	{
		private string name;
		public Investor() { }

		public Investor(string name)
		{
			Name = name;
		}

		public void Unsubscribe(Investor inversor, Stock acciones)
		{
			acciones.Unsubscribe(inversor);
		}

		public void Update(Stock acciones)
		{
			Console.WriteLine("El nombre del inversor es: {0}",name);
			Console.WriteLine("El precio de la accion es {0}", acciones.Precio);
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}
}
