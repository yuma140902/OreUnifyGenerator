using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public class TextureProviderSystemAndUser : ITextureProviderSystemAndUser
	{

		private readonly string rootDirectory;
		public TextureProviderFileSystem SystemTextureProvider { get; private set; }
		public TextureProviderFileSystem UserTextureProvider { get; private set; }

		public TextureProviderSystemAndUser(string rootDirectory)
		{
			this.SystemTextureProvider = new TextureProviderFileSystem(Path.Combine(rootDirectory, "system"));
			this.UserTextureProvider = new TextureProviderFileSystem(Path.Combine(rootDirectory, "userAdditions"));
			this.rootDirectory = rootDirectory;
		}


		public IEnumerable<string> Categories()
			=> this.SystemTextureProvider.Categories().Union(this.UserTextureProvider.Categories());


		public IEnumerable<string> Features(string category)
			=> this.SystemTextureProvider.Features(category).Union(this.UserTextureProvider.Features(category));

		public string GetTexturePathToOpen(string category, string feature)
		{
			string userPath = this.UserTextureProvider.GetTexturePath(category, feature);
			if (File.Exists(userPath)){
				return userPath;
			}
			else {
				string systemPath = this.SystemTextureProvider.GetTexturePath(category, feature);
				return systemPath;
			}
		}

		public string GetTexturePathToDelete(string category, string feature)
			=> this.UserTextureProvider.GetTexturePath(category, feature);
		public string GetTexturePathToSave(string category, string feature)
			=> this.UserTextureProvider.GetTexturePath(category, feature);

		public string GetSystemTexturePath(string category, string feature)
			=> this.SystemTextureProvider.GetTexturePath(category, feature);

		public string GetCategoryDirectorySystem(string category) => this.SystemTextureProvider.GetCategoryDirectory(category);
		public string GetCategoryDirectoryUser(string category) => this.UserTextureProvider.GetCategoryDirectory(category);
		public string GetRootDirectory() => this.rootDirectory;

		public bool IsSystemCategory(string category)
			=> Directory.Exists(this.SystemTextureProvider.GetCategoryDirectory(category));

		public bool IsUserCategory(string category)
		{
			string path = this.UserTextureProvider.GetCategoryDirectory(category);
			return Directory.Exists(path) && this.UserTextureProvider.Features(category).Count() > 0; ;
		}

		public bool IsSystemTexture(string category, string feature)
			=> File.Exists(this.SystemTextureProvider.GetTexturePath(category, feature));

		public bool IsUserTexture(string category, string feature)
			=> File.Exists(this.UserTextureProvider.GetTexturePath(category, feature));
	}
}
