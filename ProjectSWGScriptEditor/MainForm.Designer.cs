namespace ProjectSWGScriptEditor
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.setScriptPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scriptViewerTb = new System.Windows.Forms.TextBox();
			this.editorNameLbl = new System.Windows.Forms.Label();
			this.setClientdataPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.treeView1.Location = new System.Drawing.Point(3, 3);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(157, 319);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(606, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setScriptPathToolStripMenuItem,
            this.setClientdataPathToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
			this.toolStripDropDownButton1.Text = "Settings";
			// 
			// setScriptPathToolStripMenuItem
			// 
			this.setScriptPathToolStripMenuItem.Name = "setScriptPathToolStripMenuItem";
			this.setScriptPathToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.setScriptPathToolStripMenuItem.Text = "Set script path";
			this.setScriptPathToolStripMenuItem.Click += new System.EventHandler(this.setScriptPathToolStripMenuItem_Click);
			// 
			// scriptViewerTb
			// 
			this.scriptViewerTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.scriptViewerTb.Location = new System.Drawing.Point(6, 16);
			this.scriptViewerTb.Multiline = true;
			this.scriptViewerTb.Name = "scriptViewerTb";
			this.scriptViewerTb.ReadOnly = true;
			this.scriptViewerTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.scriptViewerTb.Size = new System.Drawing.Size(406, 306);
			this.scriptViewerTb.TabIndex = 5;
			this.scriptViewerTb.Text = "Script Viewer";
			this.scriptViewerTb.WordWrap = false;
			// 
			// editorNameLbl
			// 
			this.editorNameLbl.AutoSize = true;
			this.editorNameLbl.Location = new System.Drawing.Point(3, 0);
			this.editorNameLbl.Name = "editorNameLbl";
			this.editorNameLbl.Size = new System.Drawing.Size(65, 13);
			this.editorNameLbl.TabIndex = 4;
			this.editorNameLbl.Text = "Editor Name";
			// 
			// setClientdataPathToolStripMenuItem
			// 
			this.setClientdataPathToolStripMenuItem.Name = "setClientdataPathToolStripMenuItem";
			this.setClientdataPathToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.setClientdataPathToolStripMenuItem.Text = "Set clientdata path";
			this.setClientdataPathToolStripMenuItem.Click += new System.EventHandler(this.setClientdataPathToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 28);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.editorNameLbl);
			this.splitContainer1.Panel2.Controls.Add(this.scriptViewerTb);
			this.splitContainer1.Size = new System.Drawing.Size(582, 325);
			this.splitContainer1.SplitterDistance = 163;
			this.splitContainer1.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 365);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "ProjectSWG Script Editor";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem setScriptPathToolStripMenuItem;
		private System.Windows.Forms.TextBox scriptViewerTb;
		private System.Windows.Forms.Label editorNameLbl;
		private System.Windows.Forms.ToolStripMenuItem setClientdataPathToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}

