using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	internal class Logger
	{
		private List<String> msgLog = new List<string>();
		private static Logger instance = null;
		protected Logger() { }

		public static Logger Instance
		{
			get 
			{
				if (instance == null) { instance = new Logger(); }

				return instance;
			}
		}

		public void Log(string message)
		{
			msgLog.Add(message);
		}

		public void PrintLog()
		{
			foreach (var log in msgLog)
			{
				Console.WriteLine(log);
			}
		}
	}
}
