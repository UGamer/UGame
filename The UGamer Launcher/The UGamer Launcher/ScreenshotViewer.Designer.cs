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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenshotViewer));
            this.ChooseGameCombo = new System.Windows.Forms.ComboBox();
            this.FocusedPictureBox = new System.Windows.Forms.PictureBox();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.TimeTakenLabel = new System.Windows.Forms.Label();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.DetailLabels = new System.Windows.Forms.Label();
            this.ImagesPanel = new System.Windows.Forms.Panel();
            this.NoScreenshotsLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FocusedPictureBox)).BeginInit();
            this.DetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseGameCombo
            // 
            this.ChooseGameCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseGameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseGameCombo.Enabled = false;
            this.ChooseGameCombo.FormattingEnabled = true;
            this.ChooseGameCombo.Location = new System.Drawing.Point(20, 22);
            this.ChooseGameCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChooseGameCombo.Name = "ChooseGameCombo";
            this.ChooseGameCombo.Size = new System.Drawing.Size(1160, 28);
            this.ChooseGameCombo.TabIndex = 0;
            // 
            // FocusedPictureBox
            // 
            this.FocusedPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FocusedPictureBox.Location = new System.Drawing.Point(20, 63);
            this.FocusedPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FocusedPictureBox.Name = "FocusedPictureBox";
            this.FocusedPictureBox.Size = new System.Drawing.Size(808, 465);
            this.FocusedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FocusedPictureBox.TabIndex = 1;
            this.FocusedPictureBox.TabStop = false;
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailsPanel.Controls.Add(this.DeleteButton);
            this.DetailsPanel.Controls.Add(this.RenameButton);
            this.DetailsPanel.Controls.Add(this.ExpandButton);
            this.DetailsPanel.Controls.Add(this.TimeTakenLabel);
            this.DetailsPanel.Controls.Add(this.GameNameLabel);
            this.DetailsPanel.Controls.Add(this.FileNameLabel);
            this.DetailsPanel.Controls.Add(this.DetailLabels);
            this.DetailsPanel.Location = new System.Drawing.Point(837, 63);
            this.DetailsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(344, 464);
            this.DetailsPanel.TabIndex = 2;
            // 
            // ExpandButton
            // 
            this.ExpandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpandButton.Location = new System.Drawing.Point(233, 417);
            this.ExpandButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpandButton.Name = "ExpandButton";
            this.ExpandButton.Size = new System.Drawing.Size(111, 46);
            this.ExpandButton.TabIndex = 4;
            this.ExpandButton.Text = "Expand";
            this.ExpandButton.UseVisualStyleBackColor = true;
            this.ExpandButton.Click += new System.EventHandler(this.ExpandButton_Click);
            // 
            // TimeTakenLabel
            // 
            this.TimeTakenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTakenLabel.AutoSize = true;
            this.TimeTakenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTakenLabel.Location = new System.Drawing.Point(107, 388);
            this.TimeTakenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeTakenLabel.Name = "TimeTakenLabel";
            this.TimeTakenLabel.Size = new System.Drawing.Size(58, 22);
            this.TimeTakenLabel.TabIndex = 3;
            this.TimeTakenLabel.Text = "label1";
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNameLabel.Location = new System.Drawing.Point(59, 212);
            this.GameNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(58, 22);
            this.GameNameLabel.TabIndex = 2;
            this.GameNameLabel.Text = "label1";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLabel.Location = new System.Drawing.Point(92, 14);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(58, 22);
            this.FileNameLabel.TabIndex = 1;
            this.FileNameLabel.Text = "label1";
            // 
            // DetailLabels
            // 
            this.DetailLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailLabels.AutoSize = true;
            this.DetailLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailLabels.Location = new System.Drawing.Point(-2, 14);
            this.DetailLabels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetailLabels.Name = "DetailLabels";
            this.DetailLabels.Size = new System.Drawing.Size(116, 396);
            this.DetailLabels.TabIndex = 0;
            this.DetailLabels.Text = "File Name: \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nGame: \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nTime Taken: ";
            // 
            // ImagesPanel
            // 
            this.ImagesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagesPanel.AutoScroll = true;
            this.ImagesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagesPanel.Location = new System.Drawing.Point(20, 537);
            this.ImagesPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImagesPanel.Name = "ImagesPanel";
            this.ImagesPanel.Size = new System.Drawing.Size(1162, 287);
            this.ImagesPanel.TabIndex = 3;
            // 
            // NoScreenshotsLabel
            // 
            this.NoScreenshotsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoScreenshotsLabel.AutoSize = true;
            this.NoScreenshotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoScreenshotsLabel.Location = new System.Drawing.Point(146, 275);
            this.NoScreenshotsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoScreenshotsLabel.Name = "NoScreenshotsLabel";
            this.NoScreenshotsLabel.Size = new System.Drawing.Size(534, 37);
            this.NoScreenshotsLabel.TabIndex = 4;
            this.NoScreenshotsLabel.Text = "No screenshots found for this game!";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.Location = new System.Drawing.Point(4, 818);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(112, 35);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameButton.Enabled = false;
            this.RenameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenameButton.Location = new System.Drawing.Point(-1, 417);
            this.RenameButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(111, 46);
            this.RenameButton.TabIndex = 5;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(116, 417);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 46);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ScreenshotViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 858);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NoScreenshotsLabel);
            this.Controls.Add(this.ImagesPanel);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.ChooseGameCombo);
            this.Controls.Add(this.FocusedPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScreenshotViewer";
            this.Text = "Screenshots";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.FocusedPictureBox)).EndInit();
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
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
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RenameButton;
    }
}