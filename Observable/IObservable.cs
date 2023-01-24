using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
	internal interface IObservable
	{
		void Subscribe(Investor observador);
		void Unsubscribe(Investor observador);

	}
}
