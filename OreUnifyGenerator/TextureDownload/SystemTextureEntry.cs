using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.TextureDownload
{
	public class SystemTextureEntry
	{
		public SystemTextureEntry(string mod, string srcPath, string category, string feature)
		{
			this.Mod = mod;
			this.SrcPath = srcPath;
			this.Category = category;
			this.Feature = feature;
		}

		public string Mod { get; private set; }
		public string SrcPath { get; private set; }
		public string Category { get; private set; }
		public string Feature { get; private set; }
	}
}
