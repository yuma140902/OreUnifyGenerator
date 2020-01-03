using OreUnifyGenerator.Logging;
using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Download
{
	public class DownloaderWithLogger : IDownloader, IDisposable
	{

		private readonly ILogger logger;
		private readonly WebClient client;

		public DownloaderWithLogger(ILogger logger)
		{
			this.logger = logger;

			this.client = new WebClient();
		}

		public void Dispose() => this.client.Dispose();

		public bool TryDownload(DownloadCandidate candidate, string filePath)
		{
			if (File.Exists(filePath)) {
				return true;
			}

			bool succeeded = false;

			foreach(var urlStr in candidate.Enumerate()) {
				var url = new Uri(urlStr);

				DirectoryUtil.Create(Path.GetDirectoryName(filePath));
				File.Create(filePath).Close();

				this.logger.Info("Downloader", $"{url} から {filePath.GetRelativePath()} にダウンロード中");
				try {
					this.client.DownloadFile(url, filePath);
					succeeded = true;
				}
				catch(Exception ex) {
					this.logger.Error("Downloader", $"エラー: {ex.Message}");
					this.logger.Debug("Downloader", $"{ex}");
					succeeded = false;
				}

				if (succeeded) break;
			}

			return succeeded;
		}
	}
}
