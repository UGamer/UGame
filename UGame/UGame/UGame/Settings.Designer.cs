namespace UGame
{
    partial class Settings
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
            this.MainFormTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainFormLabels = new UGame.NotesTextBox();
            this.MainTabs.SuspendLayout();
            this.MainFormTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.MainFormTab);
            this.MainTabs.Controls.Add(this.tabPage2);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(800, 450);
            this.MainTabs.TabIndex = 0;
            // 
            // MainFormTab
            // 
            this.MainFormTab.Controls.Add(this.MainFormLabels);
            this.MainFormTab.Location = new System.Drawing.Point(4, 22);
            this.MainFormTab.Name = "MainFormTab";
            this.MainFormTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainFormTab.Size = new System.Drawing.Size(792, 424);
            this.MainFormTab.TabIndex = 0;
            this.MainFormTab.Text = "Main Form";
            this.MainFormTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainFormLabels
            // 
            this.MainFormLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MainFormLabels.Location = new System.Drawing.Point(9, 7);
            this.MainFormLabels.Multiline = true;
            this.MainFormLabels.Name = "MainFormLabels";
            this.MainFormLabels.Size = new System.Drawing.Size(145, 410);
            this.MainFormLabels.TabIndex = 0;
            this.MainFormLabels.Text = "s";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabs);
            this.Name = "Settings";
            this.Text = "Settings";
            this.MainTabs.ResumeLayout(false);
            this.MainFormTab.ResumeLayout(false);
            this.MainFormTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage MainFormTab;
        private System.Windows.Forms.TabPage tabPage2;
        private NotesTextBox MainFormLabels;
    }
}