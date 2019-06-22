using IGDB;
using IGDB.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame_Database_Convert__OLD_TO_NEW_
{
    public partial class Review : Form
    {
        Start refer;

        public SQLiteCommand insertCmd;
        public DataTable dataTable;

        public SQLiteConnection newCon; 
        
        public DataTable newTable;

        public int index = -1;
        int highestId;

        public string urlString = "";
        public string launchString = "";

        string oldResourcePath;
        public string newResourcePath;
        public string imageTitle;

        public bool titleLock = true;
        public bool platformLock = true;

        public Review(Start refer, DataTable newTable, SQLiteConnection newCon)
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

            SQLiteCommand fillNewTable = new SQLiteCommand("SELECT * FROM Games", newCon);
            newCon.Open();
            fillNewTable.CommandType = CommandType.Text;
            SQLiteDataAdapter da3 = new SQLiteDataAdapter(fillNewTable);
            da3.Fill(newTable);
            newCon.Close();

            if (!refer.QuickConvertCheck.Checked)
            {
                insertCmd = new SQLiteCommand("INSERT INTO Games ([Id], [Title], [Platform], [Status], [Rating], [TimePlayed], [Seconds], [Obtained], [StartDate], [LastPlayed], [Notes], [URLs], [Filters], [Developers], [Publishers], [ReleaseDate], [Genre], [PlayerCount], [Price], [GameDesc], [Launch], [Blur], [Overlay], [Discord]) VALUES (@Id, @Title, @Platform, @Status, @Rating, @TimePlayed, @Seconds, @Obtained, @StartDate, @LastPlayed, @Notes, @URLs, @Filters, @Developers, @Publishers, @ReleaseDate, @Genre, @PlayerCount, @Price, @GameDesc, @Launch, @Blur, @Overlay, @Discord);", refer.newCon);
                int index = 0;
                this.Text = "Review for \"" + dataTable.Rows[index]["Title"] + "\" (" + (index + 1) + "/" + dataTable.Rows.Count + ")";
            }
            else
            {
                insertCmd = new SQLiteCommand("INSERT INTO Games ([Id], [Title], [Platform], [Status], [Rating], [TimePlayed], [Seconds], [Obtained], [StartDate], [LastPlayed], [Notes], [URLs], [Launch], [Blur], [Overlay]) VALUES (@Id, @Title, @Platform, @Status, @Rating, @TimePlayed, @Seconds, @Obtained, @StartDate, @LastPlayed, @Notes, @URLs, @Launch, @Blur, @Overlay);", refer.newCon);


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

            if (!releaseCheck)
                insertCmd.Parameters.AddWithValue("@ReleaseDate", releaseDateDT);
            else
                insertCmd.Parameters.AddWithValue("@ReleaseDate", nullDT);

            insertCmd.Parameters.AddWithValue("@Genre", genre);
            insertCmd.Parameters.AddWithValue("@PlayerCount", playerCount);
            insertCmd.Parameters.AddWithValue("@Price", price);
            insertCmd.Parameters.AddWithValue("@GameDesc", gameDesc);
            insertCmd.Parameters.AddWithValue("@Launch", launchString);
            insertCmd.Parameters.AddWithValue("@Blur", blur.ToString());
            insertCmd.Parameters.AddWithValue("@Overlay", overlay.ToString());
            insertCmd.Parameters.AddWithValue("@Discord", "True");

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
            insertCmd.Parameters.RemoveAt("@Discord");
            refer.newCon.Close();

            highestId++;
            
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
                index++;
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

                if (dataTable.Rows[index]["Obtained"].ToString() == " " || dataTable.Rows[index]["Obtained"].ToString() ==  "")
                    ObtainedCheck.Checked = true;
                else
                    ObtainedDatePicker.Value = obtained;

                if (dataTable.Rows[index]["StartDate"].ToString() == " " || dataTable.Rows[index]["StartDate"].ToString() == "")
                    StartDateCheck.Checked = true;
                else
                    StartDatePicker.Value = startDate;


                if (dataTable.Rows[index]["EndDate"].ToString() == " " || dataTable.Rows[index]["EndDate"].ToString() == "")
                    LastPlayedCheck.Checked = true;
                else
                    LastPlayedDatePicker.Value = lastPlayed;

                NotesBox.Text = dataTable.Rows[index]["Notes"].ToString();
                launchString = "[Title]Default[URL]" + dataTable.Rows[index]["Launch"].ToString();
                urlString = dataTable.Rows[index]["News"].ToString();
                

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

                try { DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + "\\details\\" + imageTitle + ".png"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + "\\details\\" + imageTitle + ".jpg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + "\\details\\" + imageTitle + ".jpeg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + "\\details\\" + imageTitle + ".gif"); } catch { } } } }
                try { IconBox.BackgroundImage = Image.FromFile(newResourcePath + "\\icons\\" + imageTitle + ".png"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + "\\icons\\" + imageTitle + ".jpg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + "\\icons\\" + imageTitle + ".jpeg"); } catch { try { DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + "\\icons\\" + imageTitle + ".gif"); } catch { } } } }
                try { BgBox.BackgroundImage = Image.FromFile(newResourcePath + "\\bg\\" + imageTitle + ".png"); } catch { try { BgBox.BackgroundImage = Image.FromFile(newResourcePath + "\\bg\\" + imageTitle + ".jpg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(newResourcePath + "\\bg\\" + imageTitle + ".jpeg"); } catch { try { BgBox.BackgroundImage = Image.FromFile(newResourcePath + "\\bg\\" + imageTitle + ".gif"); } catch { } } } }
            }
        }

        private void Clear()
        {
            titleLock = true;
            platformLock = true;
            LockTitleButton.BackgroundImage = UGame_Database_Convert__OLD_TO_NEW_.Properties.Resources.Lock;
            LockPlatformButton.BackgroundImage = UGame_Database_Convert__OLD_TO_NEW_.Properties.Resources.Lock;
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
            ReleaseDateCheck.Checked = false;
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

        private void ClearPictureBox()
        {
            if (PictureContextMenu.Tag.ToString() == "details\\")
                DetailsBox.BackgroundImage = null;
            else if (PictureContextMenu.Tag.ToString() == "icons\\")
                IconBox.BackgroundImage = null;
            else if (PictureContextMenu.Tag.ToString() == "bg\\")
                BgBox.BackgroundImage = null;
        }

        private void ClearPictureButton_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
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
                    File.Copy(PictureDialog.FileName, newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + fileExt);
                    if (PictureContextMenu.Tag.ToString() == "details\\")
                        DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "icons\\")
                        IconBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "bg\\")
                        BgBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + fileExt);
                }
                else if (dialogResult == DialogResult.No)
                {
                    File.Move(PictureDialog.FileName, newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + fileExt);
                    if (PictureContextMenu.Tag.ToString() == "details\\")
                        DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "icons\\")
                        IconBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + fileExt);
                    else if (PictureContextMenu.Tag.ToString() == "bg\\")
                        BgBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + fileExt);
                }
            }
        }
        
        private void DatabasePictureButton_Click(object sender, EventArgs e)
        {
            DGVForm dgvForm = new DGVForm("Images", PictureContextMenu.Tag.ToString(), this);
            dgvForm.WindowState = FormWindowState.Maximized;

            if (dgvForm.ShowDialog() == DialogResult.OK)
            {

                if (PictureContextMenu.Tag.ToString() == "details\\")
                    DetailsBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + "." + dgvForm.fileExt);
                else if (PictureContextMenu.Tag.ToString() == "bg\\")
                    BgBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + "." + dgvForm.fileExt);
                else if (PictureContextMenu.Tag.ToString() == "icons\\")
                    IconBox.BackgroundImage = Image.FromFile(newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + "." + dgvForm.fileExt);
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
            if (PictureContextMenu.Tag.ToString() == "icons\\")
                url += "+icon";

            url += "&source=lnms&tbm=isch";
            
            Browser browser = new Browser(url);
            browser.WindowState = FormWindowState.Maximized;
            DialogResult dialogResult = browser.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                string fileExt = browser.url;
                while (fileExt.IndexOf(".") != -1)
                {
                    fileExt = fileExt.Substring(fileExt.IndexOf(".") + 1);
                }

                string filePath = newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + "." + fileExt;
                using (var client = new WebClient())
                {
                    try { client.DownloadFile(browser.url, filePath); } catch { filePath = newResourcePath + PictureContextMenu.Tag.ToString() + imageTitle + ".jpg"; client.DownloadFile(browser.url, filePath); }
                }

                // File.WriteAllBytes(newResourcePath + PictureContextMenu.Tag.ToString() + TitleBox.Text + "." + fileExt, imageBytes);
                
                if (PictureContextMenu.Tag.ToString() == "details\\")
                    DetailsBox.BackgroundImage = Image.FromFile(filePath);
                else if (PictureContextMenu.Tag.ToString() == "bg\\")
                    BgBox.BackgroundImage = Image.FromFile(filePath);
                else if (PictureContextMenu.Tag.ToString() == "icons\\")
                    IconBox.BackgroundImage = Image.FromFile(filePath);
            }
        }

        private void LockButton_Click(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;

            if (tempButton.Tag.ToString() == "Title")
            {
                if (titleLock)
                {
                    titleLock = false;
                    LockTitleButton.BackgroundImage = UGame_Database_Convert__OLD_TO_NEW_.Properties.Resources.Unlock;
                }
                else
                {
                    titleLock = true;
                    LockTitleButton.BackgroundImage = UGame_Database_Convert__OLD_TO_NEW_.Properties.Resources.Lock;
                }
            }

            if (tempButton.Tag.ToString() == "Platform")
            {
                if (platformLock)
                {
                    platformLock = false;
                    LockPlatformButton.BackgroundImage = UGame_Database_Convert__OLD_TO_NEW_.Properties.Resources.Unlock;
                }
                else
                {
                    platformLock = true;
                    LockPlatformButton.BackgroundImage = UGame_Database_Convert__OLD_TO_NEW_.Properties.Resources.Lock;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NextEntry();
        }

        private void IndexButton_Click(object sender, EventArgs e)
        {
            int newIndex = Convert.ToInt32(IndexBox.Text);

            for (; index < newIndex - 1;)
            {
                NextEntry();
            }
        }
    }
}
