using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_UGamer_Launcher
{
    public partial class DetailSelect : Form
    {
        public DetailSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = "", input2 = "";
            int y = 0;
            GameDetails gameWindow = new GameDetails();
            DataContext dataContext = new DataContext("Collection.accdb");
            Table<Table1> Data = dataContext.GetTable<Table1>();
            for (int x = 0; x != 1;)
            {
                input = textBox1.Text;
                if (input == "Ape Escape")
                {
                    input2 = "ApeEscape";
                    IQueryable<string> query = from e in Data
                                               select $"email: {e.email}";
                    y = 1;
                }
                else
                {
                    label2.Visible = true;
                }
                x = 1;
            }
            if (y == 1)
            {
                gameWindow.Show();
                gameWindow.DisplayInfo(input, input2);
                label2.Visible = false;
                y = 0;
            }
            
        }
    }
}
