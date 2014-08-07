using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProjectSWGScriptEditor.Editors
{
	public partial class BonusSetEditor : Form
	{
		public BonusSetEditor(string scriptPath)
		{
			InitializeComponent();
			scriptPathLbl.Text = scriptPath;
			loadScriptIntoForm();
			if (!this.IsDisposed) this.Show();
		}

		private void loadScriptIntoForm()
		{
			scriptTreeView.Nodes.Clear();
			string[] file = File.ReadAllLines(scriptPathLbl.Text);

			TreeNode bonusSetNameNode = scriptTreeView.Nodes.Add("Set Name: ");
			TreeNode requiredItemsNode = scriptTreeView.Nodes.Add("Required Items");
			TreeNode bonusesNode = scriptTreeView.Nodes.Add("Bonuses");
			try
			{
				for (int i = 0; i < file.Length; i++)
				{
					if (file[i].Contains("bonusSet = BonusSetTemplate"))
					{
						bonusSetNameNode.Text = "Set Name: " + file[i].Split('"')[1];
					}
					else if (file[i].Contains("bonusSet.addRequiredItem"))
					{
						requiredItemsNode.Nodes.Add(file[i].Split('"')[1]);
					}
					else if (file[i].Contains("if wornItems == "))
					{
						string requiredItemCount = file[i].Split('=')[2];
						TreeNode bonusNode = bonusesNode.Nodes.Add(requiredItemCount);

						int temp = i + 1;
						while (!(file[temp].Contains("elif wornItems == ") || file[temp].Contains("else:")))
						{
							bonusNode.Nodes.Add(file[temp]);
							temp++;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("The editor has encountered an error while trying to parse the selected script.");
				this.Close();
			}
		}

		private void addRequiredItemBtn_Click(object sender, EventArgs e)
		{
			List<String> file = File.ReadAllLines(scriptPathLbl.Text).ToList<String>();
			foreach (string line in file)
			{
				if (line.Contains("bonusSet.addRequiredItem"))
				{
					file.Insert(file.IndexOf(line) + 1, "\tbonusSet.addRequiredItem(\"" + objectTemplateTb.Text + "\")");
					File.WriteAllLines(scriptPathLbl.Text, file);
					loadScriptIntoForm();
					return;
				}
			}
		}
	}
}
