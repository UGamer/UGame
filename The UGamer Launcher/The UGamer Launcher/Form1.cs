using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace The_UGamer_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Starts up the program.
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Resources/Theme/backgroundImage.png");
            logo.BackgroundImage = Image.FromFile("Resources/Theme/logo.png");
        }

        // This fills the data table with the user data.
        private void Form1_Load(object sender, EventArgs e) 
        {
            // TODO: This line of code loads data into the 'collectionDataSetFinal2.Table1' table. You can move, or remove it, as needed.
            try
            {
                this.table1TableAdapter.Fill(this.collectionDataSetFinal2.Table1);
            }
            // This is caught if you don't have the required OLE DB drivers.
            catch (InvalidOperationException d)
            {
                dataTable.Visible = false;
                driverWarning.Visible = true;
                Uri installURL = new Uri("https://www.microsoft.com/en-us/download/confirmation.aspx?id=23734");
                driverInstall.Url = installURL;
            }
            int entryCount = dataTable.Rows.Count;
            if (entryCount != 1)
                gameCountText.Text = Convert.ToString(entryCount) + " total games";
            else
                gameCountText.Text = Convert.ToString(entryCount) + " total game";
        }

        // Clicking the "Details" button opens a new details window.
        private void detailButton_Click_1(object sender, EventArgs e) 
        {
            DetailSelect detailSelect = new DetailSelect(this);
            detailSelect.Show();
        }

        private void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string titleValue;
            object value = dataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            titleValue = value.ToString();
            DetailSelect detailSelect = new DetailSelect(this);
            detailSelect.dataScan(titleValue);
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame(this);
            addGame.Show();
        }
    }
}
