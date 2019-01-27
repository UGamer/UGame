using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using CefSharp;
using CefSharp.WinForms;

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
                IconAssign();
            }
            catch (FileNotFoundException e) { }

            try
            {
                File.Delete("Resources/Theme/logoUSING.png");
                File.Delete("Resources/Theme/backgroundImageUSING.png");
            }
            catch (FileNotFoundException e) { }

            try
            {
                File.Copy("Resources/Theme/backgroundImage.png", "Resources/Theme/backgroundImageUSING.png");
                this.BackgroundImage = ThemeAssign("backgroundImageUSING");
                File.Delete("Resources/Theme/backgroundImage.png");
            }
            catch (FileNotFoundException e)
            {
                try
                {
                    File.Copy("Resources/Theme/backgroundImage.jpg", "Resources/Theme/backgroundImageUSING.png");
                    this.BackgroundImage = ThemeAssign("backgroundImageUSING");
                    File.Delete("Resources/Theme/backgroundImage.jpg");
                }
                catch (FileNotFoundException f)
                {
                    try
                    {
                        File.Copy("Resources/Theme/backgroundImage.jpeg", "Resources/Theme/backgroundImageUSING.png");
                        this.BackgroundImage = ThemeAssign("backgroundImageUSING");
                        File.Delete("Resources/Theme/backgroundImage.jpeg");
                    }
                    catch (FileNotFoundException g)
                    {
                        try
                        {
                            File.Copy("Resources/Theme/backgroundImage.gif", "Resources/Theme/backgroundImageUSING.png");
                            this.BackgroundImage = ThemeAssign("backgroundImageUSING");
                            File.Delete("Resources/Theme/backgroundImage.gif");
                        }
                        catch (FileNotFoundException h) { }
                    }
                }
            }

            try
            {
                File.Copy("Resources/Theme/logo.png", "Resources/Theme/logoUSING.png");
                logo.BackgroundImage = ThemeAssign("logoUSING");
                File.Delete("Resources/Theme/logo.png");
            }
            catch (FileNotFoundException e)
            {
                try
                {
                    File.Copy("Resources/Theme/logo.jpg", "Resources/Theme/logoUSING.png");
                    logo.BackgroundImage = ThemeAssign("logoUSING");
                    File.Delete("Resources/Theme/logo.jpg");
                }
                catch (FileNotFoundException f)
                {
                    try
                    {
                        File.Copy("Resources/Theme/logo.jpeg", "Resources/Theme/logoUSING.png");
                        logo.BackgroundImage = ThemeAssign("logoUSING");
                        File.Delete("Resources/Theme/logo.jpeg");
                    }
                    catch (FileNotFoundException g)
                    {
                        try
                        {
                            File.Copy("Resources/Theme/logo.gif", "Resources/Theme/logoUSING.png");
                            logo.BackgroundImage = ThemeAssign("logoUSING");
                            File.Delete("Resources/Theme/logo.gif");
                        }
                        catch (FileNotFoundException h)
                        {
                        }
                    }
                }
            }
        }

        // This fills the data table with the user data.
        private void Form1_Load(object sender, EventArgs e) 
        {
            // TODO: This line of code loads data into the 'collectionDataSet5.Themes' table. You can move, or remove it, as needed.
            try
            {
                this.table1TableAdapter2.Fill(this.collectionDataSet4.Table1);
            }
            // This is caught if you don't have the required OLE DB drivers.
            catch (InvalidOperationException d)
            {
                dataTable.Visible = false;
                driverWarning.Visible = true;
                Uri installURL = new Uri("https://www.microsoft.com/en-us/download/confirmation.aspx?id=23734");
                driverInstall.Url = installURL;
                searchBox.Visible = false;
                gameCountText.Visible = false;
                addEntryButton.Visible = false;
                for (bool installed = false; installed == false;)
                {
                    try
                    {
                        this.table1TableAdapter2.Fill(this.collectionDataSet4.Table1);
                        installed = true;
                    }
                    catch (InvalidOperationException f)
                    {

                    }
                }
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                this.Close();
            }
            int entryCount = dataTable.Rows.Count;
            if (entryCount != 1)
                gameCountText.Text = Convert.ToString(entryCount) + " total games";
            else
                gameCountText.Text = Convert.ToString(entryCount) + " total game";

            DataTable dt = collectionDataSet4.Table1;
            AutoCompleteStringCollection autoFill = new AutoCompleteStringCollection();
            int columnIndex = 1; // Name column
            string[] table = new string[dt.Rows.Count];
            int index = 0;
            for (index = 0; index < dt.Rows.Count; index++)
            {
                table[index] = dt.Rows[index][columnIndex].ToString();
                autoFill.Add(table[index]);
            }
            searchBox.AutoCompleteCustomSource = autoFill;

            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
        }

        private void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string titleValue;
            try
            {
                object value = dataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                titleValue = value.ToString();
                dataScan(titleValue);
            }
            catch (ArgumentOutOfRangeException f) { }
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            bool refresh = false;
            AddGame addGame = new AddGame(this, refresh);
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
            DataTable dt = collectionDataSet4.Table1;
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
                string newsString = dt.Rows[z][11].ToString();
                string wikiString = dt.Rows[z][12].ToString();

                if (launchString.IndexOf("\\") != -1)
                    launchString = pathFix.Replace(launchString, "/"); // This fixes .exe links automatically.

                bool exePath = isExe(launchString);
                bool batPath = isBat(launchString);

                gameWindow.Text = input;
                gameWindow.Show();
                gameWindow.DisplayInfo(input, input2, platform, status, rating,
                    hours, obtained, startDate, endDate, notes, launchString, exePath, batPath,
                    newsString, wikiString);
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

        private static bool isBat(string p)
        {
            if (p.IndexOf(".bat") == -1)
                return false;
            else
                return true;
        }

        public Image ThemeAssign(string input2)
        {
            Image background;
            try
            {
                background = Image.FromFile("Resources/Theme/" + input2 + ".png");
                return background;
            }
            catch (FileNotFoundException e)
            {
                try
                {
                    background = Image.FromFile("Resources/Theme/" + input2 + ".jpg");
                    return background;
                }
                catch (FileNotFoundException f)
                {
                    try
                    {
                        background = Image.FromFile("Resources/Theme/" + input2 + ".jpeg");
                        return background;
                    }
                    catch (FileNotFoundException g)
                    {
                        try
                        {
                            background = Image.FromFile("Resources/Theme/" + input2 + ".gif");
                            return background;
                        }
                        catch (FileNotFoundException h)
                        {
                            return background = Image.FromFile("Resources/DONT TOUCH.png");
                        }
                    }
                }
            }
        }

        public void IconAssign()
        {
            Icon windowIcon;
            try
            {
                windowIcon = new Icon("Resources/Theme/icon.ico");
                this.Icon = windowIcon;
            }
            catch (FileNotFoundException e)
            {

            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.Show();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            // this.table1TableAdapter1.Fill(this.collectionDataSet4.Table1);
            Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void changeTheme_Click(object sender, EventArgs e)
        {

        }

        public Icon IconAssign(string input2)
        {
            Icon windowIcon;
            try
            {
                windowIcon = new Icon("Resources/Theme/" + input2 + ".ico");
                return windowIcon;
            }
            catch (FileNotFoundException e)
            {
                windowIcon = new Icon("Resources/Theme/icon.ico");
                return windowIcon;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.Copy("Resources/Theme/backgroundImageUSING.png", "Resources/Theme/backgroundImage.png");
                File.Copy("Resources/Theme/logoUSING.png", "Resources/Theme/logo.png");
            }
            catch
            {

            }
        }
    }
}
