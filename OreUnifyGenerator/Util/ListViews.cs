using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OreUnifyGenerator.Util
{
	public static class ListViews
	{
		public static bool IsAnySelected(this ListView listView) => listView.SelectedItems.Count > 0;
		public static ListViewItem SelectedItem(this ListView listView) => listView.SelectedItems[0];
		public static int SelectedIndex(this ListView listView) => listView.SelectedIndices[0];
	}
}
