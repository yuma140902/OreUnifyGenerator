namespace OreUnifyGenerator.View
{
	partial class EditTexturesForm
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
			this.categoriesListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.featuresListView = new System.Windows.Forms.ListView();
			this.nameColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.okBtn = new System.Windows.Forms.Button();
			this.checkAllBtn = new System.Windows.Forms.Button();
			this.reverseChecksBtn = new System.Windows.Forms.Button();
			this.uncheckAllBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.texturePreviewBox = new OreUnifyGenerator.Control.InterpolatedPictureBox();
			this.transparentBgPictureBox = new System.Windows.Forms.PictureBox();
			this.texturePathBox = new System.Windows.Forms.TextBox();
			this.featureNameBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.addCategoryBtn = new System.Windows.Forms.Button();
			this.editFeatureBtn = new System.Windows.Forms.Button();
			this.deleteFeatureBtn = new System.Windows.Forms.Button();
			this.addFeatureBtn = new System.Windows.Forms.Button();
			this.deleteCategoryBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.texturePreviewBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transparentBgPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// categoriesListView
			// 
			this.categoriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.categoriesListView.FullRowSelect = true;
			this.categoriesListView.HideSelection = false;
			this.categoriesListView.Location = new System.Drawing.Point(12, 12);
			this.categoriesListView.MultiSelect = false;
			this.categoriesListView.Name = "categoriesListView";
			this.categoriesListView.Size = new System.Drawing.Size(232, 184);
			this.categoriesListView.TabIndex = 0;
			this.categoriesListView.UseCompatibleStateImageBehavior = false;
			this.categoriesListView.View = System.Windows.Forms.View.Details;
			this.categoriesListView.SelectedIndexChanged += new System.EventHandler(this.categoriesListView_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "カテゴリ";
			this.columnHeader1.Width = 200;
			// 
			// featuresListView
			// 
			this.featuresListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.featuresListView.CheckBoxes = true;
			this.featuresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColHeader});
			this.featuresListView.FullRowSelect = true;
			this.featuresListView.HideSelection = false;
			this.featuresListView.Location = new System.Drawing.Point(313, 12);
			this.featuresListView.Name = "featuresListView";
			this.featuresListView.Size = new System.Drawing.Size(418, 306);
			this.featuresListView.TabIndex = 1;
			this.featuresListView.UseCompatibleStateImageBehavior = false;
			this.featuresListView.View = System.Windows.Forms.View.Details;
			this.featuresListView.SelectedIndexChanged += new System.EventHandler(this.featuresListView_SelectedIndexChanged);
			// 
			// nameColHeader
			// 
			this.nameColHeader.Text = "項目名";
			this.nameColHeader.Width = 280;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(250, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 40);
			this.label1.TabIndex = 2;
			this.label1.Text = "→";
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.Location = new System.Drawing.Point(632, 459);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(99, 23);
			this.okBtn.TabIndex = 3;
			this.okBtn.Text = "OK";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// checkAllBtn
			// 
			this.checkAllBtn.Location = new System.Drawing.Point(313, 324);
			this.checkAllBtn.Name = "checkAllBtn";
			this.checkAllBtn.Size = new System.Drawing.Size(85, 23);
			this.checkAllBtn.TabIndex = 6;
			this.checkAllBtn.Text = "すべて有効化";
			this.checkAllBtn.UseVisualStyleBackColor = true;
			this.checkAllBtn.Click += new System.EventHandler(this.checkAllBtn_Click);
			// 
			// reverseChecksBtn
			// 
			this.reverseChecksBtn.Location = new System.Drawing.Point(495, 324);
			this.reverseChecksBtn.Name = "reverseChecksBtn";
			this.reverseChecksBtn.Size = new System.Drawing.Size(113, 23);
			this.reverseChecksBtn.TabIndex = 7;
			this.reverseChecksBtn.Text = "有効/無効を反転";
			this.reverseChecksBtn.UseVisualStyleBackColor = true;
			this.reverseChecksBtn.Click += new System.EventHandler(this.reverseChecksBtn_Click);
			// 
			// uncheckAllBtn
			// 
			this.uncheckAllBtn.Location = new System.Drawing.Point(404, 324);
			this.uncheckAllBtn.Name = "uncheckAllBtn";
			this.uncheckAllBtn.Size = new System.Drawing.Size(85, 23);
			this.uncheckAllBtn.TabIndex = 8;
			this.uncheckAllBtn.Text = "すべて無効化";
			this.uncheckAllBtn.UseVisualStyleBackColor = true;
			this.uncheckAllBtn.Click += new System.EventHandler(this.uncheckAllBtn_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.texturePreviewBox);
			this.panel1.Controls.Add(this.transparentBgPictureBox);
			this.panel1.Controls.Add(this.texturePathBox);
			this.panel1.Controls.Add(this.featureNameBox);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(313, 353);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(418, 78);
			this.panel1.TabIndex = 9;
			// 
			// texturePreviewBox
			// 
			this.texturePreviewBox.BackColor = System.Drawing.Color.Transparent;
			this.texturePreviewBox.Location = new System.Drawing.Point(3, 3);
			this.texturePreviewBox.Name = "texturePreviewBox";
			this.texturePreviewBox.Size = new System.Drawing.Size(64, 64);
			this.texturePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.texturePreviewBox.TabIndex = 12;
			this.texturePreviewBox.TabStop = false;
			// 
			// transparentBgPictureBox
			// 
			this.transparentBgPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.transparentBgPictureBox.Image = global::OreUnifyGenerator.Properties.Resources.transparent_bg;
			this.transparentBgPictureBox.Location = new System.Drawing.Point(3, 3);
			this.transparentBgPictureBox.Name = "transparentBgPictureBox";
			this.transparentBgPictureBox.Size = new System.Drawing.Size(64, 64);
			this.transparentBgPictureBox.TabIndex = 11;
			this.transparentBgPictureBox.TabStop = false;
			// 
			// texturePathBox
			// 
			this.texturePathBox.Location = new System.Drawing.Point(126, 28);
			this.texturePathBox.Name = "texturePathBox";
			this.texturePathBox.ReadOnly = true;
			this.texturePathBox.Size = new System.Drawing.Size(285, 19);
			this.texturePathBox.TabIndex = 10;
			// 
			// featureNameBox
			// 
			this.featureNameBox.Location = new System.Drawing.Point(126, 3);
			this.featureNameBox.Name = "featureNameBox";
			this.featureNameBox.ReadOnly = true;
			this.featureNameBox.Size = new System.Drawing.Size(285, 19);
			this.featureNameBox.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(73, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "パス: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(73, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "項目名: ";
			// 
			// addCategoryBtn
			// 
			this.addCategoryBtn.Image = global::OreUnifyGenerator.Properties.Resources.add;
			this.addCategoryBtn.Location = new System.Drawing.Point(12, 202);
			this.addCategoryBtn.Name = "addCategoryBtn";
			this.addCategoryBtn.Size = new System.Drawing.Size(28, 23);
			this.addCategoryBtn.TabIndex = 11;
			this.addCategoryBtn.UseVisualStyleBackColor = true;
			this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
			// 
			// editFeatureBtn
			// 
			this.editFeatureBtn.Image = global::OreUnifyGenerator.Properties.Resources.edit;
			this.editFeatureBtn.Location = new System.Drawing.Point(703, 324);
			this.editFeatureBtn.Name = "editFeatureBtn";
			this.editFeatureBtn.Size = new System.Drawing.Size(28, 23);
			this.editFeatureBtn.TabIndex = 13;
			this.editFeatureBtn.UseVisualStyleBackColor = true;
			this.editFeatureBtn.Click += new System.EventHandler(this.editFeatureBtn_Click);
			// 
			// deleteFeatureBtn
			// 
			this.deleteFeatureBtn.Image = global::OreUnifyGenerator.Properties.Resources.delete;
			this.deleteFeatureBtn.Location = new System.Drawing.Point(669, 324);
			this.deleteFeatureBtn.Name = "deleteFeatureBtn";
			this.deleteFeatureBtn.Size = new System.Drawing.Size(28, 23);
			this.deleteFeatureBtn.TabIndex = 12;
			this.deleteFeatureBtn.UseVisualStyleBackColor = true;
			this.deleteFeatureBtn.Click += new System.EventHandler(this.deleteFeatureBtn_Click);
			// 
			// addFeatureBtn
			// 
			this.addFeatureBtn.Image = global::OreUnifyGenerator.Properties.Resources.add;
			this.addFeatureBtn.Location = new System.Drawing.Point(635, 324);
			this.addFeatureBtn.Name = "addFeatureBtn";
			this.addFeatureBtn.Size = new System.Drawing.Size(28, 23);
			this.addFeatureBtn.TabIndex = 10;
			this.addFeatureBtn.UseVisualStyleBackColor = true;
			this.addFeatureBtn.Click += new System.EventHandler(this.addFeatureBtn_Click);
			// 
			// deleteCategoryBtn
			// 
			this.deleteCategoryBtn.Image = global::OreUnifyGenerator.Properties.Resources.delete;
			this.deleteCategoryBtn.Location = new System.Drawing.Point(46, 202);
			this.deleteCategoryBtn.Name = "deleteCategoryBtn";
			this.deleteCategoryBtn.Size = new System.Drawing.Size(28, 23);
			this.deleteCategoryBtn.TabIndex = 14;
			this.deleteCategoryBtn.UseVisualStyleBackColor = true;
			this.deleteCategoryBtn.Click += new System.EventHandler(this.deleteCategoryBtn_Click);
			// 
			// EditTexturesForm
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 494);
			this.ControlBox = false;
			this.Controls.Add(this.deleteCategoryBtn);
			this.Controls.Add(this.editFeatureBtn);
			this.Controls.Add(this.deleteFeatureBtn);
			this.Controls.Add(this.addCategoryBtn);
			this.Controls.Add(this.addFeatureBtn);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.uncheckAllBtn);
			this.Controls.Add(this.reverseChecksBtn);
			this.Controls.Add(this.checkAllBtn);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.featuresListView);
			this.Controls.Add(this.categoriesListView);
			this.Name = "EditTexturesForm";
			this.Text = "テクスチャを変更";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTexturesForm_FormClosing);
			this.Load += new System.EventHandler(this.EditTexturesForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.texturePreviewBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transparentBgPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView categoriesListView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Button checkAllBtn;
		private System.Windows.Forms.Button reverseChecksBtn;
		private System.Windows.Forms.Button uncheckAllBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button addFeatureBtn;
		private System.Windows.Forms.Button addCategoryBtn;
		private System.Windows.Forms.Button deleteFeatureBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader nameColHeader;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button editFeatureBtn;
		private System.Windows.Forms.TextBox texturePathBox;
		private System.Windows.Forms.TextBox featureNameBox;
		private System.Windows.Forms.PictureBox transparentBgPictureBox;
		private Control.InterpolatedPictureBox texturePreviewBox;
		private System.Windows.Forms.Button deleteCategoryBtn;
		private System.Windows.Forms.ListView featuresListView;
	}
}