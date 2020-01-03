using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Logging
{
	public class LoggerDummy : ILogger
	{
		public void Debug(string name, string msg) { }
		public void Error(string name, string msg) { }
		public void Info(string name, string msg) { }
		public void Warn(string name, string msg) { }
	}
}
