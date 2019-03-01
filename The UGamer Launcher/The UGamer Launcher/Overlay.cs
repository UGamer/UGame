using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Utilities;

namespace The_UGamer_Launcher
{
    public partial class Overlay : Form
    {
        public static bool flag = true;
        globalKeyboardHook gkh = new globalKeyboardHook();
        string title;
        string[,] links;
        int linkCount;

        int playTimeCounter = 0;
        
        BrowserWindow openBrowser;
        bool browserOpen = false;

        public Overlay(string name, string[,] links, int linkCount)
        {
            
            InitializeComponent();
            title = name;
            this.links = links;
            this.linkCount = linkCount;
            InitializeName();
            InitializeTimer();

            InitializeSystemClock();
            
            gkh.HookedKeys.Add(Keys.Home);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
        }

        private void InitializeName()
        {
            NameLabel.Text = title;
        }

        private void InitializeTimer()
        {

        }

        private void InitializeSystemClock()
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_tick);
            t.Start();
        }

        private void t_tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString().Substring(10);
            SystemTime.Text = time;

            playTimeCounter++;

            int minutes = playTimeCounter / 60;
            int seconds = playTimeCounter % 60;
            int hours = minutes / 60;
            minutes %= 60;

            string hoursString = "", minutesString = "", secondsString = "";

            if (hours < 10)
                hoursString += "0" + hours;
            else
                hoursString = hours.ToString();

            if (minutes < 10)
                minutesString += "0" + minutes;
            else
                minutesString = minutes.ToString();

            if (seconds < 10)
                secondsString += "0" + seconds;
            else
                secondsString = seconds.ToString();

            string playTime = "Current Time Playing: " + hoursString + "h:" + minutesString + "m:" + secondsString + "s";
            TimeLabel.Text = playTime;
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                if (flag)
                {
                    if (browserOpen == true)
                        openBrowser.Hide();
                    this.Hide();
                    flag = false;
                }
                else
                {
                    if (browserOpen == true)
                        openBrowser.Show();
                    this.Show();
                    flag = true;
                }

                e.Handled = true;
            }
        }

        private void BrowserButton_Click(object sender, EventArgs e)
        {
            openBrowser = new BrowserWindow(links, linkCount);
            openBrowser.Show();
            browserOpen = true;
        }

        private void Overlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            gkh.unhook();
        }
    }
}
