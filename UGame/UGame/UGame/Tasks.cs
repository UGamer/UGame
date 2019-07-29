using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public partial class Tasks : Form
    {
        string friendlyTitle;

        List<PictureBox> mainPics = new List<PictureBox>();
        List<CheckBox> mainChecks = new List<CheckBox>();
        List<TextBox> mainBoxes = new List<TextBox>();

        PictureBox mainPic;
        CheckBox mainCheck;
        TextBox mainBox;

        int xPos = -100;
        int yPos = 6;

        public Tasks(string friendlyTitle)
        {
            this.friendlyTitle = friendlyTitle;

            string[] tasks = Directory.GetDirectories("Tasks\\" + friendlyTitle);
            int taskCount = tasks.Length;

            InitializeComponent();

            for (int index = 0; index < taskCount; index++)
            {
                xPos += 106;

                if (xPos < TasksTab.Size.Width - 106)
                {
                    mainPic = new PictureBox();
                    mainPic.Location = new Point(xPos, yPos);
                    mainPic.Size = new Size(100, 100);
                    mainPic.BackgroundImageLayout = ImageLayout.Zoom;
                    mainPic.BackgroundImage = Image.FromFile(tasks[index] + "\\img.png");

                    mainCheck = new CheckBox();
                    mainCheck.Location = new Point(xPos, yPos + 106);
                    mainCheck.Text = "";

                    mainBox = new TextBox();
                    mainBox.Location = new Point(xPos + 21, yPos + 103);
                    mainBox.Size = new Size(79, 20);
                    mainBox.Multiline = true;
                    mainBox.Text = tasks[index];

                    mainPics.Add(mainPic);
                    mainChecks.Add(mainCheck);
                    mainBoxes.Add(mainBox);

                    TasksTab.Controls.Add(mainPic);
                    TasksTab.Controls.Add(mainCheck);
                    TasksTab.Controls.Add(mainBox);
                }
                else
                {
                    xPos = 6;
                    yPos += 129;

                    mainPic = new PictureBox();
                    mainPic.Location = new Point(xPos, yPos);
                    mainPic.Size = new Size(100, 100);
                    mainPic.BackgroundImageLayout = ImageLayout.Zoom;
                    mainPic.BackgroundImage = Image.FromFile(tasks[index] + "\\img.png");
                    mainPic.Click += MainPic_Click;

                    mainCheck = new CheckBox();
                    mainCheck.Location = new Point(xPos, yPos + 106);
                    mainCheck.Text = "";

                    mainBox = new TextBox();
                    mainBox.Location = new Point(xPos + 21, yPos + 103);
                    mainBox.Size = new Size(79, 20);
                    mainBox.Text = tasks[index];

                    mainPics.Add(mainPic);
                    mainChecks.Add(mainCheck);
                    mainBoxes.Add(mainBox);

                    TasksTab.Controls.Add(mainPic);
                    TasksTab.Controls.Add(mainCheck);
                    TasksTab.Controls.Add(mainBox);
                }
            }
        }

        private void MainPic_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
