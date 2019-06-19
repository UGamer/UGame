using StackBlur;
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
using System.Text.RegularExpressions;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public class GameTab
    {
        MainForm refer;
        int tabIndex;
        System.Timers.Timer timer;

        int hours;
        int minutes;
        int seconds;

        string hoursString;
        string minutesString;
        string secondsString;

        static string connectionString;
        static SqlConnection con;
        public SqlCommand updateCmd;

        int rowIndex;
        public int id;
        string title;
        public string platform;
        public string status;
        public int rating;
        public string timePlayed;
        int totalSeconds;
        public DateTime obtained = new DateTime(1753, 1, 1, 0, 0, 0);
        public DateTime startDate = new DateTime(1753, 1, 1, 0, 0, 0);
        public DateTime lastPlayed = new DateTime(1753, 1, 1, 0, 0, 0);
        public string notes;
        
        public string filters;

        public string developer;
        public string publisher;
        public string releaseDate;
        public string genre;
        public string playerCount;
        public decimal price;
        public string gameDesc;

        public string urlString;
        public string[,] URLs;
        int launchCount = 0;
        string launchString;
        public string[,] launchCodes;
        bool blur;
        bool useOverlay;

        string imageTitle;

        public int screenshotCount;
        GameSummary gameSummary;

        public TabPage gameTab = new TabPage();
        PictureBox detailsBox = new PictureBox();
        PictureBox iconBox = new PictureBox();
        TextBox titleBox = new TextBox();
        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button infoButton = new Button();
        Panel infoPanel = new Panel();
        Label platformLabel = new Label();
        Label ratingLabel = new Label();
        Label timePlayedLabel = new Label();
        Button calcTimeButton = new Button();
        Label lastPlayedLabel = new Label();

        static int xPos = 14;
        Point[] labelLocation = { new Point(xPos, 21), new Point(xPos, 53), new Point(xPos, 85), new Point(xPos, 117) };

        public GameTab(MainForm refer, int rowIndex, int tabCount, int id)
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + refer.config.databasePath + "\";Integrated Security=True";
            con = new SqlConnection(connectionString);

            this.refer = refer;
            tabIndex = tabCount - 2;

            this.rowIndex = rowIndex;
            this.id = id;

            con.Open();

            title = refer.GamesDGV.Rows[rowIndex].Cells["Title"].Value.ToString();
            platform = refer.GamesDGV.Rows[rowIndex].Cells["Platform"].Value.ToString();
            status = refer.GamesDGV.Rows[rowIndex].Cells["Status"].Value.ToString();
            try { rating = Convert.ToInt32(refer.GamesDGV.Rows[rowIndex].Cells["Rating"].Value.ToString()); } catch { }
            timePlayed = refer.GamesDGV.Rows[rowIndex].Cells["TimePlayed"].Value.ToString();
            try { totalSeconds = Convert.ToInt32(refer.GamesDGV.Rows[rowIndex].Cells["Seconds"].Value.ToString()); } catch { }
            try { obtained = Convert.ToDateTime(refer.GamesDGV.Rows[rowIndex].Cells["Obtained"].Value.ToString()); } catch { }
            try { startDate = Convert.ToDateTime(refer.GamesDGV.Rows[rowIndex].Cells["StartDate"].Value.ToString()); } catch { }
            try { lastPlayed = Convert.ToDateTime(refer.GamesDGV.Rows[rowIndex].Cells["LastPlayed"].Value.ToString()); } catch { }
            notes = refer.GamesDGV.Rows[rowIndex].Cells["Notes"].Value.ToString();

            // URLs
            urlString = refer.GamesDGV.Rows[rowIndex].Cells["URLs"].Value.ToString();
            int urlCount = 0;
            string segment = urlString;
            while (segment.IndexOf("[Title]") != -1)
            {
                urlCount++;
                segment = segment.Substring(segment.IndexOf("[Title]") + 7);
            }
            URLs = new string[urlCount, 2];
            segment = urlString;
            for (int index = 0; index < urlCount; index++)
            {
                segment = segment.Substring(segment.IndexOf("[Title]") + 7);

                URLs[index, 0] = segment.Substring(0, segment.IndexOf("[URL]"));
                segment = segment.Substring(segment.IndexOf("[URL]") + 5);
                try { URLs[index, 1] = segment.Substring(0, segment.IndexOf("[Title]")); } catch { URLs[index, 1] = segment; }
                try { segment = segment.Substring(segment.IndexOf("[Title]") + 7); } catch { segment = ""; }
            }

            // FILTERS
            filters = refer.GamesDGV.Rows[rowIndex].Cells["Filters"].Value.ToString();

            developer = refer.GamesDGV.Rows[rowIndex].Cells["Developers"].Value.ToString();
            publisher = refer.GamesDGV.Rows[rowIndex].Cells["Publishers"].Value.ToString();
            releaseDate = refer.GamesDGV.Rows[rowIndex].Cells["ReleaseDate"].Value.ToString();
            genre = refer.GamesDGV.Rows[rowIndex].Cells["Genre"].Value.ToString();
            playerCount = refer.GamesDGV.Rows[rowIndex].Cells["PlayerCount"].Value.ToString();
            try { price = Convert.ToDecimal(refer.GamesDGV.Rows[rowIndex].Cells["Price"].Value.ToString()); } catch { price = -1; }
            gameDesc = refer.GamesDGV.Rows[rowIndex].Cells["GameDesc"].Value.ToString();

            // LAUNCH CODES
            launchString = refer.GamesDGV.Rows[rowIndex].Cells["Launch"].Value.ToString();
            segment = launchString;
            while (segment.IndexOf("[Title]") != -1)
            {
                launchCount++;
                segment = segment.Substring(segment.IndexOf("[Title]") + 7);
            }
            launchCodes = new string[launchCount, 2];
            segment = launchString;
            for (int index = 0; index < launchCount; index++)
            {
                segment = segment.Substring(segment.IndexOf("[Title]") + 7);

                launchCodes[index, 0] = segment.Substring(0, segment.IndexOf("[URL]"));
                segment = segment.Substring(segment.IndexOf("[URL]") + 5);
                try { launchCodes[index, 1] = segment.Substring(0, segment.IndexOf("[Title]")); } catch { launchCodes[index, 1] = segment; }
                try { segment = segment.Substring(segment.IndexOf("[Title]") + 7); } catch { segment = ""; }
            }


            try { blur = Convert.ToBoolean(refer.GamesDGV.Rows[rowIndex].Cells["Blur"].Value.ToString()); } catch { blur = true; }
            try { useOverlay = Convert.ToBoolean(refer.GamesDGV.Rows[rowIndex].Cells["Overlay"].Value.ToString()); } catch { useOverlay = true; }
            
            con.Close();


            imageTitle = title;
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

            Console.WriteLine(imageTitle);
            TabCreation();
        }

        private void TabCreation()
        {
            Image bgImage = null;
            gameTab.Text = title;
            gameTab.BackColor = Color.White;
            try { bgImage = Image.FromFile(refer.config.resourcePath + "bg\\" + imageTitle + ".png"); }
            catch { try { bgImage = Image.FromFile(refer.config.resourcePath + "bg\\" + imageTitle + ".jpg"); }
            catch { try { bgImage = Image.FromFile(refer.config.resourcePath + "bg\\" + imageTitle + ".jpeg"); }
            catch { try { bgImage = Image.FromFile(refer.config.resourcePath + "bg\\" + imageTitle + ".gif"); }
            catch { try { bgImage = Image.FromFile(refer.config.resourcePath + "bg\\" + imageTitle + ".jfif"); }
            catch { } } } } }
            try
            {
                Bitmap bg = new Bitmap(bgImage);
                if (blur)
                {
                    var radius = 20;
                    StackBlur.StackBlur.Process(bg, radius);
                }
                gameTab.BackgroundImage = bg;
                gameTab.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch { }

            detailsBox.Location = new Point(7, 7);
            detailsBox.Size = new Size(351, 351);
            try { detailsBox.BackgroundImage = Image.FromFile(refer.config.resourcePath + "details\\" + imageTitle + ".png"); }
            catch { try { detailsBox.BackgroundImage = Image.FromFile(refer.config.resourcePath + "details\\" + imageTitle + ".jpg"); }
            catch { try { detailsBox.BackgroundImage = Image.FromFile(refer.config.resourcePath + "details\\" + imageTitle + ".jpeg"); }
            catch { try { detailsBox.BackgroundImage = Image.FromFile(refer.config.resourcePath + "details\\" + imageTitle + ".gif"); }
            catch { try { detailsBox.BackgroundImage = Image.FromFile(refer.config.resourcePath + "details\\" + imageTitle + ".jfif"); }
            catch { } } } } }
            detailsBox.BackgroundImageLayout = ImageLayout.Zoom;
            detailsBox.BackColor = Color.Transparent;

            iconBox.Location = new Point(365, 7);
            iconBox.Size = new Size(68, 68);
            try { iconBox.BackgroundImage = Image.FromFile(refer.config.resourcePath + "icons\\" + imageTitle + ".png"); }
            catch { try { iconBox.BackgroundImage = Image.FromFile(refer.config.resourcePath + "icons\\" + imageTitle + ".jpg"); }
            catch { try { iconBox.BackgroundImage = Image.FromFile(refer.config.resourcePath + "icons\\" + imageTitle + ".jpeg"); }
            catch { try { iconBox.BackgroundImage = Image.FromFile(refer.config.resourcePath + "icons\\" + imageTitle + ".gif"); }
            catch { try { iconBox.BackgroundImage = Image.FromFile(refer.config.resourcePath + "icons\\" + imageTitle + ".jfif"); }
            catch { } } } } }
            iconBox.BackgroundImageLayout = ImageLayout.Zoom;
            iconBox.BackColor = Color.Transparent;


            titleBox.Location = new Point(440, 14);
            titleBox.Size = new Size(593, 68);
            titleBox.BorderStyle = BorderStyle.None;
            titleBox.Font = new Font("Century Gothic", 32);
            titleBox.Text = title;
            titleBox.ReadOnly = true;
            titleBox.BackColor = Color.White;

            button1.Location = new Point(365, 82);
            button1.Size = new Size(177, 34);
            button1.Text = "Launch & Track";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.Tag = rowIndex;
            button1.TabIndex = 0;
            button1.Click += Button1_Click;

            button2.Location = new Point(548, 82);
            button2.Size = new Size(177, 34);
            button2.Text = "Track";
            button2.UseVisualStyleBackColor = true;
            button2.Tag = rowIndex;
            button2.Click += Button2_Click;

            button3.Location = new Point(731, 82);
            button3.Size = new Size(177, 34);
            button3.Text = "Launch";
            button3.UseVisualStyleBackColor = true;
            button3.Tag = rowIndex;
            button3.Click += Button3_Click;

            infoButton.Location = new Point(958, 82);
            infoButton.Size = new Size(75, 34);
            infoButton.Text = "More Info";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Tag = rowIndex;
            infoButton.Click += InfoButton_Click;

            infoPanel.Location = new Point(365, 122);
            infoPanel.Size = new Size(668, 236);

            int locIndex = 0;
            Font labelFont = new Font("Century Gothic", 12);
            if (platform != "")
            {
                platformLabel.Location = labelLocation[locIndex];
                platformLabel.Font = labelFont;
                platformLabel.AutoSize = true;
                platformLabel.Text = "Platform: " + platform;
                locIndex++;
            }

            if (rating != 0)
            {
                ratingLabel.Location = labelLocation[locIndex];
                ratingLabel.Font = labelFont;
                ratingLabel.AutoSize = true;
                ratingLabel.Text = "Rating: ";
                for (int starNum = 0; starNum < rating; starNum++)
                    ratingLabel.Text += "★";
                for (int emptyNum = 0; emptyNum < 10 - rating; emptyNum++)
                    ratingLabel.Text += "☆";
                ratingLabel.Text += " (" + rating + "/10)";
                locIndex++;
            }

            if (timePlayed != "")
            {
                timePlayedLabel.Location = labelLocation[locIndex];
                timePlayedLabel.Font = labelFont;
                timePlayedLabel.AutoSize = true;
                timePlayedLabel.Text = "Time Played          : " + timePlayed;

                calcTimeButton.Location = new Point(116, labelLocation[locIndex].Y);
                calcTimeButton.Size = new Size(26, 26);
                calcTimeButton.UseVisualStyleBackColor = true;
                calcTimeButton.Text = "...";
                calcTimeButton.Click += CalcTimeButton_Click;

                locIndex++;
            }

            if (lastPlayed.ToString() != "1/1/0001 12:00:00 AM")
            {
                lastPlayedLabel.Location = labelLocation[locIndex];
                lastPlayedLabel.Font = labelFont;
                lastPlayedLabel.AutoSize = true;
                lastPlayedLabel.Text = "Last Played: " + lastPlayed;
            }

            gameTab.Controls.Add(detailsBox);
            gameTab.Controls.Add(iconBox);
            gameTab.Controls.Add(titleBox);
            gameTab.Controls.Add(button1);
            gameTab.Controls.Add(button2);
            gameTab.Controls.Add(button3);
            gameTab.Controls.Add(infoButton);
            gameTab.Controls.Add(infoPanel);

            infoPanel.Controls.Add(platformLabel);
            infoPanel.Controls.Add(ratingLabel);
            infoPanel.Controls.Add(timePlayedLabel);
            infoPanel.Controls.Add(calcTimeButton);
            infoPanel.Controls.SetChildIndex(calcTimeButton, 0);
            infoPanel.Controls.Add(lastPlayedLabel);

            refer.AddGameTab(gameTab);
        }
        
        public void Launch()
        {
            string launchCode = "";
            if (launchCount > 1)
            {
                LaunchChoice launchChoice = new LaunchChoice(launchCodes);
                DialogResult dialogResult = launchChoice.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    launchCode = launchCodes[launchChoice.index, 1];
                }
            }
            else
            {
                launchCode = launchCodes[0, 1];
            }

            Console.WriteLine(launchCode);

            bool isExe = false;
            bool hasArgs = false;
            ProcessStartInfo startInfo;

            if (launchCode.IndexOf(".exe") != -1)
                isExe = true;
            else if (launchCode.IndexOf(".lnk") != -1)
                isExe = true;
            else if (launchCode.IndexOf(".bat") != -1)
                isExe = true;

            try
            {
                int exeLoc = launchCode.IndexOf(".exe");
                string lookForArgs = launchCode.Substring(exeLoc);

                if (lookForArgs.IndexOf("-") != -1 && lookForArgs.IndexOf("\"") != -1)
                    hasArgs = true;
            }
            catch (ArgumentOutOfRangeException) { }

            if (isExe)
            {
                if (hasArgs)
                {
                    int getRidOfQuotes = launchCode.IndexOf("\"");
                    if (getRidOfQuotes == 0)
                    {
                        launchCode.Substring(1);
                        int secondQuote = launchCode.IndexOf("\"");
                        launchCode.Substring(0, secondQuote);
                    }
                    int exeLoc = launchCode.IndexOf(".exe");
                    string fileName = launchCode.Substring(0, exeLoc + 5);
                    string args = launchCode.Substring(exeLoc + 5);

                    startInfo = new ProcessStartInfo(fileName, args);
                }
                else
                {
                    startInfo = new ProcessStartInfo(launchCode);
                }

                Console.WriteLine(launchCode);
                Process.Start(startInfo);
            }
            else
            {
                refer.BrowserLauncher.Url = new Uri(launchCode);
            }
        }

        public void Track()
        {
            timer = new System.Timers.Timer
            {
                Interval = 1000
            };
            timer.Elapsed += Timer_Elapsed;

            timer.Start();
            hours = 0;
            minutes = 0;
            seconds = 0;

            gameTab.Text = "(...) " + title;
            SetText("Stop Playing (00h:00m:00s)", ref button1);
            SetText("Pause Playing", ref button2);
            SetText("Discard Session", ref button3);

            // OVERLAY STUFF

            /*
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            richStartTimeStamp = (int)t.TotalSeconds;
            string richPresenceConfig = "[Identifiers]\nClientID=556202672236003329\n\n[State]\nState=Playing\nDetails=" + title +
                "\nStartTimestamp=" + richStartTimeStamp + "\nEndTimestamp=\n\n\n[Images]\nLargeImage=default\nLargeImageTooltip=\nSmallImage=play\nSmallImageTooltip=";

            TextWriter tw = new StreamWriter("config.ini");
            tw.WriteLine(richPresenceConfig);
            tw.Close();

            // discordRichPresenceStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            discordRichPresenceStartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            try
            {
                discordRichPresence = Process.Start(discordRichPresenceStartInfo);
            }
            catch { }
            */
        }

        public void Stop(bool save)
        {
            if (save)
            {
                totalSeconds += seconds + (minutes * 60) + (hours * 3600);

                int hour; int min; int sec;
                
                min = totalSeconds / 60;
                sec = totalSeconds % 60;
                hour = min / 60;
                min %= 60;

                string hourString = "0"; string minString = "0"; string secString = "0";
                if (hour < 10)
                    hourString += hour;
                else
                    hourString = hour.ToString();
                hourString += "h:";
                
                if (min < 10)
                    minString += min;
                else
                    minString = min.ToString();
                minString += "m:";

                if (sec < 10)
                    secString += sec;
                else
                    secString = sec.ToString();
                secString += "s";

                timePlayed = hourString + minString + secString;

                // WRITE EVERYTHING TO THE DATABASE
                updateCmd = new SqlCommand("UPDATE Games SET TimePlayed = '" + timePlayed + "', Seconds = " + totalSeconds + ", LastPlayed = '" + DateTime.Now.ToString() + "' WHERE Id = " + id + ";", con);
                
                // WRITE EVERYTHING TO THE DATABASE
                con.Open();

                // try
                { updateCmd.ExecuteNonQuery(); }
                // catch { con.Close(); MessageBox.Show("Update to entry failed.", "Update Failed"); }
                con.Close();

                gameSummary = new GameSummary(title, totalSeconds);
                gameSummary.Show();
            }

            timer.Stop();

            gameTab.Text = title;
            
            SetText("Launch & Track", ref button1);
            SetText("Track", ref button2);
            SetText("Launch", ref button3);
        }

        private void PauseResume()
        {
            if (button2.Text == "Pause Playing")
            {
                timer.Stop();
                SetText("Resume Playing", ref button2);
            }
            else
            {
                timer.Start();
                SetText("Pause Playing", ref button2);
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            seconds++;

            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }
            if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }

            secondsString = seconds.ToString();
            minutesString = minutes.ToString();
            hoursString = hours.ToString();

            if (seconds < 10)
                secondsString = "0" + seconds;
            if (minutes < 10)
                minutesString = "0" + minutes;
            if (hours < 10)
                hoursString = "0" + hours;

            secondsString += "s";
            minutesString += "m:";
            hoursString += "h:";

            SetText("Stop Playing (" + hoursString + minutesString + secondsString + ")", ref button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Launch & Track")
            {
                Button tempButton = (Button)sender;
                int tabIndex = Convert.ToInt32(tempButton.Tag);
                Launch();
                Track();
            }
            else
            {
                Stop(true);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Track")
            {
                Button tempButton = (Button)sender;
                int tabIndex = Convert.ToInt32(tempButton.Tag);
                Track();
            }
            else
            {
                PauseResume();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Launch")
            {
                Button tempButton = (Button)sender;
                int tabIndex = Convert.ToInt32(tempButton.Tag);
                Launch();
            }
            else
            {
                Stop(false);
            }
        }

        private void InfoButton_Click(object sender, EventArgs e) // IMPROVE TO HIDE FIELDS WHEN A VALUE IS NOT WORTH SHOWING (EX: NULL, RATING = 0, etc.)
        {
            string caption = "Info on \"" + title + "\"";
            string message = "Title: " + title + "\nPlatform: " + platform + "\nStatus: " + status + "\nRating: " + rating + "\nTime Played: " + timePlayed + "\nObtained: ";
            
            if (obtained.ToString() != "1/1/1753 12:00:00 AM")
                message += obtained;

            message += "\nStarted: ";
            if (startDate.ToString() != "1/1/1753 12:00:00 AM")
                message += startDate;

            message += "\nLast Played: ";
            if (lastPlayed.ToString() != "1/1/1753 12:00:00 AM")
                message += lastPlayed;

            message += "\nNotes: " + notes + "\nFilters: " + filters + "\nDevelopers: " + developer + "\nRelease Date: " + releaseDate + "\nGenre: " + genre + "\nPublishers: " + publisher + "\nPlayer Count: " + playerCount + "\nPrice: ";

            if (price > 0)
            {
                message += "$" + price.ToString("d2");
            }
            else if (price == 0)
            {
                message += "Free";
            }

            message += "\nGame Description: " + gameDesc;

            MessageBox.Show(message, caption);
        }

        private void CalcTimeButton_Click(object sender, EventArgs e)
        {
            string caption = "Time Calculations for \"" + title + "\"";
            string message = "Total Seconds: " + totalSeconds + "\nTotal Minutes: " + totalSeconds / 60 + "\nTotal Hours: " + totalSeconds / 3600 + 
                "\nTotal Days: " + totalSeconds / 86400 + "\nTotal Weeks: " + totalSeconds / 604800 + "\nTotal Months: ~" + totalSeconds / 2592000 + 
                "\nTotal Years: " + totalSeconds / 31557600;

            MessageBox.Show(message, caption);
        }

        delegate void SetTextCallback(string text, ref Button button);

        private void SetText(string text, ref Button button)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (button1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                refer.Invoke(d, new object[] { text, button });
            }
            else
            {
                button.Text = text;
            }
        }
    }
}
