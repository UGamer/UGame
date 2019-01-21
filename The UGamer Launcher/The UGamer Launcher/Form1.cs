using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace The_UGamer_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Starts up the program.
            InitializeComponent();
            try
            {
                this.BackgroundImage = Image.FromFile("Resources/Theme/backgroundImage.png");
            }
            catch (FileNotFoundException e) { }

            try
            {
                logo.BackgroundImage = Image.FromFile("Resources/Theme/logo.png");
            }
            catch (FileNotFoundException e) { }
        }

        // This fills the data table with the user data.
        private void Form1_Load(object sender, EventArgs e) 
        {
            // TODO: This line of code loads data into the 'collectionDataSetFinal2.Table1' table. You can move, or remove it, as needed.
            try
            {
                this.table1TableAdapter.Fill(this.collectionDataSetFinal2.Table1);
            }
            // This is caught if you don't have the required OLE DB drivers.
            catch (InvalidOperationException d)
            {
                dataTable.Visible = false;
                driverWarning.Visible = true;
                Uri installURL = new Uri("https://www.microsoft.com/en-us/download/confirmation.aspx?id=23734");
                driverInstall.Url = installURL;
            }
            int entryCount = dataTable.Rows.Count;
            if (entryCount != 1)
                gameCountText.Text = Convert.ToString(entryCount) + " total games";
            else
                gameCountText.Text = Convert.ToString(entryCount) + " total game";
        }

        // Clicking the "Details" button opens a new details window.
        private void detailButton_Click_1(object sender, EventArgs e) 
        {
            DetailSelect detailSelect = new DetailSelect(this);
            detailSelect.Show();
        }

        private void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string titleValue;
            object value = dataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            titleValue = value.ToString();
            DetailSelect detailSelect = new DetailSelect(this);
            detailSelect.dataScan(titleValue);
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame(this);
            addGame.Show();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataScan(searchBox.Text);
        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            dataScan(searchBox.Text);
        }

        public void dataScan(String input)
        {
            string input2 = "";
            int y = 0, z = 0;

            // This makes the whole database into an array.
            DataTable dt = collectionDataSetFinal2.Table1;
            int columnIndex = 1; // Name column
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
                string platform = dt.Rows[z][2].ToString();
                string status = dt.Rows[z][3].ToString();
                string rating = dt.Rows[z][4].ToString();
                string hours = dt.Rows[z][5].ToString();
                string obtained = dt.Rows[z][6].ToString();
                string startDate = dt.Rows[z][7].ToString();
                string endDate = dt.Rows[z][8].ToString();
                string notes = dt.Rows[z][9].ToString();
                string launchString = dt.Rows[z][10].ToString();

                if (launchString.IndexOf("\\") != -1)
                    launchString = pathFix.Replace(launchString, "/"); // This fixes .exe links automatically.

                bool exePath = isExe(launchString);

                gameWindow.Text = input;
                gameWindow.Show();
                gameWindow.DisplayInfo(input, input2, platform, status, rating,
                    hours, obtained, startDate, endDate, notes, launchString, exePath);
                noGameLabel.Visible = false;
                y = 0;
            }
            // If the entry does not exist, an error message shows.
            else
                noGameLabel.Visible = true;
        }

        private static bool isExe(string p)
        {
            if (p.IndexOf(".exe") == -1)
                return false;
            else
                return true;
        }
    }
}
