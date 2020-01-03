using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Util
{
	public static class DirectoryUtil
	{
		public static IEnumerable<string> EnumerateDirectories(string path)
			=> Directory.Exists(path) ? Directory.EnumerateDirectories(path) : Enumerable.Empty<string>();

		public static IEnumerable<string> EnumerateFiles(string path)
			=> Directory.Exists(path) ? Directory.EnumerateFiles(path) : Enumerable.Empty<string>();

		public static IEnumerable<string> EnumerateFiles(string path, string pattern)
			=> Directory.Exists(path) ? Directory.EnumerateFiles(path, pattern) : Enumerable.Empty<string>();

		public static void DeleteRecursive(string path)
		{
			if (Directory.Exists(path)) {
				Directory.Delete(path, recursive: true);
			}
		}

		public static void Create(string path)
		{
			if (!Directory.Exists(path)) {
				Directory.CreateDirectory(path);
			}
		}
	}
}
