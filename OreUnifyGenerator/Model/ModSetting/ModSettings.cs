using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.ModSetting
{
	public static class ModSettings
	{
		public static ModSettingFile Of(string filepath) => new ModSettingFile(filepath);

		public static ModSettingComplex Of(List<string> files)
		{
			var setting = new ModSettingComplex();
			foreach(var file in files) {
				setting.AddModSetting(Of(file));
			}
			return setting;
		}

		public static ModSettingComplex OfDirectory(string directory) => Of(Directory.EnumerateFiles(directory).ToList());
	}
}
