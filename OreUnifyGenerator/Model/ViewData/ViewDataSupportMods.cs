using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.ViewData
{
	public class ViewDataSupportMods : IViewData
	{
		public Dictionary<string, bool> ModStates { get; } = new Dictionary<string, bool>();
		public HashSet<string> Mods { get; } = new HashSet<string>();

		public void AddMod(string mod, bool enabled = true)
		{
			this.ModStates.Put(mod, enabled);
			this.Mods.Add(mod);
		}

		public void RemoveMod(string mod) => this.Mods.Remove(mod);

		public bool IsModEnabled(string mod) => this.ModStates.GetOrDefault(mod, false);

		public bool SetModState(string mod, bool enabled) => this.ModStates.Put(mod, enabled);

		public void ClearMods() => this.Mods.Clear();
		public void ClearModStates() => this.ModStates.Clear();

		public string asOneLineString()
		{
			int count = this.ModStates.Count(pair => pair.Value);
			if (count <= 0) return "0個の対応するMod";
			else if (count == 1) {
				string mod = this.ModStates.First(pair => pair.Value).Key;
				return $"1個の対応するMod: {mod}";
			}
			else {
				string mod1 = this.ModStates.First(pair => pair.Value).Key;
				string mod2 = this.ModStates.Last(pair => pair.Value).Key;
				return $"{count}個の対応するMod: {mod1}, {mod2}, ...";
			}
		}
	}
}
