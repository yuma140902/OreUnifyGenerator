using OreUnifyGenerator.Model.ViewData;
using OreUnifyGenerator.Util;
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
	public partial class EditDataFilesForm : Form, IViewDataProvider<ViewDataDataFiles>
	{
		public EditDataFilesForm()
		{
			InitializeComponent();

			this.openFileDialog = new OpenFileDialog();
			this.openFileDialog.Title = "データファイルを選択";
			this.openFileDialog.Filter = "データファイル|*.json|すべてのファイル|*.*";
		}

		private readonly OpenFileDialog openFileDialog;


		private ListViewItem generateListViewItemFromPath(string path)
		{
			string filename = Path.GetFileName(path);
			return new ListViewItem(new string[] { filename, path });
		}

		public void SetData(ViewDataDataFiles data) {
			foreach (string path in data.DataFiles) {
				mainListView.Items.Add(generateListViewItemFromPath(path));
			}
		}

		private string getPathFromListViewItem(ListViewItem item) => item.SubItems.Count < 1 ? null : item.SubItems[1].Text;

		public ViewDataDataFiles GetData()
		{
			var data = new ViewDataDataFiles();

			foreach(ListViewItem item in mainListView.Items) {
				string path = getPathFromListViewItem(item);
				if(path != null) {
					data.AddDataFile(path);
				}
			}

			return data;
		}


		private void okBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}


		private void removeBtn_Click(object sender, EventArgs e)
		{
			if (!mainListView.IsAnySelected()) return;

			var item = mainListView.SelectedItem();
			if(item != null) mainListView.Items.Remove(item);
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			var result = this.openFileDialog.ShowDialog();
			if(result == DialogResult.OK) {
				mainListView.Items.Insert(0, generateListViewItemFromPath(this.openFileDialog.FileName));
			}
		}
	}
}
