namespace UGame
{
    partial class Tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.TasksTab = new System.Windows.Forms.TabPage();
            this.MainTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.TasksTab);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(662, 502);
            this.MainTabs.TabIndex = 2;
            // 
            // TasksTab
            // 
            this.TasksTab.Location = new System.Drawing.Point(4, 22);
            this.TasksTab.Name = "TasksTab";
            this.TasksTab.Padding = new System.Windows.Forms.Padding(3);
            this.TasksTab.Size = new System.Drawing.Size(654, 476);
            this.TasksTab.TabIndex = 0;
            this.TasksTab.Text = "[TASKS]";
            this.TasksTab.UseVisualStyleBackColor = true;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 502);
            this.Controls.Add(this.MainTabs);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.MainTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage TasksTab;
    }
}