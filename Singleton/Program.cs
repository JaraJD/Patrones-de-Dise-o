using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			Logger.Instance.Log("Hola Mundo");
			Logger.Instance.Log("Hello world");
			Logger.Instance.Log("Hallo Welt");
			Logger.Instance.Log("Salut Monde");
			Logger.Instance.PrintLog();

		}
	}

}