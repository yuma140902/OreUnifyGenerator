using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public class TextureProviderFileSystem : ITextureProviderFileSystem
	{
		public string Directory { get; private set; }

		public TextureProviderFileSystem(string directory)
		{
			this.Directory = directory;
		}

		public IEnumerable<string> Categories()
			=> DirectoryUtil.EnumerateDirectories(this.Directory).Select(Path.GetFileName);

		public IEnumerable<string> Features(string category)
		{
			string categoryDir = GetCategoryDirectory(category);
			return DirectoryUtil.EnumerateFiles(categoryDir, "*.png").Select(Path.GetFileNameWithoutExtension);
		}

		public string GetTexturePath(string category, string feature)
			=> Path.Combine(this.Directory, category, feature + ".png");

		public string GetCategoryDirectory(string category) => Path.Combine(this.Directory, category);
	}
}
