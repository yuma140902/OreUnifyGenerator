using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public class TextureLocator
	{
		public TextureLocator(string category, string feature)
		{
			this.Category = category;
			this.Feature = feature;
		}

		public string Category { get; private set; }
		public string Feature { get; private set; }

		public override string ToString() => $"{Category}/{Feature}";

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType()) {
				return false;
			}

			var other = (TextureLocator)obj;
			return other.Category == this.Category && other.Feature == this.Feature;
		}

		public override int GetHashCode() => ToString().GetHashCode();
	}
}
