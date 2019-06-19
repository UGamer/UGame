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
    public partial class AddTime : Form
    {
        int oldHrs, oldMins, oldSecs;
        int newHrs, newMins, newSecs;
        public int hrs = 0;
        public int mins = 0;
        public int secs = 0;
        MainForm refer;

        public AddTime(MainForm refer, int oldHrs, int oldMins, int oldSecs)
        {
            InitializeComponent();
            this.refer = refer;
            this.oldHrs = oldHrs;
            this.oldMins = oldMins;
            this.oldSecs = oldSecs;

            TimeHoursBox.Text = oldHrs.ToString();
            TimeMinutesBox.Text = oldMins.ToString();
            TimeSecondsBox.Text = oldSecs.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try { newHrs = Convert.ToInt32(NewHoursBox.Text); } catch { newHrs = 0; }
            try { newMins = Convert.ToInt32(NewMinutesBox.Text); } catch { newMins = 0; }
            try { newSecs = Convert.ToInt32(NewSecondsBox.Text); } catch { newSecs = 0; }

            secs = newSecs + oldSecs;
            mins = newMins + oldMins;
            hrs = newHrs + oldHrs;

            secs = secs + (mins * 60) + (hrs * 3600);

            mins = secs / 60;
            secs = secs % 60;
            hrs = mins / 60;
            mins = mins % 60;

            refer.TimeHoursBox.Text = hrs.ToString();
            refer.TimeMinutesBox.Text = mins.ToString();
            refer.TimeSecondsBox.Text = secs.ToString();

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
