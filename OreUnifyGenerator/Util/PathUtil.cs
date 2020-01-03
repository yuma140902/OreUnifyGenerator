using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Util
{
	public static class PathUtil
	{
		public static string GetRelativePath(string startDir, string targetFile)
		{
			if (!startDir.EndsWith("\\")) startDir += "\\";
			return new Uri(startDir).MakeRelativeUri(new Uri(targetFile)).ToString();
		}

		public static string GetRelativePath(this string targetFile) => GetRelativePath(AppDomain.CurrentDomain.BaseDirectory, targetFile);

		//TODO: 絶対パスを渡された時はそのまま返すようにする
		//TODO: 他の部分で絶対パスを取得していたら、このメソッドを使うように書き換える
		public static string GetAbsolutePath(this string path) => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
	}
}
