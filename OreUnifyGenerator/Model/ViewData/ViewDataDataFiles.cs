using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OreUnifyGenerator.Model.ModSetting;

namespace OreUnifyGenerator.Model.ViewData
{
	public class ViewDataDataFiles : IViewData
	{
		public List<string> DataFiles { get; } = new List<string>();

		public void AddDataFile(string filepath) => this.DataFiles.Add(filepath);

		public void RemoveDataFile(string filepath) => this.DataFiles.Remove(filepath);

		public IModSetting GenerateModSetting()
		{
			var complex = new ModSettingComplex();

			foreach(string file in DataFiles) {
				if (!File.Exists(file)) continue;
				var setting = ModSettings.Of(file);
				complex.AddModSetting(setting);
			}

			return complex;
		}

		public string asOneLineString()
		{
			if (DataFiles.Count <= 0) return "0個のデータファイル";
			else if (DataFiles.Count == 1) return $"1個のデータファイル: {Path.GetFileName(DataFiles[0])}";
			else return $"{DataFiles.Count}個のデータファイル: {Path.GetFileName(DataFiles[0])}, {Path.GetFileName(DataFiles[1])}, ...";
		}
	}
}
