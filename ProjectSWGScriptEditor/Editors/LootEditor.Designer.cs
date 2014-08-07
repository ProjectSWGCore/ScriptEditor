namespace ProjectSWGScriptEditor.Editors
{
	partial class LootEditor
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lootPoolListbox = new System.Windows.Forms.ListBox();
			this.lootPoolContentsDataView = new System.Windows.Forms.DataGridView();
			this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemChance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.createLootPool = new System.Windows.Forms.Button();
			this.deleteLootPool = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lootPoolContentsDataView)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(714, 491);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(706, 465);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Loot Pools";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(6, 6);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.deleteLootPool);
			this.splitContainer1.Panel1.Controls.Add(this.createLootPool);
			this.splitContainer1.Panel1.Controls.Add(this.lootPoolListbox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.lootPoolContentsDataView);
			this.splitContainer1.Size = new System.Drawing.Size(694, 453);
			this.splitContainer1.SplitterDistance = 230;
			this.splitContainer1.TabIndex = 2;
			// 
			// lootPoolListbox
			// 
			this.lootPoolListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lootPoolListbox.FormattingEnabled = true;
			this.lootPoolListbox.Location = new System.Drawing.Point(3, 46);
			this.lootPoolListbox.Name = "lootPoolListbox";
			this.lootPoolListbox.Size = new System.Drawing.Size(224, 407);
			this.lootPoolListbox.TabIndex = 0;
			this.lootPoolListbox.SelectedIndexChanged += new System.EventHandler(this.lootPoolListbox_SelectedIndexChanged);
			// 
			// lootPoolContentsDataView
			// 
			this.lootPoolContentsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.lootPoolContentsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.lootPoolContentsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemChance});
			this.lootPoolContentsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lootPoolContentsDataView.Location = new System.Drawing.Point(0, 0);
			this.lootPoolContentsDataView.Name = "lootPoolContentsDataView";
			this.lootPoolContentsDataView.Size = new System.Drawing.Size(460, 453);
			this.lootPoolContentsDataView.TabIndex = 1;
			this.lootPoolContentsDataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.lootPoolContentsDataView_CellValueChanged);
			this.lootPoolContentsDataView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.lootPoolContentsDataView_RowsRemoved);
			// 
			// itemName
			// 
			this.itemName.HeaderText = "Item";
			this.itemName.Name = "itemName";
			this.itemName.ReadOnly = true;
			// 
			// itemChance
			// 
			this.itemChance.HeaderText = "Item Chance";
			this.itemChance.Name = "itemChance";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.listBox1);
			this.tabPage2.Controls.Add(this.comboBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(707, 415);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Loot Items";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(6, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(7, 33);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 95);
			this.listBox1.TabIndex = 1;
			// 
			// createLootPool
			// 
			this.createLootPool.Dock = System.Windows.Forms.DockStyle.Top;
			this.createLootPool.Location = new System.Drawing.Point(0, 0);
			this.createLootPool.Name = "createLootPool";
			this.createLootPool.Size = new System.Drawing.Size(230, 23);
			this.createLootPool.TabIndex = 1;
			this.createLootPool.Text = "Create";
			this.createLootPool.UseVisualStyleBackColor = true;
			this.createLootPool.Click += new System.EventHandler(this.createLootPool_Click);
			// 
			// deleteLootPool
			// 
			this.deleteLootPool.Dock = System.Windows.Forms.DockStyle.Top;
			this.deleteLootPool.Location = new System.Drawing.Point(0, 23);
			this.deleteLootPool.Name = "deleteLootPool";
			this.deleteLootPool.Size = new System.Drawing.Size(230, 23);
			this.deleteLootPool.TabIndex = 2;
			this.deleteLootPool.Text = "Delete";
			this.deleteLootPool.UseVisualStyleBackColor = true;
			// 
			// LootEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 515);
			this.Controls.Add(this.tabControl1);
			this.Name = "LootEditor";
			this.Text = "LootEditor";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lootPoolContentsDataView)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView lootPoolContentsDataView;
		private System.Windows.Forms.ListBox lootPoolListbox;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemChance;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button deleteLootPool;
		private System.Windows.Forms.Button createLootPool;
	}
}