using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace The_UGamer_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void collectionButto(object sender, EventArgs e)
        {
            launcherData.Visible = false;
            collectionData.Visible = true;
            launcherButton.Visible = true;
            collectionButton.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void launcherButto(object sender, EventArgs e)
        {
            launcherData.Visible = true;
            collectionData.Visible = false;
            collectionButton.Visible = true;
            launcherButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collectionDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.collectionDataSet.Table1);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table1TableAdapter.Fill(this.collectionDataSet.Table1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table1TableAdapter.FillBy(this.collectionDataSet.Table1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailSelect detailSelect = new DetailSelect(this);
            detailSelect.Show();
        }

        private void collectionData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
