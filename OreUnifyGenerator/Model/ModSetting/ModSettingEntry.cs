using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.ModSetting
{
	public class ModSettingEntry
	{
		public string Mod { get; private set; }
		public string Category { get; private set; }
		public string Feature { get; private set; }
		public string TexturePath { get; private set; }

		public ModSettingEntry(string mod, string category, string feature, string texturePath) {
			this.Mod = mod;
			this.Category = category;
			this.Feature = feature;
			this.TexturePath = texturePath;
		}
	}
}
