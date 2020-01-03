using OreUnifyGenerator.Model.ViewData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OreUnifyGenerator.View
{
	public partial class EditSupportModsForm : Form, IViewDataProvider<ViewDataSupportMods>
	{
		public EditSupportModsForm()
		{
			InitializeComponent();
		}

		private ListViewItem generateItem(string mod, bool enabled) => new ListViewItem(mod) { Checked = enabled };

		public void SetData(ViewDataSupportMods data)
		{
			foreach(var pair in data.ModStates) {
				mainListView.Items.Add(generateItem(pair.Key, pair.Value));
			}
		}

		private (string, bool) getPairFromItem(ListViewItem item) => (item.Text, item.Checked);

		public ViewDataSupportMods GetData()
		{
			var data = new ViewDataSupportMods();
			foreach(ListViewItem item in mainListView.Items) {
				(string mod, bool enabled) = getPairFromItem(item);
				data.AddMod(mod, enabled);
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


		private void checkAllBtn_Click(object sender, EventArgs e)
		{
			foreach(ListViewItem item in mainListView.Items) {
				item.Checked = true;
			}
		}

		private void uncheckAllBtn_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in mainListView.Items) {
				item.Checked = false;
			}
		}

		private void revertChecksBtn_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in mainListView.Items) {
				item.Checked = !item.Checked;
			}
		}
	}
}
