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
        private CharacterData _characterData;
        public MainForm()
        {
            InitializeComponent();
            saveFolderTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\StoneShard";
        }

        private void readAllSavesButton_Click(object sender, EventArgs e)
        {
            var charactersFolder = saveFolderTextBox.Text + @"\characters_v1";
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
            _characterData.Abilities.RemoveAt(abilityListBox.SelectedIndex);
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
            SaveEditor saveEditor = new SaveEditor(Path.Combine(oneSaveDir, "data.sav"));
            _characterData = saveEditor.ReadCharacter();
            charDataGroupBox.Enabled = true;
            characterDataBindingSource.DataSource = _characterData;
            abilityListBox.DataSource = _characterData.Abilities;
            abilityListBox.ClearSelected();
        }



    }
}