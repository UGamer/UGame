using System;
using System.Data;
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
            frm1 = parent; // This passes along the database from Form1.
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataScan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataScan();
        }

        private void dataScan()
        {
            string input = "", input2 = "";
            int y = 0, z = 0;

            // This makes the whole database into an array.
            DataTable dt = frm1.collectionDataSetFinal.Tables[0];
            int columnIndex = 0; // Name column
            string[] table = new string[dt.Rows.Count];
            int index = 0;
            for (index = 0; index < dt.Rows.Count; index++)
            {
                table[index] = dt.Rows[index][columnIndex].ToString();
            }

            // This checks if the user input is actually an entry.
            input = textBox1.Text;
            input2 = input;
            Regex pathFix = new Regex(@"T:\\");

            // This section fixes the title so it can be translated to an image file.
            Regex rgxFix1 = new Regex("/");
            Regex rgxFix2 = new Regex(":");
            Regex rgxFix3 = new Regex(".*");
            Regex rgxFix4 = new Regex(".?");
            Regex rgxFix5 = new Regex("\"");
            Regex rgxFix6 = new Regex("<");
            Regex rgxFix7 = new Regex(">");
            Regex rgxFix8 = new Regex("|");

            if (input2.IndexOf("\\") != -1)
                input2 = pathFix.Replace(input, "/");
            if (input2.IndexOf("/") != -1)
                input2 = rgxFix1.Replace(input2, "");
            if (input2.IndexOf(":") != -1)
                input2 = rgxFix2.Replace(input2, "");
            if (input2.IndexOf("*") != -1)
                input2 = rgxFix3.Replace(input2, "");
            if (input2.IndexOf("?") != -1)
                input2 = rgxFix4.Replace(input2, "");
            if (input2.IndexOf("\"") != -1)
                input2 = rgxFix5.Replace(input2, "");
            if (input2.IndexOf("<") != -1)
                input2 = rgxFix6.Replace(input2, "");
            if (input2.IndexOf(">") != -1)
                input2 = rgxFix7.Replace(input2, "");
            if (input2.IndexOf("|") != -1)
                input2 = rgxFix8.Replace(input2, "");

            for (int x = 0; x < dt.Rows.Count; x++)
                if (input == table[x])
                {
                    z = x;
                    y = 1;
                }

            // This transfers all of the entry's data to the Game Details window.
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

                if (launchString.IndexOf("\\") != -1)
                    launchString = pathFix.Replace(input, "/"); // This fixes .exe links automatically.

                Uri launch;
                if (launchString != "")
                    launch = new Uri(launchString);
                else
                    launch = new Uri("https://ugamer.github.io/");

                gameWindow.Text = input;
                gameWindow.Show();
                gameWindow.DisplayInfo(input, input2, platform, status, rating,
                    hours, obtained, startDate, endDate, notes, launch);
                label2.Visible = false;
                y = 0;
            }
            // If the entry does not exist, an error message shows.
            else
                label2.Visible = true;
        }

        public void dataScan(String input)
        {
            string input2 = "";
            int y = 0, z = 0;

            // This makes the whole database into an array.
            DataTable dt = frm1.collectionDataSetFinal.Tables[0];
            int columnIndex = 0; // Name column
            string[] table = new string[dt.Rows.Count];
            int index = 0;
            for (index = 0; index < dt.Rows.Count; index++)
            {
                table[index] = dt.Rows[index][columnIndex].ToString();
            }

            // This checks if the user input is actually an entry.
            input2 = input;
            Regex pathFix = new Regex(@"T:\\");

            // This section fixes the title so it can be translated to an image file.
            Regex rgxFix1 = new Regex("/");
            Regex rgxFix2 = new Regex(":");
            Regex rgxFix3 = new Regex(".*");
            Regex rgxFix4 = new Regex(".?");
            Regex rgxFix5 = new Regex("\"");
            Regex rgxFix6 = new Regex("<");
            Regex rgxFix7 = new Regex(">");
            Regex rgxFix8 = new Regex("|");

            if (input2.IndexOf("\\") != -1)
                input2 = pathFix.Replace(input, "/");
            if (input2.IndexOf("/") != -1)
                input2 = rgxFix1.Replace(input2, "");
            if (input2.IndexOf(":") != -1)
                input2 = rgxFix2.Replace(input2, "");
            if (input2.IndexOf("*") != -1)
                input2 = rgxFix3.Replace(input2, "");
            if (input2.IndexOf("?") != -1)
                input2 = rgxFix4.Replace(input2, "");
            if (input2.IndexOf("\"") != -1)
                input2 = rgxFix5.Replace(input2, "");
            if (input2.IndexOf("<") != -1)
                input2 = rgxFix6.Replace(input2, "");
            if (input2.IndexOf(">") != -1)
                input2 = rgxFix7.Replace(input2, "");
            if (input2.IndexOf("|") != -1)
                input2 = rgxFix8.Replace(input2, "");

            for (int x = 0; x < dt.Rows.Count; x++)
                if (input == table[x])
                {
                    z = x;
                    y = 1;
                }

            // This transfers all of the entry's data to the Game Details window.
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

                if (launchString.IndexOf("\\") != -1)
                    launchString = pathFix.Replace(input, "/"); // This fixes .exe links automatically.

                Uri launch;
                if (launchString != "")
                    launch = new Uri(launchString);
                else
                    launch = new Uri("https://ugamer.github.io/");

                gameWindow.Text = input;
                gameWindow.Show();
                gameWindow.DisplayInfo(input, input2, platform, status, rating,
                    hours, obtained, startDate, endDate, notes, launch);
                label2.Visible = false;
                y = 0;
            }
            // If the entry does not exist, an error message shows.
            else
                label2.Visible = true;
        }
    }
}
