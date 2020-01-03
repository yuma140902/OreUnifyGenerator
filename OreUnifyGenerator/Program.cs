using OreUnifyGenerator.Initialize;
using OreUnifyGenerator.Logging;
using OreUnifyGenerator.Model.Texture;
using OreUnifyGenerator.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OreUnifyGenerator
{
	static class Program
	{
		public const string Name = "OreUnifyGenerator";
		public const string Version = "0.0.0";
		public static readonly Initializer Initializer = new Initializer();

		private static readonly string texturesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"textures");
		public static readonly TextureProviderSystemAndUser TextureProvider = new TextureProviderSystemAndUser(texturesDirectory);

		public static ILogger InitializingLogger { get; private set; }

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if ((args.Length > 0 && args[0] == "--force-init") || Initializer.NeedInit()) {
				var initForm = new InitializingForm(Initializer);
				InitializingLogger = initForm;
				Application.Run(initForm);
			}

			Application.Run(new Form1());
		}
	}
}
