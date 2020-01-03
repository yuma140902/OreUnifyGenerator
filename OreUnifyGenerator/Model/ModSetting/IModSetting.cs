using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.ModSetting
{
	public interface IModSetting
	{
		string GetRelativePath(string mod, string category, string feature);

		IEnumerable<ModSettingEntry> Enumerate(string mod);

		IEnumerable<string> EnumerateMods();
	}
}
