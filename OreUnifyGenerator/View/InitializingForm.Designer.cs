namespace OreUnifyGenerator.View
{
	partial class InitializingForm
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
			this.logBox = new System.Windows.Forms.RichTextBox();
			this.finishBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// logBox
			// 
			this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.logBox.BackColor = System.Drawing.SystemColors.Control;
			this.logBox.Location = new System.Drawing.Point(12, 12);
			this.logBox.Name = "logBox";
			this.logBox.ReadOnly = true;
			this.logBox.Size = new System.Drawing.Size(447, 324);
			this.logBox.TabIndex = 0;
			this.logBox.Text = "";
			// 
			// finishBtn
			// 
			this.finishBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.finishBtn.Enabled = false;
			this.finishBtn.Location = new System.Drawing.Point(384, 342);
			this.finishBtn.Name = "finishBtn";
			this.finishBtn.Size = new System.Drawing.Size(75, 23);
			this.finishBtn.TabIndex = 1;
			this.finishBtn.Text = "完了";
			this.finishBtn.UseVisualStyleBackColor = true;
			this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
			// 
			// InitializingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 377);
			this.Controls.Add(this.finishBtn);
			this.Controls.Add(this.logBox);
			this.Name = "InitializingForm";
			this.Text = "初期準備中";
			this.Load += new System.EventHandler(this.InitializingForm_Load);
			this.Shown += new System.EventHandler(this.InitializingForm_Shown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox logBox;
		private System.Windows.Forms.Button finishBtn;
	}
}