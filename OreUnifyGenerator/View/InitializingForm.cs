using OreUnifyGenerator.Initialize;
using OreUnifyGenerator.Logging;
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
	public partial class InitializingForm : Form, ILogger
	{

		private readonly Initializer initializer;

		public InitializingForm(Initializer initializer)
		{
			InitializeComponent();

			this.initializer = initializer;
		}

		public void log(Color back, Color fore, string text)
		{
			int start = logBox.Text.Length;
			int length = text.Length;
			logBox.AppendText(text);

			logBox.Select(start, length);

			logBox.SelectionBackColor = back;
			logBox.SelectionColor = fore;

			logBox.Select(logBox.Text.Length - 1, 0);
			logBox.ScrollToCaret();
		}

		public void Debug(string name, string msg) => log(logBox.BackColor, Color.DarkGray, $"[{name}] {msg}\n");
		public void Error(string name, string msg) => log(Color.Black, Color.Red, $"[{name}] {msg}\n");
		public void Info(string name, string msg) => log(logBox.BackColor, Color.Black, $"[{name}] {msg}\n");
		public void Warn(string name, string msg) => log(logBox.BackColor, Color.DarkRed, $"[{name}] {msg}\n");

		private void InitializingForm_Load(object sender, EventArgs e)
		{

		}

		private void InitializingForm_Shown(object sender, EventArgs e)
		{
			initializer.InitEnvironment();
			if (initializer.HasError) {
				Error("Initializer", "エラーあり。正しく動作しない可能性があります");
			}
			else {
				Info("Initializer", "=== 初期準備完了 ===");
			}

			this.Text += " - 完了";
			finishBtn.Enabled = true;
			this.AcceptButton = finishBtn;
		}

		private void finishBtn_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
