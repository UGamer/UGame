namespace UGame
{
    partial class GameSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSummary));
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.SubtitleBox = new System.Windows.Forms.TextBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.TimeSummaryBox = new System.Windows.Forms.TextBox();
            this.TimePlayedLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconBox
            // 
            this.IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconBox.Location = new System.Drawing.Point(13, 13);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(86, 86);
            this.IconBox.TabIndex = 2;
            this.IconBox.TabStop = false;
            // 
            // SubtitleBox
            // 
            this.SubtitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtitleBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleBox.Location = new System.Drawing.Point(105, 79);
            this.SubtitleBox.Name = "SubtitleBox";
            this.SubtitleBox.Size = new System.Drawing.Size(518, 21);
            this.SubtitleBox.TabIndex = 4;
            this.SubtitleBox.Text = "Game Summary";
            this.SubtitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPanel.Controls.Add(this.TimeSummaryBox);
            this.InfoPanel.Controls.Add(this.TimePlayedLabel);
            this.InfoPanel.Location = new System.Drawing.Point(13, 106);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(610, 331);
            this.InfoPanel.TabIndex = 5;
            // 
            // TimeSummaryBox
            // 
            this.TimeSummaryBox.AcceptsReturn = true;
            this.TimeSummaryBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSummaryBox.Location = new System.Drawing.Point(16, 37);
            this.TimeSummaryBox.Multiline = true;
            this.TimeSummaryBox.Name = "TimeSummaryBox";
            this.TimeSummaryBox.ReadOnly = true;
            this.TimeSummaryBox.Size = new System.Drawing.Size(576, 277);
            this.TimeSummaryBox.TabIndex = 1;
            // 
            // TimePlayedLabel
            // 
            this.TimePlayedLabel.AutoSize = true;
            this.TimePlayedLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePlayedLabel.Location = new System.Drawing.Point(12, 12);
            this.TimePlayedLabel.Name = "TimePlayedLabel";
            this.TimePlayedLabel.Size = new System.Drawing.Size(194, 21);
            this.TimePlayedLabel.TabIndex = 0;
            this.TimePlayedLabel.Text = "Time Played from \"\" to \"\":";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(251, 443);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(123, 36);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(105, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(170, 56);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "label1";
            // 
            // GameSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(632, 491);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.SubtitleBox);
            this.Controls.Add(this.IconBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameSummary";
            this.Text = "GameSummary";
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.TextBox SubtitleBox;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TimePlayedLabel;
        private System.Windows.Forms.TextBox TimeSummaryBox;
    }
}