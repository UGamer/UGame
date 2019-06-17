using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public partial class MainForm : Form
    {
        public List<GameTab> games = new List<GameTab>();
        public GameTab game;
        public WebBrowser BrowserLauncher = new WebBrowser();
        public int index = 0;
        int highestId;
        public string mdfPath;
        public static string connectionString;
        static SqlConnection con;
        public SqlCommand selectCmd;
        public SqlCommand insertCmd;
        public DataTable dataTable;

        int rowIndex;
        int currentRow = 0;

        public string urlString = "";
        public string launchString = "";
        
        public string resourcePath = "resources\\";

        public MainForm()
        {
            if (!Directory.Exists("resources"))
                Directory.CreateDirectory("resources");
            if (!Directory.Exists("resources\\details"))
                Directory.CreateDirectory("resources\\details");
            if (!Directory.Exists("resources\\icons"))
                Directory.CreateDirectory("resources\\icons");
            if (!Directory.Exists("resources\\bg"))
                Directory.CreateDirectory("resources\\bg");
            
            Uri location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            mdfPath = new FileInfo(location.AbsolutePath).Directory.FullName + "\\UGameDB.mdf";
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + mdfPath + "\";Integrated Security=True";
            con = new SqlConnection(connectionString);

            selectCmd = new SqlCommand("SELECT * FROM Games", con);
            insertCmd = new SqlCommand("INSERT INTO Games ([Id], [Title], [Platform], [Status], [Rating], [TimePlayed], [Seconds], [Obtained], [StartDate], [LastPlayed], [Notes], [URLs], [Filters], [Developers], [Publishers], [ReleaseDate], [Genre], [PlayerCount], [Price], [GameDesc], [Launch], [Blur], [Overlay]) VALUES (@Id, @Title, @Platform, @Status, @Rating, @TimePlayed, @Seconds, @Obtained, @StartDate, @LastPlayed, @Notes, @URLs, @Filters, @Developers, @Publishers, @ReleaseDate, @Genre, @PlayerCount, @Price, @GameDesc, @Launch, @Blur, @Overlay);", con);
            
            InitializeComponent();
            FillDGV();
        }

        private void FillDGV()
        {
            con.Open();
            selectCmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(selectCmd);
            dataTable = new DataTable();
            dataTable.Columns.Add(" ", typeof(Image));
            da.Fill(dataTable);
            con.Close();
            
            // TEMPORARY DATA FOR TESTING
            DataRow dataRow = dataTable.NewRow();
            dataRow[0] = Image.FromFile("resources\\icons\\Minecraft.png");
            dataRow["Id"] = 0;
            dataRow["Title"] = "Minecraft";
            dataRow["Platform"] = "PC";
            dataRow["Status"] = "Playing";
            dataRow["Rating"] = 9;
            dataRow["TimePlayed"] = "5000h:00m:00s";
            dataRow["Seconds"] = 18000000;
            dataRow["Obtained"] = new DateTime(1753, 1, 1);
            dataRow["LastPlayed"] = DateTime.Now;

            dataTable.Rows.Add(dataRow);
            // TEMPORARY DATA FOR TESTING


            GamesDGV.DataSource = dataTable;
            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                try { GamesDGV.Rows[index].Cells[0].Value = Image.FromFile("resources\\icons\\" + dataTable.Rows[index]["Title"] + ".png"); } catch { GamesDGV.Rows[index].Cells[0].Value = Image.FromFile("resources\\unknown.png"); }

                
                if (GamesDGV.Rows[index].Cells["Obtained"].Value.ToString() == "1/1/1753")
                    GamesDGV.Rows[index].Cells["Obtained"].Value = DateTime.Now;
            }

            ((DataGridViewImageColumn)GamesDGV.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            GamesDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesDGV.Columns["Id"].Visible = false;
            GamesDGV.Columns["Seconds"].Visible = false;
            GamesDGV.Columns["Notes"].Visible = false;
            GamesDGV.Columns["URLs"].Visible = false;
            GamesDGV.Columns["Filters"].Visible = false;
            GamesDGV.Columns["GameDesc"].Visible = false;
            GamesDGV.Columns["Launch"].Visible = false;
            GamesDGV.Columns["Blur"].Visible = false;
            GamesDGV.Columns["Overlay"].Visible = false;
        }
        
        private void NewTab(int rowIndex)
        {
            // try
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
            // catch { }
        }

        public void AddGameTab(TabPage gameTab)
        {
            GamesTabs.Controls.Add(gameTab);
            gameTab.Tag = GamesTabs.TabPages.Count - 3;
        }

        private void GamesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NewTab(e.RowIndex);
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
                releaseDate = ReleaseDatePicker.Value.ToShortDateString();
            else
                releaseDate = nullDT.ToShortDateString();

            con.Open();
            
            insertCmd.Parameters.AddWithValue("@Id", highestId + 1);
            insertCmd.Parameters.AddWithValue("@Title", TitleBox.Text);
            insertCmd.Parameters.AddWithValue("@Platform", PlatformBox.Text);
            insertCmd.Parameters.AddWithValue("@Status", StatusBox.Text);
            insertCmd.Parameters.AddWithValue("@Rating", RatingBar.Value);
            insertCmd.Parameters.AddWithValue("@TimePlayed", timePlayed);
            insertCmd.Parameters.AddWithValue("@Seconds", totalSeconds);

            if (!ObtainedCheck.Checked)
                insertCmd.Parameters.AddWithValue("@Obtained", ObtainedDatePicker.Value);
            else
                insertCmd.Parameters.AddWithValue("@Obtained", nullDT);

            if (!StartDateCheck.Checked)
                insertCmd.Parameters.AddWithValue("@StartDate", StartDatePicker.Value);
            else
                insertCmd.Parameters.AddWithValue("@StartDate", nullDT);

            if (!LastPlayedCheck.Checked)
                insertCmd.Parameters.AddWithValue("@LastPlayed", LastPlayedDatePicker.Value);
            else
                insertCmd.Parameters.AddWithValue("@LastPlayed", nullDT);

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

            insertCmd.ExecuteNonQuery();

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
            con.Close();

            highestId++;
            index++;
        }

        public void EditEntry(int rowIndex)
        {
            Clear();

            string playTime = dataTable.Rows[rowIndex]["TimePlayed"].ToString();

            int hours = Convert.ToInt32(playTime.Substring(0, playTime.IndexOf("h")));
            int minutes = Convert.ToInt32(playTime.Substring(playTime.IndexOf("h:") + 2, 2));
            int seconds = Convert.ToInt32(playTime.Substring(playTime.IndexOf("m:") + 2, 2));

            int year; int month; int day;

            string obt = dataTable.Rows[rowIndex]["Obtained"].ToString();
            try
            {
                year = Convert.ToInt32(obt.Substring(0, 4));
                month = Convert.ToInt32(obt.Substring(5, 2));
                day = Convert.ToInt32(obt.Substring(8, 2));
            }
            catch
            {
                year = DateTime.Now.Year;
                month = DateTime.Now.Month;
                day = DateTime.Now.Day;
            }
            DateTime obtained = new DateTime(year, month, day);

            string str = dataTable.Rows[rowIndex]["StartDate"].ToString();
            try
            {
                year = Convert.ToInt32(str.Substring(0, 4));
                month = Convert.ToInt32(str.Substring(5, 2));
                day = Convert.ToInt32(str.Substring(8, 2));
            }
            catch
            {
                year = DateTime.Now.Year;
                month = DateTime.Now.Month;
                day = DateTime.Now.Day;
            }
            DateTime startDate = new DateTime(year, month, day);

            string lst = dataTable.Rows[rowIndex]["LastPlayed"].ToString();
            try
            {
                year = Convert.ToInt32(lst.Substring(0, 4));
                month = Convert.ToInt32(lst.Substring(5, 2));
                day = Convert.ToInt32(lst.Substring(8, 2));
            }
            catch
            {
                year = DateTime.Now.Year;
                month = DateTime.Now.Month;
                day = DateTime.Now.Day;
            }
            DateTime lastPlayed = new DateTime(year, month, day);

            TitleBox.Text = dataTable.Rows[rowIndex]["Title"].ToString();
            PlatformBox.Text = dataTable.Rows[rowIndex]["Platform"].ToString();
            StatusBox.Text = dataTable.Rows[rowIndex]["Status"].ToString();
            RatingBar.Value = Convert.ToInt32(dataTable.Rows[rowIndex]["Rating"]);
            if (hours != 0) TimeHoursBox.Text = hours.ToString(); else TimeHoursBox.Text = "";
            if (minutes != 0) TimeMinutesBox.Text = minutes.ToString(); else TimeMinutesBox.Text = "";
            if (seconds != 0) TimeSecondsBox.Text = seconds.ToString(); else TimeSecondsBox.Text = "";

            ObtainedCheck.Checked = false;
            StartDateCheck.Checked = false;
            LastPlayedCheck.Checked = false;

            ObtainedDatePicker.Value = DateTime.Now;
            StartDatePicker.Value = DateTime.Now;
            LastPlayedDatePicker.Value = DateTime.Now;

            if (dataTable.Rows[rowIndex]["Obtained"].ToString() == " ")
                ObtainedCheck.Checked = true;
            else
                ObtainedDatePicker.Value = obtained;

            if (dataTable.Rows[rowIndex]["StartDate"].ToString() == " ")
                StartDateCheck.Checked = true;
            else
                StartDatePicker.Value = startDate;
            
            if (dataTable.Rows[rowIndex]["LastPlayed"].ToString() == " ")
                LastPlayedCheck.Checked = true;
            else
                LastPlayedDatePicker.Value = lastPlayed;

            NotesBox.Text = dataTable.Rows[rowIndex]["Notes"].ToString();
            launchString = "[Title]Default[URL]" + dataTable.Rows[rowIndex]["Launch"].ToString();
            urlString = dataTable.Rows[index]["URLs"].ToString();
            try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + TitleBox.Text + ".png"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + TitleBox.Text + ".jpg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + TitleBox.Text + ".jpeg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(resourcePath + "\\details\\" + TitleBox.Text + ".gif"); } catch { } } } }
            try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + TitleBox.Text + ".png"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + TitleBox.Text + ".jpg"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + TitleBox.Text + ".jpeg"); } catch { try { IconBox.BackgroundImage = Image.FromFile(resourcePath + "\\icons\\" + TitleBox.Text + ".gif"); } catch { } } } }
            try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\bg\\" + TitleBox.Text + ".png"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + TitleBox.Text + ".jpg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + TitleBox.Text + ".jpeg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(resourcePath + "\\BG\\" + TitleBox.Text + ".gif"); } catch { } } } }

            TabPage entriesTab = GamesEntriesTab;
            GamesTabs.SelectedTab = entriesTab;
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

        
        
    }
}
