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

            string hString, mString, sString, dString;
            if (hours == 1)
                hString = "hour, ";
            else
                hString = "hours, ";

            if (minutes == 1)
                mString = "minute, and ";
            else
                mString = "minutes, and ";

            if (seconds == 1)
                sString = " second.";
            else
                sString = " seconds.";

            if (hours / 24 == 1)
                dString = " day.";
            else
                dString = " days.";


            TimeSummaryBox.AppendText(hours + hString + minutes + mString + seconds + sString);
            TimeSummaryBox.AppendText(Environment.NewLine);
            TimeSummaryBox.AppendText(Environment.NewLine);
            TimeSummaryBox.AppendText(totalSeconds + " total" + sString);
            TimeSummaryBox.AppendText(Environment.NewLine);

            try { mString = mString.Substring(0, 7); } catch { mString = mString.Substring(0, 6); }
            TimeSummaryBox.AppendText(totalMinutes + " total " + mString + ".");

            TimeSummaryBox.AppendText(Environment.NewLine);
            TimeSummaryBox.AppendText(Environment.NewLine);
            TimeSummaryBox.AppendText(hours / 24 + dString);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
