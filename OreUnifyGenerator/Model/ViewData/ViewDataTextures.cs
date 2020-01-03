using OreUnifyGenerator.Model.Texture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.ViewData
{
	public class ViewDataTextures : IViewData
	{
		public ITextureEnableStateRegistry EnableStateRegistry { get; private set; }
		public ITextureProviderSystemAndUser Provider { get; private set; }
		public ITextureOperator Operator { get; private set; }

		public ViewDataTextures(ITextureEnableStateRegistry enableStateRegistry,
			ITextureProviderSystemAndUser provider, ITextureOperator importer)
		{
			this.EnableStateRegistry = enableStateRegistry;
			this.Provider = provider;
			this.Operator = importer;
		}

		public string asOneLineString() => "";

	}
}
