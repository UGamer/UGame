namespace The_UGamer_Launcher
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SystemTime = new System.Windows.Forms.Label();
            this.BrowserButton = new System.Windows.Forms.Button();
            this.NotepadButton = new System.Windows.Forms.Button();
            this.ScreenshotLabel = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ScreenshotsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(13, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(224, 79);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.UseMnemonic = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(617, 102);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(171, 13);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "Current Time Playing: 00h:00m:00s";
            // 
            // SystemTime
            // 
            this.SystemTime.AutoSize = true;
            this.SystemTime.Location = new System.Drawing.Point(12, 9);
            this.SystemTime.Name = "SystemTime";
            this.SystemTime.Size = new System.Drawing.Size(84, 13);
            this.SystemTime.TabIndex = 2;
            this.SystemTime.Text = "Loading Clock...";
            // 
            // BrowserButton
            // 
            this.BrowserButton.Location = new System.Drawing.Point(15, 92);
            this.BrowserButton.Name = "BrowserButton";
            this.BrowserButton.Size = new System.Drawing.Size(90, 23);
            this.BrowserButton.TabIndex = 3;
            this.BrowserButton.Text = "Show Browser";
            this.BrowserButton.UseVisualStyleBackColor = true;
            this.BrowserButton.Click += new System.EventHandler(this.BrowserButton_Click);
            // 
            // NotepadButton
            // 
            this.NotepadButton.Location = new System.Drawing.Point(111, 92);
            this.NotepadButton.Name = "NotepadButton";
            this.NotepadButton.Size = new System.Drawing.Size(90, 23);
            this.NotepadButton.TabIndex = 4;
            this.NotepadButton.Text = "Notepad";
            this.NotepadButton.UseVisualStyleBackColor = true;
            this.NotepadButton.Click += new System.EventHandler(this.NotepadButton_Click);
            // 
            // ScreenshotLabel
            // 
            this.ScreenshotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenshotLabel.AutoSize = true;
            this.ScreenshotLabel.Location = new System.Drawing.Point(582, 9);
            this.ScreenshotLabel.Name = "ScreenshotLabel";
            this.ScreenshotLabel.Size = new System.Drawing.Size(110, 13);
            this.ScreenshotLabel.TabIndex = 5;
            this.ScreenshotLabel.Text = "Screenshot Captured!";
            this.ScreenshotLabel.Visible = false;
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseButton.Location = new System.Drawing.Point(519, 97);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(92, 23);
            this.PauseButton.TabIndex = 6;
            this.PauseButton.Text = "Pause Playing";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ScreenshotsButton
            // 
            this.ScreenshotsButton.Location = new System.Drawing.Point(698, 4);
            this.ScreenshotsButton.Name = "ScreenshotsButton";
            this.ScreenshotsButton.Size = new System.Drawing.Size(90, 23);
            this.ScreenshotsButton.TabIndex = 7;
            this.ScreenshotsButton.Text = "Screenshots";
            this.ScreenshotsButton.UseVisualStyleBackColor = true;
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 128);
            this.Controls.Add(this.ScreenshotsButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.ScreenshotLabel);
            this.Controls.Add(this.NotepadButton);
            this.Controls.Add(this.BrowserButton);
            this.Controls.Add(this.SystemTime);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Overlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Overlay";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Overlay_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label SystemTime;
        private System.Windows.Forms.Button BrowserButton;
        private System.Windows.Forms.Button NotepadButton;
        private System.Windows.Forms.Label ScreenshotLabel;
        public System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ScreenshotsButton;
    }
}