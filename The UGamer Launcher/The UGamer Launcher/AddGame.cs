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
            string obtained = obtainedBox.Text;
            string startDate = startDateBox.Text;
            string endDate = endDateBox.Text;
            string launchCode = launchBox.Text;
            string notes = notesBox.Text;

            addEntry(title, platform, status, rating, hours, obtained, startDate, 
                endDate, launchCode, notes);
        }

        private void addEntry(string title, string platform, string status,
            string rating, string hours, string obtained, string startDate,
                string endDate, string launchCode, string notes)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Collection.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Table1 (Title, Platform, Status, Rating, Hours, Obtained, StartDate, EndDate, Notes, Launch) VALUES (@Title, @Platform, @Status, @Rating, @Hours, @Obtained, @StartDate, @EndDate, @Notes, @Launch);", con);

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

            if (hours == "")
                cmd.Parameters.AddWithValue("@Hours", "0");
            else
                cmd.Parameters.AddWithValue("@Hours", hours);

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

            DataTable dt = frm1.collectionDataSetFinal2.Table1;
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
            string obtained = obtainedBox.Text;
            string startDate = startDateBox.Text;
            string endDate = endDateBox.Text;
            string launchCode = launchBox.Text;
            string notes = notesBox.Text;

            replaceEntryMethod(originalTitleString, title, platform, status, rating, hours, obtained, startDate,
                endDate, launchCode, notes);
        }

        private void replaceEntryMethod(string originalTitleString, string title, string platform, string status,
            string rating, string hours, string obtained, string startDate,
                string endDate, string launchCode, string notes)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Collection.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand delCmd = new OleDbCommand("DELETE FROM Table1 WHERE Title='" + originalTitleString + "';", con);
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Table1 (Title, Platform, Status, Rating, Hours, Obtained, StartDate, EndDate, Notes, Launch) VALUES (@Title, @Platform, @Status, @Rating, @Hours, @Obtained, @StartDate, @EndDate, @Notes, @Launch);", con);

            string message = "Are you sure you want to edit entry \"" + originalTitleString + "\"?";
            string caption = "Editing entry \"" + originalTitleString + "\"";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

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

                if (hours == "")
                    cmd.Parameters.AddWithValue("@Hours", "0");
                else
                    cmd.Parameters.AddWithValue("@Hours", hours);

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
    }
}
