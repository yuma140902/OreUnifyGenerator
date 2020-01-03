using OreUnifyGenerator.Download;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OreUnifyGenerator.TextureDownload.ModJarAccessor;

namespace OreUnifyGenerator.TextureDownload
{
	public class ModTexturesDownloader
	{
		public static readonly DownloadCandidate IC2 = new DownloadCandidate(
			"https://media.forgecdn.net/files/2353/971/industrialcraft-2-2.2.827-experimental.jar", 
			"http://jenkins.ic2.player.to/job/IC2_experimental/lastSuccessfulBuild/artifact/build/libs/industrialcraft-2-2.2.828-experimental.jar");

		public static readonly DownloadCandidate BCCore = new DownloadCandidate(
			"https://www.mod-buildcraft.com/releases/BuildCraft/7.1.23/modules/buildcraft-7.1.23-core.jar",
			"https://media.forgecdn.net/files/2427/226/buildcraft-7.1.22-core.jar");

		public static readonly DownloadCandidate TF = new DownloadCandidate(
			"https://media.forgecdn.net/files/2388/752/ThermalFoundation-%5b1.7.10%5d1.2.6-118.jar");

		public static readonly DownloadCandidate TiC = new DownloadCandidate(
			"https://media.forgecdn.net/files/2264/246/TConstruct-1.7.10-1.8.8.jar");

		public static readonly DownloadCandidate FFM = new DownloadCandidate(
			"http://jenkins.ic2.player.to/job/Forestry/lastSuccessfulBuild/artifact/build/dist/forestry_1.7.10-4.2.16.64.jar",
			"https://media.forgecdn.net/files/2333/823/forestry_1.7.10-4.2.16.64.jar");

		public bool HasError { get; private set; }

		public void DownloadDependencies()
		{
			var succeeded = new List<bool>();
			Program.InitializingLogger.Info("DownloadDep", "依存関係のダウンロード開始");
			using (var downloader = new DownloaderWithLogger(Program.InitializingLogger)) {
				succeeded.Add(downloader.TryDownload(IC2, IC2Jar));
				succeeded.Add(downloader.TryDownload(BCCore, BCCoreJar));
				succeeded.Add(downloader.TryDownload(TF, TFJar));
				succeeded.Add(downloader.TryDownload(TiC, TiCJar));
				succeeded.Add(downloader.TryDownload(FFM, FFMJar));
			}

			Program.InitializingLogger.Info("DownloadDep", "依存関係のダウンロード完了");

			this.HasError = succeeded.Any(item => item == false);
		}
	}
}
