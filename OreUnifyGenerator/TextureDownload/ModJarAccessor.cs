using OreUnifyGenerator.Download;
using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.TextureDownload
{
	public class ModJarAccessor
	{
		public static readonly string ModJarDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mod_jar");

		public static readonly string IC2Jar = path("industrialcraft-2-2.2.827-experimental.jar");
		public static readonly string BCCoreJar = path("buildcraft-7.1.23-core.jar");
		public static readonly string TFJar = path("ThermalFoundation-[1.7.10]1.2.6-118.jar");
		public static readonly string TiCJar = path("TConstruct-1.7.10-1.8.8.jar");
		public static readonly string FFMJar = path("forestry_1.7.10-4.2.16.64.jar");

		private static string path(string fileName) => Path.Combine(ModJarDirectory, fileName);

		public static readonly Dictionary<string, string> textureDomainToModJar = new Dictionary<string, string>()
		{
			{"ic2", IC2Jar },
			{"buildcraftcore",  BCCoreJar },
			{"thermalfoundation", TFJar },
			{"tinker",  TiCJar },
			{"forestry", FFMJar}
		};
	}
}
