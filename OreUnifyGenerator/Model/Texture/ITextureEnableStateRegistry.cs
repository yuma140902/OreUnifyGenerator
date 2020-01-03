using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public interface ITextureEnableStateRegistry
	{
		void SetEnabled(string category, string feature, bool enable);
		void SetEnabled(TextureLocator locator, bool enable);
		bool IsEnabled(string category, string feature);
		bool IsEnabled(TextureLocator locator);
	}
}
