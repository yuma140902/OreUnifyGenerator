using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public interface ITextureProvider
	{
		IEnumerable<string> Categories();
		IEnumerable<string> Features(string category);
	}
}
