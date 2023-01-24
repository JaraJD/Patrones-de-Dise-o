using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
	internal class Stock : IObservable
	{
		private List<Investor> observadores = new List<Investor>();
		private double precio;

		public Stock()
		{
		}

		public void Subscribe(Investor observador)
		{
			observadores.Add(observador);
		}

		public void Unsubscribe(Investor observador)
		{
			observadores.Remove(observador);
		}

		public List<Investor> Observadores
		{
			get { return observadores; }
		}

		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}

	}
}
