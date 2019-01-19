using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private static void addEntry(string title, string platform, string status,
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

            if (launchCode == "")
                cmd.Parameters.AddWithValue("@Launch", " ");
            else
                cmd.Parameters.AddWithValue("@Launch", launchCode);

            if (title != "")
                cmd.ExecuteNonQuery();
        }
    }
}
