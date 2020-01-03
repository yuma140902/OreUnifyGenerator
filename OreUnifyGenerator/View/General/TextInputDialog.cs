using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OreUnifyGenerator.View.General
{
	public partial class TextInputDialog : Form
	{
		public static string Show(string message, string caption = "", string text = "")
			=> new TextInputDialog().ShowDialog(message, caption, text);


		public TextInputDialog()
		{
			InitializeComponent();
		}

		public void SetCaption(string caption) => this.Text = caption;

		public void SetMessage(string message) => messageLabel.Text = message;

		public void SetText(string text) => inputBox.Text = text;

		private void okBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Close();
		}

		public string ShowDialog(string message, string caption = "", string text = "")
		{
			SetMessage(message);
			SetCaption(caption);
			SetText(text);
			ShowDialog();
			return inputBox.Text;
		}
	}
}
