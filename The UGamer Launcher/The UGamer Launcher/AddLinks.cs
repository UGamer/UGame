using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_UGamer_Launcher
{
    public partial class AddLinks : Form
    {
        public int linkAmount;
        public string[] linkTitles;
        public string[] linkURLs;
        private int index = 0;

        public AddLinks()
        {
            InitializeComponent();
            Size firstSize = new Size(330, 173);
            this.Size = firstSize;
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
    }
}
