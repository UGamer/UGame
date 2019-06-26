using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace UGame
{
    public partial class Overlay : Form
    {
        globalKeyboardHook gkh = new globalKeyboardHook();
        static bool flag = true;
        Timer vanish = new Timer();

        GameTab refer;
        DateTime now;
        Timer systemClock = new Timer();
        Timer playTimer = new Timer();

        Browser browser;

        public Overlay(string title, Image icon, GameTab refer)
        {
            this.refer = refer;
            
            InitializeComponent();

            gkh.HookedKeys.Add(Keys.Home);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);

            vanish.Interval = 1;
            vanish.Tick += Vanish_Tick;

            TitleLabel.Text = title;
            IconBox.BackgroundImage = icon;
            if (icon == null)
                IconBox.BackgroundImage = Image.FromFile(refer.refer.config.resourcePath + "unknown.png");

            now = DateTime.Now;
            ClockLabel.Text = now.ToString("h:mm:ss tt");
            systemClock.Interval = 1000;
            systemClock.Tick += SystemClock_Tick;
            systemClock.Start();
            DateLabel.Text = now.ToString("dddd, MMMM d yyyy");

            playTimer.Interval = 1000;
            playTimer.Tick += PlayTimer_Tick;
            playTimer.Start();
        }
        
        private void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (!flag)
            {
                this.Show();
                try { browser.Show(); } catch { }
            }

            vanish.Start();
        }

        private void Vanish_Tick(object sender, EventArgs e)
        {
            if (flag)
            { 
                if (this.Opacity != 0) 
                { 
                    this.Opacity -= 0.05;
                }
                else
                {
                    this.Hide();
                    try { browser.Hide(); } catch { }
                    flag = false;
                    vanish.Stop();
                }
            } 
            else
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    flag = true;
                    vanish.Stop();
                }
            }
        }

        private void SystemClock_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            ClockLabel.Text = now.ToString("h:mm:ss tt");

            if (ClockLabel.Text == "12:00:00 AM")
                DateLabel.Text = now.ToString("dddd, MMMM d yyyy");
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            string timePlayed = refer.button1.Text.Substring(14);
            try { TimerBox.Text = timePlayed.Substring(0, timePlayed.Length - 1); } catch { playTimer.Stop(); }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            refer.PauseResume();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to save this play session?", "Stopping Session", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                refer.Stop(true);
            }
            else if (dialogResult == DialogResult.No)
            {
                refer.Stop(false);
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
        }

        private void WebBrowserButton_Click(object sender, EventArgs e)
        {
            try
            {
                browser.Show();
            }
            catch
            {
                try
                {
                    Console.WriteLine(refer.urlString);
                    browser = new Browser(refer.urlString);
                    browser.Show();
                }
                catch
                {
                    browser = new Browser("https://www.google.com/");
                    browser.Show();
                }
            }
        }

        private void Overlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            gkh.HookedKeys.Remove(Keys.Home);
        }
    }
}
