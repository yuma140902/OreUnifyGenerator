using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Logging
{
	public interface ILogger
	{
		void Info(string name, string msg);
		void Warn(string name, string msg);
		void Error(string name, string msg);
		void Debug(string name, string msg);
	}
}
