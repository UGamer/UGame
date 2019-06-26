using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public partial class Notes : Form
    {
        private string titleFriendly;

        public Notes(string titleFriendly)
        {
            this.titleFriendly = titleFriendly;
            InitializeComponent();
            LockButton.BackgroundImage = Image.FromFile("Resources\\Theme\\Unlock.png");
            InitializeDesign();
        }

        private void InitializeDesign()
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            /*
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(FileDialog.SelectedPath + "\\test.txt");
                tw.WriteLine(NotepadArea.Text);
                tw.Close();
                // File.WriteAllText(filename, logfiletextbox.Text);
                MessageBox.Show("Saved to " + FileDialog.SelectedPath, "Saved Log File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */

            SavePanel.Visible = true;
        }

        private void ConfirmSaveButton_Click(object sender, EventArgs e)
        {
            SavePanel.Visible = false;

            string folderPath = "Notes\\" + titleFriendly + "\\";
            string fileName = SaveFileNameBox.Text + ".txt";

            try
            {
                TextWriter tw = new StreamWriter(folderPath + fileName);
                tw.WriteLine(NotepadArea.Text);
                tw.Close();
                // File.WriteAllText(filename, logfiletextbox.Text);
                MessageBox.Show("Saved to \"" + folderPath, "\".", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Directory.CreateDirectory("Notes\\" + titleFriendly);
                TextWriter tw = new StreamWriter(folderPath + fileName);
                tw.WriteLine(NotepadArea.Text);
                tw.Close();
                // File.WriteAllText(filename, logfiletextbox.Text);
                MessageBox.Show("Saved to \"" + folderPath, "\".", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (LoadFileDialog.ShowDialog() == DialogResult.OK)
            {
                NotepadArea.Text = File.ReadAllText(LoadFileDialog.FileName, Encoding.UTF8);
            }

            // Figures out where to start
            int indexOfPath = LoadFileDialog.FileName.IndexOf(titleFriendly + "\\");
            string fileDialogCopy = LoadFileDialog.FileName;
            fileDialogCopy = fileDialogCopy.Substring(indexOfPath);
            int indexOfName = fileDialogCopy.IndexOf("\\");


            // 
            indexOfName += indexOfPath + 1;
            string loadedFile = LoadFileDialog.FileName.Substring(indexOfName);
            loadedFile = loadedFile.Substring(0, loadedFile.Length - 4);

            SaveFileNameBox.Text = loadedFile;
        }

        public bool locked = false;

        private void LockButton_Click(object sender, EventArgs e)
        {
            if (locked == false)
            {
                locked = true;
                LockButton.BackgroundImage = Image.FromFile("Resources\\Theme\\Lock.png");
            }
            else
            {
                locked = false;
                LockButton.BackgroundImage = Image.FromFile("Resources\\Theme\\Unlock.png");
            }
        }

        private void OpacityBar_ValueChanged(object sender, EventArgs e)
        {
            double opacityValue = Convert.ToDouble(OpacityBar.Value);
            opacityValue /= 100;
            this.Opacity = opacityValue;
        }
    }
}
