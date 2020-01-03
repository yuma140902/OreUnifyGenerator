using Newtonsoft.Json;
using OreUnifyGenerator.Model.ModSetting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.TextureDownload
{
	public class SystemTextureProvider
	{
		private readonly Dictionary<string, Dictionary<string, string>> json;

		public SystemTextureProvider(string filepath)
		{
			using (var reader = new StreamReader(filepath, Encoding.UTF8)) {
				this.json = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(reader.ReadToEnd());
			}
		}


		private string parseModName(string srcPath)
		{
			var tmp = srcPath.Split(new[]{'/'}, 3);
			if(tmp.Length <= 1) {
				return null;
			}
			return tmp[1];
		}

		public IEnumerable<SystemTextureEntry> Enumerate()
		{
			foreach(var category in json) {
				string categoryName = category.Key;
				foreach(var feature in category.Value) {
					string featureName = feature.Key;
					string srcPath = "assets/" + feature.Value + ".png";
					string modName = parseModName(srcPath);
					yield return new SystemTextureEntry(modName, srcPath, categoryName, featureName);
				}
			}
		}

	}
}
