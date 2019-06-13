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
using System.Text;
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

        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\deboltm\\Documents\\GitHub\\UGame\\UGame\\UGame\\UGame\\bin\\Debug\\UGameDB.mdf\";Integrated Security=True";
        static SqlConnection con = new SqlConnection(connectionString);
        public SqlCommand cmd;

        int rowIndex;
        public string title;
        public string platform;
        public string status;
        public int rating;
        public string timePlayed;
        public string obtainedDate;
        public string startDate;
        public string lastPlayed;
        public string notes;
        public string[] filters;

        public string developer;
        public string publisher;
        public string releaseDate;
        public string genre;
        public string playerCount;
        public string price;
        public string description;

        public string[] URLs;
        public string launchCode;

        public int screenshotCount;
        GameSummary gameSummary;

        public TabPage gameTab = new TabPage();
        PictureBox detailsBox = new PictureBox();
        PictureBox iconBox = new PictureBox();
        TextBox titleBox = new TextBox();
        Button button1 = new Button();
        Button button2 = new Button();
        Button Button3 = new Button();
        Button infoButton = new Button();

        public GameTab(MainForm refer, int rowIndex, int tabCount)
        {
            this.refer = refer;
            tabIndex = tabCount - 2;

            this.rowIndex = rowIndex;

            con.Open();


            title = refer.dataTable.Rows[rowIndex][1].ToString();
            platform = "PC";

            status = "Playing";
            rating = 10;
            timePlayed = "5000h:30m:45s";
            obtainedDate = "2011/07/11";
            startDate = "2010/06/01";
            lastPlayed = "2019/06/10";
            notes = "Best game of all time.";
            
            filters = new string[1];
            filters[0] = "Favorites";

            developer = "Mojang";
            publisher = "Microsoft";
            releaseDate = "2009/05/20";
            genre = "Adventure, Action, Sandbox";
            playerCount = "1-4";
            price = "$29.95";
            description = "";

            URLs = new string[1];
            URLs[0] = "[Title]Minecraft.net[URL]minecraft.net";

            launchCode = "C:\\Users\\deboltm\\Downloads\\Minecraft.exe";

            TabCreation();
        }

        private void TabCreation()
        {
            gameTab.Text = title;
            gameTab.BackColor = Color.White;
            try { gameTab.BackgroundImage = Image.FromFile("resources\\bg\\" + title + ".png"); }
            catch { try { gameTab.BackgroundImage = Image.FromFile("resources\\bg\\" + title + ".jpg"); }
            catch { try { gameTab.BackgroundImage = Image.FromFile("resources\\bg\\" + title + ".jpeg"); }
            catch { try { gameTab.BackgroundImage = Image.FromFile("resources\\bg\\" + title + ".gif"); }
            catch { try { gameTab.BackgroundImage = Image.FromFile("resources\\bg\\" + title + ".jfif"); }
            catch { } } } } }
            gameTab.BackgroundImageLayout = ImageLayout.Stretch;

            detailsBox.Location = new Point(7, 7);
            detailsBox.Size = new Size(351, 351);
            try { detailsBox.BackgroundImage = Image.FromFile("resources\\details\\" + title + ".png"); }
            catch { try { detailsBox.BackgroundImage = Image.FromFile("resources\\details\\" + title + ".jpg"); }
            catch { try { detailsBox.BackgroundImage = Image.FromFile("resources\\details\\" + title + ".jpeg"); }
            catch { try { detailsBox.BackgroundImage = Image.FromFile("resources\\details\\" + title + ".gif"); }
            catch { try { detailsBox.BackgroundImage = Image.FromFile("resources\\details\\" + title + ".jfif"); }
            catch { } } } } }
            detailsBox.BackgroundImageLayout = ImageLayout.Zoom;
            detailsBox.BackColor = Color.Transparent;

            iconBox.Location = new Point(365, 7);
            iconBox.Size = new Size(68, 68);
            try { iconBox.BackgroundImage = Image.FromFile("resources\\icons\\" + title + ".png"); }
            catch { try { iconBox.BackgroundImage = Image.FromFile("resources\\icons\\" + title + ".jpg"); }
            catch { try { iconBox.BackgroundImage = Image.FromFile("resources\\icons\\" + title + ".jpeg"); }
            catch { try { iconBox.BackgroundImage = Image.FromFile("resources\\icons\\" + title + ".gif"); }
            catch { try { iconBox.BackgroundImage = Image.FromFile("resources\\icons\\" + title + ".jfif"); }
            catch { } } } } }
            iconBox.BackgroundImageLayout = ImageLayout.Zoom;
            iconBox.BackColor = Color.Transparent;

            titleBox.Location = new Point(440, 7);
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

            Button3.Location = new Point(731, 82);
            Button3.Size = new Size(177, 34);
            Button3.Text = "Launch";
            Button3.UseVisualStyleBackColor = true;
            Button3.Tag = rowIndex;
            Button3.Click += Button3_Click;

            gameTab.Controls.Add(detailsBox);
            gameTab.Controls.Add(iconBox);
            gameTab.Controls.Add(titleBox);
            gameTab.Controls.Add(button1);
            gameTab.Controls.Add(button2);
            gameTab.Controls.Add(Button3);

            refer.AddGameTab(gameTab);
        }

        public void Launch()
        {
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

                if (lookForArgs.IndexOf("-") == -1 && lookForArgs.IndexOf("\"") == -1)
                    hasArgs = false;
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

            SetText("Stop Playing (00h:00m:00s)", ref button1);
            SetText("Pause Playing", ref button2);
            SetText("Discard Session", ref Button3);

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
                // WRITE EVERYTHING TO THE DATABASE

                int totalSeconds = seconds + (minutes * 60) + (hours * 3600);

                gameSummary = new GameSummary(title, totalSeconds);
                gameSummary.Show();
            }

            timer.Stop();

            SetText("Launch & Track", ref button1);
            SetText("Track", ref button2);
            SetText("Launch", ref Button3);
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
            if (Button3.Text == "Launch")
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
