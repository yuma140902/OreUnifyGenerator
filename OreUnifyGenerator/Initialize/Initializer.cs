using OreUnifyGenerator.Properties;
using OreUnifyGenerator.TextureDownload;
using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace OreUnifyGenerator.Initialize
{
	public class Initializer
	{
		public readonly string DefaultDataDirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "default_data_files");
		private readonly string defaultDataFilesZip = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "default_data_files.zip");
		private readonly string systemTextureSettingFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "system.json");

		public bool HasError { get; private set; }

		private void generateFileIfNotExists(string path, byte[] bytes)
		{
			if (!File.Exists(path)) {
				Program.InitializingLogger.Info("Initializer-FileGen", $"{path.GetRelativePath()} を生成中");
				using (var stream = new FileStream(path, FileMode.CreateNew, FileAccess.Write)) {
					stream.Write(bytes, 0, bytes.Length);
				}
				Program.InitializingLogger.Info("Initializer-FileGen", $"完了 ({bytes.Length}Byte)");
			}
		}

		public bool NeedInit()
			=> !File.Exists(defaultDataFilesZip)
			|| !File.Exists(systemTextureSettingFilePath)
			|| !Directory.Exists(DefaultDataDirPath)
			|| Directory.GetFiles(DefaultDataDirPath).Length == 0
			|| !Directory.Exists(ModJarAccessor.ModJarDirectory)
			|| Directory.GetFiles(ModJarAccessor.ModJarDirectory).Length == 0
			|| !Directory.Exists(Program.TextureProvider.GetRootDirectory())
			|| Directory.GetDirectories(Program.TextureProvider.GetRootDirectory()).Length == 0
			;



		public void InitEnvironment()
		{
#if DEBUG
			Program.InitializingLogger.Debug("TEST", "debug - 詳細なログ");
			Program.InitializingLogger.Info("TEST", "info - 通常のログ");
			Program.InitializingLogger.Warn("TEST", "warn - 警告。無視しても問題ない");
			Program.InitializingLogger.Error("TEST", "error - エラー。再起不能");
#endif


			DirectoryUtil.Create(DefaultDataDirPath);

			if (!File.Exists(defaultDataFilesZip) || !Directory.Exists(DefaultDataDirPath) || Directory.GetFiles(DefaultDataDirPath).Length == 0) {
				generateFileIfNotExists(defaultDataFilesZip, Resources.DefaultDataFilesZip);
				DirectoryUtil.DeleteRecursive(DefaultDataDirPath);
				Program.InitializingLogger.Info("Initializer-Extract", $"{defaultDataFilesZip.GetRelativePath()} を展開中");
				ZipFile.ExtractToDirectory(defaultDataFilesZip, DefaultDataDirPath);
				Program.InitializingLogger.Info("Initializer-Extract", $"展開完了");
			}
			generateFileIfNotExists(systemTextureSettingFilePath, Resources.SystemTextureSettingFile);

			var downloader = new ModTexturesDownloader();
			downloader.DownloadDependencies();
			if (downloader.HasError) {
				this.HasError = true;
			}

			// TODO: ここでModのjarファイルのテクスチャの配置処理
			var organizer = new ModTextureOrganizer(new SystemTextureProvider(systemTextureSettingFilePath), Program.TextureProvider);
			organizer.Organize();
			if (organizer.HasError) {
				this.HasError = true;
			}
		}
	}
}
