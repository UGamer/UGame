using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_UGamer_Launcher
{
    public partial class AddLinks : Form
    {
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Collection.accdb";
        private OleDbConnection con = new OleDbConnection(connectionString);

        public int linkAmount;
        public string[] linkTitles;
        public string[] linkURLs;
        private int index = 0;
        string title;

        bool bookmark = false;

        public AddLinks()
        {
            InitializeComponent();
            Size firstSize = new Size(330, 173);
            this.Size = firstSize;
        }

        public AddLinks(string address, string title, string tabTitle)
        {
            InitializeComponent();
            this.TopMost = true;
            linkAmount = 1;
            Size fullSize = new Size(691, 173);
            ChooseAmountBox.Visible = false;
            ChooseAmountButton.Visible = false;
            ChooseAmountLabel.Visible = false;
            this.Size = fullSize;

            LinkTitleLabel.Visible = true;
            LinkTitleBox.Visible = true;
            LinkURLLabel.Visible = true;
            LinkURLBox.Visible = true;
            LinkAddButton.Visible = true;
            
            linkTitles = new string[linkAmount];
            linkURLs = new string[linkAmount];

            LinkURLBox.Text = address;
            LinkTitleBox.Text = tabTitle;
            bookmark = true;
            this.title = title;
        }

        private void ChooseAmountButton_Click(object sender, EventArgs e)
        {
            Size fullSize = new Size(691, 173);
            ChooseAmountBox.Visible = false;
            ChooseAmountButton.Visible = false;
            ChooseAmountLabel.Visible = false;
            this.Size = fullSize;

            LinkTitleLabel.Visible = true;
            LinkTitleBox.Visible = true;
            LinkURLLabel.Visible = true;
            LinkURLBox.Visible = true;
            LinkAddButton.Visible = true;

            linkAmount = Convert.ToInt32(ChooseAmountBox.Text);
            linkTitles = new string[linkAmount];
            linkURLs = new string[linkAmount];
        }

        private void LinkAddButton_Click(object sender, EventArgs e)
        {
            if (bookmark == false)
            {
                if (index < linkAmount)
                {
                    linkTitles[index] = LinkTitleBox.Text;
                    linkURLs[index] = LinkURLBox.Text;

                    LinkTitleBox.Text = "";
                    LinkURLBox.Text = "";

                    index++;
                    if (index == linkAmount)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                linkTitle = LinkTitleBox.Text;
                linkURL = LinkURLBox.Text;
                AddBookmark();
            }
        }

        public string linkTitle;
        public string linkURL;

        private void AddBookmark()
        {
            int y = 0, z = 0;
            string input = title;

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Table1", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable newTable = new DataTable();
            da.Fill(newTable);

            con.Close();

            // This makes the whole database into an array.

            // DataTable dt = collectionDataSet4.Table1;
            DataTable dt = newTable;
            int columnIndex = 1; // Name column
            string[] table = new string[dt.Rows.Count];
            int index = 0;
            for (index = 0; index < dt.Rows.Count; index++)
            {
                table[index] = dt.Rows[index][columnIndex].ToString();
            }

            for (int x = 0; x < dt.Rows.Count; x++)
                if (input == table[x])
                {
                    z = x;
                    y = 1;
                }

            if (y == 1)
            {
                string platform = dt.Rows[z][2].ToString();
                string status = dt.Rows[z][3].ToString();
                string rating = dt.Rows[z][4].ToString();
                string hours = dt.Rows[z][5].ToString();
                string obtained = dt.Rows[z][6].ToString();
                string startDate = dt.Rows[z][7].ToString();
                string endDate = dt.Rows[z][8].ToString();
                string notes = dt.Rows[z][9].ToString();
                string launchString = dt.Rows[z][10].ToString();
                string newsString = dt.Rows[z][11].ToString();
                string wikiString = dt.Rows[z][12].ToString();

                newsString = "[Title]" + linkTitle + "[URL]" + linkURL;
                this.newsString = newsString;
                
                y = 0;

                OleDbCommand delCmd = new OleDbCommand("DELETE FROM Table1 WHERE Title=\"" + title + "\";", con);
                OleDbCommand cmd2 = new OleDbCommand("INSERT INTO Table1 (Title, Platform, Status, Rating, PlayTime, Obtained, StartDate, EndDate, Notes, Launch, News, Wiki) VALUES (@Title, @Platform, @Status, @Rating, @PlayTime, @Obtained, @StartDate, @EndDate, @Notes, @Launch, @News, @Wiki);", con);
                con.Open();

                delCmd.ExecuteNonQuery();

                cmd2.Parameters.AddWithValue("@Title", title);
                cmd2.Parameters.AddWithValue("@Platform", platform);
                cmd2.Parameters.AddWithValue("@Status", status);
                cmd2.Parameters.AddWithValue("@Rating", rating);
                cmd2.Parameters.AddWithValue("@PlayTime", hours);
                cmd2.Parameters.AddWithValue("@Obtained", obtained);
                cmd2.Parameters.AddWithValue("@StartDate", startDate);
                cmd2.Parameters.AddWithValue("@EndDate", endDate);
                cmd2.Parameters.AddWithValue("@Notes", notes);
                cmd2.Parameters.AddWithValue("@Launch", launchString);
                cmd2.Parameters.AddWithValue("@News", newsString);
                cmd2.Parameters.AddWithValue("@Wiki", wikiString);
                cmd2.ExecuteNonQuery();

                con.Close();
            }
            else
            {

            }

            this.Close();
        }

        public string newsString;
    }
}
