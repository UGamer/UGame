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
            string input = "";
            int y = 0, z = 0;

            DataTable dt = frm1.collectionDataSetFinal.Tables[0];
            int columnIndex = 0; // Name column
            string[] table = new string[dt.Rows.Count];
            int index = 0;
            for (index = 0; index < dt.Rows.Count; index++)
            {
                table[index] = dt.Rows[index][columnIndex].ToString();
            }
            input = textBox1.Text;
            for (int x = 0; x < dt.Rows.Count; x++)
                if (input == table[x])
                {
                    z = x;
                    y = 1;
                }

            GameDetails gameWindow = new GameDetails();
            if (y == 1)
            {
                string platform = dt.Rows[z][1].ToString();
                string status = dt.Rows[z][2].ToString();
                string rating = dt.Rows[z][3].ToString();
                string hours = dt.Rows[z][4].ToString();
                string obtained = dt.Rows[z][5].ToString();
                string startDate = dt.Rows[z][6].ToString();
                string endDate = dt.Rows[z][7].ToString();
                string notes = dt.Rows[z][8].ToString();
                string launchString = dt.Rows[z][9].ToString();
                Uri launch;
                if (launchString != "")
                    launch = new Uri(launchString);
                else
                    launch = new Uri("https://ugamer.github.io/");
                        
                gameWindow.Text = input;
                gameWindow.Show();
                gameWindow.DisplayInfo(input, platform, status, rating,
                    hours, obtained, startDate, endDate, notes, launch);
                label2.Visible = false;
                y = 0;
            }
            else
                label2.Visible = true;
        }
    }
}
