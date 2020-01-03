using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.UpdateCheck.Json
{
	[JsonObject]
	public class VersionEntryJson : IComparable<VersionEntryJson>
	{
		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		public int CompareTo(VersionEntryJson otherObj)
		{
			var self = System.Version.Parse(this.Version);
			var other = System.Version.Parse(otherObj.Version);
			return self.CompareTo(other);
		}
	}
}
