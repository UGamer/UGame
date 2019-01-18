using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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
            string startDate, string endDate, string notes, Uri launch)
        { 
            noImageText.Visible = false;
            
            try
            {
                Icon windowIcon = new Icon("Resources/Icons/" + input2 + ".ico");
                this.Icon = windowIcon;
            }
            // This catchs the exception for when there is no icon.
            catch (FileNotFoundException e)
            {
                
            }

            try
            {
                gamePicture.BackgroundImage = Image.FromFile("Resources/Details/" + input2 + ".png");
            }
            // This catchs the exception for when there is no image.
            catch (FileNotFoundException e)
            {
                noImageText.Text = "Image \"" + input2 + "\" not found.";
                noImageText.Visible = true;
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

            button1.Click += (sender, EventArgs) => { button_Click(sender, EventArgs, launch); }; // This passes the launch URL to the launch button.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e, Uri launch2)
        {
            launcher.Url = launch2; // The game launches through URL.
        }
    }
}
