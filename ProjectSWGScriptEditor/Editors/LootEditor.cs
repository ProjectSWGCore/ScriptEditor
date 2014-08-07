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
	public partial class LootEditor : Form
	{
		string scriptPath;
		bool ready = false;

		public LootEditor(string scriptPath)
		{
			InitializeComponent();
			this.scriptPath = scriptPath;

			loadScriptIntoForm();

			if (!this.IsDisposed) this.Show();
			this.Activate();
		}

		private void loadScriptIntoForm()
		{
			string[] files = Directory.GetFiles(scriptPath + "/lootPools");

			for (int i = 0; i < files.Length; i++)
			{
				lootPoolListbox.Items.Add(Path.GetFileNameWithoutExtension(files[i]));
			}
		}

		private void parseLootGroup(string filepath)
		{
			lootPoolContentsDataView.Rows.Clear();

			try
			{
				string[] file = File.ReadAllLines(filepath);

				for (int i = 0; i < file.Length; i++)
				{
					string line = file[i].TrimStart();

					if (line.Contains("itemNames()"))
					{
						line = file[i + 1];
						line = line.Replace("return [", "");
						line = line.Replace("]", "");
						line = line.Replace("'", "");

						string[] lineContents = line.Split(',');

						for (int a = 0; a < lineContents.Length; a++)
						{
							lootPoolContentsDataView.Rows.Add(lineContents[a]);
						}
					}

					if (line.Contains("itemChances()"))
					{
						line = file[i + 1];
						line = line.Replace("return [", "");
						line = line.Replace("]", "");

						string[] lineContents = line.Split(',');

						for (int a = 0; a < lineContents.Length; a++)
						{
							lootPoolContentsDataView.Rows[a].Cells[1].Value = lineContents[a];
						}
					}
				}

				int totalChance = 0;
				for (int i = 0; i < lootPoolContentsDataView.Rows.Count - 1; i++)
				{
					totalChance += Int32.Parse((string) lootPoolContentsDataView.Rows[i].Cells[1].Value);
				}

				ready = true;
				//lootPoolContentsDataView.Rows.Add("Total Items: " + (lootPoolContentsDataView.Rows.Count - 1), "Total Chance: " + totalChance);
			}
			catch (Exception ex)
			{
				MessageBox.Show("The editor has encountered an error while trying to parse the selected loot pool.");
			}
		}

		public void saveLootGroupData()
		{
			string filePath = scriptPath + "/lootPools/" + lootPoolListbox.Text + ".py";
			StringBuilder sbuilder = new StringBuilder();

			sbuilder.AppendLine("def itemNames():");
			sbuilder.Append("\treturn [");
			for (int i = 0; i < lootPoolContentsDataView.Rows.Count - 1; i++)
			{
				if (lootPoolContentsDataView.Rows[i].Cells[0].Value == null) continue;

				sbuilder.Append("'" + ((String)lootPoolContentsDataView.Rows[i].Cells[0].Value).TrimStart() + "'");
				if (i < lootPoolContentsDataView.Rows.Count - 2) sbuilder.Append(",");
			}
			sbuilder.Append("]");

			sbuilder.AppendLine();

			sbuilder.AppendLine("def itemChances():");
			sbuilder.Append("\treturn [");
			for (int i = 0; i < lootPoolContentsDataView.Rows.Count - 1; i++)
			{
				if (lootPoolContentsDataView.Rows[i].Cells[1].Value == null) continue;

				sbuilder.Append(((String)lootPoolContentsDataView.Rows[i].Cells[1].Value).TrimStart());
				if (i < lootPoolContentsDataView.Rows.Count - 2) sbuilder.Append(",");
			}
			sbuilder.Append("]");

			Console.WriteLine(filePath);
			File.WriteAllText(filePath, sbuilder.ToString());
		}

		private void lootPoolListbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ready = false;
			parseLootGroup(scriptPath + "/lootPools/" + lootPoolListbox.Text + ".py");
		}

		private void lootPoolContentsDataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(ready) saveLootGroupData();
		}

		private void lootPoolContentsDataView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			if (ready) saveLootGroupData();
		}

		private void createLootPool_Click(object sender, EventArgs e)
		{

		}
	}
}
