using IGDB;
using IGDB.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.OleDb;
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

namespace UGame_Database_Convert__OLD_TO_NEW_
{
    public partial class Review : Form
    {
        Start refer;

        public SqlCommand insertCmd;
        public DataTable dataTable;

        public SqlConnection newCon; 
        
        public DataTable newTable;

        public int index = 0;
        int highestId;

        public string urlString = "";
        public string launchString = "";

        string oldResourcePath;
        public string newResourcePath;

        public Review(Start refer, DataTable newTable, SqlConnection newCon)
        {
            this.refer = refer;
            this.newTable = newTable;
            this.newCon = newCon;

            oldResourcePath = refer.oldPath.Substring(0, refer.oldPath.Length - 16) + "Resources\\";
            newResourcePath = refer.newPath.Substring(0, refer.newPath.Length - 11) + "resources\\";

            Console.WriteLine(oldResourcePath);
            Console.WriteLine(newResourcePath);

            dataTable = new DataTable();
            OleDbConnection oldCon = new OleDbConnection(refer.oldConString);
            OleDbCommand oldCmd = new OleDbCommand("SELECT * FROM Table1", oldCon);
            oldCon.Open();
            oldCmd.CommandType = CommandType.Text;
            OleDbDataAdapter da2 = new OleDbDataAdapter(oldCmd);
            da2.Fill(dataTable);
            oldCon.Close();

            SqlCommand fillNewTable = new SqlCommand("SELECT * FROM Games", newCon);
            newCon.Open();
            fillNewTable.CommandType = CommandType.Text;
            SqlDataAdapter da3 = new SqlDataAdapter(fillNewTable);
            da3.Fill(newTable);
            newCon.Close();

            if (!refer.QuickConvertCheck.Checked)
            {
                insertCmd = new SqlCommand("INSERT INTO Games ([Id], [Title], [Platform], [Status], [Rating], [TimePlayed], [Seconds], [Obtained], [StartDate], [LastPlayed], [Notes], [URLs], [Filters], [Developers], [Publishers], [ReleaseDate], [Genre], [PlayerCount], [Price], [GameDesc], [Launch], [Blur], [Overlay]) VALUES (@Id, @Title, @Platform, @Status, @Rating, @TimePlayed, @Seconds, @Obtained, @StartDate, @LastPlayed, @Notes, @URLs, @Filters, @Developers, @Publishers, @ReleaseDate, @Genre, @PlayerCount, @Price, @GameDesc, @Launch, @Blur, @Overlay);", refer.newCon);
                int index = 0;
                this.Text = "Review for \"" + dataTable.Rows[index]["Title"] + "\" (" + (index + 1) + "/" + dataTable.Rows.Count + ")";
            }
            else
            {
                insertCmd = new SqlCommand("INSERT INTO Games ([Id], [Title], [Platform], [Status], [Rating], [TimePlayed], [Seconds], [Obtained], [StartDate], [LastPlayed], [Notes], [URLs], [Launch], [Blur], [Overlay]) VALUES (@Id, @Title, @Platform, @Status, @Rating, @TimePlayed, @Seconds, @Obtained, @StartDate, @LastPlayed, @Notes, @URLs, @Launch, @Blur, @Overlay);", refer.newCon);


            }

            InitializeComponent();
        }

        /// <summary>
        /// The next section of code deals with the entry system.
        /// </summary>

        public void AddEntry(string title, string platform, string status, int rating, string hours1, string minutes1, string seconds1, DateTime obtained, DateTime startDate,
        DateTime lastPlayed, string notes, string urlString, string filters, string developers, string publishers,
        DateTime releaseDateDT, string genre, string playerCount, decimal price, string gameDesc, string launchString,
        bool blur, bool overlay, bool obtCheck, bool strCheck, bool lstCheck, bool releaseCheck)
        {
            this.Text = title;
            for (int index = 0; index < newTable.Rows.Count; index++)
                if (highestId < Convert.ToInt32(newTable.Rows[index]["Id"]))
                    highestId = Convert.ToInt32(newTable.Rows[index]["Id"]);

            int hours; int minutes; int seconds;

            string hoursString = "";
            string minutesString = "";
            string secondsString = "";

            try { hours = Convert.ToInt32(hours1); } catch { hours = 0; }
            try { minutes = Convert.ToInt32(minutes1); } catch { minutes = 0; }
            try { seconds = Convert.ToInt32(seconds1); } catch { seconds = 0; }

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
            if (!releaseCheck)
                releaseDate = releaseDateDT.ToShortDateString();
            else
                releaseDate = nullDT.ToShortDateString();

            refer.newCon.Open();

            insertCmd.Parameters.AddWithValue("@Id", highestId + 1);
            insertCmd.Parameters.AddWithValue("@Title", title);
            insertCmd.Parameters.AddWithValue("@Platform", platform);
            insertCmd.Parameters.AddWithValue("@Status", status);
            insertCmd.Parameters.AddWithValue("@Rating", rating);
            insertCmd.Parameters.AddWithValue("@TimePlayed", timePlayed);
            insertCmd.Parameters.AddWithValue("@Seconds", totalSeconds);

            if (!obtCheck)
                insertCmd.Parameters.AddWithValue("@Obtained", obtained);
            else
                insertCmd.Parameters.AddWithValue("@Obtained", nullDT);

            if (!strCheck)
                insertCmd.Parameters.AddWithValue("@StartDate", startDate);
            else
                insertCmd.Parameters.AddWithValue("@StartDate", nullDT);

            if (!lstCheck)
                insertCmd.Parameters.AddWithValue("@LastPlayed", lastPlayed);
            else
                insertCmd.Parameters.AddWithValue("@LastPlayed", nullDT);

            insertCmd.Parameters.AddWithValue("@Notes", notes);
            insertCmd.Parameters.AddWithValue("@URLs", urlString);
            insertCmd.Parameters.AddWithValue("@Filters", filters);
            insertCmd.Parameters.AddWithValue("@Developers", developers);
            insertCmd.Parameters.AddWithValue("@Publishers", publishers);
            insertCmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);
            insertCmd.Parameters.AddWithValue("@Genre", genre);
            insertCmd.Parameters.AddWithValue("@PlayerCount", playerCount);
            insertCmd.Parameters.AddWithValue("@Price", price);
            insertCmd.Parameters.AddWithValue("@GameDesc", gameDesc);
            insertCmd.Parameters.AddWithValue("@Launch", launchString);
            insertCmd.Parameters.AddWithValue("@Blur", blur.ToString());
            insertCmd.Parameters.AddWithValue("@Overlay", overlay.ToString());

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
            refer.newCon.Close();

            highestId++;

            index++;
            NextEntry();
        }

        public void NextEntry()
        {
            if (index + 1 == dataTable.Rows.Count)
            {
                MessageBox.Show("Congratulations! Your old database has sucessfully been updated for use with the new UGame.");
            }
            else
            {
                this.Text = "Review for \"" + dataTable.Rows[index]["Title"] + "\" (" + (index + 1) + "/" + dataTable.Rows.Count + ")";

                Clear();

                string playTime = dataTable.Rows[index]["PlayTime"].ToString();

                int hours = Convert.ToInt32(playTime.Substring(0, playTime.IndexOf("h")));
                int minutes = Convert.ToInt32(playTime.Substring(playTime.IndexOf("h:") + 2, 2));
                int seconds = Convert.ToInt32(playTime.Substring(playTime.IndexOf("m:") + 2, 2));

                int year; int month; int day;

                string obt = dataTable.Rows[index]["Obtained"].ToString();
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

                string str = dataTable.Rows[index]["StartDate"].ToString();
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

                string lst = dataTable.Rows[index]["EndDate"].ToString();
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

                TitleBox.Text = dataTable.Rows[index]["Title"].ToString();
                PlatformBox.Text = dataTable.Rows[index]["Platform"].ToString();
                StatusBox.Text = dataTable.Rows[index]["Status"].ToString();
                RatingBar.Value = Convert.ToInt32(dataTable.Rows[index]["Rating"]);
                if (hours != 0) TimeHoursBox.Text = hours.ToString(); else TimeHoursBox.Text = "";
                if (minutes != 0) TimeMinutesBox.Text = minutes.ToString(); else TimeMinutesBox.Text = "";
                if (seconds != 0) TimeSecondsBox.Text = seconds.ToString(); else TimeSecondsBox.Text = "";

                ObtainedCheck.Checked = false;
                StartDateCheck.Checked = false;
                LastPlayedCheck.Checked = false;

                ObtainedDatePicker.Value = DateTime.Now;
                StartDatePicker.Value = DateTime.Now;
                LastPlayedDatePicker.Value = DateTime.Now;

                if (dataTable.Rows[index]["Obtained"].ToString() == " ")
                    ObtainedCheck.Checked = true;
                else
                    ObtainedDatePicker.Value = obtained;

                if (dataTable.Rows[index]["StartDate"].ToString() == " ")
                    StartDateCheck.Checked = true;
                else
                    StartDatePicker.Value = startDate;


                if (dataTable.Rows[index]["EndDate"].ToString() == " ")
                    LastPlayedCheck.Checked = true;
                else
                    LastPlayedDatePicker.Value = lastPlayed;

                NotesBox.Text = dataTable.Rows[index]["Notes"].ToString();
                launchString = "[Title]Default[URL]" + dataTable.Rows[index]["Launch"].ToString();
                urlString = dataTable.Rows[index]["News"].ToString();
                try { DetailsBox.BackgroundImage = Image.FromFile(oldResourcePath + "\\Details\\" + TitleBox.Text + ".png"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(oldResourcePath + "\\Details\\" + TitleBox.Text + ".jpg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(oldResourcePath + "\\Details\\" + TitleBox.Text + ".jpeg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(oldResourcePath + "\\Details\\" + TitleBox.Text + ".gif"); } catch { } } } }
                try { IconBox.BackgroundImage = Bitmap.FromHicon(new Icon(oldResourcePath + "\\Icons\\" + TitleBox.Text + ".ico", new Size(48, 48)).Handle); } catch { }
                try { BgBox.BackgroundImage = Image.FromFile(oldResourcePath + "\\BG\\" + TitleBox.Text + ".png"); } catch { try { BgBox.BackgroundImage = Image.FromFile(oldResourcePath + "\\BG\\" + TitleBox.Text + ".jpg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(oldResourcePath + "\\BG\\" + TitleBox.Text + ".jpeg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(oldResourcePath + "\\BG\\" + TitleBox.Text + ".gif"); } catch { } } } }
                
            }
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            decimal price = -1;
            if (PriceBox.Text != "")
                price = Convert.ToDecimal(PriceBox.Text);

            AddEntry(TitleBox.Text, PlatformBox.Text, StatusBox.Text, RatingBar.Value, TimeHoursBox.Text,
                TimeMinutesBox.Text, TimeSecondsBox.Text, ObtainedDatePicker.Value, StartDatePicker.Value,
                LastPlayedDatePicker.Value, NotesBox.Text, urlString, FiltersBox.Text, DevelopersBox.Text,
                PublishersBox.Text, ReleaseDatePicker.Value, GenreBox.Text, PlayerCountBox.Text, price,
                GameDescBox.Text, launchString, BlurCheck.Checked, OverlayCheck.Checked, ObtainedCheck.Checked,
                StartDateCheck.Checked, LastPlayedCheck.Checked, ReleaseDateCheck.Checked);
        }

        private void SearchDatabase()
        {
            DGVForm dbForm = new DGVForm("DB", TitleBox.Text, this);
            dbForm.Show();
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
                    File.Copy(PictureDialog.FileName, newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    if (PictureContextMenu.Tag.ToString() == "details\\")
                        DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "icons\\")
                        IconBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "bg\\")
                        BgBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                }
                else if (dialogResult == DialogResult.No)
                {
                    File.Move(PictureDialog.FileName, newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    if (PictureContextMenu.Tag.ToString() == "details\\")
                        DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "icons\\")
                        IconBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "bg\\")
                        BgBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + fileExt);
                }
            }
        }
        
        private void DatabasePictureButton_Click(object sender, EventArgs e)
        {
            DGVForm dgvForm = new DGVForm("Images", PictureContextMenu.Tag.ToString(), this);
            
            if (dgvForm.ShowDialog() == DialogResult.OK)
            {
                if (PictureContextMenu.Tag.ToString() == "details\\")
                    DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + dgvForm.fileExt);
                else if (PictureContextMenu.Tag.ToString() == "bg\\")
                    BgBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + dgvForm.fileExt);
                else if (PictureContextMenu.Tag.ToString() == "icons\\")
                    IconBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + dgvForm.fileExt);
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
                    // try
                    {
                        part = segment.Substring(0, segment.IndexOf(" "));
                        segment = segment.Substring(segment.IndexOf(" ") + 1);

                        url += part + "%";
                    }
                    // catch
                    {
                        // url += segment;
                        // segment = "";
                    }
                    
                }
                catch { }
                
            }
            url += "&source=lnms&tbm=isch";


            Browser browser = new Browser(url);
            DialogResult dialogResult = browser.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                string fileExt = browser.url.Substring(browser.url.IndexOf(".") + 1);

                WebClient webClient = new WebClient();
                byte[] imageBytes = webClient.DownloadData(url);

                File.WriteAllBytes(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + fileExt, imageBytes);

                if (PictureContextMenu.Tag.ToString() == "details\\")
                    DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + fileExt);
                else if (PictureContextMenu.Tag.ToString() == "bg\\")
                    BgBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + fileExt);
                else if (PictureContextMenu.Tag.ToString() == "icons\\")
                    IconBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + fileExt);
            }
        }
    }
}
