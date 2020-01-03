using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Util
{
	public static class FileUtil
	{
		public static void CopyOverwrite(string source, string dest)
		{
			if(source == dest) {
				return;
			}

			if (!File.Exists(source)) {
				return;
			}

			if (File.Exists(dest)) {
				File.Delete(dest);
			}
			DirectoryUtil.Create(Path.GetDirectoryName(dest));
			File.Copy(source, dest);
		}

		public static void Delete(string path)
		{
			if (File.Exists(path)) {
				File.Delete(path);
			}
		}
	}
}
