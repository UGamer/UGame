using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public partial class MainForm : Form
    {
        public Config config;

        public List<GameTab> games = new List<GameTab>();
        public GameTab game;
        public WebBrowser BrowserLauncher = new WebBrowser();
        public int index = 0;
        int highestId;
        public string mdfPath;
        public static string connectionString;
        public static SQLiteConnection con;
        public SQLiteCommand selectCmd;
        public SQLiteCommand insertCmd;
        public DataTable gameTable;
        public DataTable consoleTable;

        int editedId = 0;
        int editedRow = 0;
        int rowIndex;
        int currentRow = 0;

        public string urlString = "";
        public string launchString = "";

        string imageTitle;
        public string resourcePath;

        public bool titleLocked = false;
        public bool platformLocked = false;

        public ImageList icons;

        public MainForm()
        {
            config = new Config();
            resourcePath = config.resourcePath;

            if (config.resourcePath == "")
            {
                config.resourcePath = "resources\\";

                if (!Directory.Exists("resources"))
                    Directory.CreateDirectory("resources");
                if (!Directory.Exists("resources\\details"))
                    Directory.CreateDirectory("resources\\details");
                if (!Directory.Exists("resources\\icons"))
                    Directory.CreateDirectory("resources\\icons");
                if (!Directory.Exists("resources\\bg"))
                    Directory.CreateDirectory("resources\\bg");
            }
            
            connectionString = "Data Source=" + config.databasePath + ";Version=3;";
            con = new SQLiteConnection(connectionString);
            selectCmd = new SQLiteCommand("SELECT * FROM Games", con);
            insertCmd = new SQLiteCommand("INSERT INTO Games ([Id], [Title], [Platform], [Status], [Rating], [TimePlayed], [Seconds], [Obtained], [StartDate], [LastPlayed], [Notes], [URLs], [Filters], [Developers], [Publishers], [ReleaseDate], [Genre], [PlayerCount], [Price], [GameDesc], [Launch], [Blur], [Overlay], [Discord]) VALUES (@Id, @Title, @Platform, @Status, @Rating, @TimePlayed, @Seconds, @Obtained, @StartDate, @LastPlayed, @Notes, @URLs, @Filters, @Developers, @Publishers, @ReleaseDate, @Genre, @PlayerCount, @Price, @GameDesc, @Launch, @Blur, @Overlay, @Discord);", con);
            con.Open();

            InitializeComponent();
            InitializeTheme();
            FillDGV();

            try { ConsolesDGV.Sort(ConsolesDGV.Columns["Name"], ListSortDirection.Ascending); } catch { }

            FillConsole(ConsolesDGV.Rows[0].Cells["Name"].Value.ToString());

            GamesDGV.Focus();
        }

        private void InitializeTheme()
        {
            RefreshButton.Image = Image.FromFile(resourcePath + "refresh.png");

            LockTitleButton.BackgroundImage = Image.FromFile(resourcePath + "Unlock.png");
            LockPlatformButton.BackgroundImage = Image.FromFile(resourcePath + "Unlock.png");
        }

        private void FillDGV()
        {
            // This block of code constructs the dataTable and fills it.
            selectCmd.CommandType = CommandType.Text;
            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            gameTable = new DataTable();
            gameTable.Columns.Add(" ", typeof(Image));
            da.Fill(gameTable);
            
            GamesDGV.DataSource = gameTable;
            GamesListTab.Text = "[LIST] " + gameTable.Rows.Count + "/" + gameTable.Rows.Count;

            // This for loop assigns icons to each row in the DGV, and checks if any date value is
            // equal to "1/1/1753" and if any price value is equal to -1. If true, the value is hidden.
            // (WIP)
            for (int index = 0; index < gameTable.Rows.Count; index++)
            {
                imageTitle = gameTable.Rows[index]["Title"].ToString();
                Regex rgxFix1 = new Regex("/");
                Regex rgxFix2 = new Regex(":");
                Regex rgxFix3 = new Regex(".*");
                Regex rgxFix4 = new Regex(".?");
                Regex rgxFix5 = new Regex("\"");
                Regex rgxFix6 = new Regex("<");
                Regex rgxFix7 = new Regex(">");
                Regex rgxFix8 = new Regex("|");
                Regex rgxFix9 = new Regex(@"T:\\");

                while (imageTitle.IndexOf("/") != -1)
                    imageTitle = rgxFix1.Replace(imageTitle, "");
                while (imageTitle.IndexOf(":") != -1)
                    imageTitle = rgxFix2.Replace(imageTitle, "");
                while (imageTitle.IndexOf("*") != -1)
                    imageTitle = rgxFix3.Replace(imageTitle, "");
                while (imageTitle.IndexOf("?") != -1)
                    imageTitle = rgxFix4.Replace(imageTitle, "");
                while (imageTitle.IndexOf("\"") != -1)
                    imageTitle = rgxFix5.Replace(imageTitle, "");
                while (imageTitle.IndexOf("<") != -1)
                    imageTitle = rgxFix6.Replace(imageTitle, "");
                while (imageTitle.IndexOf(">") != -1)
                    imageTitle = rgxFix7.Replace(imageTitle, "");
                while (imageTitle.IndexOf("|") != -1)
                    imageTitle = rgxFix8.Replace(imageTitle, "");
                while (imageTitle.IndexOf("\\") != -1)
                    imageTitle = rgxFix9.Replace(imageTitle, "");
                
                try
                {
                    try { GamesDGV.Rows[index].Cells[0].Value = Image.FromFile(config.resourcePath + "icons\\" + imageTitle + ".png"); }
                    catch { try { GamesDGV.Rows[index].Cells[0].Value = Image.FromFile(config.resourcePath + "icons\\" + imageTitle + ".jpg"); }
                    catch { try { GamesDGV.Rows[index].Cells[0].Value = Image.FromFile(config.resourcePath + "icons\\" + imageTitle + ".jpeg"); }
                    catch { try { GamesDGV.Rows[index].Cells[0].Value = Image.FromFile(config.resourcePath + "icons\\" + imageTitle + ".jfif"); }
                    catch { try { GamesDGV.Rows[index].Cells[0].Value = Image.FromFile(config.resourcePath + "icons\\" + imageTitle + ".gif"); }
                    catch { GamesDGV.Rows[index].Cells[0].Value = Image.FromFile(config.resourcePath + "unknown.png"); } } } } }
                }
                catch { }
                
                // This code prevents editing entries with any date that has 1/1/1753. Need to find another way.
                try
                {
                    if (Convert.ToDateTime(GamesDGV.Rows[index].Cells["Obtained"].Value) == new DateTime(1753, 1, 1))
                        GamesDGV.Rows[index].Cells["Obtained"].Value = "";

                    if (Convert.ToDateTime(GamesDGV.Rows[index].Cells["StartDate"].Value) == new DateTime(1753, 1, 1))
                        GamesDGV.Rows[index].Cells["StartDate"].Value = "";

                    if (Convert.ToDateTime(GamesDGV.Rows[index].Cells["LastPlayed"].Value) == new DateTime(1753, 1, 1))
                        GamesDGV.Rows[index].Cells["LastPlayed"].Value = "";
                }
                catch { }


                // Code works, but column doesn't sort properly. Same problem from UGame 1.0
                if (Convert.ToDecimal(GamesDGV.Rows[index].Cells["Price"].Value) == -1)
                    GamesDGV.Rows[index].Cells["Price"].Value = "";
                else if (Convert.ToDecimal(GamesDGV.Rows[index].Cells["Price"].Value) == 0)
                    GamesDGV.Rows[index].Cells["Price"].Value = "Free";

            }

            // This try-catch block configures the image layout for the column and autosize mode for the icon
            // column and title column.
            try
            {
                ((DataGridViewImageColumn)GamesDGV.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                GamesDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                GamesDGV.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch { }

            // This try-catch block hides fields in the DGV, and changes column header texts.
            try
            {
                GamesDGV.Columns["Id"].Visible = false;
                GamesDGV.Columns["Seconds"].Visible = false;
                GamesDGV.Columns["Notes"].Visible = false;
                GamesDGV.Columns["URLs"].Visible = false;
                GamesDGV.Columns["Filters"].Visible = false;
                GamesDGV.Columns["GameDesc"].Visible = false;
                GamesDGV.Columns["Launch"].Visible = false;
                GamesDGV.Columns["Blur"].Visible = false;
                GamesDGV.Columns["Overlay"].Visible = false;
                GamesDGV.Columns["Discord"].Visible = false;

                GamesDGV.Columns["TimePlayed"].HeaderText = "Time Played";
                GamesDGV.Columns["StartDate"].HeaderText = "Start Date";
                GamesDGV.Columns["LastPlayed"].HeaderText = "Last Played";
                GamesDGV.Columns["ReleaseDate"].HeaderText = "Release Date";
                GamesDGV.Columns["PlayerCount"].HeaderText = "Player Count";
            }
            catch { }

            /*
            icons = new ImageList();

            ImageConverter imgConverter = new ImageConverter();
            for (int index = 0; index < GamesDGV.Rows.Count; index++)
            {
                object obj = GamesDGV.Rows[index].Cells[0].Value;
                imgConverter.ConvertFrom(jeff);
                icons.Images.Add(obj);
            }
            */

            try { GamesDGV.Sort(GamesDGV.Columns["Title"], ListSortDirection.Ascending); } catch { }

            // The code from hereon deals with filling the Consoles DGV
            consoleTable = new DataTable();

            consoleTable.Columns.Add("Name");

            DataRow dRow;
            ArrayList consolesAdded = new ArrayList();
            bool newConsole = true;
            string platform;
            for (int index = 0; index < gameTable.Rows.Count; index++)
            {
                platform = gameTable.Rows[index]["Platform"].ToString();
                for (int consoleIndex = 0; consoleIndex < consolesAdded.Count; consoleIndex++)
                {
                    if (platform == consolesAdded[consoleIndex].ToString())
                    {
                        newConsole = false;
                        break;
                    }
                }
                if (newConsole)
                {
                    consolesAdded.Add(platform);

                    dRow = consoleTable.NewRow();

                    dRow["Name"] = platform;

                    consoleTable.Rows.Add(dRow);
                }

                newConsole = true;
            }

            ConsolesDGV.DataSource = consoleTable;
        }
        
        private void NewTab(int rowIndex)
        {
            int id = Convert.ToInt32(GamesDGV.Rows[rowIndex].Cells["Id"].Value);
            int index;
            bool make = true;
            for (index = 0; index < games.Count; index++)
            {
                if (games[index].id == id)
                {
                    make = false;
                    break;
                }
            }

            if (make)
            {
                game = new GameTab(this, rowIndex, GamesTabs.TabPages.Count, id);
                games.Add(game);
                GamesTabs.SelectedTab = game.gameTab;
            }
            else
            {
                GamesTabs.SelectedTab = games[index].gameTab;
            }
        }

        public void AddGameTab(TabPage gameTab)
        {
            GamesTabs.Controls.Add(gameTab);
            gameTab.Tag = GamesTabs.TabPages.Count - 3;
        }

        private void GamesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                NewTab(currentRow);
            }
        }

        private void GamesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;

            try { NewTab(e.RowIndex); } catch { }
        }

        private void GamesDGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    // this.GamesDGV.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;

                    if (GamesDGV.SelectedRows.Count <= 1)
                        GamesDGV.CurrentCell = GamesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    this.GamesDGVContextMenu.Show(this.GamesDGV, e.Location);
                    GamesDGVContextMenu.Show(Cursor.Position);
                }
            }
            catch { }
        }

        private void EditEntryButton_Click(object sender, EventArgs e)
        {
            EditEntry(rowIndex);
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < GamesDGV.SelectedRows.Count; index++)
            {
                Console.WriteLine(GamesDGV.SelectedRows[index].Cells["Title"].Value);

                int deletedId = Convert.ToInt32(GamesDGV.SelectedRows[index].Cells["Id"].Value);

                SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM Games WHERE Id = " + deletedId, con);
                deleteCommand.ExecuteNonQuery();
            }
            
            FillDGV();

            GamesListTab.Text = "[LIST] " + gameTable.Rows.Count + "/" + gameTable.Rows.Count;
        }

        private void GamesTabs_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.GameTabsContextMenu.Show(this.GamesTabs, e.Location);
                    GameTabsContextMenu.Show(Cursor.Position);
                }
            }
            catch { }
        }

        private void CloseTabButton_Click(object sender, EventArgs e)
        {
            if (GamesTabs.SelectedIndex != 0 && GamesTabs.SelectedIndex != 1)
            {
                GamesTabs.Controls.Remove(GamesTabs.SelectedTab);
            }
        }
        
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            FillDGV();
            try { GamesDGV.Sort(GamesDGV.Columns["Title"], ListSortDirection.Ascending); } catch { }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(gameTable);
            try { DV.RowFilter = string.Format("Title LIKE '%{0}%'", SearchBox.Text); }
            catch { }

            GamesDGV.DataSource = DV;
        }

        /// <summary>
        /// The next section of code deals with the consoles tab.
        /// </summary>

        private void FillConsole(string name)
        {
            try { ConsolePictureBox.BackgroundImage = Image.FromFile(config.resourcePath + "consoles\\" + name + ".png"); }
            catch { try {  ConsolePictureBox.BackgroundImage = Image.FromFile(config.resourcePath + "consoles\\" + name + ".jpg"); }
            catch { try {  ConsolePictureBox.BackgroundImage = Image.FromFile(config.resourcePath + "consoles\\" + name + ".jpeg"); }
            catch { try {  ConsolePictureBox.BackgroundImage = Image.FromFile(config.resourcePath + "consoles\\" + name + ".jfif"); }
            catch { try {  ConsolePictureBox.BackgroundImage = Image.FromFile(config.resourcePath + "consoles\\" + name + ".gif"); }
            catch {  ConsolePictureBox.BackgroundImage = Image.FromFile(config.resourcePath + "unknown.png"); } } } } }

            ConsoleNameBox.Text = name;

            DataView DV = new DataView(gameTable);
            try { DV.RowFilter = string.Format("Platform LIKE '%{0}%'", name); }
            catch { }

            ConsoleGamesDGV.DataSource = DV;

            try
            {
                ((DataGridViewImageColumn)ConsoleGamesDGV.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                ConsoleGamesDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ConsoleGamesDGV.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch { }

            try
            {
                ConsoleGamesDGV.Columns["Id"].Visible = false;
                ConsoleGamesDGV.Columns["Seconds"].Visible = false;
                ConsoleGamesDGV.Columns["Notes"].Visible = false;
                ConsoleGamesDGV.Columns["URLs"].Visible = false;
                ConsoleGamesDGV.Columns["Filters"].Visible = false;
                ConsoleGamesDGV.Columns["GameDesc"].Visible = false;
                ConsoleGamesDGV.Columns["Launch"].Visible = false;
                ConsoleGamesDGV.Columns["Blur"].Visible = false;
                ConsoleGamesDGV.Columns["Overlay"].Visible = false;
                ConsoleGamesDGV.Columns["Discord"].Visible = false;

                ConsoleGamesDGV.Columns["TimePlayed"].HeaderText = "Time Played";
                ConsoleGamesDGV.Columns["StartDate"].HeaderText = "Start Date";
                ConsoleGamesDGV.Columns["LastPlayed"].HeaderText = "Last Played";
                ConsoleGamesDGV.Columns["ReleaseDate"].HeaderText = "Release Date";
                ConsoleGamesDGV.Columns["PlayerCount"].HeaderText = "Player Count";
            }
            catch { }
            
            try { ConsoleGamesDGV.Sort(ConsoleGamesDGV.Columns["Title"], ListSortDirection.Ascending); } catch { }
        }

        private void ConsolesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { FillConsole(ConsolesDGV.Rows[e.RowIndex].Cells["Name"].Value.ToString()); } catch { }
        }

        private void NewConsoleGameTab(int rowIndex)
        {
            int id = Convert.ToInt32(ConsoleGamesDGV.Rows[rowIndex].Cells["Id"].Value);

            int index;
            for (index = 0; index < GamesDGV.Rows.Count; index++)
            {
                if (Convert.ToInt32(GamesDGV.Rows[index].Cells["Id"].Value) == id)
                {
                    rowIndex = index;
                    break;
                }
            }

            bool make = true;
            for (index = 0; index < games.Count; index++)
            {
                if (games[index].id == id)
                {
                    make = false;
                    break;
                }
            }

            if (make)
            {
                game = new GameTab(this, rowIndex, GamesTabs.TabPages.Count, id);
                games.Add(game);
                GamesTabs.SelectedTab = game.gameTab;
            }
            else
            {
                GamesTabs.SelectedTab = games[index].gameTab;
            }
        }

        private void ConsoleGamesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NewConsoleGameTab(e.RowIndex);
            
            MainTabs.SelectedTab = GamesTab;
        }

        private void ConsoleGamesDGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.ConsoleGamesDGV.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.ConsoleGamesDGV.CurrentCell = this.ConsoleGamesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.ConsoleGamesDGVContextMenu.Show(this.ConsoleGamesDGV, e.Location);
                    ConsoleGamesDGVContextMenu.Show(Cursor.Position);
                }
            }
            catch { }
        }

        private void EditConsoleGameEntryButton_Click(object sender, EventArgs e)
        {
            EditConsoleGameEntry(rowIndex);
        }

        /// <summary>
        /// The next section of code deals with the entry system.
        /// </summary>

        public void AddEntry()
        {
            highestId = 0;

            for (int index = 0; index < gameTable.Rows.Count; index++)
                if (highestId < Convert.ToInt32(gameTable.Rows[index]["Id"]))
                    highestId = Convert.ToInt32(gameTable.Rows[index]["Id"]);

            if (highestId == 0)
                highestId--;
            
            int hours; int minutes; int seconds;

            string hoursString = ""; string minutesString = ""; string secondsString = "";

            try { hours = Convert.ToInt32(TimeHoursBox.Text); } catch { hours = 0; }
            try { minutes = Convert.ToInt32(TimeMinutesBox.Text); } catch { minutes = 0; }
            try { seconds = Convert.ToInt32(TimeSecondsBox.Text); } catch { seconds = 0; }

            minutes += seconds / 60;
            seconds %= 60;
            hours += minutes / 60;
            minutes %= 60;

            if (hours < 10)
                hoursString = "0";
            hoursString += hours + "h:";

            if (minutes < 10)
                minutesString = "0";
            minutesString += minutes + "m:";

            if (seconds < 10)
                secondsString = "0";
            secondsString += seconds + "s";

            string timePlayed = hoursString + minutesString + secondsString;

            int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            string nullDT = "1753-01-01 00:00:00";
            string obtained;
            string startDate;
            string lastPlayed;

            if (!ObtainedCheck.Checked)
                obtained = ObtainedDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            else
                obtained = nullDT;

            if (!StartDateCheck.Checked)
                startDate = StartDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            else
                startDate = nullDT;

            if (!LastPlayedCheck.Checked)
                lastPlayed = LastPlayedDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            else
                lastPlayed = nullDT;

            string releaseDate;
            if (!ReleaseDateCheck.Checked)
                releaseDate = ReleaseDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            else
                releaseDate = nullDT;

            decimal price;
            try { price = Convert.ToDecimal(PriceBox.Text); } catch { try { price = Convert.ToDecimal(PriceBox.Text.Substring(1)); } catch { price = -1; } }

            try
            {
                insertCmd.Parameters.AddWithValue("@Id", highestId + 1);
                insertCmd.Parameters.AddWithValue("@Title", TitleBox.Text);
                insertCmd.Parameters.AddWithValue("@Platform", PlatformBox.Text);
                insertCmd.Parameters.AddWithValue("@Status", StatusBox.Text);
                insertCmd.Parameters.AddWithValue("@Rating", RatingBar.Value);
                insertCmd.Parameters.AddWithValue("@TimePlayed", timePlayed);
                insertCmd.Parameters.AddWithValue("@Seconds", totalSeconds);

                insertCmd.Parameters.AddWithValue("@Obtained", obtained);
                insertCmd.Parameters.AddWithValue("@StartDate", startDate);
                insertCmd.Parameters.AddWithValue("@LastPlayed", lastPlayed);

                insertCmd.Parameters.AddWithValue("@Notes", NotesBox.Text);
                insertCmd.Parameters.AddWithValue("@URLs", urlString);
                insertCmd.Parameters.AddWithValue("@Filters", FiltersBox.Text);
                insertCmd.Parameters.AddWithValue("@Developers", DevelopersBox.Text);
                insertCmd.Parameters.AddWithValue("@Publishers", PublishersBox.Text);
                insertCmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);
                insertCmd.Parameters.AddWithValue("@Genre", GenreBox.Text);
                insertCmd.Parameters.AddWithValue("@PlayerCount", PlayerCountBox.Text);
                insertCmd.Parameters.AddWithValue("@Price", price);
                insertCmd.Parameters.AddWithValue("@GameDesc", GameDescBox.Text);
                insertCmd.Parameters.AddWithValue("@Launch", launchString);
                insertCmd.Parameters.AddWithValue("@Blur", BlurCheck.Checked.ToString());
                insertCmd.Parameters.AddWithValue("@Overlay", OverlayCheck.Checked.ToString());
                insertCmd.Parameters.AddWithValue("@Discord", DiscordCheck.Checked.ToString());

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("\"" + TitleBox.Text + "\" successfully added to collection.", "Successful Addition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                insertCmd.Parameters.RemoveAt("@Id");
                insertCmd.Parameters.RemoveAt("@Title");
                insertCmd.Parameters.RemoveAt("@Platform");
                insertCmd.Parameters.RemoveAt("@Status");
                insertCmd.Parameters.RemoveAt("@Rating");
                insertCmd.Parameters.RemoveAt("@TimePlayed");
                insertCmd.Parameters.RemoveAt("@Seconds");
                insertCmd.Parameters.RemoveAt("@Obtained");
                insertCmd.Parameters.RemoveAt("@StartDate");
                insertCmd.Parameters.RemoveAt("@LastPlayed");
                insertCmd.Parameters.RemoveAt("@Notes");
                insertCmd.Parameters.RemoveAt("@URLs");
                insertCmd.Parameters.RemoveAt("@Filters");
                insertCmd.Parameters.RemoveAt("@Developers");
                insertCmd.Parameters.RemoveAt("@Publishers");
                insertCmd.Parameters.RemoveAt("@ReleaseDate");
                insertCmd.Parameters.RemoveAt("@Genre");
                insertCmd.Parameters.RemoveAt("@PlayerCount");
                insertCmd.Parameters.RemoveAt("@Price");
                insertCmd.Parameters.RemoveAt("@GameDesc");
                insertCmd.Parameters.RemoveAt("@Launch");
                insertCmd.Parameters.RemoveAt("@Blur");
                insertCmd.Parameters.RemoveAt("@Overlay");
                insertCmd.Parameters.RemoveAt("@Discord");
            }
            catch { }

            DataRow dRow = gameTable.NewRow();
            
            dRow["Id"] = highestId + 1;
            dRow["Title"] = TitleBox.Text;
            dRow["Platform"] = PlatformBox.Text;
            dRow["Status"] = StatusBox.Text;
            dRow["Rating"] = RatingBar.Value;
            dRow["TimePlayed"] = timePlayed;
            dRow["Seconds"] = totalSeconds;
            dRow["Obtained"] = obtained;
            dRow["StartDate"] = startDate;
            dRow["LastPlayed"] = lastPlayed;
            dRow["Notes"] = NotesBox.Text;
            dRow["URLs"] = urlString;
            dRow["Filters"] = FiltersBox.Text;
            dRow["Developers"] = DevelopersBox.Text;
            dRow["Publishers"] = PublishersBox.Text;
            dRow["ReleaseDate"] = releaseDate;
            dRow["Genre"] = GenreBox.Text;
            dRow["PlayerCount"] = PlayerCountBox.Text;
            dRow["Price"] = price;
            dRow["GameDesc"] = GameDescBox.Text;
            dRow["Launch"] = launchString;
            dRow["Blur"] = BlurCheck.ToString();
            dRow["Overlay"] = OverlayCheck.ToString();
            dRow["Discord"] = DiscordCheck.ToString();

            gameTable.Rows.Add(dRow);

            highestId++;
            index++;

            GamesListTab.Text = "[LIST] " + gameTable.Rows.Count + "/" + gameTable.Rows.Count;
        }

        public void EditEntry(int rowIndex)
        {

            Clear();
            
            editedId = Convert.ToInt32(GamesDGV.Rows[rowIndex].Cells["Id"].Value);
            editedRow = rowIndex;
            string playTime = GamesDGV.Rows[rowIndex].Cells["TimePlayed"].Value.ToString();

            // This could be replaced by just pulling from "Seconds" and using division
            int hours = Convert.ToInt32(playTime.Substring(0, playTime.IndexOf("h")));
            int minutes = Convert.ToInt32(playTime.Substring(playTime.IndexOf("h:") + 2, 2));
            int seconds = Convert.ToInt32(playTime.Substring(playTime.IndexOf("m:") + 2, 2));
            
            DateTime obtained = Convert.ToDateTime(GamesDGV.Rows[rowIndex].Cells["Obtained"].Value);
            DateTime startDate = Convert.ToDateTime(GamesDGV.Rows[rowIndex].Cells["StartDate"].Value);
            DateTime lastPlayed = Convert.ToDateTime(GamesDGV.Rows[rowIndex].Cells["LastPlayed"].Value);
            DateTime releaseDate = Convert.ToDateTime(GamesDGV.Rows[rowIndex].Cells["ReleaseDate"].Value);

            if (obtained == new DateTime())
                obtained = new DateTime(1753, 1, 1);
            if (startDate == new DateTime())
                startDate = new DateTime(1753, 1, 1);
            if (lastPlayed == new DateTime())
                lastPlayed = new DateTime(1753, 1, 1);
            if (releaseDate == new DateTime())
                releaseDate = new DateTime(1753, 1, 1);

            Console.WriteLine(startDate);

            TitleBox.Text = GamesDGV.Rows[rowIndex].Cells["Title"].Value.ToString();
            PlatformBox.Text = GamesDGV.Rows[rowIndex].Cells["Platform"].Value.ToString();
            StatusBox.Text = GamesDGV.Rows[rowIndex].Cells["Status"].Value.ToString();
            RatingBar.Value = Convert.ToInt32(GamesDGV.Rows[rowIndex].Cells["Rating"].Value.ToString());
            if (hours != 0) TimeHoursBox.Text = hours.ToString(); else TimeHoursBox.Text = "";
            if (minutes != 0) TimeMinutesBox.Text = minutes.ToString(); else TimeMinutesBox.Text = "";
            if (seconds != 0) TimeSecondsBox.Text = seconds.ToString(); else TimeSecondsBox.Text = "";

            ObtainedCheck.Checked = false;
            StartDateCheck.Checked = false;
            LastPlayedCheck.Checked = false;
            ReleaseDateCheck.Checked = false;

            if (obtained == new DateTime(1753, 1, 1))
                ObtainedCheck.Checked = true;
            else
                ObtainedDatePicker.Value = obtained;

            if (startDate == new DateTime(1753, 1, 1))
                StartDateCheck.Checked = true;
            else
                StartDatePicker.Value = startDate;
            
            if (lastPlayed == new DateTime(1753, 1, 1))
                LastPlayedCheck.Checked = true;
            else
                LastPlayedDatePicker.Value = lastPlayed;

            NotesBox.Text = GamesDGV.Rows[rowIndex].Cells["Notes"].Value.ToString();
            urlString = GamesDGV.Rows[rowIndex].Cells["URLs"].Value.ToString();

            FiltersBox.Text = GamesDGV.Rows[rowIndex].Cells["Filters"].Value.ToString();
            DevelopersBox.Text = GamesDGV.Rows[rowIndex].Cells["Developers"].Value.ToString();
            PublishersBox.Text = GamesDGV.Rows[rowIndex].Cells["Publishers"].Value.ToString();

            if (releaseDate == new DateTime(1753, 1, 1))
                ReleaseDateCheck.Checked = true;
            else
                ReleaseDatePicker.Value = releaseDate;


            GenreBox.Text = GamesDGV.Rows[rowIndex].Cells["Genre"].Value.ToString();
            PlayerCountBox.Text = GamesDGV.Rows[rowIndex].Cells["PlayerCount"].Value.ToString();

            if (GamesDGV.Rows[rowIndex].Cells["Price"].Value.ToString() != "-1")
                PriceBox.Text = GamesDGV.Rows[rowIndex].Cells["Price"].Value.ToString();
            else
                PriceBox.Text = "";

            GameDescBox.Text = GamesDGV.Rows[rowIndex].Cells["GameDesc"].Value.ToString();

            launchString = GamesDGV.Rows[rowIndex].Cells["Launch"].Value.ToString();

            try { BlurCheck.Checked = Convert.ToBoolean(GamesDGV.Rows[rowIndex].Cells["Blur"].Value); } catch { BlurCheck.Checked = true; }
            try { OverlayCheck.Checked = Convert.ToBoolean(GamesDGV.Rows[rowIndex].Cells["Overlay"].Value); } catch { OverlayCheck.Checked = true; }
            try { DiscordCheck.Checked = Convert.ToBoolean(GamesDGV.Rows[rowIndex].Cells["Discord"].Value); } catch { DiscordCheck.Checked = true; }

            imageTitle = TitleBox.Text;
            Regex rgxFix1 = new Regex("/");
            Regex rgxFix2 = new Regex(":");
            Regex rgxFix3 = new Regex(".*");
            Regex rgxFix4 = new Regex(".?");
            Regex rgxFix5 = new Regex("\"");
            Regex rgxFix6 = new Regex("<");
            Regex rgxFix7 = new Regex(">");
            Regex rgxFix8 = new Regex("|");
            Regex rgxFix9 = new Regex(@"T:\\");

            while (imageTitle.IndexOf("/") != -1)
                imageTitle = rgxFix1.Replace(imageTitle, "");
            while (imageTitle.IndexOf(":") != -1)
                imageTitle = rgxFix2.Replace(imageTitle, "");
            while (imageTitle.IndexOf("*") != -1)
                imageTitle = rgxFix3.Replace(imageTitle, "");
            while (imageTitle.IndexOf("?") != -1)
                imageTitle = rgxFix4.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\"") != -1)
                imageTitle = rgxFix5.Replace(imageTitle, "");
            while (imageTitle.IndexOf("<") != -1)
                imageTitle = rgxFix6.Replace(imageTitle, "");
            while (imageTitle.IndexOf(">") != -1)
                imageTitle = rgxFix7.Replace(imageTitle, "");
            while (imageTitle.IndexOf("|") != -1)
                imageTitle = rgxFix8.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\\") != -1)
                imageTitle = rgxFix9.Replace(imageTitle, "");

            try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + imageTitle + ".png"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + imageTitle + ".jpg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + imageTitle + ".jpeg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + imageTitle + ".gif"); } catch { } } } }
            try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + imageTitle + ".png"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + imageTitle + ".jpg"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + imageTitle + ".jpeg"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + imageTitle + ".gif"); } catch { } } } }
            try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\bg\\" + imageTitle + ".png"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + imageTitle + ".jpg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + imageTitle + ".jpeg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + imageTitle + ".gif"); } catch { } } } }

            ReplaceButton.Visible = true;
            DeleteButton.Visible = true;

            TabPage entriesTab = GamesEntriesTab;
            GamesTabs.SelectedTab = entriesTab;
        }

        private void EditConsoleGameEntry(int rowIndex)
        {
            Clear();

            editedId = Convert.ToInt32(ConsoleGamesDGV.Rows[rowIndex].Cells["Id"].Value);
            editedRow = rowIndex;
            string playTime = ConsoleGamesDGV.Rows[rowIndex].Cells["TimePlayed"].Value.ToString();

            // This could be replaced by just pulling from "Seconds" and using division
            int hours = Convert.ToInt32(playTime.Substring(0, playTime.IndexOf("h")));
            int minutes = Convert.ToInt32(playTime.Substring(playTime.IndexOf("h:") + 2, 2));
            int seconds = Convert.ToInt32(playTime.Substring(playTime.IndexOf("m:") + 2, 2));

            DateTime obtained = Convert.ToDateTime(ConsoleGamesDGV.Rows[rowIndex].Cells["Obtained"].Value);
            DateTime startDate = Convert.ToDateTime(ConsoleGamesDGV.Rows[rowIndex].Cells["StartDate"].Value);
            DateTime lastPlayed = Convert.ToDateTime(ConsoleGamesDGV.Rows[rowIndex].Cells["LastPlayed"].Value);
            DateTime releaseDate = Convert.ToDateTime(ConsoleGamesDGV.Rows[rowIndex].Cells["ReleaseDate"].Value);

            TitleBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["Title"].Value.ToString();
            PlatformBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["Platform"].Value.ToString();
            StatusBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["Status"].Value.ToString();
            RatingBar.Value = Convert.ToInt32(ConsoleGamesDGV.Rows[rowIndex].Cells["Rating"].Value.ToString());
            if (hours != 0) TimeHoursBox.Text = hours.ToString(); else TimeHoursBox.Text = "";
            if (minutes != 0) TimeMinutesBox.Text = minutes.ToString(); else TimeMinutesBox.Text = "";
            if (seconds != 0) TimeSecondsBox.Text = seconds.ToString(); else TimeSecondsBox.Text = "";

            ObtainedCheck.Checked = false;
            StartDateCheck.Checked = false;
            LastPlayedCheck.Checked = false;
            ReleaseDateCheck.Checked = false;

            if (Convert.ToDateTime(ConsoleGamesDGV.Rows[rowIndex].Cells["Obtained"].Value) == new DateTime(1753, 1, 1))
                ObtainedCheck.Checked = true;
            else
                ObtainedDatePicker.Value = obtained;

            if (Convert.ToDateTime(ConsoleGamesDGV.Rows[rowIndex].Cells["StartDate"].Value) == new DateTime(1753, 1, 1))
                StartDateCheck.Checked = true;
            else
                StartDatePicker.Value = startDate;

            if (Convert.ToDateTime(GamesDGV.Rows[rowIndex].Cells["LastPlayed"].Value) == new DateTime(1753, 1, 1))
                LastPlayedCheck.Checked = true;
            else
                LastPlayedDatePicker.Value = lastPlayed;

            NotesBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["Notes"].Value.ToString();
            urlString = ConsoleGamesDGV.Rows[rowIndex].Cells["URLs"].Value.ToString();

            FiltersBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["Filters"].Value.ToString();
            DevelopersBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["Developers"].Value.ToString();
            PublishersBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["Publishers"].Value.ToString();

            if (Convert.ToDateTime(ConsoleGamesDGV.Rows[rowIndex].Cells["ReleaseDate"].Value) == new DateTime(1753, 1, 1))
                ReleaseDateCheck.Checked = true;
            else
                ReleaseDatePicker.Value = releaseDate;


            GenreBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["Genre"].Value.ToString();
            PlayerCountBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["PlayerCount"].Value.ToString();

            if (ConsoleGamesDGV.Rows[rowIndex].Cells["Price"].Value.ToString() != "-1")
                PriceBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["Price"].Value.ToString();
            else
                PriceBox.Text = "";

            GameDescBox.Text = ConsoleGamesDGV.Rows[rowIndex].Cells["GameDesc"].Value.ToString();

            launchString = ConsoleGamesDGV.Rows[rowIndex].Cells["Launch"].Value.ToString();

            BlurCheck.Checked = Convert.ToBoolean(ConsoleGamesDGV.Rows[rowIndex].Cells["Blur"].Value);
            OverlayCheck.Checked = Convert.ToBoolean(ConsoleGamesDGV.Rows[rowIndex].Cells["Overlay"].Value);
            DiscordCheck.Checked = Convert.ToBoolean(ConsoleGamesDGV.Rows[rowIndex].Cells["Discord"].Value);

            imageTitle = TitleBox.Text;
            Regex rgxFix1 = new Regex("/");
            Regex rgxFix2 = new Regex(":");
            Regex rgxFix3 = new Regex(".*");
            Regex rgxFix4 = new Regex(".?");
            Regex rgxFix5 = new Regex("\"");
            Regex rgxFix6 = new Regex("<");
            Regex rgxFix7 = new Regex(">");
            Regex rgxFix8 = new Regex("|");
            Regex rgxFix9 = new Regex(@"T:\\");

            while (imageTitle.IndexOf("/") != -1)
                imageTitle = rgxFix1.Replace(imageTitle, "");
            while (imageTitle.IndexOf(":") != -1)
                imageTitle = rgxFix2.Replace(imageTitle, "");
            while (imageTitle.IndexOf("*") != -1)
                imageTitle = rgxFix3.Replace(imageTitle, "");
            while (imageTitle.IndexOf("?") != -1)
                imageTitle = rgxFix4.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\"") != -1)
                imageTitle = rgxFix5.Replace(imageTitle, "");
            while (imageTitle.IndexOf("<") != -1)
                imageTitle = rgxFix6.Replace(imageTitle, "");
            while (imageTitle.IndexOf(">") != -1)
                imageTitle = rgxFix7.Replace(imageTitle, "");
            while (imageTitle.IndexOf("|") != -1)
                imageTitle = rgxFix8.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\\") != -1)
                imageTitle = rgxFix9.Replace(imageTitle, "");

            try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + imageTitle + ".png"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + imageTitle + ".jpg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + imageTitle + ".jpeg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + imageTitle + ".gif"); } catch { } } } }
            try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + imageTitle + ".png"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + imageTitle + ".jpg"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + imageTitle + ".jpeg"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + imageTitle + ".gif"); } catch { } } } }
            try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\bg\\" + imageTitle + ".png"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + imageTitle + ".jpg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + imageTitle + ".jpeg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + imageTitle + ".gif"); } catch { } } } }

            ReplaceButton.Visible = true;
            DeleteButton.Visible = true;
            
            GamesTabs.SelectedTab = GamesEntriesTab;
            
            MainTabs.SelectedTab = GamesTab;
        }

        private void Replace()
        {
            string hoursString = ""; string minutesString = ""; string secondsString = "";
            int hr, min, sec;

            try { hr = Convert.ToInt32(TimeHoursBox.Text); } catch { hr = 0; }
            try { min = Convert.ToInt32(TimeMinutesBox.Text); } catch { min = 0; }
            try { sec = Convert.ToInt32(TimeSecondsBox.Text); } catch { sec = 0; }

            int totalSec = (hr * 3600) + (min * 60) + sec;
            min = totalSec / 60;
            sec = totalSec % 60;
            hr = min / 60;
            min = min % 60;

            if (hr < 10)
                hoursString = "0";
            hoursString += hr + "h:";

            if (min < 10)
                minutesString = "0";
            minutesString += min + "m:";

            if (sec < 10)
                secondsString = "0";
            secondsString += sec + "s";

            string timePlayed = hoursString + minutesString + secondsString;

            DateTime obtained, startDate, lastPlayed, releaseDate;
            obtained = new DateTime(1753, 1, 1);
            startDate = new DateTime(1753, 1, 1);
            lastPlayed = new DateTime(1753, 1, 1);
            releaseDate = new DateTime(1753, 1, 1);

            if (!ObtainedCheck.Checked)
                obtained = ObtainedDatePicker.Value;
            if (!StartDateCheck.Checked)
                startDate = StartDatePicker.Value;
            if (!LastPlayedCheck.Checked)
                lastPlayed = LastPlayedDatePicker.Value;
            if (!ReleaseDateCheck.Checked)
                releaseDate = ReleaseDatePicker.Value;

            decimal price;
            if (PriceBox.Text != "")
                try { price = Convert.ToDecimal(PriceBox.Text); } catch { price = 0; }
            else
                price = -1;

            string command = "UPDATE Games SET Title = @Title, Platform = @Platform, Status = @Status, Rating = @Rating, TimePlayed = @TimePlayed, " +
                "Seconds = @Seconds, Obtained = @Obtained, StartDate = @StartDate, LastPlayed = @LastPlayed, Notes = @Notes, URLs = @URLs, " +
                "Filters = @Filters, Developers = @Developers, Publishers = @Publishers, ReleaseDate = @ReleaseDate, Genre = @Genre, PlayerCount = @PlayerCount, " +
                "Price = @Price, GameDesc = @GameDesc, Launch = @Launch, Blur = @Blur, Overlay = @Overlay, Discord = @Discord WHERE Id = " + editedId + ";";
            
            SQLiteCommand replaceCmd = new SQLiteCommand(command, con);

            replaceCmd.Parameters.AddWithValue("@Title", TitleBox.Text);
            replaceCmd.Parameters.AddWithValue("@Platform", PlatformBox.Text);
            replaceCmd.Parameters.AddWithValue("@Status", StatusBox.Text);
            replaceCmd.Parameters.AddWithValue("@Rating", RatingBar.Value);
            replaceCmd.Parameters.AddWithValue("@TimePlayed", timePlayed);
            replaceCmd.Parameters.AddWithValue("@Seconds", totalSec);
            replaceCmd.Parameters.AddWithValue("@Obtained", obtained.ToString("yyyy-MM-dd HH:mm:ss"));
            replaceCmd.Parameters.AddWithValue("@StartDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
            replaceCmd.Parameters.AddWithValue("@LastPlayed", lastPlayed.ToString("yyyy-MM-dd HH:mm:ss"));
            replaceCmd.Parameters.AddWithValue("@Notes", NotesBox.Text);
            replaceCmd.Parameters.AddWithValue("@URLs", urlString);
            replaceCmd.Parameters.AddWithValue("@Filters", FiltersBox.Text);
            replaceCmd.Parameters.AddWithValue("@Developers", DevelopersBox.Text);
            replaceCmd.Parameters.AddWithValue("@Publishers", PublishersBox.Text);
            replaceCmd.Parameters.AddWithValue("@ReleaseDate", releaseDate.ToString("yyyy-MM-dd HH:mm:ss"));
            replaceCmd.Parameters.AddWithValue("@Genre", GenreBox.Text);
            replaceCmd.Parameters.AddWithValue("@PlayerCount", PlayerCountBox.Text);
            replaceCmd.Parameters.AddWithValue("@Price", price);
            replaceCmd.Parameters.AddWithValue("@GameDesc", GameDescBox.Text);
            replaceCmd.Parameters.AddWithValue("@Launch", launchString);
            replaceCmd.Parameters.AddWithValue("@Blur", BlurCheck.Checked.ToString());
            replaceCmd.Parameters.AddWithValue("@Overlay", OverlayCheck.Checked.ToString());
            replaceCmd.Parameters.AddWithValue("@Discord", DiscordCheck.Checked.ToString());
            replaceCmd.ExecuteNonQuery();
            MessageBox.Show("\"" + TitleBox.Text + "\" successfully edited.", "Successful Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReplaceButton.Visible = false;
            DeleteButton.Visible = false;

            imageTitle = TitleBox.Text;
            Regex rgxFix1 = new Regex("/");
            Regex rgxFix2 = new Regex(":");
            Regex rgxFix3 = new Regex(".*");
            Regex rgxFix4 = new Regex(".?");
            Regex rgxFix5 = new Regex("\"");
            Regex rgxFix6 = new Regex("<");
            Regex rgxFix7 = new Regex(">");
            Regex rgxFix8 = new Regex("|");
            Regex rgxFix9 = new Regex(@"T:\\");

            while (imageTitle.IndexOf("/") != -1)
                imageTitle = rgxFix1.Replace(imageTitle, "");
            while (imageTitle.IndexOf(":") != -1)
                imageTitle = rgxFix2.Replace(imageTitle, "");
            while (imageTitle.IndexOf("*") != -1)
                imageTitle = rgxFix3.Replace(imageTitle, "");
            while (imageTitle.IndexOf("?") != -1)
                imageTitle = rgxFix4.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\"") != -1)
                imageTitle = rgxFix5.Replace(imageTitle, "");
            while (imageTitle.IndexOf("<") != -1)
                imageTitle = rgxFix6.Replace(imageTitle, "");
            while (imageTitle.IndexOf(">") != -1)
                imageTitle = rgxFix7.Replace(imageTitle, "");
            while (imageTitle.IndexOf("|") != -1)
                imageTitle = rgxFix8.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\\") != -1)
                imageTitle = rgxFix9.Replace(imageTitle, "");

            try { GamesDGV.Rows[editedRow].Cells[0].Value = Image.FromFile(config.resourcePath + "icons\\" + imageTitle + ".png"); }
            catch { try { GamesDGV.Rows[editedRow].Cells[0].Value = Image.FromFile(config.resourcePath + "icons\\" + imageTitle + ".jpg"); }
            catch { try { GamesDGV.Rows[editedRow].Cells[0].Value = Image.FromFile(config.resourcePath + "icons\\" + imageTitle + ".jpeg"); }
            catch { try { GamesDGV.Rows[editedRow].Cells[0].Value = Image.FromFile(config.resourcePath + "icons\\" + imageTitle + ".jfif"); }
            catch { try { GamesDGV.Rows[editedRow].Cells[0].Value = Image.FromFile(config.resourcePath + "icons\\" + imageTitle + ".gif"); }
            catch { GamesDGV.Rows[editedRow].Cells[0].Value = Image.FromFile(config.resourcePath + "unknown.png"); } } } } }

            for (int index = 0; index < gameTable.Rows.Count; index++)
                if (Convert.ToInt32(gameTable.Rows[index]["Id"].ToString()) == editedId)
                {
                    editedRow = index;
                    break;
                }

            gameTable.Rows[editedRow]["Title"] = TitleBox.Text;
            gameTable.Rows[editedRow]["Platform"] = PlatformBox.Text;
            gameTable.Rows[editedRow]["Status"] = StatusBox.Text;
            gameTable.Rows[editedRow]["Rating"] = RatingBar.Value;
            gameTable.Rows[editedRow]["TimePlayed"] = timePlayed;
            gameTable.Rows[editedRow]["Seconds"] = totalSec;
            gameTable.Rows[editedRow]["Obtained"] = obtained;
            gameTable.Rows[editedRow]["StartDate"] = startDate;
            gameTable.Rows[editedRow]["LastPlayed"] = lastPlayed;
            gameTable.Rows[editedRow]["Notes"] = NotesBox.Text;
            gameTable.Rows[editedRow]["URLs"] = urlString;
            gameTable.Rows[editedRow]["Filters"] = FiltersBox.Text;
            gameTable.Rows[editedRow]["Developers"] = DevelopersBox.Text;
            gameTable.Rows[editedRow]["Publishers"] = PublishersBox.Text;
            gameTable.Rows[editedRow]["ReleaseDate"] = releaseDate;
            gameTable.Rows[editedRow]["Genre"] = GenreBox.Text;
            gameTable.Rows[editedRow]["PlayerCount"] = PlayerCountBox.Text;
            gameTable.Rows[editedRow]["Price"] = price;
            gameTable.Rows[editedRow]["GameDesc"] = GameDescBox.Text;
            gameTable.Rows[editedRow]["Launch"] = launchString;
            gameTable.Rows[editedRow]["Blur"] = BlurCheck.ToString();
            gameTable.Rows[editedRow]["Overlay"] = OverlayCheck.ToString();
            gameTable.Rows[editedRow]["Discord"] = DiscordCheck.ToString();

            highestId++;

            Clear();
        }

        /*
        private void RemoveEntry(int rowIndex)
        {
            
        }
        */

        private void Clear()
        {
            if (!titleLocked)
                TitleBox.Text = "";
            if (!platformLocked)
                PlatformBox.Text = "";
            StatusBox.Text = "";
            RatingBar.Value = 0;
            TimeHoursBox.Text = "";
            TimeMinutesBox.Text = "";
            TimeSecondsBox.Text = "";
            ObtainedCheck.Checked = true;
            StartDateCheck.Checked = true;
            LastPlayedCheck.Checked = true;
            ObtainedDatePicker.Value = DateTime.Now;
            StartDatePicker.Value = DateTime.Now;
            LastPlayedDatePicker.Value = DateTime.Now;
            NotesBox.Text = "";
            DevelopersBox.Text = "";
            PublishersBox.Text = "";
            ReleaseDateCheck.Checked = true;
            ReleaseDatePicker.Value = DateTime.Now;
            GenreBox.Text = "";
            PlayerCountBox.Text = "";
            PriceBox.Text = "";
            GameDescBox.Text = "";
            launchString = "";
            urlString = "";
            FiltersBox.Text = "";
            BlurCheck.Checked = true;
            OverlayCheck.Checked = true;
            DetailsBox.BackgroundImage = null;
            IconBox.BackgroundImage = null;
            BgBox.BackgroundImage = null;

            titleLocked = false;
            platformLocked = false;
        }

        private void SearchDatabase()
        {
            DGVForm dbForm = new DGVForm("DB", TitleBox.Text, this);
            dbForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEntry();   
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // EditEntry();
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            Replace();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM Games WHERE Id = " + editedId, con);
            deleteCommand.ExecuteNonQuery();

            GamesDGV.Rows.Remove(GamesDGV.Rows[editedRow]);

            DataRow row = ((DataRowView)GamesDGV.Rows[editedRow].DataBoundItem).Row;
            gameTable.Rows.Remove(row);

            GamesListTab.Text = "[LIST] " + gameTable.Rows.Count + "/" + gameTable.Rows.Count;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void RatingBar_ValueChanged(object sender, EventArgs e)
        {
            RatingBox.Text = RatingBar.Value.ToString();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            DGVForm dgvForm = new DGVForm("Launch", launchString, this);
            dgvForm.Show();
        }

        private void URLButton_Click(object sender, EventArgs e)
        {
            DGVForm dgvForm = new DGVForm("URLs", urlString, this);
            dgvForm.Show();
        }

        private void SearchDatabaseButton_Click(object sender, EventArgs e)
        {
            SearchDatabase();
        }

        private void DetailsBox_MouseUp(object sender, MouseEventArgs e)
        {
            imageTitle = TitleBox.Text;
            Regex rgxFix1 = new Regex("/");
            Regex rgxFix2 = new Regex(":");
            Regex rgxFix3 = new Regex(".*");
            Regex rgxFix4 = new Regex(".?");
            Regex rgxFix5 = new Regex("\"");
            Regex rgxFix6 = new Regex("<");
            Regex rgxFix7 = new Regex(">");
            Regex rgxFix8 = new Regex("|");
            Regex rgxFix9 = new Regex(@"T:\\");

            while (imageTitle.IndexOf("/") != -1)
                imageTitle = rgxFix1.Replace(imageTitle, "");
            while (imageTitle.IndexOf(":") != -1)
                imageTitle = rgxFix2.Replace(imageTitle, "");
            while (imageTitle.IndexOf("*") != -1)
                imageTitle = rgxFix3.Replace(imageTitle, "");
            while (imageTitle.IndexOf("?") != -1)
                imageTitle = rgxFix4.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\"") != -1)
                imageTitle = rgxFix5.Replace(imageTitle, "");
            while (imageTitle.IndexOf("<") != -1)
                imageTitle = rgxFix6.Replace(imageTitle, "");
            while (imageTitle.IndexOf(">") != -1)
                imageTitle = rgxFix7.Replace(imageTitle, "");
            while (imageTitle.IndexOf("|") != -1)
                imageTitle = rgxFix8.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\\") != -1)
                imageTitle = rgxFix9.Replace(imageTitle, "");

            this.PictureContextMenu.Show(this.DetailsBox, e.Location);
            PictureContextMenu.Tag = "details\\";
            PictureContextMenu.Show(Cursor.Position);
        }

        private void IconBox_MouseUp(object sender, MouseEventArgs e)
        {
            imageTitle = TitleBox.Text;
            Regex rgxFix1 = new Regex("/");
            Regex rgxFix2 = new Regex(":");
            Regex rgxFix3 = new Regex(".*");
            Regex rgxFix4 = new Regex(".?");
            Regex rgxFix5 = new Regex("\"");
            Regex rgxFix6 = new Regex("<");
            Regex rgxFix7 = new Regex(">");
            Regex rgxFix8 = new Regex("|");
            Regex rgxFix9 = new Regex(@"T:\\");

            while (imageTitle.IndexOf("/") != -1)
                imageTitle = rgxFix1.Replace(imageTitle, "");
            while (imageTitle.IndexOf(":") != -1)
                imageTitle = rgxFix2.Replace(imageTitle, "");
            while (imageTitle.IndexOf("*") != -1)
                imageTitle = rgxFix3.Replace(imageTitle, "");
            while (imageTitle.IndexOf("?") != -1)
                imageTitle = rgxFix4.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\"") != -1)
                imageTitle = rgxFix5.Replace(imageTitle, "");
            while (imageTitle.IndexOf("<") != -1)
                imageTitle = rgxFix6.Replace(imageTitle, "");
            while (imageTitle.IndexOf(">") != -1)
                imageTitle = rgxFix7.Replace(imageTitle, "");
            while (imageTitle.IndexOf("|") != -1)
                imageTitle = rgxFix8.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\\") != -1)
                imageTitle = rgxFix9.Replace(imageTitle, "");

            this.PictureContextMenu.Show(this.IconBox, e.Location);
            PictureContextMenu.Tag = "icons\\";
            PictureContextMenu.Show(Cursor.Position);
        }

        private void BgBox_MouseUp(object sender, MouseEventArgs e)
        {
            imageTitle = TitleBox.Text;
            Regex rgxFix1 = new Regex("/");
            Regex rgxFix2 = new Regex(":");
            Regex rgxFix3 = new Regex(".*");
            Regex rgxFix4 = new Regex(".?");
            Regex rgxFix5 = new Regex("\"");
            Regex rgxFix6 = new Regex("<");
            Regex rgxFix7 = new Regex(">");
            Regex rgxFix8 = new Regex("|");
            Regex rgxFix9 = new Regex(@"T:\\");

            while (imageTitle.IndexOf("/") != -1)
                imageTitle = rgxFix1.Replace(imageTitle, "");
            while (imageTitle.IndexOf(":") != -1)
                imageTitle = rgxFix2.Replace(imageTitle, "");
            while (imageTitle.IndexOf("*") != -1)
                imageTitle = rgxFix3.Replace(imageTitle, "");
            while (imageTitle.IndexOf("?") != -1)
                imageTitle = rgxFix4.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\"") != -1)
                imageTitle = rgxFix5.Replace(imageTitle, "");
            while (imageTitle.IndexOf("<") != -1)
                imageTitle = rgxFix6.Replace(imageTitle, "");
            while (imageTitle.IndexOf(">") != -1)
                imageTitle = rgxFix7.Replace(imageTitle, "");
            while (imageTitle.IndexOf("|") != -1)
                imageTitle = rgxFix8.Replace(imageTitle, "");
            while (imageTitle.IndexOf("\\") != -1)
                imageTitle = rgxFix9.Replace(imageTitle, "");

            this.PictureContextMenu.Show(this.BgBox, e.Location);
            PictureContextMenu.Tag = "bg\\";
            PictureContextMenu.Show(Cursor.Position);
        }

        private void ClearPictureButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("HEADS UP: Clearing a file will not delete it.", "Clearing Picture", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                if (PictureContextMenu.Tag.ToString() == "details\\")
                    DetailsBox.BackgroundImage = null;
                else if (PictureContextMenu.Tag.ToString() == "icons\\")
                    IconBox.BackgroundImage = null;
                else if (PictureContextMenu.Tag.ToString() == "bg\\")
                    BgBox.BackgroundImage = null;
            }
        }

        private void LocalPictureButton_Click(object sender, EventArgs e)
        {
            if (PictureDialog.ShowDialog() == DialogResult.OK)
            {
                CutOrCopy cutOrCopy = new CutOrCopy();

                DialogResult dialogResult = cutOrCopy.ShowDialog();
                string fileExt = Path.GetExtension(PictureDialog.FileName);

                if (dialogResult == DialogResult.Yes)
                {
                    File.Copy(PictureDialog.FileName, resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    if (PictureContextMenu.Tag.ToString() == "details\\")
                        DetailsBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "icons\\")
                        IconBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "bg\\")
                        BgBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                }
                else if (dialogResult == DialogResult.No)
                {
                    File.Move(PictureDialog.FileName, resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    if (PictureContextMenu.Tag.ToString() == "details\\")
                        DetailsBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "icons\\")
                        IconBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "bg\\")
                        BgBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                }
            }
        }

        private void DatabasePictureButton_Click(object sender, EventArgs e)
        {
            DGVForm dgvForm = new DGVForm("Images", PictureContextMenu.Tag.ToString(), this);
            
            if (dgvForm.ShowDialog() == DialogResult.OK)
            {
                if (PictureContextMenu.Tag.ToString() == "details\\")
                    DetailsBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + imageTitle + ".png");
                else if (PictureContextMenu.Tag.ToString() == "bg\\")
                    BgBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + imageTitle + ".png");
                else if (PictureContextMenu.Tag.ToString() == "icons\\")
                    IconBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + imageTitle + ".png");
            }
        }

        private void InternetPictureButton_Click(object sender, EventArgs e)
        {
            ArrayList titleParts = new ArrayList();

            string segment = TitleBox.Text;
            string part = "";

            string url = "https://google.com/search?q=" + TitleBox.Text;

            if (PictureContextMenu.Tag.ToString() == "icons\\")
                url += " icon";

            url += "&source=lnms&tbm=isch";

            Browser browser = new Browser(url, "Download");
            DialogResult dialogResult = browser.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                string downloadUrl = browser.downloadUrl;

                /*
                string fileExt = browser.url;
                while (fileExt.IndexOf(".") != -1)
                {
                    fileExt = fileExt.Substring(fileExt.IndexOf(".") + 1);
                }
                */

                WebClient webClient = new WebClient();
                try
                {
                    byte[] imageBytes = webClient.DownloadData(downloadUrl);
                    Console.WriteLine(imageBytes.LongLength);

                    // try { File.WriteAllBytes(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + fileExt, imageBytes); } catch { File.WriteAllBytes(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + ".jpg", imageBytes); }
                    File.WriteAllBytes(resourcePath + PictureContextMenu.Tag.ToString() + imageTitle + ".png", imageBytes);
                    
                    if (PictureContextMenu.Tag.ToString() == "details\\")
                        DetailsBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + imageTitle + ".png");
                    else if (PictureContextMenu.Tag.ToString() == "bg\\")
                        BgBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + imageTitle + ".png");
                    else if (PictureContextMenu.Tag.ToString() == "icons\\")
                        IconBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + imageTitle + ".png");
                }
                catch
                {
                    MessageBox.Show("Image download failed.");
                }
            }
        }

        private void GamesDGV_Sorted(object sender, EventArgs e)
        {
            if (GamesDGV.SortedColumn.HeaderText == "Time Played")
            {
                if (GamesDGV.SortOrder == System.Windows.Forms.SortOrder.Ascending)
                    GamesDGV.Sort(GamesDGV.Columns["Seconds"], ListSortDirection.Descending);
                else
                    GamesDGV.Sort(GamesDGV.Columns["Seconds"], ListSortDirection.Ascending);
            }
        }

        private void LockTitleButton_Click(object sender, EventArgs e)
        {
            if (titleLocked)
            {
                LockTitleButton.BackgroundImage = Image.FromFile(resourcePath + "Unlock.png");
                titleLocked = false;
            }
            else
            {
                LockTitleButton.BackgroundImage = Image.FromFile(resourcePath + "Lock.png");
                titleLocked = true;
            }
        }

        private void LockPlatformButton_Click(object sender, EventArgs e)
        {
            if (platformLocked)
            {
                LockPlatformButton.BackgroundImage = Image.FromFile(resourcePath + "Unlock.png");
                platformLocked = false;
            }
            else
            {
                LockPlatformButton.BackgroundImage = Image.FromFile(resourcePath + "Lock.png");
                platformLocked = true;
            }
        }

        private void AddTimeButton_Click(object sender, EventArgs e)
        {
            int oldHrs, oldMins, oldSecs;
            try { oldHrs = Convert.ToInt32(TimeHoursBox.Text); } catch { oldHrs = 0; }
            try { oldMins = Convert.ToInt32(TimeMinutesBox.Text); } catch { oldMins = 0; }
            try { oldSecs = Convert.ToInt32(TimeSecondsBox.Text); } catch { oldSecs = 0; }

            AddTime addTime = new AddTime(this, oldHrs, oldMins, oldSecs);
            DialogResult dialogResult = addTime.ShowDialog();
            if (dialogResult == DialogResult.Yes) { }
        }

        private void GamesTabs_ControlRemoved(object sender, ControlEventArgs e)
        {
            int tabIndex = e.Control.TabIndex - 2;
            // games[tabIndex].Close();
            games.RemoveAt(tabIndex);
        }
        
        public void UpdateTime(string timePlayed, int totalSeconds, DateTime lastPlayed, int id, DateTime startDate)
        {
            SQLiteCommand updateCmd = new SQLiteCommand("UPDATE Games SET TimePlayed = '" + timePlayed + "', Seconds = " + totalSeconds + ", StartDate = '" + startDate.ToString("yyyy-MM-dd HH:mm:ss") + "', LastPlayed = '" + lastPlayed.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Id = " + id + ";", con);
            updateCmd.ExecuteNonQuery();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void ConsolesDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try { FillConsole(ConsolesDGV.Rows[e.RowIndex].Cells["Name"].Value.ToString()); } catch { }
        }

        private void MainTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabs.SelectedTab.Text == "Games")
                GamesDGV.Focus();
            else if (MainTabs.SelectedTab.Text == "Consoles")
                ConsolesDGV.Focus();
        }

        private void AdvancedSearchButton_Click(object sender, EventArgs e)
        {
            AdvancedSearch advSearch = new AdvancedSearch(this);
            advSearch.Show();
        }
    }
}
