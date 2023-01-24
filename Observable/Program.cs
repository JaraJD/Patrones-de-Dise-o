using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
	class Program
	{
		static void Main(string[] args)
		{
			Stock acciones= new Stock();
			Investor inversores= new Investor();

			Investor inversor1 = new Investor("juan");	
			Investor inversor2 = new Investor("pedrp");	
			Investor inversor3 = new Investor("pablo");	
			Investor inversor4 = new Investor("julio");

			acciones.Subscribe(inversor1);
			acciones.Subscribe(inversor2);
			acciones.Subscribe(inversor3);
			acciones.Subscribe(inversor4);

			acciones.Precio = 1500.56;
			acciones.Unsubscribe(inversor2);
			inversor4.Unsubscribe(inversor4, acciones);

			inversor3.Update(acciones);

			foreach(var item in acciones.Observadores)
			{
				Console.WriteLine(item.Name);
			}




		}
	}
	
}
