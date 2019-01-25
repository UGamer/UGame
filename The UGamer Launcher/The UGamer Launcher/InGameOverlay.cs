using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_UGamer_Launcher
{
    public partial class InGameOverlay : Form
    {
        public InGameOverlay()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }

        private void InGameOverlay_Load(object sender, EventArgs e)
        {

        }

        public void Setup(string gameTitle)
        {
            gameTitleLabel.Text = gameTitle;
        }

        public void UpdateTime(int seconds)
        {
            int minutes = seconds / 60;
            seconds %= 60;
            int hours = minutes / 60;
            minutes %= 60;

            string hoursString = Convert.ToString(hours);
            string minutesString = Convert.ToString(minutes);
            string secondsString = Convert.ToString(seconds);

            if (hours < 10)
            {
                hoursString = "0" + hours;
            }
            if (minutes < 10)
            {
                minutesString = "0" + minutes;
            }
            if (seconds < 10)
            {
                secondsString = "0" + seconds;
            }

            string currentPlaySession = "Current Play Session: " + hoursString + "h:" + minutesString + "m:" 
                + secondsString + "s";
            currentPlaySessionLabel.Text = currentPlaySession;
        }
    }
}
