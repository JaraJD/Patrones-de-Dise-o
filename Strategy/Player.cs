using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	internal class Player
	{
		private IMovement movimiento;

		public Player()
		{
			this.movimiento = new Walk();
		}

		public void MovimientoFly()
		{
			this.movimiento = new Fly();
		}

		public void MovimientoWalk()
		{
			this.movimiento = new Walk();
		}

		public void Move()
		{ 
			this.movimiento.Move();
		}

		public IMovement Movimiento
		{
			get { return this.movimiento;}
		}

	}
}
