using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public class TextureRegistry : ITextureRegistry
	{
		private readonly Dictionary<string, HashSet<string>> categories = new Dictionary<string, HashSet<string>>();

		public void AddFromProvider(ITextureProvider provider)
		{
			foreach(string category in provider.Categories()) {
				AddCategory(category);
				AddFeatures(category, provider.Features(category));
			}
		}

		public void AddCategory(string category) => this.categories.Put(category, new HashSet<string>());
		public void AddCategories(IEnumerable<string> categories) { 
			foreach(string category in categories) {
				AddCategory(category);
			}
		}
		public void AddFeature(string category, string feature)
		{
			if (this.categories.ContainsKey(category)) {
				this.categories[category].Add(feature);
			}
			else {
				this.categories.Add(category, new HashSet<string>() { feature });
			}
		}
		public void AddFeatures(string category, IEnumerable<string> features)
		{
			if (this.categories.ContainsKey(category)) {
				var list = this.categories[category];
				foreach(string feature in features) {
					list.Add(feature);
				}
			}
			else {
				var list = new HashSet<string>();
				foreach(string feature in features) {
					list.Add(feature);
				}
				this.categories.Add(category, list);
			}
		}


		public void Clear()
		{
			foreach(string category in Categories()) {
				ClearFeatures(category);
			}
			ClearCategories();
		}
		public void ClearCategories() { }
		public void ClearFeatures(string category) => this.categories.Remove(category);


		public void RemoveCategory(string category) => this.categories.RemoveSafely(category);

		public void RemoveFeature(string category, string feature)
		{
			if (!this.categories.ContainsKey(category)) {
				return;
			}
			var list = this.categories[category];
			list.Remove(feature);
		}


		public IEnumerable<string> Categories() => this.categories.Keys;
		public IEnumerable<string> Features(string category) => this.categories.GetOrEmpty(category);
	}
}
