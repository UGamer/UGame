using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public class TaskTab
    {
        public TabPage tabPage = new TabPage();

        PictureBox imgBox = new PictureBox();
        TextBox taskBox = new TextBox();
        CheckBox checkBox = new CheckBox();
        Button editButton = new Button();
        TreeView treeView = new TreeView();

        string textFile;
        string checkFile;

        string[,] nodeTable;

        public TaskTab(string taskPath)
        {
            // get the task name

            string taskName = taskPath;
            while (taskName.IndexOf("\\") != -1)
            {
                taskName = taskName.Substring(taskName.IndexOf("\\") + 1);
            }

            //
            // count all of the nodes and assign them values

            textFile = File.ReadAllText(taskPath + "\\text.txt", Encoding.UTF8);
            checkFile = File.ReadAllText(taskPath + "\\check.txt", Encoding.UTF8);

            string checkFileCopy = checkFile;
            int nodeCount = 0;
            while (checkFileCopy.IndexOf("\n") != -1)
            {
                checkFileCopy = checkFileCopy.Substring(checkFileCopy.IndexOf("\n") + 1);
                nodeCount++;
            }

            nodeTable = new string[nodeCount, 2];

            string textFileCopy = textFile;
            checkFileCopy = checkFile;
            for (int index = 0; index < nodeCount; index++)
            {
                try { nodeTable[index, 0] = textFileCopy.Substring(0, textFileCopy.IndexOf("\n")); } catch { nodeTable[index, 0] = textFileCopy; }
                textFileCopy = textFileCopy.Substring(textFileCopy.IndexOf("\n") + 1);
                Console.WriteLine();

                try { nodeTable[index, 1] = checkFileCopy.Substring(0, checkFileCopy.IndexOf("\n")); } catch { nodeTable[index, 1] = checkFileCopy; }
                checkFileCopy = checkFileCopy.Substring(checkFileCopy.IndexOf("\n") + 1);
            }

            //
            // Create the tabpage

            tabPage.Text = taskName;
            tabPage.UseVisualStyleBackColor = true;

            imgBox.Location = new Point(9, 7);
            imgBox.Size = new Size(130, 130);
            imgBox.BackgroundImageLayout = ImageLayout.Zoom;
            imgBox.BackgroundImage = Image.FromFile(taskPath + "\\img.png");

            taskBox.Font = new Font("Century Gothic", 24);
            taskBox.Location = new Point(145, 39);
            taskBox.Size = new Size(501, 47);
            taskBox.Text = taskName;

            checkBox.Location = new Point(145, 92);
            checkBox.AutoSize = true;
            checkBox.UseVisualStyleBackColor = true;
            checkBox.Text = "Complete?";

            editButton.Location = new Point(145, 114);
            editButton.Size = new Size(75, 23);
            editButton.UseVisualStyleBackColor = true;
            editButton.Text = "Edit Mode";

            treeView.Dock = DockStyle.Bottom;
            treeView.Size = new Size(648, 330);

            // treeView.Nodes[0].Nodes.

            //
            // Add all contents to tabpage

            tabPage.Controls.Add(imgBox);
            tabPage.Controls.Add(taskBox);
            tabPage.Controls.Add(checkBox);
            tabPage.Controls.Add(editButton);
            tabPage.Controls.Add(treeView);

            //

            
        }
    }
}
