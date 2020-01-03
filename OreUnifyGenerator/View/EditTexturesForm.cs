using OreUnifyGenerator.Model.Texture;
using OreUnifyGenerator.Model.ViewData;
using OreUnifyGenerator.Util;
using OreUnifyGenerator.View.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OreUnifyGenerator.View
{
	public partial class EditTexturesForm : Form, IViewDataProvider<ViewDataTextures>
	{
		public EditTexturesForm()
		{
			InitializeComponent();

			this.category = new Category(this);
			this.feature = new Feature(this);
			this.listViewItem = new ListViewItems(this);
			this.listView = new ListViews(this);

			texturePreviewBox.Parent = transparentBgPictureBox;
			texturePreviewBox.Location = new Point(0, 0);
			texturePreviewBox.Size = new Size(64, 64);
		}

		private void EditTexturesForm_Load(object sender, EventArgs e)
		{
			if (categoriesListView.Items.Count > 0) {
				categoriesListView.Items[0].Selected = true;
			}
		}

		private readonly OpenFileDialog addFeatureFileDialog = new OpenFileDialog()
		{
			Title = "テクスチャファイルを選択",
			Filter = "テクスチャファイル|*.png|すべてのファイル|*.*",
			Multiselect = true
		};


		private ViewDataTextures viewData;

		private readonly Category category;
		private readonly Feature feature;
		private readonly ListViewItems listViewItem;
		private readonly ListViews listView;
		

		public void SetData(ViewDataTextures data)
		{
			this.viewData = data;

			this.listView.UpdateCategoriesListView();
		}

		public ViewDataTextures GetData()
		{
			foreach(ListViewItem categoryItem in categoriesListView.Items) {
				string category = this.category.NameOf(categoryItem);
				var featureListViewItems = this.listView.FeaturesOf(category);
				foreach(var featureItem in featureListViewItems) {
					string feature = this.feature.NameOf(featureItem);
					this.viewData.EnableStateRegistry.SetEnabled(category, feature, featureItem.Checked);
				}
			}
			return this.viewData;
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void EditTexturesForm_FormClosing(object sender, FormClosingEventArgs e) => this.DialogResult = DialogResult.OK;


		private void checkAllBtn_Click(object sender, EventArgs e)
		{
			foreach(ListViewItem item in featuresListView.Items) {
				item.Checked = true;
			}
		}

		private void uncheckAllBtn_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in featuresListView.Items) {
				item.Checked = false;
			}
		}

		private void reverseChecksBtn_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in featuresListView.Items) {
				item.Checked = !item.Checked;
			}
		}

		private void addFeatureBtn_Click(object sender, EventArgs e)
		{
			string category = this.category.GetCurrent();
			if(category == null) {
				MessageBox.Show("カテゴリーを指定してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var result = addFeatureFileDialog.ShowDialog();
			if(result != DialogResult.OK) {
				return;
			}

			if (addFeatureFileDialog.FileNames.Length == 1) {
				string feature = Path.GetFileNameWithoutExtension(addFeatureFileDialog.FileName);
				feature = TextInputDialog.Show("追加する項目の名前: ", "", feature);
				this.viewData.Operator.Import(category, feature, addFeatureFileDialog.FileName);
				featuresListView.Items.Add(this.listViewItem.Of(category, feature));
			}
			else {
				foreach(var fileName in addFeatureFileDialog.FileNames) {
					string feature = Path.GetFileNameWithoutExtension(fileName);
					this.viewData.Operator.Import(category, feature, fileName);
					featuresListView.Items.Add(this.listViewItem.Of(category, feature));
				}
			}

			this.listView.RemoveCache(category);
			this.listView.UpdateFeaturesListView();
		}

		private void editFeatureBtn_Click(object sender, EventArgs e)
		{
			if (!featuresListView.IsAnySelected()) {
				return;
			}

			var item = featuresListView.SelectedItem();
			string category = this.category.GetCurrent();
			string oldFeature = this.feature.NameOf(item);
			string oldPath = this.viewData.Provider.GetTexturePathToOpen(category, oldFeature);

			string newFeature = TextInputDialog.Show("項目名を変更", "", oldFeature);
			if (newFeature == oldFeature) return;

			this.viewData.Operator.Import(category, newFeature, oldPath);
			featuresListView.Items.Add(this.listViewItem.Of(category, newFeature));

			this.viewData.Operator.RemoveFeature(category, oldFeature);
			if (!this.viewData.Provider.IsSystemTexture(category, oldFeature)) {
				featuresListView.Items.Remove(item);
			}

			this.listView.RemoveCache(category);
			this.listView.UpdateFeaturesListView();
		}

		private void deleteFeatureBtn_Click(object sender, EventArgs e)
		{
			if (!featuresListView.IsAnySelected()) return;

			string category = this.category.GetCurrent();
			if (category == null) {
				return;
			}

			foreach (string feature in this.feature.GetCurrentFeatures()) {
				this.viewData.Operator.RemoveFeature(category, feature);
			}

			foreach (ListViewItem item in featuresListView.SelectedItems) {
				if (!this.viewData.Provider.IsSystemTexture(category, this.feature.NameOf(item))) {
					featuresListView.Items.Remove(item);
				}
			}

			this.listView.RemoveCache(category);
			this.listView.UpdateFeaturesListView();
		}



		private void addCategoryBtn_Click(object sender, EventArgs e)
		{
			string category = TextInputDialog.Show("新しいカテゴリーの名前: ");
			categoriesListView.Items.Add(this.listViewItem.Of(category));
			this.viewData.Operator.AddCategory(category);

			this.listView.UpdateCategoriesListView();
		}

		private void deleteCategoryBtn_Click(object sender, EventArgs e)
		{
			if (!categoriesListView.IsAnySelected()) {
				return;
			}

			var result = MessageBox.Show("このカテゴリー内のユーザが追加したテクスチャはすべて削除されます。\n(ただし、デフォルトのテクスチャは削除されません)\n\nよろしいですか?", "確認",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
			if (result != DialogResult.Yes) {
				return;
			}

			string category = this.category.GetCurrent();
			this.viewData.Operator.RemoveCategory(category);
			if (!this.viewData.Provider.IsSystemCategory(category)) {
				categoriesListView.Items.Remove(categoriesListView.SelectedItem());
			}

			this.listView.UpdateCategoriesListView();
		}


		private void categoriesListView_SelectedIndexChanged(object sender, EventArgs e) => this.listView.UpdateFeaturesListView();

		private void featuresListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!featuresListView.IsAnySelected()) return;
			if (!categoriesListView.IsAnySelected()) return;

			string category = this.category.GetCurrent();
			string feature = this.feature.GetCurrent();
			string path = this.viewData.Provider.GetTexturePathToOpen(category, feature);
			string pathToShow = PathUtil.GetRelativePath(this.viewData.Provider.GetRootDirectory(), path);

			featureNameBox.Text = feature;
			texturePathBox.Text = pathToShow;

			texturePreviewBox.ImageLocation = path;
		}

	}
}
