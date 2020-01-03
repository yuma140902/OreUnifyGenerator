using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OreUnifyGenerator.Model.ModSetting.Json
{
	[JsonObject]
	public class ModSettingJson
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("tex")]
		public Dictionary<string, Dictionary<string, string>> TextureCategories { get; set; }

	}
}
