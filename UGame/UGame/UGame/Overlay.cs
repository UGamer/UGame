using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public GameTab refer;
        DateTime now;
        Timer systemClock = new Timer();
        Timer playTimer = new Timer();

        Browser browser;
        Notes notes;
        Tasks tasks;

        string imageTitle;

        public Overlay(string title, Image icon, GameTab refer)
        {

            this.refer = refer;

            string imageTitle = title;
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
            
            InitializeComponent();

            gkh.HookedKeys.Add(Keys.Home);
            gkh.HookedKeys.Add(Keys.PrintScreen);
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
            if (e.KeyData == Keys.Home)
            {
                if (!flag)
                {
                    this.Show();
                    try { browser.Show(); } catch { }
                    try { notes.Show(); } catch { }
                }
                vanish.Start();
            }
            

            if (e.KeyData == Keys.PrintScreen)
            {
                try
                {
                    try { this.Hide(); }
                    catch (NullReferenceException f) { }

                    try { browser.Hide(); }
                    catch (NullReferenceException f) { }

                    try { notes.Hide(); }
                    catch (NullReferenceException f) { }

                    //Creating a new Bitmap object
                    int screenWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width.ToString());
                    int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height.ToString());

                    Bitmap captureBitmap = new Bitmap(screenWidth, screenHeight, PixelFormat.Format32bppArgb);


                    //Creating a Rectangle object which will  

                    //capture our Current Screen

                    Rectangle captureRectangle = Screen.AllScreens[0].Bounds;


                    //Creating a New Graphics Object

                    Graphics captureGraphics = Graphics.FromImage(captureBitmap);


                    //Copying Image from The Screen

                    captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);


                    //Saving the Image File (I am here Saving it in My E drive).
                    
                    string folderPath = "Screenshots\\" + imageTitle + "\\";
                    string fileName = "";
                    int number = 1;
                    bool dupe = true;

                    for (dupe = true; dupe == true; number++)
                    {
                        fileName = "[" + imageTitle + "] " + number;
                        dupe = File.Exists(folderPath + fileName + ".jpg");
                    }

                    dupe = true;

                    try
                    {
                        captureBitmap.Save(folderPath + fileName + ".jpg", ImageFormat.Jpeg);
                        /*
                        ScreenshotLabel.Visible = true;
                        screenshotTimer = new System.Windows.Forms.Timer();
                        screenshotTimer.Interval = 2000;
                        screenshotTimer.Tick += new EventHandler(this.screenshotTimer_tick);
                        screenshotTimer.Start();
                        */
                    }
                    catch
                    {
                        Directory.CreateDirectory("Screenshots\\" + imageTitle);
                        captureBitmap.Save(folderPath + fileName + ".jpg", ImageFormat.Jpeg);
                        /*
                        ScreenshotLabel.Visible = true;
                        screenshotTimer = new System.Windows.Forms.Timer();
                        screenshotTimer.Interval = 2000;
                        screenshotTimer.Tick += new EventHandler(this.screenshotTimer_tick);
                        screenshotTimer.Start();
                        */
                    }


                    //Displaying the Successful Result

                    try { this.Show(); }
                    catch (NullReferenceException f) { }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                e.Handled = true;
            }
        }

        private void Vanish_Tick(object sender, EventArgs e)
        {
            if (flag)
            { 
                if (this.Opacity != 0) 
                { 
                    this.Opacity -= 0.05;
                    try { browser.Opacity -= 0.05; } catch { }
                    try { notes.Opacity -= 0.05; } catch { }
                }
                else
                {
                    this.Hide();
                    try { browser.Hide(); } catch { }
                    try { notes.Hide(); } catch { }
                    flag = false;
                    vanish.Stop();
                }
            } 
            else
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.05;
                    try { browser.Opacity += 0.05; } catch { }
                    try { notes.Opacity += 0.05; } catch { }
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
                    browser = new Browser(refer.urlString, "Browser");
                    browser.Show();
                }
                catch
                {
                    browser = new Browser("https://www.google.com/", "Browser");
                    browser.Show();
                }
            }
        }

        private void NotesButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Show();
            }
            catch
            {
                notes = new Notes(refer.imageTitle, refer.refer.config.resourcePath);
                notes.Show();
            }
        }

        private void Overlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            gkh.HookedKeys.Remove(Keys.Home);
        }

        private void TasksButton_Click(object sender, EventArgs e)
        {
            string imageTitle = TitleLabel.Text;
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
                tasks.Show();
            }
            catch
            {
                tasks = new Tasks(imageTitle);
                tasks.Show();
            }
        }
    }
}
