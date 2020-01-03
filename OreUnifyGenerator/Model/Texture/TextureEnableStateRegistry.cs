using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public class TextureEnableStateRegistry : ITextureEnableStateRegistry
	{
		private readonly List<TextureLocator> disabledTextures = new List<TextureLocator>();

		public void SetEnabled(string category, string feature, bool enable)
			=> SetEnabled(new TextureLocator(category, feature), enable);
		public void SetEnabled(TextureLocator locator, bool enable)
		{
			if (!enable) {
				this.disabledTextures.Add(locator);
			}
			else {
				this.disabledTextures.Remove(locator);
			}
		}

		public bool IsEnabled(string category, string feature) => IsEnabled(new TextureLocator(category, feature));
		public bool IsEnabled(TextureLocator locator) => !this.disabledTextures.Contains(locator);
	}
}
