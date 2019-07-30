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
        string taskPath;

        public TabPage tabPage = new TabPage();

        PictureBox imgBox = new PictureBox();
        TextBox taskBox = new TextBox();
        CheckBox checkBox = new CheckBox();
        Button editButton = new Button();
        Button saveButton = new Button();
        TreeView treeView = new TreeView();

        string textFile;
        string checkFile;

        string[,] nodeTable;

        public TaskTab(string taskPath)
        {
            this.taskPath = taskPath;

            // get the task name

            string taskName = taskPath;
            while (taskName.IndexOf("\\") != -1)
            {
                taskName = taskName.Substring(taskName.IndexOf("\\") + 1);
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
            taskBox.Enabled = false;

            checkBox.Location = new Point(145, 92);
            checkBox.AutoSize = true;
            checkBox.UseVisualStyleBackColor = true;
            checkBox.Text = "Complete?";
            checkBox.CheckedChanged += CheckBox_CheckedChanged;

            editButton.Location = new Point(145, 114);
            editButton.Size = new Size(75, 23);
            editButton.UseVisualStyleBackColor = true;
            editButton.Text = "Edit Mode";

            saveButton.Location = new Point(230, 114);
            saveButton.Size = new Size(75, 23);
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Text = "Save";
            saveButton.Click += SaveButton_Click;

            treeView.Dock = DockStyle.Bottom;
            treeView.Size = new Size(648, 330);
            treeView.CheckBoxes = true;
            //
            // count all of the nodes and assign them values

            textFile = File.ReadAllText(taskPath + "\\text.txt", Encoding.UTF8);

            string[] lines = textFile.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] checks = new string[lines.Length];

            for (int index = 0; index < lines.Length; index++)
            {
                checks[index] = lines[index].Substring(lines[index].Length - 1);

                lines[index] = lines[index].Substring(0, lines[index].Length - 2);
            }

            treeView.Nodes.Clear();
            Dictionary<int, TreeNode> parents = new Dictionary<int, TreeNode>();
            int checkIndex = 0;
            foreach (string text_line in lines)
            {
                // See how many tabs are at the start of the line.
                int level = text_line.Length - text_line.TrimStart('\t').Length;

                // Add the new node.
                if (level == 0)
                    parents[level] = treeView.Nodes.Add(text_line.Trim());
                else
                    parents[level] = parents[level - 1].Nodes.Add(text_line.Trim());

                parents[level].EnsureVisible();

                if (checks[checkIndex] == "Y")
                    parents[level].Checked = true;

                checkIndex++;
            }

            if (treeView.Nodes.Count > 0)
                treeView.Nodes[0].EnsureVisible();
            
            //
            // Add all contents to tabpage

            tabPage.Controls.Add(imgBox);
            tabPage.Controls.Add(taskBox);
            tabPage.Controls.Add(checkBox);
            tabPage.Controls.Add(editButton);
            tabPage.Controls.Add(saveButton);
            tabPage.Controls.Add(treeView);

            //
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (TreeNode node in treeView.Nodes)
                WriteNodeIntoString(0, node, sb);

            // Write the result into the file.
            File.WriteAllText(taskPath + "\\text.txt", sb.ToString());

            bool fullComplete = true;
            foreach (TreeNode node in treeView.Nodes)
            {
                if (!node.Checked)
                {
                    fullComplete = false;
                    break;
                }
            }

            if (fullComplete)
            {
                // if (!File.Exists(taskPath + "\\fullComplete.txt"))
                    File.Create(taskPath + "\\fullComplete.txt");
            }
            else
            {
                // if (File.Exists(taskPath + "\\fullComplete.txt"))
                    File.Delete(taskPath + "\\fullComplete.txt");
            }
        }

        private void WriteNodeIntoString(int level, TreeNode node, StringBuilder sb)
        {
            // Append the correct number of tabs and the node's text.
            if (node.Checked)
                sb.AppendLine(new string('\t', level) + node.Text + ";Y");
            else
                sb.AppendLine(new string('\t', level) + node.Text + ";N");
            
            // Recursively add children with one greater level of tabs.
            foreach (TreeNode child in node.Nodes)
                WriteNodeIntoString(level + 1, child, sb);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                CheckAllNodes(treeView.Nodes);
            }
            else
            {
                UncheckAllNodes(treeView.Nodes);
            }
        }

        public void CheckAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = true;
                CheckChildren(node, true);
            }
        }

        public void UncheckAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = false;
                CheckChildren(node, false);
            }
        }

        private void CheckChildren(TreeNode rootNode, bool isChecked)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                CheckChildren(node, isChecked);
                node.Checked = isChecked;
            }
        }
    }
}
