using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace The_UGamer_Launcher
{
    public partial class GameDetails : Form
    {
        // Starts up a detail form.
        public GameDetails() 
        {
            InitializeComponent();
        }
        
        // Displays all the info for the game.
        public void DisplayInfo(string title, string input2, string platform,
            string status, string rating, string hours, string obtained,
            string startDate, string endDate, string notes, string launchString2, bool exePath2)
        { 
            noImageText.Visible = false;
            
            // This block of text determines the icon.
            try
            {
                Icon windowIcon = new Icon("Resources/Icons/" + input2 + ".ico");
                this.Icon = windowIcon;
            }
            catch (FileNotFoundException e) { }

            Image detailedPic = detailedImageAssign(input2);
            Image backgroundPic = backgroundImageAssign(input2, detailedPic);

            if (detailedPic.Width != 1)
            {
                gamePicture.BackgroundImage = detailedPic;
            }
            else
            {
                try
                {
                    if (backgroundPic.Width != 1)
                    {
                        gamePicture.BackgroundImage = backgroundPic;
                        noImageText.Visible = false;
                    }
                }
                catch (FileNotFoundException e) { }
            }

            if (backgroundPic.Width != 1)
            {
                try
                {
                    Bitmap bg = new Bitmap(backgroundPic);
                    var radius = 20;
                    StackBlur.StackBlur.Process(bg, radius);
                    this.BackgroundImage = bg;
                }
                catch (FileNotFoundException f)
                {
                    try
                    {
                        Bitmap bg = new Bitmap(detailedPic);
                        var radius = 20;
                        StackBlur.StackBlur.Process(bg, radius);
                        this.BackgroundImage = bg;
                    }
                    catch (FileNotFoundException g) { }
                }
            }

            nameLabel.Text = title; // Displays the name of the game.
            platformLabel.Text = "Platform: " + platform;
            statusLabel.Text = "Status: " + status;
            if (rating == "")
                ratingLabel.Text = "";
            else
                ratingLabel.Text = "Rating: " + rating + "/10";
            hoursLabel.Text = "Hours: " + hours;
            if (obtained == "")
                obtainedLabel.Text = "";
            else
                obtainedLabel.Text = "Obtained: " + obtained;
            if (startDate == "")
                startDateLabel.Text = "";
            else
                startDateLabel.Text = "Start Date: " + startDate;
            if (endDate == "")
                endDateLabel.Text = "";
            else
                endDateLabel.Text = "End Date: " + endDate;
            if (notes == "")
                notesBox.Text = "";
            else
                notesBox.Text = notes;

            if (launchString2 == "")
                button1.Visible = false;

            button1.Click += (sender, EventArgs) => { button_Click(sender, EventArgs, launchString2, exePath2); }; // This passes the launch URL to the launch button.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e, String launchString3, bool exePath3)
        {
            if (exePath3 == true)
            {
                Process.Start(launchString3);
            }
            else
            {
                Uri launch2;
                launch2 = new Uri(launchString3);
                launcher.Url = launch2; // The game launches through URL.
            }
        }

        private Image detailedImageAssign(string input2)
        {
            Image background;
            try
            {
                background = Image.FromFile("Resources/Details/" + input2 + ".png");
                return background;
            }
            catch (FileNotFoundException e)
            {
                try
                {
                    background = Image.FromFile("Resources/Details/" + input2 + ".jpg");
                    return background;
                }
                catch (FileNotFoundException f)
                {
                    try
                    {
                        background = Image.FromFile("Resources/Details/" + input2 + ".jpeg");
                        return background;
                    }
                    catch (FileNotFoundException g)
                    {
                        try
                        {
                           background = Image.FromFile("Resources/Details/" + input2 + ".gif");
                            return background;
                        }
                        catch (FileNotFoundException h)
                        {
                            noImageText.Text = "Image \"" + input2 + "\" not found.";
                            noImageText.Visible = true;
                            return background = Image.FromFile("Resources/DONT TOUCH.png");
                        }
                    }
                }
            }

        }

        private Bitmap backgroundImageAssign(string input2, Image backup)
        {
            Image background;
            Bitmap bg;
            try
            {
                background = Image.FromFile("Resources/BG/" + input2 + ".png");
                bg = new Bitmap(background);
                return bg;
            }
            catch (FileNotFoundException e)
            {
                try
                {
                    background = Image.FromFile("Resources/BG/" + input2 + ".jpg");
                    bg = new Bitmap(background);
                    return bg;
                }
                catch (FileNotFoundException f)
                {
                    try
                    {
                        background = Image.FromFile("Resources/BG/" + input2 + ".jpeg");
                        bg = new Bitmap(background);
                        return bg;
                    }
                    catch (FileNotFoundException g)
                    {
                        try
                        {
                            background = Image.FromFile("Resources/BG/" + input2 + ".gif");
                            bg = new Bitmap(background);
                            return bg;
                        }
                        catch (FileNotFoundException h)
                        {
                            bg = new Bitmap(backup);
                            return bg;
                        }
                    }
                }
            }
        }
    }
}
