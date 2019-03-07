namespace The_UGamer_Launcher
{
    partial class ScreenshotViewer
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
            this.ChooseGameCombo = new System.Windows.Forms.ComboBox();
            this.FocusedPictureBox = new System.Windows.Forms.PictureBox();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.DetailLabels = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.TimeTakenLabel = new System.Windows.Forms.Label();
            this.ImagesPanel = new System.Windows.Forms.Panel();
            this.NoScreenshotsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FocusedPictureBox)).BeginInit();
            this.DetailsPanel.SuspendLayout();
            this.ImagesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseGameCombo
            // 
            this.ChooseGameCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseGameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseGameCombo.FormattingEnabled = true;
            this.ChooseGameCombo.Location = new System.Drawing.Point(13, 14);
            this.ChooseGameCombo.Name = "ChooseGameCombo";
            this.ChooseGameCombo.Size = new System.Drawing.Size(775, 21);
            this.ChooseGameCombo.TabIndex = 0;
            // 
            // FocusedPictureBox
            // 
            this.FocusedPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FocusedPictureBox.Location = new System.Drawing.Point(13, 41);
            this.FocusedPictureBox.Name = "FocusedPictureBox";
            this.FocusedPictureBox.Size = new System.Drawing.Size(538, 297);
            this.FocusedPictureBox.TabIndex = 1;
            this.FocusedPictureBox.TabStop = false;
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsPanel.Controls.Add(this.TimeTakenLabel);
            this.DetailsPanel.Controls.Add(this.GameNameLabel);
            this.DetailsPanel.Controls.Add(this.FileNameLabel);
            this.DetailsPanel.Controls.Add(this.DetailLabels);
            this.DetailsPanel.Location = new System.Drawing.Point(558, 41);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(230, 297);
            this.DetailsPanel.TabIndex = 2;
            // 
            // DetailLabels
            // 
            this.DetailLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailLabels.AutoSize = true;
            this.DetailLabels.Location = new System.Drawing.Point(3, 29);
            this.DetailLabels.Name = "DetailLabels";
            this.DetailLabels.Size = new System.Drawing.Size(70, 234);
            this.DetailLabels.TabIndex = 0;
            this.DetailLabels.Text = "File Name: \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nGame: \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nTime Taken: ";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(80, 29);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(35, 13);
            this.FileNameLabel.TabIndex = 1;
            this.FileNameLabel.Text = "label1";
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Location = new System.Drawing.Point(80, 147);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(35, 13);
            this.GameNameLabel.TabIndex = 2;
            this.GameNameLabel.Text = "label1";
            // 
            // TimeTakenLabel
            // 
            this.TimeTakenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTakenLabel.AutoSize = true;
            this.TimeTakenLabel.Location = new System.Drawing.Point(80, 250);
            this.TimeTakenLabel.Name = "TimeTakenLabel";
            this.TimeTakenLabel.Size = new System.Drawing.Size(35, 13);
            this.TimeTakenLabel.TabIndex = 3;
            this.TimeTakenLabel.Text = "label1";
            // 
            // ImagesPanel
            // 
            this.ImagesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagesPanel.Controls.Add(this.panel1);
            this.ImagesPanel.Location = new System.Drawing.Point(13, 345);
            this.ImagesPanel.Name = "ImagesPanel";
            this.ImagesPanel.Size = new System.Drawing.Size(775, 109);
            this.ImagesPanel.TabIndex = 3;
            // 
            // NoScreenshotsLabel
            // 
            this.NoScreenshotsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoScreenshotsLabel.AutoSize = true;
            this.NoScreenshotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoScreenshotsLabel.Location = new System.Drawing.Point(97, 179);
            this.NoScreenshotsLabel.Name = "NoScreenshotsLabel";
            this.NoScreenshotsLabel.Size = new System.Drawing.Size(358, 25);
            this.NoScreenshotsLabel.TabIndex = 4;
            this.NoScreenshotsLabel.Text = "No screenshots found for this game!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 74);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 106);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // ScreenshotViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.NoScreenshotsLabel);
            this.Controls.Add(this.ImagesPanel);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.FocusedPictureBox);
            this.Controls.Add(this.ChooseGameCombo);
            this.Name = "ScreenshotViewer";
            this.Text = "ScreenshotViewer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.FocusedPictureBox)).EndInit();
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            this.ImagesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseGameCombo;
        private System.Windows.Forms.PictureBox FocusedPictureBox;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Label DetailLabels;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.Label TimeTakenLabel;
        private System.Windows.Forms.Panel ImagesPanel;
        private System.Windows.Forms.Label NoScreenshotsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}