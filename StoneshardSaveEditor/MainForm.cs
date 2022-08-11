using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StoneshardSaveEditor
{
    public partial class MainForm : Form
    {
        private SaveEditor _saveEditor;

        public MainForm()
        {
            InitializeComponent();
            saveFolderTextBox.Text = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "StoneShard");
        }

        private void readAllSavesButton_Click(object sender, EventArgs e)
        {
            var charactersFolder = Path.Combine(saveFolderTextBox.Text, "characters_v1");
            if (Directory.Exists(charactersFolder))
            {
                BuildTree(charactersFolder);
                treeView1.ExpandAll();
            }
            else
            {
                MessageBox.Show("This folder does not contain Stoneshard saves (characters_v1 subfolder)");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                saveFolderTextBox.Text = dataFolderBrowser.SelectedPath;
            }
        }

        private void BuildTree(string rootSavesFolder)
        {
            treeView1.Nodes.Clear();
            foreach (var allSavesForOneCharDir in Directory.EnumerateDirectories(rootSavesFolder).Reverse())
            {
                var charMapJson = Utils.ReadJson(Path.Combine(allSavesForOneCharDir, "character.map"));
                var charName = charMapJson.Value<string>("nameKey");
                var parent = new TreeNode(Path.GetFileName(allSavesForOneCharDir) + " " + charName);
                parent.ForeColor = Color.Gray;

                foreach (var oneSaveDir in Directory.EnumerateDirectories(allSavesForOneCharDir))
                {
                    FileInfo fileInfo = new FileInfo(oneSaveDir);
                    var saveMapJson = Utils.ReadJson(Path.Combine(oneSaveDir, "save.map"));
                    var dateTimeString = saveMapJson.Value<string>("dateTime");
                    var dateAsDouble = double.Parse(dateTimeString, NumberFormatInfo.InvariantInfo);
                    var oneSaveNode = new TreeNode(fileInfo.Name + " " + DateTime.FromOADate(dateAsDouble).ToLocalTime());
                    oneSaveNode.Tag = oneSaveDir;
                    parent.Nodes.Add(oneSaveNode);
                }

                treeView1.Nodes.Add(parent);
            }
        }

        private void removeAbilityButton_Click(object sender, EventArgs e)
        {
            _saveEditor.Character.Abilities.RemoveAt(abilityListBox.SelectedIndex);
            EnableSaveButton(sender, e);
        }

        private void abilityListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            removeAbilityButton.Enabled = (abilityListBox.SelectedValue != null);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                charDataGroupBox.Enabled = false;
                return;
            }

            var oneSaveDir = (string)e.Node.Tag;
            _saveEditor = new SaveEditor(Path.Combine(oneSaveDir, "data.sav"));
            charDataGroupBox.Enabled = true;
            characterDataBindingSource.DataSource = _saveEditor.Character;
            abilityListBox.DataSource = _saveEditor.Character.Abilities;
            abilityListBox.ClearSelected();
            saveButton.Enabled = false;
        }

        private void EnableSaveButton(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _saveEditor.Save();
            MessageBox.Show("Save file updated" + Environment.NewLine + 
                            Environment.NewLine + "Backup file: " + _saveEditor.BackupFilePath,
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            saveButton.Enabled = false;
        }
    }
}