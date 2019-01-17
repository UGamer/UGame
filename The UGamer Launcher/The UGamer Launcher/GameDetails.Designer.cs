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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.noImageLabel = new System.Windows.Forms.Label();
            this.launcher = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 266);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(277, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(12, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "s";
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Location = new System.Drawing.Point(277, 57);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(12, 13);
            this.platformLabel.TabIndex = 2;
            this.platformLabel.Text = "s";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(277, 85);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(12, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "s";
            // 
            // obtainedLabel
            // 
            this.obtainedLabel.AutoSize = true;
            this.obtainedLabel.Location = new System.Drawing.Point(277, 175);
            this.obtainedLabel.Name = "obtainedLabel";
            this.obtainedLabel.Size = new System.Drawing.Size(12, 13);
            this.obtainedLabel.TabIndex = 4;
            this.obtainedLabel.Text = "s";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(277, 141);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(12, 13);
            this.hoursLabel.TabIndex = 5;
            this.hoursLabel.Text = "s";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(277, 111);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(12, 13);
            this.ratingLabel.TabIndex = 6;
            this.ratingLabel.Text = "s";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(277, 201);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(12, 13);
            this.endDateLabel.TabIndex = 7;
            this.endDateLabel.Text = "s";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(277, 187);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(12, 13);
            this.startDateLabel.TabIndex = 8;
            this.startDateLabel.Text = "s";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(277, 226);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(12, 13);
            this.notesLabel.TabIndex = 9;
            this.notesLabel.Text = "s";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noImageLabel
            // 
            this.noImageLabel.AutoSize = true;
            this.noImageLabel.Location = new System.Drawing.Point(95, 141);
            this.noImageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noImageLabel.Name = "noImageLabel";
            this.noImageLabel.Size = new System.Drawing.Size(87, 13);
            this.noImageLabel.TabIndex = 11;
            this.noImageLabel.Text = "Image not found.";
            this.noImageLabel.Visible = false;
            // 
            // launcher
            // 
            this.launcher.Location = new System.Drawing.Point(339, 12);
            this.launcher.MinimumSize = new System.Drawing.Size(20, 20);
            this.launcher.Name = "launcher";
            this.launcher.Size = new System.Drawing.Size(250, 250);
            this.launcher.TabIndex = 12;
            this.launcher.Visible = false;
            // 
            // GameDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 320);
            this.Controls.Add(this.launcher);
            this.Controls.Add(this.noImageLabel);
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
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameDetails";
            this.Text = "GameDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Label noImageLabel;
        private System.Windows.Forms.WebBrowser launcher;
    }
}