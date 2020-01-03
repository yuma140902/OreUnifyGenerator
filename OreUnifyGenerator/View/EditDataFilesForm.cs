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

		//TODO:
		private const bool hasBuiltinDataFile = false;

		private readonly OpenFileDialog openFileDialog;


		private ListViewItem generateListViewItemFromPath(string path)
		{
			string filename = Path.GetFileName(path);
			return new ListViewItem(new string[] { filename, path });
		}

		private void decorateBuiltinDataFile(ListViewItem item)
		{
			item.Font = new Font(item.Font, FontStyle.Bold);
			item.BackColor = Color.LightGray;
			item.ToolTipText = "デフォルト項目は変更できません。";
		}

		public void SetData(ViewDataDataFiles data) {
			foreach (string path in data.DataFiles) {
				mainListView.Items.Add(generateListViewItemFromPath(path));
			}
			if (hasBuiltinDataFile && mainListView.Items.Count > 0) {
				decorateBuiltinDataFile(mainListView.Items[0]);
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


		private void swapItems(int index1, int index2)
		{
			int lastIndex = mainListView.Items.Count - 1;
			if(hasBuiltinDataFile && (index1 == lastIndex || index2 == lastIndex)) {
				showBuiltinDataFileOperationError();
				return;
			}

			var item1 = mainListView.Items[index1];
			var item2 = mainListView.Items[index2];

			mainListView.Items.Remove(item1);
			mainListView.Items.Remove(item2);

			mainListView.Items.Insert(index1, item2);
			mainListView.Items.Insert(index2, item1);
		}

		private void showBuiltinDataFileOperationError()
		{
			MessageBox.Show("デフォルト項目は並べ替え・除去できません。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void upBtn_Click(object sender, EventArgs e)
		{
			if (!mainListView.IsAnySelected()) return;
			int index = mainListView.SelectedIndices[0];
			if (index == 0) return;
			swapItems(index - 1, index);
		}

		private void downBtn_Click(object sender, EventArgs e)
		{
			if (!mainListView.IsAnySelected()) return;
			int index = mainListView.SelectedIndices[0];
			if (index == mainListView.Items.Count - 1) return;
			swapItems(index, index + 1);
		}

		private void removeBtn_Click(object sender, EventArgs e)
		{
			if (!mainListView.IsAnySelected()) return;
			var index = mainListView.SelectedIndex();
			if (hasBuiltinDataFile && index == mainListView.Items.Count - 1) {
				showBuiltinDataFileOperationError();
				return;
			}

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
