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
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.IO;
using Utilities;

namespace The_UGamer_Launcher
{
    public partial class Overlay : Form
    {
        GameDetails details;

        public static bool flag = true;
        globalKeyboardHook gkh = new globalKeyboardHook();

        string title;
        string titleFriendly;
        string[,] links;
        int linkCount;

        bool overlayVisible = true;

        public System.Windows.Forms.Timer t;
        int playTimeCounter = 0;
        bool isPaused = true;
        
        BrowserWindow openBrowser;
        bool browserOpen = false;

        Notepad notes;
        bool notesOpen = false;

        int screenWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width.ToString());
        int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height.ToString());
        System.Windows.Forms.Timer screenshotTimer;
        System.Windows.Forms.Timer shiftTimer;
        globalKeyboardHook screenshotHook = new globalKeyboardHook();
        bool shiftDown = false;

        ScreenshotViewer screenshotView;
        bool screenshotsOpen = false;

        bool locked = false;

        public Overlay(string name, string[,] links, int linkCount, GameDetails details)
        {
            InitializeComponent();
            LockButton.BackgroundImage = Image.FromFile("Resources\\Theme\\Unlock.png");
            this.details = details;
            title = name;
            this.links = links;
            this.linkCount = linkCount;
            InitializeName();
            InitializeTimer();

            InitializeSystemClock();
            
            gkh.HookedKeys.Add(Keys.Tab);
            gkh.HookedKeys.Add(Keys.F2);
            screenshotHook.HookedKeys.Add(Keys.LShiftKey);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            screenshotHook.KeyDown += new KeyEventHandler(screenshotHook_KeyDown);
            screenshotHook.KeyUp += new KeyEventHandler(screenshotHook_KeyUp);
        }

        private void InitializeName()
        {
            NameLabel.Text = title;
            string input = title;
            string input2 = input;

            Regex pathFix = new Regex(@"T:\\");

            // This section fixes the title so it can be translated to an image file.
            Regex rgxFix1 = new Regex("/");
            Regex rgxFix2 = new Regex(":");
            Regex rgxFix3 = new Regex(".*");
            Regex rgxFix4 = new Regex(".?");
            Regex rgxFix5 = new Regex("\"");
            Regex rgxFix6 = new Regex("<");
            Regex rgxFix7 = new Regex(">");
            Regex rgxFix8 = new Regex("|");

            if (input2.IndexOf("\\") != -1)
                input2 = pathFix.Replace(input, "/");
            if (input2.IndexOf("/") != -1)
                input2 = rgxFix1.Replace(input2, "");
            if (input2.IndexOf(":") != -1)
                input2 = rgxFix2.Replace(input2, "");
            if (input2.IndexOf("*") != -1)
                input2 = rgxFix3.Replace(input2, "");
            if (input2.IndexOf("?") != -1)
                input2 = rgxFix4.Replace(input2, "");
            if (input2.IndexOf("\"") != -1)
                input2 = rgxFix5.Replace(input2, "");
            if (input2.IndexOf("<") != -1)
                input2 = rgxFix6.Replace(input2, "");
            if (input2.IndexOf(">") != -1)
                input2 = rgxFix7.Replace(input2, "");
            if (input2.IndexOf("|") != -1)
                input2 = rgxFix8.Replace(input2, "");

            titleFriendly = input2;
        }

        private void InitializeTimer()
        {

        }

        private void InitializeSystemClock()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_tick);
            t.Start();

            shiftTimer = new System.Windows.Forms.Timer();
            shiftTimer.Interval = 200;
            shiftTimer.Tick += new EventHandler(this.shiftTimer_tick);
        }

        private void t_tick(object sender, EventArgs e)
        {
            int startIndex = (DateTime.Now.ToString().IndexOf(" ") + 1);
            string time = DateTime.Now.ToString().Substring(startIndex);
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

        void screenshotHook_KeyDown(object sender, KeyEventArgs e)
        {
            shiftDown = true;
        }

        void screenshotHook_KeyUp(object sender, KeyEventArgs e)
        {
            shiftTimer.Start();
        }

        private void shiftTimer_tick(object sender, EventArgs e)
        {
            shiftDown = false;
            shiftTimer.Stop();
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && shiftDown == true)
            {
                if (flag)
                {
                    if (browserOpen == true && openBrowser.locked == false)
                        openBrowser.Hide();
                    if (notesOpen == true && notes.locked == false)
                        notes.Hide();
                    if (screenshotsOpen == true && screenshotView.locked == false)
                        screenshotView.Hide();

                    overlayVisible = false;

                    if (locked == false)
                        this.Hide();
                    flag = false;
                }
                else
                {
                    if (browserOpen == true && openBrowser.locked == false)
                        openBrowser.Show();
                    if (notesOpen == true && notes.locked == false)
                        notes.Show();
                    if (screenshotsOpen == true && screenshotView.locked == false)
                        screenshotView.Show();

                    overlayVisible = true;

                    if (locked == false)
                        this.Show();
                    flag = true;
                }

                e.Handled = true;
            }

            if (e.KeyCode == Keys.F2 && shiftDown == true)
            {
                try
                {
                    try { this.Hide(); }
                    catch (NullReferenceException f) { }

                    try { openBrowser.Hide(); }
                    catch (NullReferenceException f) { }

                    try { notes.Hide(); }
                    catch (NullReferenceException f) { }
                    
                    //Creating a new Bitmap object

                    Bitmap captureBitmap = new Bitmap(screenWidth, screenHeight, PixelFormat.Format32bppArgb);
                    

                    //Creating a Rectangle object which will  

                    //capture our Current Screen

                    Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

                    
                    //Creating a New Graphics Object

                    Graphics captureGraphics = Graphics.FromImage(captureBitmap);

                    
                    //Copying Image from The Screen

                    captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);


                    //Saving the Image File (I am here Saving it in My E drive).
                    
                    string folderPath = "Screenshots\\" + titleFriendly + "\\";
                    string fileName = "";
                    string dateAndTime = "";
                    int number = 1;
                    bool dupe = true;

                    for (dupe = true; dupe == true; number++)
                    {
                        fileName = "[" + titleFriendly + "] " + number;
                        dupe = File.Exists(folderPath + fileName + ".jpg");
                    }

                    dupe = true;

                    try
                    {
                        captureBitmap.Save(folderPath + fileName + ".jpg", ImageFormat.Jpeg);
                        ScreenshotLabel.Visible = true;
                        screenshotTimer = new System.Windows.Forms.Timer();
                        screenshotTimer.Interval = 2000;
                        screenshotTimer.Tick += new EventHandler(this.screenshotTimer_tick);
                        screenshotTimer.Start();
                    }
                    catch
                    {
                        Directory.CreateDirectory("Screenshots\\" + titleFriendly);
                        captureBitmap.Save(folderPath + fileName + ".jpg", ImageFormat.Jpeg);
                        ScreenshotLabel.Visible = true;
                        screenshotTimer = new System.Windows.Forms.Timer();
                        screenshotTimer.Interval = 2000;
                        screenshotTimer.Tick += new EventHandler(this.screenshotTimer_tick);
                        screenshotTimer.Start();
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

        private void screenshotTimer_tick(object sender, EventArgs e)
        {
            ScreenshotLabel.Visible = false;
            screenshotTimer.Stop();

            if (overlayVisible == false && locked == false)
            {
                try { this.Hide(); }
                catch (NullReferenceException f) { }
            }
        }

        private void BrowserButton_Click(object sender, EventArgs e)
        {
            openBrowser = new BrowserWindow(links, linkCount, title, details);
            openBrowser.Show();
            browserOpen = true;
            openBrowser.FormClosing += new FormClosingEventHandler(this.openBrowser_FormClosing);
        }

        private void openBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            browserOpen = false;
        }

        private void NotepadButton_Click(object sender, EventArgs e)
        {
            notes = new Notepad(titleFriendly);
            notes.Show();
            notesOpen = true;
            notes.FormClosing += new FormClosingEventHandler(this.notes_FormClosing);
        }

        private void notes_FormClosing(object sender, FormClosingEventArgs e)
        {
            notesOpen = false;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (isPaused == false)
                t.Stop();
            else
                t.Start();

            details.PauseTime();
            Lock();
        }

        private void Overlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            gkh.unhook();
        }

        private void ScreenshotsButton_Click(object sender, EventArgs e)
        {
            screenshotView = new ScreenshotViewer(titleFriendly);
            screenshotView.Show();
            screenshotsOpen = true;
            screenshotView.FormClosing += new FormClosingEventHandler(this.screenshotView_FormClosing);
        }

        private void screenshotView_FormClosing(object sender, FormClosingEventArgs e)
        {
            screenshotsOpen = false;
        }

        private void LockButton_Click(object sender, EventArgs e)
        {
            Lock();
        }

        private void Lock()
        {
            if (locked == false)
            {
                locked = true;
                LockButton.BackgroundImage = Image.FromFile("Resources\\Theme\\Lock.png");
            }
            else
            {
                locked = false;
                LockButton.BackgroundImage = Image.FromFile("Resources\\Theme\\Unlock.png");
            }
        }

        private void OpacityBar_ValueChanged(object sender, EventArgs e)
        {
            double opacityValue = Convert.ToDouble(OpacityBar.Value);
            opacityValue /= 100;
            this.Opacity = opacityValue;
        }
    }
}