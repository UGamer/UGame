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
        public GameSummary(string title, int totalSeconds)
        {
            InitializeComponent();
            label1.Text = "You played \"" + title + "\" for ";

            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            int hours = minutes / 60;
            minutes %= 60;

            int totalMinutes = totalSeconds / 60;

            textBox1.Text = hours + " hours, " + minutes + " minutes, and " + seconds + " seconds.";
            textBox1.Text += "\n\n" + totalSeconds + " total seconds";
            textBox1.Text += "\n" + totalMinutes + " total minutes";

            textBox1.Text += "\n\n" + hours / 24 + " days";
        }
    }
}
