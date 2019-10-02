using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public partial class AdvancedSearch : Form
    {
        MainForm refer;

        public AdvancedSearch(MainForm refer)
        {
            this.refer = refer;

            InitializeComponent();
        }

        private void Box_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(refer.gameTable);

            int varCount = 0;

            bool doTitle = false, doPlatform = false, doStatus = false, doRating = false, doFilter = false, 
                doDeveloper = false, doPublisher = false, doGenre = false;

            if (TitleBox.Text != "") { doTitle = true; varCount++; }
            if (PlatformBox.Text != "") { doPlatform = true; varCount++; }
            if (StatusBox.Text != "") { doStatus = true; varCount++; }
            if (RatingBox.Text != "")
            {
                doRating = true;
                varCount++;
            }
            if (FilterBox.Text != "")
            {
                doFilter = true;
                varCount++;
            }
            if (DeveloperBox.Text != "")
            {
                doDeveloper = true;
                varCount++;
            }
            if (PublisherBox.Text != "")
            {
                doPublisher = true;
                varCount++;
            }
            if (GenreBox.Text != "")
            {
                doGenre = true;
                varCount++;
            }

            /*
            string formatString = "";
            while (varCount >= 0)
            {
                if (doTitle)
                {
                    doTitle = false;
                    formatString += "Title LIKE '" + TitleBox.Text + "'";
                    varCount--;
                    if (varCount > 0)
                        formatString += ", ";
                    continue;
                }
                if (doPlatform)
                {
                    doPlatform = false;
                    formatString += "Platform LIKE '" + PlatformBox.Text + "'";
                    varCount--;
                    if (varCount > 0)
                        formatString += ", ";
                    continue;
                }
                
                //VERY IMPORTANT! IMPLEMENT ALL OTHER VARIABLES!
            
                if (doFilter)
                {
                    doFilter = false;
                    formatString += "Filters LIKE '%" + FilterBox.Text + "%'";
                    varCount--;
                    if (varCount > 0)
                        formatString += ", ";
                    continue;
                }
            }
            */

            try { DV.RowFilter = "Filters LIKE '%" + FilterBox.Text + "%'"; }
            catch { }

            refer.GamesDGV.DataSource = DV;
        }
    }
}
