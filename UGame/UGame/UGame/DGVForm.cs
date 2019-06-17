using System;
using System.Collections;
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
    public partial class DGVForm : Form
    {
        string type;
        string data;
        MainForm refer;

        DataTable dataTable;
        ArrayList titles;
        ArrayList secondColumn;

        public DGVForm(string type, string data, MainForm refer)
        {
            this.type = type;
            this.data = data;
            this.refer = refer;
            
            InitializeComponent();
            FillDGV();
        }

        private void FillDGV()
        {
            dataTable = new DataTable();
            titles = new ArrayList();
            secondColumn = new ArrayList();

            dataTable.Columns.Add("Title");

            if (type == "URLs")
            {
                dataTable.Columns.Add("URL");
            }
            else if (type == "Launch")
            {
                dataTable.Columns.Add("Code");
            }
            
            DataRow dataRow;
            string section = data;
            string title;
            string url;
            string pattern1 = "[Title]";
            string pattern2 = "[URL]";
            int index = 0;
            while (section.IndexOf(pattern1) != -1) // get rid of arraylist and just add straight to datatable
            {
                section = section.Substring(pattern1.Length);
                title = section.Substring(0, section.IndexOf(pattern2));
                titles.Add(title);

                section = section.Substring(section.IndexOf(pattern2) + pattern2.Length);
                try { url = section.Substring(0, section.IndexOf(pattern1)); } catch { url = section; }
                secondColumn.Add(url);

                try { section = section.Substring(section.IndexOf(pattern1)); } catch { }

                dataRow = dataTable.NewRow();
                dataRow[0] = titles[index];
                dataRow[1] = secondColumn[index];
                dataTable.Rows.Add(dataRow);

                index++;
            }

            DGV.DataSource = dataTable;
        }

        private void DGVForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string returnString = "";

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                returnString += "[Title]" + dataTable.Rows[index][0] + "[URL]" + dataTable.Rows[index][1];
            }

            if (type == "Launch")
                refer.launchString = returnString;
            else if (type == "URLs")
                refer.urlString = returnString;
        }
    }
}
