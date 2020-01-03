using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.ModSetting
{
	public class ModSettingFile : IModSetting
	{
		private readonly string filepath;
		private readonly Json.ModSettingJson json;

		public ModSettingFile(string filepath)
		{
			this.filepath = filepath;
			using (var reader = new StreamReader(filepath, Encoding.UTF8)) {
				this.json = JsonConvert.DeserializeObject<Json.ModSettingJson>(reader.ReadToEnd());
			}
		}

		public Json.ModSettingJson GetJsonObject() => this.json;

		public string GetRelativePath(string mod, string category, string feature)
		{
			if(this.json.Name != mod) {
				return null;
			}

			if (!this.json.TextureCategories.ContainsKey(category)) {
				return null;
			}

			var features = this.json.TextureCategories[category];
			if (!features.ContainsKey(feature)) {
				return null;
			}
			return features[feature];
		}

		public IEnumerable<ModSettingEntry> Enumerate(string mod)
		{
			if(this.json.Name != mod) {
				yield break;
			}

			foreach(var pair in this.json.TextureCategories) {
				string category = pair.Key;
				foreach(var feature in this.json.TextureCategories[category]) {
					string featureName = feature.Key;
					string path = feature.Value;
					yield return new ModSettingEntry(mod, category, featureName, path);
				}
			}
		}

		public IEnumerable<string> EnumerateMods()
		{
			yield return this.json.Name;
		}

		public string FilePath => this.filepath;

	}
}
