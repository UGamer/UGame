namespace The_UGamer_Launcher
{
    partial class GameDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDetails));
            this.nameLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.obtainedLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.launcher = new System.Windows.Forms.WebBrowser();
            this.gamePicture = new System.Windows.Forms.PictureBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.noImageText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(416, 12);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(17, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "s";
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Location = new System.Drawing.Point(416, 88);
            this.platformLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(17, 20);
            this.platformLabel.TabIndex = 2;
            this.platformLabel.Text = "s";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(416, 131);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(17, 20);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "s";
            // 
            // obtainedLabel
            // 
            this.obtainedLabel.AutoSize = true;
            this.obtainedLabel.Location = new System.Drawing.Point(416, 269);
            this.obtainedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.obtainedLabel.Name = "obtainedLabel";
            this.obtainedLabel.Size = new System.Drawing.Size(17, 20);
            this.obtainedLabel.TabIndex = 4;
            this.obtainedLabel.Text = "s";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(416, 217);
            this.hoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(17, 20);
            this.hoursLabel.TabIndex = 5;
            this.hoursLabel.Text = "s";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(416, 171);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(17, 20);
            this.ratingLabel.TabIndex = 6;
            this.ratingLabel.Text = "s";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(416, 309);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(17, 20);
            this.endDateLabel.TabIndex = 7;
            this.endDateLabel.Text = "s";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(416, 288);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(17, 20);
            this.startDateLabel.TabIndex = 8;
            this.startDateLabel.Text = "s";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(416, 348);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(136, 20);
            this.notesLabel.TabIndex = 9;
            this.notesLabel.Text = "Notes/Comments:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // launcher
            // 
            this.launcher.Location = new System.Drawing.Point(508, 18);
            this.launcher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.launcher.MinimumSize = new System.Drawing.Size(30, 31);
            this.launcher.Name = "launcher";
            this.launcher.Size = new System.Drawing.Size(375, 385);
            this.launcher.TabIndex = 12;
            this.launcher.Visible = false;
            // 
            // gamePicture
            // 
            this.gamePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gamePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePicture.Location = new System.Drawing.Point(12, 12);
            this.gamePicture.Name = "gamePicture";
            this.gamePicture.Size = new System.Drawing.Size(394, 409);
            this.gamePicture.TabIndex = 13;
            this.gamePicture.TabStop = false;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(416, 374);
            this.notesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.ReadOnly = true;
            this.notesBox.Size = new System.Drawing.Size(499, 93);
            this.notesBox.TabIndex = 14;
            // 
            // noImageText
            // 
            this.noImageText.Location = new System.Drawing.Point(28, 183);
            this.noImageText.Multiline = true;
            this.noImageText.Name = "noImageText";
            this.noImageText.Size = new System.Drawing.Size(358, 66);
            this.noImageText.TabIndex = 15;
            this.noImageText.Text = "Image not found.";
            this.noImageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.noImageText.Visible = false;
            // 
            // GameDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 492);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.obtainedLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.platformLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.launcher);
            this.Controls.Add(this.noImageText);
            this.Controls.Add(this.gamePicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameDetails";
            this.Text = "GameDetails";
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label obtainedLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser launcher;
        private System.Windows.Forms.PictureBox gamePicture;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.TextBox noImageText;
    }
}