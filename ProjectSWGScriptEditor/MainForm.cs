using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProjectSWGScriptEditor
{
	public partial class MainForm : Form
	{
		static String scriptsDirectory = "./";
		static String clientdataDirectory = "./";

		public MainForm()
		{
			if (!Config.containsKey("scriptsDirectory")) Config.setValue("scriptsDirectory", scriptsDirectory);
			else scriptsDirectory = Config.returnValue("scriptsDirectory");

			if (!Config.containsKey("clientdataDirectory")) Config.setValue("clientdataDirectory", scriptsDirectory);
			else clientdataDirectory = Config.returnValue("clientdataDirectory");

			InitializeComponent();
			loadContentToTreeView();
		}

		private void loadContentToTreeView()
		{
			string[] directories = Directory.GetDirectories(scriptsDirectory);
			string[] files = Directory.GetFiles(scriptsDirectory);

			for (int i = 0; i < directories.Length; i++) treeView1.Nodes.Add(directories[i].Replace(scriptsDirectory, ""));
			for (int i = 0; i < files.Length; i++) treeView1.Nodes.Add(files[i].Replace(scriptsDirectory, ""));
		}

		private void setScriptPathToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog dialog = new FolderBrowserDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK) scriptsDirectory = dialog.SelectedPath;
			}
			Config.setValue("scriptsDirectory", scriptsDirectory);

			treeView1.Nodes.Clear();
			loadContentToTreeView();
		}

		private void setClientdataPathToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog dialog = new FolderBrowserDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK) clientdataDirectory = dialog.SelectedPath;
			}
			Config.setValue("clientdataDirectory", clientdataDirectory);
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string directory = scriptsDirectory + getNodeFilePath(treeView1.SelectedNode);
			string childDirectory = getNodeFilePath(treeView1.SelectedNode);

			Console.WriteLine(childDirectory);

			if (!treeView1.SelectedNode.Text.EndsWith(".py"))
			{
				string[] directories = Directory.GetDirectories(directory);
				string[] files = Directory.GetFiles(directory);

				treeView1.SelectedNode.Nodes.Clear();

				for (int i = 0; i < directories.Length; i++) treeView1.SelectedNode.Nodes.Add(directories[i].Replace(directory, ""));
				for (int i = 0; i < files.Length; i++) treeView1.SelectedNode.Nodes.Add(files[i].Replace(directory, ""));

				if (childDirectory.Equals(@"\loot"))
				{
					editorNameLbl.Text = "Loot Editor";

					Editors.LootEditor editor = new Editors.LootEditor(directory);
				}
			}
			else if (treeView1.SelectedNode.Text.EndsWith(".py"))
			{
				scriptViewerTb.Text = File.ReadAllText(directory);

				if (childDirectory.StartsWith(@"\equipment\bonus_sets\"))
				{
					editorNameLbl.Text = "Bonus Set Editor";

					Editors.BonusSetEditor editor = new Editors.BonusSetEditor(directory);
				}
				else if (childDirectory == "")
				{
					
				}
				else editorNameLbl.Text = "Unknown script type";
			}
		}

		private string getNodeFilePath(TreeNode node)
		{
			if(node.Parent == null) return node.Text;
			return getNodeFilePath(node.Parent) + node.Text;
		}
	}
}
