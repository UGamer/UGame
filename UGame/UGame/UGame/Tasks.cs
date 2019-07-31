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
        Overlay overlay;

        string[] tasks;

        List<TaskTab> taskTabs = new List<TaskTab>();

        List<PictureBox> mainPics;
        List<CheckBox> mainChecks;

        PictureBox mainPic;
        CheckBox mainCheck;

        public Tasks(string friendlyTitle, Overlay overlay)
        {
            this.friendlyTitle = friendlyTitle;
            this.overlay = overlay;

            InitializeComponent();
            FillGrid();
        }

        public void FillGrid()
        {
            mainPics = new List<PictureBox>();
            mainChecks = new List<CheckBox>();

            Console.WriteLine(TasksTab.Controls.Count);

            while (TasksTab.Controls.Count > 0)
            {
                TasksTab.Controls.RemoveAt(0);
            }

            tasks = Directory.GetDirectories("Tasks\\" + friendlyTitle);
            int taskCount = tasks.Length;

            int xPos = -100;
            int yPos = 6;

            for (int index = 0; index < taskCount; index++)
            {
                xPos += 106;

                if (xPos < TasksTab.Size.Width - 106)
                {
                    mainPic = new PictureBox();
                    mainPic.Location = new Point(xPos, yPos);
                    mainPic.Size = new Size(100, 100);
                    mainPic.BorderStyle = BorderStyle.FixedSingle;
                    mainPic.BackgroundImageLayout = ImageLayout.Zoom;
                    try { mainPic.BackgroundImage = Image.FromFile(tasks[index] + "\\img.png"); } catch (FileNotFoundException) { mainPic.BackgroundImage = null; }
                    mainPic.Tag = index;
                    mainPic.Click += MainPic_Click;

                    mainCheck = new CheckBox();
                    mainCheck.Location = new Point(xPos, yPos + 106);
                    mainCheck.Text = "Complete?";
                    if (File.Exists(tasks[index] + "\\fullComplete.txt"))
                        mainCheck.Checked = true;

                    mainPics.Add(mainPic);
                    mainChecks.Add(mainCheck);

                    TasksTab.Controls.Add(mainPic);
                    TasksTab.Controls.Add(mainCheck);
                }
                else
                {
                    xPos = 6;
                    yPos += 129;

                    mainPic = new PictureBox();
                    mainPic.Location = new Point(xPos, yPos);
                    mainPic.Size = new Size(100, 100);
                    mainPic.BackgroundImageLayout = ImageLayout.Zoom;
                    try { mainPic.BackgroundImage = Image.FromFile(tasks[index] + "\\img.png"); } catch (FileNotFoundException) { mainPic.BackgroundImage = null; }
                    mainPic.Tag = index;
                    mainPic.Click += MainPic_Click;

                    mainCheck = new CheckBox();
                    mainCheck.Location = new Point(xPos, yPos + 106);
                    mainCheck.Text = "Complete?";

                    mainPics.Add(mainPic);
                    mainChecks.Add(mainCheck);

                    TasksTab.Controls.Add(mainPic);
                    TasksTab.Controls.Add(mainCheck);
                }
            }

            xPos += 106;

            if (xPos < TasksTab.Size.Width - 106)
            {
                mainPic = new PictureBox();
                mainPic.Location = new Point(xPos, yPos);
                mainPic.Size = new Size(100, 100);
                mainPic.BackgroundImageLayout = ImageLayout.Zoom;
                mainPic.BackgroundImage = Image.FromFile(overlay.refer.refer.config.resourcePath + "\\New Task.png");
                mainPic.Tag = "New";
                mainPic.Click += MainPic_Click;

                mainPics.Add(mainPic);

                TasksTab.Controls.Add(mainPic);
            }
            else
            {
                xPos = 6;
                yPos += 129;

                mainPic = new PictureBox();
                mainPic.Location = new Point(xPos, yPos);
                mainPic.Size = new Size(100, 100);
                mainPic.BackgroundImageLayout = ImageLayout.Zoom;
                mainPic.BackgroundImage = Image.FromFile(overlay.refer.refer.config.resourcePath + "\\New Task.png");
                mainPic.Tag = "New";
                mainPic.Click += MainPic_Click;

                mainPics.Add(mainPic);

                TasksTab.Controls.Add(mainPic);
            }
        }

        private void MainPic_Click(object sender, EventArgs e)
        {
            PictureBox tempBox = (PictureBox) sender;
            string tag = tempBox.Tag.ToString();

            if (tag != "New")
            {
                int tagIndex = Convert.ToInt32(tag);
                TaskTab taskTab = new TaskTab(tasks[tagIndex]);

                // create tab?

                taskTabs.Add(taskTab);

                MainTabs.TabPages.Add(taskTab.tabPage);
                MainTabs.SelectedTab = taskTab.tabPage;
            }
            else
            {
                TaskCreate taskCreate = new TaskCreate(friendlyTitle, this);
                taskCreate.Show();
            }
        }
    }
}
