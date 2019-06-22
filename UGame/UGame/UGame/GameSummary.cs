using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public partial class GameSummary : Form
    {
        public GameSummary(string title, int seconds, int minutes, int hours, Image icon, DateTime startTime, DateTime endTime)
        {
            InitializeComponent();

            IconBox.BackgroundImage = icon;
            TitleLabel.Text = title;

            TimePlayedLabel.Text = "Time Played from \"" + startTime.ToString() + "\" to \"" + endTime.ToString() + "\":";

            int totalSeconds = seconds + (minutes * 60) + (hours * 3600);
            int totalMinutes = totalSeconds / 60;

            string timeSummary = hours + " hours, " + minutes + " minutes, and " + seconds + " seconds.";
            timeSummary += "\n\n" + totalSeconds + " total seconds";
            timeSummary += "\n" + totalMinutes + " total minutes";
            timeSummary += "\n\n" + hours / 24 + " days";
            
            TimeSummaryBox.Text = timeSummary;
        }
    }
}
