using OreUnifyGenerator.Model.Texture;
using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.TextureDownload
{
	public class ModTextureOrganizer
	{
		private readonly SystemTextureProvider srcProvider;
		private readonly ITextureProviderSystemAndUser destProvider;

		public bool HasError { get; private set; }

		public ModTextureOrganizer(SystemTextureProvider srcProvider, ITextureProviderSystemAndUser destProvider)
		{
			this.srcProvider = srcProvider;
			this.destProvider = destProvider;
		}

		public void Organize()
		{
			var modJarCache = new Dictionary<string, ZipArchive>();
			foreach (var jarPath in ModJarAccessor.textureDomainToModJar.Values) {
				modJarCache.Add(jarPath, ZipFile.OpenRead(jarPath));
			}

			const string LOG = "SystemTextre";

			Program.InitializingLogger.Info(LOG, "テクスチャの配置を開始");

			foreach (var entry in srcProvider.Enumerate()) {
				var jarPath = ModJarAccessor.textureDomainToModJar[entry.Mod];
				var archive = modJarCache[jarPath];
				var destFile = destProvider.GetSystemTexturePath(entry.Category, entry.Feature);
				if (!File.Exists(destFile)) {
					DirectoryUtil.Create(Path.GetDirectoryName(destFile));
					Program.InitializingLogger.Info(LOG, $"{jarPath.GetRelativePath()} から {entry.Category}/{entry.Feature} を展開中");
					archive.GetEntry(entry.SrcPath).ExtractToFile(destFile, overwrite: false);
				}
			}

			Program.InitializingLogger.Info(LOG, "テクスチャの配置完了");
		}
	}
}
