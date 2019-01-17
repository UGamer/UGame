using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace The_UGamer_Launcher
{
    public partial class DetailSelect : Form
    {
        public Form1 frm1;
        public DetailSelect(Form1 parent)
        {
            InitializeComponent();
            frm1 = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = "", input2 = "";
            int y = 0, z = 0;

            DataTable dt = frm1.collectionDataSet.Tables[0];
            int columnIndex = 2; // Name column
            string[] table = new string[dt.Rows.Count];
            int index = 0;
            for (index = 0; index < dt.Rows.Count; index++)
            {
                table[index] = dt.Rows[index][columnIndex].ToString();
            }
            Regex rgx = new Regex(" ");
            input = textBox1.Text;
            input2 = rgx.Replace(input, "");
            for (int x = 0; x < dt.Rows.Count; x++)
                if (input == table[x])
                {
                    z = x;
                    y = 1;
                }

            GameDetails gameWindow = new GameDetails();
            if (y == 1)
            {
                string platform = dt.Rows[z][3].ToString();
                gameWindow.Show();
                gameWindow.DisplayInfo(input, input2, platform);
                label2.Visible = false;
                y = 0;
            }
            else
                label2.Visible = true;
        }
    }
}
