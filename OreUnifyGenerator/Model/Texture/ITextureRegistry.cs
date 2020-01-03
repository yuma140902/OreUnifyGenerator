using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public interface ITextureRegistry
	{
		void AddFromProvider(ITextureProvider provider);

		void AddCategory(string category);
		void AddFeature(string category, string feature);
		void AddCategories(IEnumerable<string> categories);
		void AddFeatures(string category, IEnumerable<string> features);

		void ClearCategories();
		void ClearFeatures(string category);
		void Clear();

		void RemoveCategory(string category);
		void RemoveFeature(string category, string feature);

		IEnumerable<string> Categories();
		IEnumerable<string> Features(string category);
	}
}
