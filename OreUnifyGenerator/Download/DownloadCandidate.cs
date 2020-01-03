using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Download
{
	public class DownloadCandidate
	{
		private readonly List<string> urls = new List<string>();

		public DownloadCandidate(params string[] urls)
		{
			this.urls.AddRange(urls);
		}

		public IEnumerable<string> Enumerate() => this.urls;
	}
}
