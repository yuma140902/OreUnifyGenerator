using Newtonsoft.Json;
using OreUnifyGenerator.Download;
using OreUnifyGenerator.Logging;
using OreUnifyGenerator.UpdateCheck.Json;
using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OreUnifyGenerator.UpdateCheck
{
	public class UpdateChecker
	{
		private readonly DownloadCandidate candidate;

		public UpdateChecker(DownloadCandidate candidate)
		{
			this.candidate = candidate;
		}

		public bool HasError { get; private set; } = false;


		public VersionEntryJson CheckForUpdate()
		{
			string file = "tmp/versions.json".GetAbsolutePath();

			bool succeeded;
			using (var downloader = new DownloaderWithLogger(new LoggerDummy())) {
				succeeded = downloader.TryDownload(this.candidate, file);
			}

			if (!succeeded) {
				this.HasError = true;
				return null;
			}

			VersionsJson json;
			using (var reader = new StreamReader(file, Encoding.UTF8)) {
				json = JsonConvert.DeserializeObject<VersionsJson>(reader.ReadToEnd());
			}

			var currentVer = Version.Parse(Program.Version);
			var versionJson = json.Versions.Max();
			var ver = Version.Parse(versionJson.Version);
			if (ver > currentVer) {
				return versionJson;
			}

			return null;

		}
	}
}
