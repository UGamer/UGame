using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public partial class MainForm : Form
    {
        public List<GameTab> games = new List<GameTab>();
        public GameTab game;
        public WebBrowser BrowserLauncher = new WebBrowser();

        static string connectionString;
        static SqlConnection con;
        public SqlCommand selectCmd;
        public SqlCommand insertCmd;
        public DataTable dataTable;
        
        int currentRow = 0;

        public string urlString = "";
        public string launchString = "";

        public MainForm()
        {
            if (!Directory.Exists("resources"))
                Directory.CreateDirectory("resources");
            if (!Directory.Exists("resources\\details"))
                Directory.CreateDirectory("resources\\details");
            if (!Directory.Exists("resources\\icons"))
                Directory.CreateDirectory("resources\\icons");
            if (!Directory.Exists("resources\\bg"))
                Directory.CreateDirectory("resources\\bg");
            
            Uri location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            string mdfPath = new FileInfo(location.AbsolutePath).Directory.FullName + "\\UGameDB.mdf";
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + mdfPath + "\";Integrated Security=True";
            con = new SqlConnection(connectionString);

            selectCmd = new SqlCommand("SELECT * FROM Games", con);
            insertCmd = new SqlCommand("INSERT INTO Games ([Id], [Title], [Platform], [Status], [Rating], [TimePlayed], [Seconds], [Obtained], [StartDate], [LastPlayed], [Notes], [URLs], [Filters], [Developers], [Publishers], [ReleaseDate], [Genre], [PlayerCount], [Price], [GameDesc], [Launch], [Blur], [Overlay]) VALUES (@Id, @Title, @Platform, @Status, @Rating, @TimePlayed, @Seconds, @Obtained, @StartDate, @LastPlayed, @Notes, @URLs, @Filters, @Developers, @Publishers, @ReleaseDate, @Genre, @PlayerCount, @Price, @GameDesc, @Launch, @Blur, @Overlay);", con);
            
            InitializeComponent();
            FillDGV();
        }

        private void FillDGV()
        {
            con.Open();
            selectCmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(selectCmd);
            dataTable = new DataTable();
            dataTable.Columns.Add(" ", typeof(Image));
            da.Fill(dataTable);
            con.Close();
            
            // TEMPORARY DATA FOR TESTING
            DataRow dataRow = dataTable.NewRow();
            dataRow[0] = Image.FromFile("resources\\icons\\Minecraft.png");
            dataRow["Id"] = 0;
            dataRow["Title"] = "Minecraft";
            dataRow["Platform"] = "PC";
            dataRow["Status"] = "Playing";
            dataRow["Rating"] = 9;
            dataRow["TimePlayed"] = "5000h:00m:00s";
            dataRow["Seconds"] = 18000000;
            dataRow["LastPlayed"] = DateTime.Now;

            dataTable.Rows.Add(dataRow);
            // TEMPORARY DATA FOR TESTING

            GamesDGV.DataSource = dataTable;

            ((DataGridViewImageColumn)GamesDGV.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            GamesDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesDGV.Columns["Id"].Visible = false;
            GamesDGV.Columns["Seconds"].Visible = false;
            GamesDGV.Columns["Notes"].Visible = false;
            GamesDGV.Columns["URLs"].Visible = false;
            GamesDGV.Columns["Filters"].Visible = false;
            GamesDGV.Columns["GameDesc"].Visible = false;
            GamesDGV.Columns["Launch"].Visible = false;
            GamesDGV.Columns["Blur"].Visible = false;
            GamesDGV.Columns["Overlay"].Visible = false;
        }
        
        private void NewTab(int rowIndex)
        {
            try
            {
                int id = Convert.ToInt32(GamesDGV.Rows[rowIndex].Cells["Id"].Value);
                int index;
                bool make = true;
                for (index = 0; index < games.Count; index++)
                {
                    if (games[index].id == id)
                    {
                        make = false;
                        break;
                    }
                }

                if (make)
                {
                    game = new GameTab(this, rowIndex, GamesTabs.TabPages.Count, id);
                    games.Add(game);
                    GamesTabs.SelectedTab = game.gameTab;
                }
                else
                {
                    GamesTabs.SelectedTab = games[index].gameTab;
                }
            }
            catch { }
        }

        public void AddGameTab(TabPage gameTab)
        {
            GamesTabs.Controls.Add(gameTab);
            gameTab.Tag = GamesTabs.TabPages.Count - 3;
        }

        private void GamesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NewTab(e.RowIndex);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                NewTab(currentRow);
            }
        }

        private void GamesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
        }
        
        /// <summary>
        /// The next section of code deals with the entry system.
        /// </summary>

        public void AddEntry()
        {
            int highestId = 0;

            for (int index = 0; index < dataTable.Rows.Count; index++)
                if (highestId < Convert.ToInt32(dataTable.Rows[index]["Id"]))
                    highestId = Convert.ToInt32(dataTable.Rows[index]["Id"]);

            if (highestId == 0)
                highestId--;
            
            int hours;
            int minutes;
            int seconds;

            string hoursString = "";
            string minutesString = "";
            string secondsString = "";

            try { hours = Convert.ToInt32(TimeHoursBox.Text); } catch { hours = 0; }
            try { minutes = Convert.ToInt32(TimeMinutesBox.Text); } catch { minutes = 0; }
            try { seconds = Convert.ToInt32(TimeSecondsBox.Text); } catch { seconds = 0; }

            minutes += seconds / 60;
            seconds %= 60;
            hours += minutes / 60;
            minutes %= 60;

            if (hours < 10)
                hoursString = "0";
            hoursString += hours + "h:";

            if (minutes < 10)
                minutesString = "0";
            minutesString += minutes + "m:";

            if (seconds < 10)
                secondsString = "0";
            secondsString += seconds + "s";

            string timePlayed = hoursString + minutesString + secondsString;

            int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            DateTime nullDT = new DateTime(1753, 1, 1, 0, 0, 0);

            string releaseDate = ReleaseDatePicker.Value.ToShortDateString();

            con.Open();
            
            insertCmd.Parameters.AddWithValue("@Id", highestId + 1);
            insertCmd.Parameters.AddWithValue("@Title", TitleBox.Text);
            insertCmd.Parameters.AddWithValue("@Platform", PlatformBox.Text);
            insertCmd.Parameters.AddWithValue("@Status", StatusBox.Text);
            insertCmd.Parameters.AddWithValue("@Rating", RatingBar.Value);
            insertCmd.Parameters.AddWithValue("@TimePlayed", timePlayed);
            insertCmd.Parameters.AddWithValue("@Seconds", totalSeconds);

            if (ObtainedCheck.Checked)
                insertCmd.Parameters.AddWithValue("@Obtained", ObtainedDatePicker.Value);
            else
                insertCmd.Parameters.AddWithValue("@Obtained", nullDT);

            if (StartDateCheck.Checked)
                insertCmd.Parameters.AddWithValue("@StartDate", StartDatePicker.Value);
            else
                insertCmd.Parameters.AddWithValue("@StartDate", nullDT);

            if (LastPlayedCheck.Checked)
                insertCmd.Parameters.AddWithValue("@LastPlayed", LastPlayedDatePicker.Value);
            else
                insertCmd.Parameters.AddWithValue("@LastPlayed", nullDT);

            insertCmd.Parameters.AddWithValue("@Notes", NotesBox.Text);
            insertCmd.Parameters.AddWithValue("@URLs", urlString);
            insertCmd.Parameters.AddWithValue("@Filters", FiltersBox.Text);
            insertCmd.Parameters.AddWithValue("@Developers", DevelopersBox.Text);
            insertCmd.Parameters.AddWithValue("@Publishers", PublishersBox.Text);
            insertCmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);
            insertCmd.Parameters.AddWithValue("@Genre", GenreBox.Text);
            insertCmd.Parameters.AddWithValue("@PlayerCount", PlayerCountBox.Text);
            try { insertCmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(PriceBox.Text)); } catch { insertCmd.Parameters.AddWithValue("@Price", -1); }
            insertCmd.Parameters.AddWithValue("@GameDesc", GameDescBox.Text);
            insertCmd.Parameters.AddWithValue("@Launch", launchString);
            insertCmd.Parameters.AddWithValue("@Blur", BlurCheck.Checked.ToString());
            insertCmd.Parameters.AddWithValue("@Overlay", OverlayCheck.Checked.ToString());

            insertCmd.ExecuteNonQuery();
            con.Close();
        }

        private void Clear()
        {
            TitleBox.Text = "";
            PlatformBox.Text = "";
            StatusBox.Text = "";
            RatingBar.Value = 0;
            TimeHoursBox.Text = "";
            TimeMinutesBox.Text = "";
            TimeSecondsBox.Text = "";
            ObtainedCheck.Checked = true;
            StartDateCheck.Checked = true;
            LastPlayedCheck.Checked = true;
            ObtainedDatePicker.Value = DateTime.Now;
            StartDatePicker.Value = DateTime.Now;
            LastPlayedDatePicker.Value = DateTime.Now;
            NotesBox.Text = "";
            DevelopersBox.Text = "";
            PublishersBox.Text = "";
            ReleaseDateCheck.Checked = true;
            ReleaseDatePicker.Value = DateTime.Now;
            GenreBox.Text = "";
            PlayerCountBox.Text = "";
            PriceBox.Text = "";
            GameDescBox.Text = "";
            launchString = "";
            urlString = "";
            FiltersBox.Text = "";
            BlurCheck.Checked = true;
            OverlayCheck.Checked = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEntry();   
        }
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void RatingBar_ValueChanged(object sender, EventArgs e)
        {
            RatingBox.Text = RatingBar.Value.ToString();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            DGVForm dgvForm = new DGVForm("Launch", launchString, this);
            dgvForm.Show();
        }

        private void URLButton_Click(object sender, EventArgs e)
        {
            DGVForm dgvForm = new DGVForm("URLs", urlString, this);
            dgvForm.Show();
        }
    }
}
