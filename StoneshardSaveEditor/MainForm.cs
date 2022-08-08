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
        public MainForm()
        {
            InitializeComponent();
            saveFolderTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\StoneShard";
        }

        private void readAllSavesButton_Click(object sender, EventArgs e)
        {
            var characterData = new CharacterData() { Name = "a" };
            bindingSource1.DataSource = characterData;
            
            var charactersFolder = saveFolderTextBox.Text + @"\characters_v1";
            if (Directory.Exists(charactersFolder))
            {
                buildTree(charactersFolder);
                treeView1.ExpandAll();
                charDataGroupBox.Enabled = true;
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

        private void buildTree(string rootSavesFolder)
        {
            treeView1.Nodes.Clear();
            foreach (var allSavesForOneCharDir in Directory.EnumerateDirectories(rootSavesFolder).Reverse())
            {
                var charMapJson = Utils.ReadJson(allSavesForOneCharDir + @"\character.map");
                var charName = charMapJson.Value<string>("nameKey");
                var parent = new TreeNode(Path.GetFileName(allSavesForOneCharDir) + " " + charName);
                parent.ForeColor = Color.Gray;

                foreach (var oneSaveDir in Directory.EnumerateDirectories(allSavesForOneCharDir))
                {
                    FileInfo fileInfo = new FileInfo(oneSaveDir);
                    var saveMapJson = Utils.ReadJson(oneSaveDir + @"\save.map");
                    var dateTimeString = saveMapJson.Value<string>("dateTime");
                    var dateAsDouble = double.Parse(dateTimeString, NumberFormatInfo.InvariantInfo);
                    var oneSaveNode = new TreeNode(fileInfo.Name + " " + DateTime.FromOADate(dateAsDouble).ToLocalTime());
                    oneSaveNode.Tag = oneSaveDir;
                    parent.Nodes.Add(oneSaveNode);
                }
                
                treeView1.Nodes.Add(parent);
            }
        }

    }
}