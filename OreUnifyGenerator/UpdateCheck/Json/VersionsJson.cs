using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.UpdateCheck.Json
{
	[JsonObject]
	public class VersionsJson
	{
		[JsonProperty("versions")]
		public List<VersionEntryJson> Versions { get; set; }
	}
}
