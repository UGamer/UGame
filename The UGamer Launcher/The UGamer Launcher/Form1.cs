using System;
using System.Windows.Forms;

namespace The_UGamer_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (InvalidOperationException e) // This is caught if you don't have the required OLE DB drivers.
            {
                driverWarningLabel.Visible = true;
                Uri installURL = new Uri("https://www.microsoft.com/en-us/download/confirmation.aspx?id=23734");
                driverInstall.Url = installURL;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Delete this later.
        {

        }

        private void Form1_Load(object sender, EventArgs e) // This fills the data table with the user data.
        {
            this.table1TableAdapter3.Fill(this.collectionDataSetFinal.Table1);

        }

        private void detailButton_Click_1(object sender, EventArgs e) // Clicking the "Details" button opens a new details window.
        {
            DetailSelect detailSelect = new DetailSelect(this);
            detailSelect.Show();
        }
    }
}
