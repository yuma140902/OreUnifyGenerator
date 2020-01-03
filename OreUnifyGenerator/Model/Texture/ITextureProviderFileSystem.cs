using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public interface ITextureProviderFileSystem : ITextureProvider
	{
		string GetCategoryDirectory(string category);
		string GetTexturePath(string category, string feature);
	}
}
