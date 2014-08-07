namespace ProjectSWGScriptEditor.Editors
{
	partial class BonusSetEditor
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
			if (disposing && (components != null))
			{
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
			this.scriptPathLbl = new System.Windows.Forms.Label();
			this.scriptTreeView = new System.Windows.Forms.TreeView();
			this.objectTemplateTb = new System.Windows.Forms.TextBox();
			this.addRequiredItemBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// scriptPathLbl
			// 
			this.scriptPathLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scriptPathLbl.AutoSize = true;
			this.scriptPathLbl.Location = new System.Drawing.Point(12, 271);
			this.scriptPathLbl.Name = "scriptPathLbl";
			this.scriptPathLbl.Size = new System.Drawing.Size(59, 13);
			this.scriptPathLbl.TabIndex = 0;
			this.scriptPathLbl.Text = "Script Path";
			// 
			// scriptTreeView
			// 
			this.scriptTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.scriptTreeView.Location = new System.Drawing.Point(12, 12);
			this.scriptTreeView.Name = "scriptTreeView";
			this.scriptTreeView.Size = new System.Drawing.Size(372, 256);
			this.scriptTreeView.TabIndex = 1;
			// 
			// objectTemplateTb
			// 
			this.objectTemplateTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.objectTemplateTb.Location = new System.Drawing.Point(390, 12);
			this.objectTemplateTb.Name = "objectTemplateTb";
			this.objectTemplateTb.Size = new System.Drawing.Size(232, 20);
			this.objectTemplateTb.TabIndex = 4;
			this.objectTemplateTb.Text = "Object STF Name or Object Template";
			// 
			// addRequiredItemBtn
			// 
			this.addRequiredItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addRequiredItemBtn.Location = new System.Drawing.Point(390, 38);
			this.addRequiredItemBtn.Name = "addRequiredItemBtn";
			this.addRequiredItemBtn.Size = new System.Drawing.Size(232, 23);
			this.addRequiredItemBtn.TabIndex = 5;
			this.addRequiredItemBtn.Text = "Add Required Item";
			this.addRequiredItemBtn.UseVisualStyleBackColor = true;
			this.addRequiredItemBtn.Click += new System.EventHandler(this.addRequiredItemBtn_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(390, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 204);
			this.label1.TabIndex = 6;
			this.label1.Text = "Warning:\r\nThis editor automically saves changes - please do not make a change wit" +
    "hout being positive of the changes.  \r\n\r\nThis is temporary.\r\n";
			// 
			// BonusSetEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 293);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addRequiredItemBtn);
			this.Controls.Add(this.objectTemplateTb);
			this.Controls.Add(this.scriptTreeView);
			this.Controls.Add(this.scriptPathLbl);
			this.Name = "BonusSetEditor";
			this.Text = "Bonus Set Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label scriptPathLbl;
		private System.Windows.Forms.TreeView scriptTreeView;
		private System.Windows.Forms.TextBox objectTemplateTb;
		private System.Windows.Forms.Button addRequiredItemBtn;
		private System.Windows.Forms.Label label1;
	}
}