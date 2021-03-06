﻿using OreUnifyGenerator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using OreUnifyGenerator.Util;
using OreUnifyGenerator.View;
using OreUnifyGenerator.Model.ViewData;
using OreUnifyGenerator.Model.Texture;
using OreUnifyGenerator.Generation;
using OreUnifyGenerator.Model.ModSetting;
using OreUnifyGenerator.Initialize;
using OreUnifyGenerator.UpdateCheck;
using OreUnifyGenerator.Download;
using System.Diagnostics;

namespace OreUnifyGenerator
{
	public partial class Form1 : Form
	{
		private static readonly string outputDirectory = "Output".GetAbsolutePath();

		private ViewDataDataFiles dataFilesViewData = new ViewDataDataFiles();
		private ViewDataSupportMods supportModsViewData = new ViewDataSupportMods();
		private ViewDataTextures texturesViewData;

		public Form1()
		{
			InitializeComponent();

			targetMcVersionBox.SelectedIndex = 0;

			foreach (string datafile in Directory.EnumerateFiles(Program.Initializer.DefaultDataDirPath)) {
				this.dataFilesViewData.AddDataFile(datafile);
			}
			this.dataFilesLabel.Text = this.dataFilesViewData.asOneLineString();

			foreach (string mod in this.dataFilesViewData.GenerateModSetting().EnumerateMods()) {
				this.supportModsViewData.AddMod(mod);
			}
			this.supportModsLabel.Text = this.supportModsViewData.asOneLineString();


			this.texturesViewData = new ViewDataTextures(
				new TextureEnableStateRegistry(),
				Program.TextureProvider,
				new TextureOperatorFileSystem(new TextureRegistry(), Program.TextureProvider));

			this.texturesLabel.Text = this.texturesViewData.asOneLineString();
		}

		private void editDataFilesBtn_Click(object sender, EventArgs e)
		{
			var dialog = new EditDataFilesForm();
			dialog.Owner = this;
			dialog.SetData(this.dataFilesViewData);
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK) {
				this.dataFilesViewData = dialog.GetData();
				dataFilesLabel.Text = this.dataFilesViewData.asOneLineString();
			}

			// supprotModsViewDataを更新する処理
			this.supportModsViewData.ClearMods();
			foreach (string mod in this.dataFilesViewData.GenerateModSetting().EnumerateMods()) {
				this.supportModsViewData.AddMod(mod, true);
			}
		}

		private void editSupportModsBtn_Click(object sender, EventArgs e)
		{
			var dialog = new EditSupportModsForm();
			dialog.Owner = this;
			dialog.SetData(this.supportModsViewData);
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK) {
				this.supportModsViewData = dialog.GetData();
				supportModsLabel.Text = this.supportModsViewData.asOneLineString();
			}
		}

		private void editTexturesBtn_Click(object sender, EventArgs e)
		{
			var dialog = new EditTexturesForm();
			dialog.Owner = this;
			dialog.SetData(this.texturesViewData);
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK) {
				this.texturesViewData = dialog.GetData();
				texturesLabel.Text = this.texturesViewData.asOneLineString();
			}
		}

		private void generateBtn_Click(object sender, EventArgs e)
		{
			var setting = this.dataFilesViewData.GenerateModSetting();
			var modList = this.supportModsViewData.ModStates.Where(pair => pair.Value).Select(pair => pair.Key).ToList();

			var generator = new ResourcePackGenerator(this.texturesViewData.Provider, setting);
			generator.generate(outputDirectory, modList);

			MessageBox.Show("完了しました", "完了");
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			//TODO:
			new AboutBox().ShowDialog();
		}

		private void UpdateCheckMenuItem_Click(object sender, EventArgs e)
		{
			var candidate = new DownloadCandidate("https://raw.githubusercontent.com/yuma140902/UpdateJSON_Forge/master/OreUnifyGeneratorWin/versions.json");
			var checker = new UpdateChecker(candidate);
			var version = checker.CheckForUpdate();

			if (checker.HasError) {
				MessageBox.Show($"{candidate.Enumerate().FirstOrDefault()} を取得できません。\nアップデートの確認に失敗しました。",
					"アップデート確認失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (version == null) {
				MessageBox.Show($"最新のバージョンを使っています: {Program.Version}");
				return;
			}

			var sb = new StringBuilder();
			sb.AppendLine($"新しいバージョン {version.Version} が利用可能です。");
			if (!string.IsNullOrEmpty(version.Description)) {
				sb.AppendLine($"説明: {version.Description}");
			}
			sb.AppendLine($"URL: {version.Url}");
			sb.AppendLine("ダウンロードしますか?");

			var result = MessageBox.Show(sb.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (result == DialogResult.Yes) {
				if (version.Url.StartsWith("http")) {
					Process.Start(version.Url);
				}
			}
		}
	}
}
