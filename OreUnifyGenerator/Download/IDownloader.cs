using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Download
{
	public interface IDownloader
	{
		bool TryDownload(DownloadCandidate condidate, string filePath);
	}
}
