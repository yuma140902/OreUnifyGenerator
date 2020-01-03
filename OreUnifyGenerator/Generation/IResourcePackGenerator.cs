using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Generation
{
	public interface IResourcePackGenerator
	{
		void generate(string outputPath, IEnumerable<string> supportMods);
	}
}
