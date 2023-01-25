using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	internal class Game
	{
		public static void Main(string[] args)
		{
			//Instancia del Contexto
			Player jugador = new Player();

			 //Movimiento por defecto es Walk ya que en la clase player se define el tipo del objeto como walk en el constructor
			jugador.Move();
			Console.WriteLine(jugador.Movimiento.GetType());

			//Se cambia la estrategia de movimiento de Walk a Fly
			jugador.MovimientoFly();
			jugador.Move();
			Console.WriteLine(jugador.Movimiento.GetType());



		}
	}
}