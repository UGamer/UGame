using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace The_UGamer_Launcher
{
    public partial class GameDetails : Form
    {
        public GameDetails()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void DisplayInfo(string title, string platform,
            string status, string rating, string hours, string obtained,
            string startDate, string endDate, string notes, Uri launch)
        {
            noImageLabel.Visible = false;
            try
            {
                pictureBox1.BackgroundImage = Image.FromFile("Resources/" + title + ".png");
            }
            catch (FileNotFoundException e)
            {
                noImageLabel.Visible = true;
            }
            nameLabel.Text = title;
            platformLabel.Text = "Platform: " + platform;
            statusLabel.Text = "Status: " + status;
            if (rating == "")
                ratingLabel.Text = "";
            else
                ratingLabel.Text = "Rating: " + rating;
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
                notesLabel.Text = "";
            else
                notesLabel.Text = "Notes/Comments: \n" + notes;

            button1.Click += (sender, EventArgs) => { button_Click(sender, EventArgs, launch); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e, Uri launch2)
        {
            launcher.Url = launch2;
        }
    }
}
