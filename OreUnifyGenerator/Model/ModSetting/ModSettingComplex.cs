using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.ModSetting
{
	public class ModSettingComplex : IModSetting
	{
		private readonly List<IModSetting> modSettings = new List<IModSetting>();

		public void AddModSetting(IModSetting setting) => this.modSettings.Add(setting);

		public string GetRelativePath(string mod, string category, string feature)
		{
			foreach(var modSetting in this.modSettings) {
				string path = modSetting.GetRelativePath(mod, category, feature);
				if(path != null) {
					return path;
				}
			}
			return null;
		}

		public IEnumerable<ModSettingEntry> Enumerate(string mod)
			=> this.modSettings.SelectMany(modSettings => modSettings.Enumerate(mod));

		public IEnumerable<string> EnumerateMods()
			=> this.modSettings.SelectMany(modSetting => modSetting.EnumerateMods());

		public void RemoveModSetting(IModSetting setting) => this.modSettings.Remove(setting);
	}
}
