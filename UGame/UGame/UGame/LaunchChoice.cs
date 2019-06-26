using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public partial class LaunchChoice : Form
    {
        public int index = 0;

        public LaunchChoice(string[,] launchTable, int launchCount)
        {
            InitializeComponent();

            for (int index = 0; index < launchCount; index++)
                LaunchBox.Items.Add("[" + index + "] " + launchTable[index, 0]);
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;

            index = Convert.ToInt32(LaunchBox.Text.Substring(1, LaunchBox.Text.IndexOf("]") - 1));

            this.Close();
        }
    }
}
