using System;
using System.Windows.Forms;

namespace The_UGamer_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collectionDataSetFinal.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter3.Fill(this.collectionDataSetFinal.Table1);
            // TODO: This line of code loads data into the 'collectionDataSet2.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter2.Fill(this.collectionDataSet2.Table1);
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

        private void detailButton_Click(object sender, EventArgs e)
        {
            
        }

        private void collectionData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.table1TableAdapter1.FillBy(this.collectionDataSet1.Table1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table1TableAdapter1.FillBy1(this.collectionDataSet1.Table1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.table1TableAdapter.FillBy1(this.collectionDataSet.Table1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table1TableAdapter1.FillBy2(this.collectionDataSet1.Table1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.table1TableAdapter2.FillBy(this.collectionDataSet2.Table1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void detailButton_Click_1(object sender, EventArgs e)
        {
            DetailSelect detailSelect = new DetailSelect(this);
            detailSelect.Show();
        }
    }
}
