namespace UGame
{
    partial class Overlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.TimerBox = new System.Windows.Forms.TextBox();
            this.WebBrowserButton = new System.Windows.Forms.Button();
            this.NotesButton = new System.Windows.Forms.Button();
            this.TasksButton = new System.Windows.Forms.Button();
            this.AchievementsButton = new System.Windows.Forms.Button();
            this.UMusicButton = new System.Windows.Forms.Button();
            this.ScreenshotsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconBox
            // 
            this.IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconBox.Location = new System.Drawing.Point(13, 13);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(80, 80);
            this.IconBox.TabIndex = 0;
            this.IconBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(99, 29);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(131, 44);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "label1";
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(3, 96);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(306, 58);
            this.ClockLabel.TabIndex = 2;
            this.ClockLabel.Text = "12:00:00 AM";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(15, 145);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(416, 39);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Saturday, June 22nd 2019";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.PauseButton);
            this.panel1.Controls.Add(this.TimerBox);
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 81);
            this.panel1.TabIndex = 4;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(372, 16);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(59, 49);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(307, 16);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(59, 49);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // TimerBox
            // 
            this.TimerBox.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerBox.Location = new System.Drawing.Point(12, 16);
            this.TimerBox.Multiline = true;
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(286, 49);
            this.TimerBox.TabIndex = 0;
            this.TimerBox.Text = "00h:00m:00s";
            this.TimerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WebBrowserButton
            // 
            this.WebBrowserButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebBrowserButton.Location = new System.Drawing.Point(12, 281);
            this.WebBrowserButton.Name = "WebBrowserButton";
            this.WebBrowserButton.Size = new System.Drawing.Size(415, 49);
            this.WebBrowserButton.TabIndex = 5;
            this.WebBrowserButton.Text = "WEB BROWSER";
            this.WebBrowserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WebBrowserButton.UseVisualStyleBackColor = true;
            this.WebBrowserButton.Click += new System.EventHandler(this.WebBrowserButton_Click);
            // 
            // NotesButton
            // 
            this.NotesButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesButton.Location = new System.Drawing.Point(12, 336);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Size = new System.Drawing.Size(415, 49);
            this.NotesButton.TabIndex = 6;
            this.NotesButton.Text = "NOTES";
            this.NotesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotesButton.UseVisualStyleBackColor = true;
            this.NotesButton.Click += new System.EventHandler(this.NotesButton_Click);
            // 
            // TasksButton
            // 
            this.TasksButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksButton.Location = new System.Drawing.Point(12, 391);
            this.TasksButton.Name = "TasksButton";
            this.TasksButton.Size = new System.Drawing.Size(415, 49);
            this.TasksButton.TabIndex = 7;
            this.TasksButton.Text = "TASKS";
            this.TasksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TasksButton.UseVisualStyleBackColor = true;
            // 
            // AchievementsButton
            // 
            this.AchievementsButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchievementsButton.Location = new System.Drawing.Point(12, 446);
            this.AchievementsButton.Name = "AchievementsButton";
            this.AchievementsButton.Size = new System.Drawing.Size(415, 49);
            this.AchievementsButton.TabIndex = 8;
            this.AchievementsButton.Text = "ACHIEVEMENTS";
            this.AchievementsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AchievementsButton.UseVisualStyleBackColor = true;
            // 
            // UMusicButton
            // 
            this.UMusicButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UMusicButton.Location = new System.Drawing.Point(12, 556);
            this.UMusicButton.Name = "UMusicButton";
            this.UMusicButton.Size = new System.Drawing.Size(415, 49);
            this.UMusicButton.TabIndex = 10;
            this.UMusicButton.Text = "UMUSIC";
            this.UMusicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UMusicButton.UseVisualStyleBackColor = true;
            // 
            // ScreenshotsButton
            // 
            this.ScreenshotsButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenshotsButton.Location = new System.Drawing.Point(12, 501);
            this.ScreenshotsButton.Name = "ScreenshotsButton";
            this.ScreenshotsButton.Size = new System.Drawing.Size(415, 49);
            this.ScreenshotsButton.TabIndex = 9;
            this.ScreenshotsButton.Text = "SCREENSHOTS";
            this.ScreenshotsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScreenshotsButton.UseVisualStyleBackColor = true;
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(439, 624);
            this.Controls.Add(this.UMusicButton);
            this.Controls.Add(this.ScreenshotsButton);
            this.Controls.Add(this.AchievementsButton);
            this.Controls.Add(this.TasksButton);
            this.Controls.Add(this.NotesButton);
            this.Controls.Add(this.WebBrowserButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.IconBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Overlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Overlay";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Overlay_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TimerBox;
        private System.Windows.Forms.Button StopButton;
        public System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button WebBrowserButton;
        private System.Windows.Forms.Button NotesButton;
        private System.Windows.Forms.Button TasksButton;
        private System.Windows.Forms.Button AchievementsButton;
        private System.Windows.Forms.Button UMusicButton;
        private System.Windows.Forms.Button ScreenshotsButton;
    }
}