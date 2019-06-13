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
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\deboltm\\Documents\\GitHub\\UGame\\UGame\\UGame\\UGame\\bin\\Debug\\UGameDB.mdf\";Integrated Security=True";
        static SqlConnection con = new SqlConnection(connectionString);
        public SqlCommand cmd = new SqlCommand("SELECT * FROM Games", con);
        public DataTable dataTable;

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
            
            InitializeComponent();
            FillDGV();
        }

        private void FillDGV()
        {
            con.Open();
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dataTable = new DataTable();
            da.Fill(dataTable);
            con.Close();

            GamesDGV.DataSource = dataTable;
            GamesDGV.Columns[0].Visible = false;
        }

        private void GamesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(GamesDGV.Rows[e.RowIndex].Cells[0].Value);
                game = new GameTab(this, e.RowIndex, GamesTabs.TabPages.Count);
                games.Add(game);
                GamesTabs.SelectedTab = game.gameTab;
            }
            catch { }
        }

        public void AddGameTab(TabPage gameTab)
        {
            GamesTabs.Controls.Add(gameTab);
            gameTab.Tag = GamesTabs.TabPages.Count - 2;
        }
    }
}
