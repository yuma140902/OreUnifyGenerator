using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public class TextureOperatorFileSystem : ITextureOperator
	{
		public ITextureRegistry Registry { get; private set; }
		private readonly ITextureProviderSystemAndUser provider;

		public TextureOperatorFileSystem(ITextureRegistry registry, ITextureProviderSystemAndUser provider)
		{
			this.Registry = registry;
			this.Registry.AddFromProvider(provider);

			this.provider = provider;
		}

		public void AddCategory(string category)
		{
			string categoryDir = this.provider.GetCategoryDirectoryUser(category);
			DirectoryUtil.Create(categoryDir);

			this.Registry.AddCategory(category);
		}

		public void AddFeature(string category, string feature)
			=> this.Registry.AddFeature(category, feature);

		public void Import(string category, string feature, string textureFileSrc)
		{
			string dest = this.provider.GetTexturePathToSave(category, feature);
			FileUtil.CopyOverwrite(textureFileSrc, dest);

			AddFeature(category, feature);
		}


		public void RemoveCategory(string category)
		{
			string categoryDir = this.provider.GetCategoryDirectoryUser(category);
			DirectoryUtil.DeleteRecursive(categoryDir);

			if (!this.provider.IsSystemCategory(category)) {
				this.Registry.RemoveCategory(category);
			}
		}

		public void RemoveFeature(string category, string feature)
		{
			string path = this.provider.GetTexturePathToDelete(category, feature);
			FileUtil.Delete(path);

			if(!this.provider.IsSystemTexture(category, feature)) {
				this.Registry.RemoveFeature(category, feature);
			}
		}

	}
}
