using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_UGamer_Launcher
{
    public partial class GameDetails : Form
    {
        public GameDetails()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        public void DisplayInfo(string input1, string input2)
        {
            pictureBox1.BackgroundImage = Image.FromFile("Resources/detail/" + input2 + ".png");
        }

    }
}
