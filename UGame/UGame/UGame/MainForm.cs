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
        public DataTable dataTable;

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

            try { GamesDGV.Sort(GamesDGV.Columns["Title"], ListSortDirection.Ascending); } catch { }
        }

        private void InitializeTheme()
        {
            RefreshButton.Image = Image.FromFile(resourcePath + "refresh.png");

            LockTitleButton.BackgroundImage = Image.FromFile(resourcePath + "Unlock.png");
            LockPlatformButton.BackgroundImage = Image.FromFile(resourcePath + "Unlock.png");
        }

        private void FillDGV()
        {
            selectCmd.CommandType = CommandType.Text;
            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            dataTable = new DataTable();
            dataTable.Columns.Add(" ", typeof(Image));
            da.Fill(dataTable);
            
            GamesDGV.DataSource = dataTable;
            GamesListTab.Text = "[LIST] " + dataTable.Rows.Count + "/" + dataTable.Rows.Count;

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                imageTitle = dataTable.Rows[index]["Title"].ToString();
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
                /*
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
                */


                // This code results in an error for each cell with -1 for a price. Maybe just hide the text with a font color or something
                // for -1 values?
                /*
                if (Convert.ToDecimal(GamesDGV.Rows[index].Cells["Price"].Value) == -1)
                    GamesDGV.Rows[index].Cells["Price"].Value = "S";
                    */

            }

            try
            {
                ((DataGridViewImageColumn)GamesDGV.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                GamesDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                GamesDGV.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch { }

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
            
        }
        
        private void NewTab(int rowIndex)
        {
            try
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
            catch { }
        }

        public void AddGameTab(TabPage gameTab)
        {
            GamesTabs.Controls.Add(gameTab);
            gameTab.Tag = GamesTabs.TabPages.Count - 3;
        }

        private void GamesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { NewTab(e.RowIndex); } catch { }
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
        }

        private void GamesDGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.GamesDGV.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.GamesDGV.CurrentCell = this.GamesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
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

        /// <summary>
        /// The next section of code deals with the entry system.
        /// </summary>

        public void AddEntry()
        {
            highestId = 0;

            for (int index = 0; index < dataTable.Rows.Count; index++)
                if (highestId < Convert.ToInt32(dataTable.Rows[index]["Id"]))
                    highestId = Convert.ToInt32(dataTable.Rows[index]["Id"]);

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

            DateTime nullDT = new DateTime(1753, 1, 1, 0, 0, 0);

            string releaseDate;
            if (!ReleaseDateCheck.Checked)
                releaseDate = ReleaseDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            else
                releaseDate = nullDT.ToString("yyyy-MM-dd HH:mm:ss");

            /*
            try { con.Open(); }
            catch
            {
                File.Copy(config.databasePath, config.databasePath + ".mdf", true);
                File.Delete(config.databasePath);
                File.Copy(config.databasePath + ".mdf", config.databasePath, true);
                File.Delete(config.databasePath + ".mdf");
                con = new SqlConnection(connectionString);
                con.Open();
            }
            */

            try
            {
                insertCmd.Parameters.AddWithValue("@Id", highestId + 1);
                insertCmd.Parameters.AddWithValue("@Title", TitleBox.Text);
                insertCmd.Parameters.AddWithValue("@Platform", PlatformBox.Text);
                insertCmd.Parameters.AddWithValue("@Status", StatusBox.Text);
                insertCmd.Parameters.AddWithValue("@Rating", RatingBar.Value);
                insertCmd.Parameters.AddWithValue("@TimePlayed", timePlayed);
                insertCmd.Parameters.AddWithValue("@Seconds", totalSeconds);

                if (!ObtainedCheck.Checked)
                    insertCmd.Parameters.AddWithValue("@Obtained", ObtainedDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                else
                    insertCmd.Parameters.AddWithValue("@Obtained", nullDT.ToString("yyyy-MM-dd HH:mm:ss"));

                if (!StartDateCheck.Checked)
                    insertCmd.Parameters.AddWithValue("@StartDate", StartDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                else
                    insertCmd.Parameters.AddWithValue("@StartDate", nullDT.ToString("yyyy-MM-dd HH:mm:ss"));

                if (!LastPlayedCheck.Checked)
                    insertCmd.Parameters.AddWithValue("@LastPlayed", LastPlayedDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                else
                    insertCmd.Parameters.AddWithValue("@LastPlayed", nullDT.ToString("yyyy-MM-dd HH:mm:ss"));

                insertCmd.Parameters.AddWithValue("@Notes", NotesBox.Text);
                insertCmd.Parameters.AddWithValue("@URLs", urlString);
                insertCmd.Parameters.AddWithValue("@Filters", FiltersBox.Text);
                insertCmd.Parameters.AddWithValue("@Developers", DevelopersBox.Text);
                insertCmd.Parameters.AddWithValue("@Publishers", PublishersBox.Text);
                insertCmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);
                insertCmd.Parameters.AddWithValue("@Genre", GenreBox.Text);
                insertCmd.Parameters.AddWithValue("@PlayerCount", PlayerCountBox.Text);
                try { insertCmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(PriceBox.Text)); } catch { try { insertCmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(PriceBox.Text.Substring(1))); } catch { insertCmd.Parameters.AddWithValue("@Price", -1); } }
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

            highestId++;
            index++;
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

            if (Convert.ToDateTime(GamesDGV.Rows[rowIndex].Cells["Obtained"].Value) == new DateTime(1753, 1, 1))
                ObtainedCheck.Checked = true;
            else
                ObtainedDatePicker.Value = obtained;

            if (Convert.ToDateTime(GamesDGV.Rows[rowIndex].Cells["StartDate"].Value) == new DateTime(1753, 1, 1))
                StartDateCheck.Checked = true;
            else
                StartDatePicker.Value = startDate;
            
            if (Convert.ToDateTime(GamesDGV.Rows[rowIndex].Cells["LastPlayed"].Value) == new DateTime(1753, 1, 1))
                ReleaseDateCheck.Checked = true;
            else
                ReleaseDatePicker.Value = releaseDate;

            NotesBox.Text = GamesDGV.Rows[rowIndex].Cells["Notes"].Value.ToString();
            urlString = GamesDGV.Rows[rowIndex].Cells["URLs"].Value.ToString();

            FiltersBox.Text = GamesDGV.Rows[rowIndex].Cells["Filters"].Value.ToString();
            DevelopersBox.Text = GamesDGV.Rows[rowIndex].Cells["Developers"].Value.ToString();
            PublishersBox.Text = GamesDGV.Rows[rowIndex].Cells["Publishers"].Value.ToString();

            if (Convert.ToDateTime(GamesDGV.Rows[rowIndex].Cells["ReleaseDate"].Value) == new DateTime(1753, 1, 1))
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

            BlurCheck.Checked = Convert.ToBoolean(GamesDGV.Rows[rowIndex].Cells["Blur"].Value);
            OverlayCheck.Checked = Convert.ToBoolean(GamesDGV.Rows[rowIndex].Cells["Overlay"].Value);
            DiscordCheck.Checked = Convert.ToBoolean(GamesDGV.Rows[rowIndex].Cells["Discord"].Value);

            try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + TitleBox.Text + ".png"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + TitleBox.Text + ".jpg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + TitleBox.Text + ".jpeg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + TitleBox.Text + ".gif"); } catch { } } } }
            try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + TitleBox.Text + ".png"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + TitleBox.Text + ".jpg"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + TitleBox.Text + ".jpeg"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + TitleBox.Text + ".gif"); } catch { } } } }
            try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\bg\\" + TitleBox.Text + ".png"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + TitleBox.Text + ".jpg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + TitleBox.Text + ".jpeg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + TitleBox.Text + ".gif"); } catch { } } } }

            ReplaceButton.Visible = true;
            DeleteButton.Visible = true;

            TabPage entriesTab = GamesEntriesTab;
            GamesTabs.SelectedTab = entriesTab;
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
                price = Convert.ToDecimal(PriceBox.Text);
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

            GamesDGV.Rows[editedRow].Cells["Title"].Value = TitleBox.Text;
            GamesDGV.Rows[editedRow].Cells["Platform"].Value = PlatformBox.Text;
            GamesDGV.Rows[editedRow].Cells["Status"].Value = StatusBox.Text;
            GamesDGV.Rows[editedRow].Cells["Rating"].Value = RatingBar.Value;
            GamesDGV.Rows[editedRow].Cells["TimePlayed"].Value = timePlayed;
            GamesDGV.Rows[editedRow].Cells["Obtained"].Value = ObtainedDatePicker.Value;
            GamesDGV.Rows[editedRow].Cells["StartDate"].Value = StartDatePicker.Value;
            GamesDGV.Rows[editedRow].Cells["LastPlayed"].Value = LastPlayedDatePicker.Value;
            GamesDGV.Rows[editedRow].Cells["Developers"].Value = DevelopersBox.Text;
            GamesDGV.Rows[editedRow].Cells["Publishers"].Value = PublishersBox.Text;
            GamesDGV.Rows[editedRow].Cells["ReleaseDate"].Value = ReleaseDatePicker.Value;
            GamesDGV.Rows[editedRow].Cells["Genre"].Value = GenreBox.Text;
            GamesDGV.Rows[editedRow].Cells["PlayerCount"].Value = PlayerCountBox.Text;

            if (PriceBox.Text != "")
                GamesDGV.Rows[editedRow].Cells["Price"].Value = Convert.ToDecimal(PriceBox.Text);
            else
                GamesDGV.Rows[editedRow].Cells["Price"].Value = -1;
        }

        private void Clear()
        {
            TitleBox.Text = "";
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
            this.PictureContextMenu.Show(this.DetailsBox, e.Location);
            PictureContextMenu.Tag = "details\\";
            PictureContextMenu.Show(Cursor.Position);
        }

        private void IconBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.PictureContextMenu.Show(this.IconBox, e.Location);
            PictureContextMenu.Tag = "icons\\";
            PictureContextMenu.Show(Cursor.Position);
        }

        private void BgBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.PictureContextMenu.Show(this.BgBox, e.Location);
            PictureContextMenu.Tag = "bg\\";
            PictureContextMenu.Show(Cursor.Position);
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
                    DetailsBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + dgvForm.fileExt);
                else if (PictureContextMenu.Tag.ToString() == "bg\\")
                    BgBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + dgvForm.fileExt);
                else if (PictureContextMenu.Tag.ToString() == "icons\\")
                    IconBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + dgvForm.fileExt);
            }
        }

        private void InternetPictureButton_Click(object sender, EventArgs e)
        {
            ArrayList titleParts = new ArrayList();

            string segment = TitleBox.Text;
            string part = "";

            string url = "https://google.com/search?q=";
            while (segment.IndexOf(" ") != -1)
            {
                try
                {
                    Console.WriteLine(segment);
                    try
                    {
                        part = segment.Substring(0, segment.IndexOf(" "));
                        segment = segment.Substring(segment.IndexOf(" ") + 1);

                        url += part + "+";
                    }
                    catch { }
                }
                catch { }
                url += segment;
                segment = "";
            }
            url += "&source=lnms&tbm=isch";

            Browser browser = new Browser(url);
            DialogResult dialogResult = browser.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                string fileExt = browser.url;
                while (fileExt.IndexOf(".") != -1)
                {
                    fileExt = fileExt.Substring(fileExt.IndexOf(".") + 1);
                }

                WebClient webClient = new WebClient();
                byte[] imageBytes = webClient.DownloadData(url);

                try { File.WriteAllBytes(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + fileExt, imageBytes); } catch { File.WriteAllBytes(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + ".jpg", imageBytes); }

                if (PictureContextMenu.Tag.ToString() == "details\\")
                    DetailsBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + fileExt);
                else if (PictureContextMenu.Tag.ToString() == "bg\\")
                    BgBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + fileExt);
                else if (PictureContextMenu.Tag.ToString() == "icons\\")
                    IconBox.BackgroundImage = Image.FromFile(resourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + fileExt);
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
            int oldHrs = Convert.ToInt32(TimeHoursBox.Text);
            int oldMins = Convert.ToInt32(TimeMinutesBox.Text);
            int oldSecs = Convert.ToInt32(TimeSecondsBox.Text);

            AddTime addTime = new AddTime(this, oldHrs, oldMins, oldSecs);
            DialogResult dialogResult = addTime.ShowDialog();
            if (dialogResult == DialogResult.Yes) { }
        }

        private void GamesTabs_ControlRemoved(object sender, ControlEventArgs e)
        {
            int tabIndex = e.Control.TabIndex - 2;
            games[tabIndex].Close();
            games.RemoveAt(tabIndex);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
            
            /*
            if (File.Exists(config.databasePath + ".mdf"))
            {
                File.Delete(config.databasePath);
                File.Copy(config.databasePath + ".mdf", config.databasePath);
                File.Delete(config.databasePath + ".mdf");
            }
            */
        }

        public void UpdateTime(string timePlayed, int totalSeconds, DateTime lastPlayed, int id)
        {
            SQLiteCommand updateCmd = new SQLiteCommand("UPDATE Games SET TimePlayed = '" + timePlayed + "', Seconds = " + totalSeconds + ", LastPlayed = '" + lastPlayed.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Id = " + id + ";", con);
            updateCmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
