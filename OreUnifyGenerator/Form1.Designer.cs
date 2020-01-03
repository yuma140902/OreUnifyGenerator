namespace OreUnifyGenerator
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.outputDirectoryBox = new System.Windows.Forms.TextBox();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UpdateCheckMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.outputDirectoryReferenceBtn = new System.Windows.Forms.Button();
			this.dataFilesLabel = new System.Windows.Forms.Label();
			this.editDataFilesBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.editSupportModsBtn = new System.Windows.Forms.Button();
			this.supportModsLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.editTexturesBtn = new System.Windows.Forms.Button();
			this.texturesLabel = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.generateBtn = new System.Windows.Forms.Button();
			this.targetMcVersionBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.mainMenu.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// outputDirectoryBox
			// 
			this.outputDirectoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputDirectoryBox.Location = new System.Drawing.Point(65, 29);
			this.outputDirectoryBox.Name = "outputDirectoryBox";
			this.outputDirectoryBox.Size = new System.Drawing.Size(324, 19);
			this.outputDirectoryBox.TabIndex = 0;
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.helpMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(482, 24);
			this.mainMenu.TabIndex = 1;
			this.mainMenu.Text = "menuStrip1";
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
			this.fileMenuItem.Name = "fileMenuItem";
			this.fileMenuItem.Size = new System.Drawing.Size(67, 20);
			this.fileMenuItem.Text = "ファイル(&F)";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(113, 22);
			this.exitMenuItem.Text = "終了(&X)";
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// helpMenuItem
			// 
			this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.UpdateCheckMenuItem});
			this.helpMenuItem.Name = "helpMenuItem";
			this.helpMenuItem.Size = new System.Drawing.Size(65, 20);
			this.helpMenuItem.Text = "ヘルプ(&H)";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutMenuItem.Text = "このソフトについて(&A)";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// UpdateCheckMenuItem
			// 
			this.UpdateCheckMenuItem.Name = "UpdateCheckMenuItem";
			this.UpdateCheckMenuItem.Size = new System.Drawing.Size(180, 22);
			this.UpdateCheckMenuItem.Text = "アップデートの確認(&U)";
			this.UpdateCheckMenuItem.Click += new System.EventHandler(this.UpdateCheckMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "出力先: ";
			// 
			// outputDirectoryReferenceBtn
			// 
			this.outputDirectoryReferenceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.outputDirectoryReferenceBtn.Location = new System.Drawing.Point(395, 27);
			this.outputDirectoryReferenceBtn.Name = "outputDirectoryReferenceBtn";
			this.outputDirectoryReferenceBtn.Size = new System.Drawing.Size(75, 23);
			this.outputDirectoryReferenceBtn.TabIndex = 3;
			this.outputDirectoryReferenceBtn.Text = "参照(&R)";
			this.outputDirectoryReferenceBtn.UseVisualStyleBackColor = true;
			this.outputDirectoryReferenceBtn.Click += new System.EventHandler(this.outputDirectoryReferenceBtn_Click);
			// 
			// dataFilesLabel
			// 
			this.dataFilesLabel.AutoSize = true;
			this.dataFilesLabel.Location = new System.Drawing.Point(16, 24);
			this.dataFilesLabel.Name = "dataFilesLabel";
			this.dataFilesLabel.Size = new System.Drawing.Size(50, 12);
			this.dataFilesLabel.TabIndex = 6;
			this.dataFilesLabel.Text = "data.json";
			// 
			// editDataFilesBtn
			// 
			this.editDataFilesBtn.Location = new System.Drawing.Point(18, 50);
			this.editDataFilesBtn.Name = "editDataFilesBtn";
			this.editDataFilesBtn.Size = new System.Drawing.Size(190, 23);
			this.editDataFilesBtn.TabIndex = 7;
			this.editDataFilesBtn.Text = "データファイルを追加・編集";
			this.editDataFilesBtn.UseVisualStyleBackColor = true;
			this.editDataFilesBtn.Click += new System.EventHandler(this.editDataFilesBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.editSupportModsBtn);
			this.groupBox1.Controls.Add(this.supportModsLabel);
			this.groupBox1.Location = new System.Drawing.Point(14, 144);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 82);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "対応するMod";
			// 
			// editSupportModsBtn
			// 
			this.editSupportModsBtn.Location = new System.Drawing.Point(18, 50);
			this.editSupportModsBtn.Name = "editSupportModsBtn";
			this.editSupportModsBtn.Size = new System.Drawing.Size(190, 23);
			this.editSupportModsBtn.TabIndex = 8;
			this.editSupportModsBtn.Text = "対応するModを変更";
			this.editSupportModsBtn.UseVisualStyleBackColor = true;
			this.editSupportModsBtn.Click += new System.EventHandler(this.editSupportModsBtn_Click);
			// 
			// supportModsLabel
			// 
			this.supportModsLabel.AutoSize = true;
			this.supportModsLabel.Location = new System.Drawing.Point(16, 24);
			this.supportModsLabel.Name = "supportModsLabel";
			this.supportModsLabel.Size = new System.Drawing.Size(35, 12);
			this.supportModsLabel.TabIndex = 0;
			this.supportModsLabel.Text = "label2";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.editTexturesBtn);
			this.groupBox2.Controls.Add(this.texturesLabel);
			this.groupBox2.Location = new System.Drawing.Point(14, 242);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(456, 82);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "統一するテクスチャ";
			// 
			// editTexturesBtn
			// 
			this.editTexturesBtn.Location = new System.Drawing.Point(18, 50);
			this.editTexturesBtn.Name = "editTexturesBtn";
			this.editTexturesBtn.Size = new System.Drawing.Size(190, 23);
			this.editTexturesBtn.TabIndex = 9;
			this.editTexturesBtn.Text = "テクスチャを変更";
			this.editTexturesBtn.UseVisualStyleBackColor = true;
			this.editTexturesBtn.Click += new System.EventHandler(this.editTexturesBtn_Click);
			// 
			// texturesLabel
			// 
			this.texturesLabel.AutoSize = true;
			this.texturesLabel.Location = new System.Drawing.Point(16, 24);
			this.texturesLabel.Name = "texturesLabel";
			this.texturesLabel.Size = new System.Drawing.Size(35, 12);
			this.texturesLabel.TabIndex = 0;
			this.texturesLabel.Text = "label2";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.dataFilesLabel);
			this.groupBox3.Controls.Add(this.editDataFilesBtn);
			this.groupBox3.Location = new System.Drawing.Point(14, 56);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(456, 82);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "データファイル";
			// 
			// generateBtn
			// 
			this.generateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.generateBtn.Location = new System.Drawing.Point(327, 396);
			this.generateBtn.Name = "generateBtn";
			this.generateBtn.Size = new System.Drawing.Size(143, 45);
			this.generateBtn.TabIndex = 11;
			this.generateBtn.Text = "生成開始！";
			this.generateBtn.UseVisualStyleBackColor = true;
			this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
			// 
			// targetMcVersionBox
			// 
			this.targetMcVersionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.targetMcVersionBox.Enabled = false;
			this.targetMcVersionBox.FormattingEnabled = true;
			this.targetMcVersionBox.Items.AddRange(new object[] {
            "Minecraft 1.7.10"});
			this.targetMcVersionBox.Location = new System.Drawing.Point(118, 348);
			this.targetMcVersionBox.Name = "targetMcVersionBox";
			this.targetMcVersionBox.Size = new System.Drawing.Size(121, 20);
			this.targetMcVersionBox.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Enabled = false;
			this.label2.Location = new System.Drawing.Point(12, 351);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 12);
			this.label2.TabIndex = 13;
			this.label2.Text = "マイクラのバージョン: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(263, 348);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 12);
			this.label3.TabIndex = 14;
			this.label3.Text = "現在はMinecraft1.7.10のみ対応しています";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(196, 371);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(274, 12);
			this.label4.TabIndex = 15;
			this.label4.Text = "今後のアップデートで他のバージョンにも対応する予定です";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 452);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.targetMcVersionBox);
			this.Controls.Add(this.generateBtn);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.outputDirectoryReferenceBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.outputDirectoryBox);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name = "Form1";
			this.Text = "メイン画面 - OreUnifyGenerator";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox outputDirectoryBox;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button outputDirectoryReferenceBtn;
		private System.Windows.Forms.Label dataFilesLabel;
		private System.Windows.Forms.Button editDataFilesBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button editSupportModsBtn;
		private System.Windows.Forms.Label supportModsLabel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button editTexturesBtn;
		private System.Windows.Forms.Label texturesLabel;
		private System.Windows.Forms.Button generateBtn;
		private System.Windows.Forms.ComboBox targetMcVersionBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripMenuItem UpdateCheckMenuItem;
	}
}

