using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace The_UGamer_Launcher
{
    public partial class AddGame : Form
    {
        public Form1 frm1;
        public AddGame(Form1 parent)
        {
            InitializeComponent();
            frm1 = parent;
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            string title = titleBox.Text;
            string platform = platformBox.Text;
            string status = statusBox.Text;
            string rating = ratingBox.Text;

            string hours = hoursBox.Text;
            string minutes = minutesBox.Text;
            string seconds = secondsBox.Text;

            string obtained = obtainedBox.Text;
            string startDate = startDateBox.Text;
            string endDate = endDateBox.Text;
            string launchCode = launchBox.Text;
            string notes = notesBox.Text;

            addEntry(title, platform, status, rating, hours, minutes, seconds, obtained, startDate, 
                endDate, launchCode, notes);
        }

        private void addEntry(string title, string platform, string status,
            string rating, string hours, string minutes, string seconds, string obtained, string startDate,
                string endDate, string launchCode, string notes)
        {

            int hoursInt = 0;
            int minsInt = 0;
            int secsInt = 0;

            string newHoursString = "00";
            string newMinutesString = "00";
            string newSecondsString = "00";

            if (hours != "")
            {
                hoursInt = Convert.ToInt32(hours);
                newHoursString = hours;
            }
            if (minutes != "")
            {
                minsInt = Convert.ToInt32(minutes);
                newMinutesString = minutes;
            }
            if (seconds != "")
            {
                secsInt = Convert.ToInt32(seconds);
                newSecondsString = seconds;
            }

            if (hoursInt < 10 && minsInt != 0)
                newHoursString = "0" + hours;
            if (minsInt < 10 && minsInt != 0)
                newMinutesString = "0" + minutes;
            if (secsInt < 10 && secsInt != 0)
                newSecondsString = "0" + seconds;
            
            string playTime = newHoursString + "h:" + newMinutesString + "m:" + newSecondsString + "s";

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Collection.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Table1 (Title, Platform, Status, Rating, PlayTime, Obtained, StartDate, EndDate, Notes, Launch) VALUES (@Title, @Platform, @Status, @Rating, @PlayTime, @Obtained, @StartDate, @EndDate, @Notes, @Launch);", con);

            con.Open();

            cmd.Parameters.AddWithValue("@Title", title);
            if (platform == "")
                cmd.Parameters.AddWithValue("@Platform", " ");
            else
                cmd.Parameters.AddWithValue("@Platform", platform);

            if (status == "")
                cmd.Parameters.AddWithValue("@Status", " ");
            else
                cmd.Parameters.AddWithValue("@Status", status);

            if (rating == "")
                cmd.Parameters.AddWithValue("@Rating", "0");
            else
                cmd.Parameters.AddWithValue("@Rating", rating);

            if (playTime == "")
                cmd.Parameters.AddWithValue("@PlayTime", "00h:00m:00s");
            else
                cmd.Parameters.AddWithValue("@PlayTime", playTime);

            if (obtained == "")
                cmd.Parameters.AddWithValue("@Obtained", " ");
            else
                cmd.Parameters.AddWithValue("@Obtained", obtained);

            if (startDate == "")
                cmd.Parameters.AddWithValue("@StartDate", " ");
            else
                cmd.Parameters.AddWithValue("@StartDate", startDate);

            if (endDate == "")
                cmd.Parameters.AddWithValue("@EndDate", " ");
            else
                cmd.Parameters.AddWithValue("@EndDate", endDate);

            if (notes == "")
                cmd.Parameters.AddWithValue("@Notes", " ");
            else
                cmd.Parameters.AddWithValue("@Notes", notes);

            if (title == "Sonic World")
                cmd.Parameters.AddWithValue("@Launch", "BATs/Sonic World.bat");
            else if (launchCode == "")
                cmd.Parameters.AddWithValue("@Launch", "");
            else
                cmd.Parameters.AddWithValue("@Launch", launchCode);

            if (title != "")
            {
                cmd.ExecuteNonQuery();
                this.Text = "Add an entry... Game added.";
                titleBox.Text = "";
                platformBox.Text = "";
                statusBox.Text = "";
                ratingBox.Text = "";
                hoursBox.Text = "";
                minutesBox.Text = "";
                secondsBox.Text = "";
                obtainedBox.Text = "";
                startDateBox.Text = "";
                endDateBox.Text = "";
                launchBox.Text = "";
                notesBox.Text = "";
            }
            else
            {
                this.Text = "Add an entry... Game not added.";
            }
            return;
        }

        private void editEntry_Click(object sender, EventArgs e)
        {
            int z = 0, y = 0;

            DataTable dt = frm1.collectionDataSet3.Table1;
            int columnIndex = 1; // Name column
            string[] table = new string[dt.Rows.Count];
            int index = 0;
            for (index = 0; index < dt.Rows.Count; index++)
            {
                table[index] = dt.Rows[index][columnIndex].ToString();
            }

            string title = titleBox.Text;

            for (int x = 0; x < dt.Rows.Count; x++)
                if (title == table[x])
                {
                    z = x;
                    y = 1;
                }

            if (y == 1)
            {
                originalTitle.Text = dt.Rows[z][1].ToString();
                platformBox.Text = dt.Rows[z][2].ToString();
                statusBox.Text = dt.Rows[z][3].ToString();
                ratingBox.Text = dt.Rows[z][4].ToString();

                hoursBox.Text = dt.Rows[z][5].ToString();

                string hoursPlayed = hoursBox.Text;
                string minutesPlayed = hoursBox.Text;
                string secondsPlayed = hoursBox.Text;

                int hourIndex = hoursPlayed.IndexOf("h");
                string hours = hoursPlayed.Substring(0, hourIndex);
                int minuteIndex = minutesPlayed.IndexOf("m");
                int minuteLength = minutesPlayed.IndexOf("m") - (hourIndex + 2);
                string minutes = minutesPlayed.Substring(hourIndex + 2, minuteLength);
                int secondIndex = secondsPlayed.IndexOf("s");
                int secondLength = secondsPlayed.IndexOf("s") - (minuteIndex + 2);
                string seconds = secondsPlayed.Substring(minuteIndex + 2, secondLength);

                int hoursInt = 0;
                int minsInt = 0;
                int secsInt = 0;

                string newHoursString = "00";
                string newMinutesString = "00";
                string newSecondsString = "00";

                if (hours != "")
                {
                    hoursInt = Convert.ToInt32(hours);
                    newHoursString = hours;
                }
                if (minutes != "")
                {
                    minsInt = Convert.ToInt32(minutes);
                    newMinutesString = minutes;
                }
                if (seconds != "")
                {
                    secsInt = Convert.ToInt32(seconds);
                    newSecondsString = seconds;
                }

                if (hoursInt < 10 && minsInt != 0)
                    newHoursString = "0" + hours;
                if (minsInt < 10 && minsInt != 0)
                    newMinutesString = "0" + minutes;
                if (secsInt < 10 && secsInt != 0)
                    newSecondsString = "0" + seconds;

                string playTime = newHoursString + "h:" + newMinutesString + "m:" + newSecondsString + "s";

                hoursBox.Text = hours;
                minutesBox.Text = minutes;
                secondsBox.Text = seconds;

                obtainedBox.Text = dt.Rows[z][6].ToString();
                startDateBox.Text = dt.Rows[z][7].ToString();
                endDateBox.Text = dt.Rows[z][8].ToString();
                notesBox.Text = dt.Rows[z][9].ToString();
                launchBox.Text = dt.Rows[z][10].ToString();
                noGameLabel.Visible = false;
                y = 0;

                this.Text = "Edit an entry... Editing \"" + title + "\"";

                replaceEntry.Visible = true;
                deleteEntryButton.Visible = true;
            }
            // If the entry does not exist, an error message shows.
            else
                noGameLabel.Visible = true;
        }

        private void replaceEntry_Click(object sender, EventArgs e)
        {
            string originalTitleString = originalTitle.Text;
            string title = titleBox.Text;
            string platform = platformBox.Text;
            string status = statusBox.Text;
            string rating = ratingBox.Text;

            string hours = hoursBox.Text;
            string minutes = minutesBox.Text;
            string seconds = secondsBox.Text;

            string obtained = obtainedBox.Text;
            string startDate = startDateBox.Text;
            string endDate = endDateBox.Text;
            string launchCode = launchBox.Text;
            string notes = notesBox.Text;

            replaceEntryMethod(originalTitleString, title, platform, status, rating, 
                hours, minutes, seconds, obtained, startDate,
                endDate, launchCode, notes);
        }

        private void replaceEntryMethod(string originalTitleString, string title, string platform, string status,
            string rating, string hours, string minutes,
            string seconds, string obtained, string startDate,
                string endDate, string launchCode, string notes)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Collection.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand delCmd = new OleDbCommand("DELETE FROM Table1 WHERE Title='" + originalTitleString + "';", con);
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Table1 (Title, Platform, Status, Rating, PlayTime, Obtained, StartDate, EndDate, Notes, Launch) VALUES (@Title, @Platform, @Status, @Rating, @PlayTime, @Obtained, @StartDate, @EndDate, @Notes, @Launch);", con);

            string message = "Are you sure you want to edit entry \"" + originalTitleString + "\"?";
            string caption = "Editing entry \"" + originalTitleString + "\"";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            int hoursInt = 0;
            int minsInt = 0;
            int secsInt = 0;

            string newHoursString = "00";
            string newMinutesString = "00";
            string newSecondsString = "00";

            if (hours != "")
            {
                hoursInt = Convert.ToInt32(hours);
                newHoursString = hours;
            }
            if (minutes != "")
            {
                minsInt = Convert.ToInt32(minutes);
                newMinutesString = minutes;
            }
            if (seconds != "")
            {
                secsInt = Convert.ToInt32(seconds);
                newSecondsString = seconds;
            }

            if (hoursInt < 10 && minsInt != 0)
                newHoursString = "0" + hours;
            if (minsInt < 10 && minsInt != 0)
                newMinutesString = "0" + minutes;
            if (secsInt < 10 && secsInt != 0)
                newSecondsString = "0" + seconds;

            string playTime = newHoursString + "h:" + newMinutesString + "m:" + newSecondsString + "s";

            if (result == DialogResult.Yes)
            {
                con.Open();

                delCmd.ExecuteNonQuery();

                cmd.Parameters.AddWithValue("@Title", title);
                if (platform == "")
                    cmd.Parameters.AddWithValue("@Platform", " ");
                else
                    cmd.Parameters.AddWithValue("@Platform", platform);

                if (status == "")
                    cmd.Parameters.AddWithValue("@Status", " ");
                else
                    cmd.Parameters.AddWithValue("@Status", status);

                if (rating == "")
                    cmd.Parameters.AddWithValue("@Rating", "0");
                else
                    cmd.Parameters.AddWithValue("@Rating", rating);

                if (playTime == "")
                    cmd.Parameters.AddWithValue("@PlayTime", "00h:00m:00s");
                else
                    cmd.Parameters.AddWithValue("@PlayTime", playTime);

                if (obtained == "")
                    cmd.Parameters.AddWithValue("@Obtained", " ");
                else
                    cmd.Parameters.AddWithValue("@Obtained", obtained);

                if (startDate == "")
                    cmd.Parameters.AddWithValue("@StartDate", " ");
                else
                    cmd.Parameters.AddWithValue("@StartDate", startDate);

                if (endDate == "")
                    cmd.Parameters.AddWithValue("@EndDate", " ");
                else
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                if (notes == "")
                    cmd.Parameters.AddWithValue("@Notes", " ");
                else
                    cmd.Parameters.AddWithValue("@Notes", notes);

                if (title == "Sonic World")
                    cmd.Parameters.AddWithValue("@Launch", "BATs/Sonic World.bat");
                else if (launchCode == "")
                    cmd.Parameters.AddWithValue("@Launch", "");
                else
                    cmd.Parameters.AddWithValue("@Launch", launchCode);

                cmd.ExecuteNonQuery();
                this.Text = "Edit an entry... Game edited.";
                titleBox.Text = "";
                platformBox.Text = "";
                statusBox.Text = "";
                ratingBox.Text = "";
                hoursBox.Text = "";
                minutesBox.Text = "";
                secondsBox.Text = "";
                obtainedBox.Text = "";
                startDateBox.Text = "";
                endDateBox.Text = "";
                launchBox.Text = "";
                notesBox.Text = "";
            }
            else
            {
                return;
            }
            return;
        }

        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            string originalTitleString = originalTitle.Text;
            deleteEntry(originalTitleString);
        }

        private void deleteEntry(string originalTitleString)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Collection.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand delCmd = new OleDbCommand("DELETE FROM Table1 WHERE Title='" + originalTitleString + "';", con);

            this.Text = "Remove an entry... Removing \"" + originalTitleString + "\"";

            string message = "Are you sure you want to delete entry \"" + originalTitleString + "\"?";
            string title = "Deleting entry \"" + originalTitleString + "\"";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.Open();

                delCmd.ExecuteNonQuery();

                this.Text = "Entries... removed \"" + originalTitleString + "\"";
                titleBox.Text = "";
                platformBox.Text = "";
                statusBox.Text = "";
                ratingBox.Text = "";
                hoursBox.Text = "";
                minutesBox.Text = "";
                secondsBox.Text = "";
                obtainedBox.Text = "";
                startDateBox.Text = "";
                endDateBox.Text = "";
                launchBox.Text = "";
                notesBox.Text = "";

                return;
            }
            else
            {
                this.Text = "Edit an entry... Editing \"" + title + "\"";
                return;
            }
        }

        private void minutesBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                secondsBox.Focus();
        }

        private void secondsBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                obtainedBox.Focus();
        }

        private void hoursBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Tab)
                minutesBox.Focus();
        }
    }
}