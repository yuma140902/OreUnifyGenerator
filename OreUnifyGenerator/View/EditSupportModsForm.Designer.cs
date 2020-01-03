namespace OreUnifyGenerator.View
{
	partial class EditSupportModsForm
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
			this.okBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.mainListView = new System.Windows.Forms.ListView();
			this.modNameColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.revertChecksBtn = new System.Windows.Forms.Button();
			this.checkAllBtn = new System.Windows.Forms.Button();
			this.uncheckAllBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.Location = new System.Drawing.Point(271, 367);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(99, 23);
			this.okBtn.TabIndex = 0;
			this.okBtn.Text = "OK";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(166, 367);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(99, 23);
			this.cancelBtn.TabIndex = 1;
			this.cancelBtn.Text = "キャンセル";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// mainListView
			// 
			this.mainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainListView.CheckBoxes = true;
			this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modNameColHeader});
			this.mainListView.HideSelection = false;
			this.mainListView.Location = new System.Drawing.Point(12, 12);
			this.mainListView.Name = "mainListView";
			this.mainListView.Size = new System.Drawing.Size(358, 313);
			this.mainListView.TabIndex = 2;
			this.mainListView.UseCompatibleStateImageBehavior = false;
			this.mainListView.View = System.Windows.Forms.View.Details;
			// 
			// modNameColHeader
			// 
			this.modNameColHeader.Text = "Mod";
			this.modNameColHeader.Width = 300;
			// 
			// revertChecksBtn
			// 
			this.revertChecksBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.revertChecksBtn.Location = new System.Drawing.Point(204, 331);
			this.revertChecksBtn.Name = "revertChecksBtn";
			this.revertChecksBtn.Size = new System.Drawing.Size(99, 23);
			this.revertChecksBtn.TabIndex = 3;
			this.revertChecksBtn.Text = "チェックを反転";
			this.revertChecksBtn.UseVisualStyleBackColor = true;
			this.revertChecksBtn.Click += new System.EventHandler(this.revertChecksBtn_Click);
			// 
			// checkAllBtn
			// 
			this.checkAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkAllBtn.Location = new System.Drawing.Point(12, 331);
			this.checkAllBtn.Name = "checkAllBtn";
			this.checkAllBtn.Size = new System.Drawing.Size(81, 23);
			this.checkAllBtn.TabIndex = 4;
			this.checkAllBtn.Text = "全て選択";
			this.checkAllBtn.UseVisualStyleBackColor = true;
			this.checkAllBtn.Click += new System.EventHandler(this.checkAllBtn_Click);
			// 
			// uncheckAllBtn
			// 
			this.uncheckAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.uncheckAllBtn.Location = new System.Drawing.Point(99, 331);
			this.uncheckAllBtn.Name = "uncheckAllBtn";
			this.uncheckAllBtn.Size = new System.Drawing.Size(99, 23);
			this.uncheckAllBtn.TabIndex = 5;
			this.uncheckAllBtn.Text = "全て選択解除";
			this.uncheckAllBtn.UseVisualStyleBackColor = true;
			this.uncheckAllBtn.Click += new System.EventHandler(this.uncheckAllBtn_Click);
			// 
			// EditSupportModsForm
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(382, 402);
			this.Controls.Add(this.uncheckAllBtn);
			this.Controls.Add(this.checkAllBtn);
			this.Controls.Add(this.revertChecksBtn);
			this.Controls.Add(this.mainListView);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.okBtn);
			this.Name = "EditSupportModsForm";
			this.Text = "対応するModを変更";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.ListView mainListView;
		private System.Windows.Forms.ColumnHeader modNameColHeader;
		private System.Windows.Forms.Button revertChecksBtn;
		private System.Windows.Forms.Button checkAllBtn;
		private System.Windows.Forms.Button uncheckAllBtn;
	}
}