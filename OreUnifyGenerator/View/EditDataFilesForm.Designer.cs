namespace OreUnifyGenerator.View
{
	partial class EditDataFilesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainListView = new System.Windows.Forms.ListView();
			this.fileNameColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.filePathColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.removeBtn = new System.Windows.Forms.Button();
			this.addBtn = new System.Windows.Forms.Button();
			this.okBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mainListView
			// 
			this.mainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameColHeader,
            this.filePathColHeader});
			this.mainListView.FullRowSelect = true;
			this.mainListView.HideSelection = false;
			this.mainListView.Location = new System.Drawing.Point(12, 12);
			this.mainListView.MultiSelect = false;
			this.mainListView.Name = "mainListView";
			this.mainListView.ShowItemToolTips = true;
			this.mainListView.Size = new System.Drawing.Size(397, 153);
			this.mainListView.TabIndex = 0;
			this.mainListView.UseCompatibleStateImageBehavior = false;
			this.mainListView.View = System.Windows.Forms.View.Details;
			// 
			// fileNameColHeader
			// 
			this.fileNameColHeader.Text = "名前";
			this.fileNameColHeader.Width = 120;
			// 
			// filePathColHeader
			// 
			this.filePathColHeader.Text = "パス";
			this.filePathColHeader.Width = 240;
			// 
			// removeBtn
			// 
			this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.removeBtn.Image = global::OreUnifyGenerator.Properties.Resources.delete;
			this.removeBtn.Location = new System.Drawing.Point(415, 12);
			this.removeBtn.Name = "removeBtn";
			this.removeBtn.Size = new System.Drawing.Size(75, 23);
			this.removeBtn.TabIndex = 3;
			this.removeBtn.Text = "除去(&R)";
			this.removeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.removeBtn.UseVisualStyleBackColor = true;
			this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
			// 
			// addBtn
			// 
			this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addBtn.Image = global::OreUnifyGenerator.Properties.Resources.add;
			this.addBtn.Location = new System.Drawing.Point(415, 41);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 4;
			this.addBtn.Text = "追加(&A)";
			this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.Location = new System.Drawing.Point(391, 177);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(99, 23);
			this.okBtn.TabIndex = 5;
			this.okBtn.Text = "OK";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(286, 177);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(99, 23);
			this.cancelBtn.TabIndex = 6;
			this.cancelBtn.Text = "キャンセル";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// EditDataFilesForm
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(502, 212);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.removeBtn);
			this.Controls.Add(this.mainListView);
			this.Name = "EditDataFilesForm";
			this.Text = "データファイルを編集";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView mainListView;
		private System.Windows.Forms.ColumnHeader fileNameColHeader;
		private System.Windows.Forms.ColumnHeader filePathColHeader;
		private System.Windows.Forms.Button removeBtn;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Button cancelBtn;
	}
}