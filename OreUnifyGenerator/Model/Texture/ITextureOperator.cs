using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public interface ITextureOperator
	{
		ITextureRegistry Registry { get; }
		void AddCategory(string category);
		void AddFeature(string category, string feature);
		void Import(string category, string feature, string textureFile);
		void RemoveCategory(string category);
		void RemoveFeature(string category, string feature);
	}
}
