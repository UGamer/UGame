using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace The_UGamer_Launcher
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
            InitializeDesign();
        }

        private void InitializeDesign()
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(FileDialog.SelectedPath + "\\test.txt");
                tw.WriteLine(NotepadArea.Text);
                tw.Close();
                // File.WriteAllText(filename, logfiletextbox.Text);
                MessageBox.Show("Saved to " + FileDialog.SelectedPath, "Saved Log File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
