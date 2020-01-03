using OreUnifyGenerator.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OreUnifyGenerator.View
{
	public partial class EditTexturesForm
	{
		private class Category
		{
			private readonly EditTexturesForm form;
			public Category(EditTexturesForm form) => this.form = form;

			public string NameOf(ListViewItem item) => item.Text;

			public string GetCurrent()
			{
				if (!form.categoriesListView.IsAnySelected()) {
					return null;
				}
				return NameOf(form.categoriesListView.SelectedItem());
			}
		}

		private class Feature
		{
			private readonly EditTexturesForm form;
			public Feature(EditTexturesForm form) => this.form = form;

			public string NameOf(ListViewItem item) => item.Text;

			public string GetCurrent()
			{
				if (!form.featuresListView.IsAnySelected()) {
					return null;
				}
				return NameOf(form.featuresListView.SelectedItem());
			}

			public IEnumerable<string> GetCurrentFeatures()
			{
				foreach (ListViewItem item in form.featuresListView.SelectedItems) {
					yield return NameOf(item);
				}
			}
		}

		private class ListViewItems
		{
			private readonly EditTexturesForm form;
			public ListViewItems(EditTexturesForm form) => this.form = form;

			public ListViewItem Of(string category, string feature)
			{
				string path = form.viewData.Provider.GetTexturePathToOpen(category, feature);
				bool enabled = form.viewData.EnableStateRegistry.IsEnabled(category, feature);
				var item = new ListViewItem(new string[] { feature, path }) { Checked = enabled };
				if (form.viewData.Provider.IsSystemTexture(category, feature) && !form.viewData.Provider.IsUserTexture(category, feature)) {
					decorateAsSystemItem(item);
				}
				return item;
			}

			public ListViewItem Of(string category)
			{
				var item = new ListViewItem(category);
				if (form.viewData.Provider.IsSystemCategory(category) && !form.viewData.Provider.IsUserCategory(category)) {
					decorateAsSystemItem(item);
				}
				return item;
			}

			private ListViewItem decorateAsSystemItem(ListViewItem item)
			{
				item.BackColor = Color.LightGray;
				item.Font = new Font(item.Font, FontStyle.Bold);
				return item;
			}

		}

		private class ListViews
		{
			private readonly Cache<List<ListViewItem>> listViewCache = new Cache<List<ListViewItem>>();

			private readonly EditTexturesForm form;
			public ListViews(EditTexturesForm form) => this.form = form;

			public List<ListViewItem> FeaturesOf(string category)
			{
				var listViewItems = listViewCache.Get(category);
				if (listViewItems == null) {
					listViewItems = new List<ListViewItem>();
					var features = form.viewData.Operator.Registry.Features(category);
					foreach (string feature in features) {
						listViewItems.Add(form.listViewItem.Of(category, feature));
					}
					listViewCache.Set(category, listViewItems);
				}
				return listViewItems;
			}

			public void UpdateFeaturesListView()
			{
				if (!form.categoriesListView.IsAnySelected()) return;

				string category = form.category.NameOf(form.categoriesListView.SelectedItem());

				var items = FeaturesOf(category);

				form.featuresListView.Items.Clear();
				form.featuresListView.BeginUpdate();
				items.ForEach(item => form.featuresListView.Items.Add(item));
				form.featuresListView.EndUpdate();
			}

			public void UpdateCategoriesListView()
			{
				form.categoriesListView.BeginUpdate();
				form.categoriesListView.Items.Clear();
				foreach (string category in form.viewData.Operator.Registry.Categories()) {
					form.categoriesListView.Items.Add(form.listViewItem.Of(category));
				}
				form.categoriesListView.EndUpdate();
			}

			public void RemoveCache(string category)
			{
				this.listViewCache.Remove(category);
			}

		}

	}
}
