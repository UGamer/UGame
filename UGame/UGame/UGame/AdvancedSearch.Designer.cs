namespace UGame
{
    partial class AdvancedSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlatformBox = new System.Windows.Forms.ComboBox();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeveloperBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenreBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PublisherBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.RatingBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RatingBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.RatingBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // TitleBox
            // 
            this.TitleBox.Enabled = false;
            this.TitleBox.Location = new System.Drawing.Point(30, 72);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(540, 31);
            this.TitleBox.TabIndex = 1;
            this.TitleBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Platform";
            // 
            // PlatformBox
            // 
            this.PlatformBox.Enabled = false;
            this.PlatformBox.FormattingEnabled = true;
            this.PlatformBox.Location = new System.Drawing.Point(619, 72);
            this.PlatformBox.Name = "PlatformBox";
            this.PlatformBox.Size = new System.Drawing.Size(540, 33);
            this.PlatformBox.TabIndex = 4;
            this.PlatformBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // StatusBox
            // 
            this.StatusBox.Enabled = false;
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(30, 187);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(540, 33);
            this.StatusBox.TabIndex = 6;
            this.StatusBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // DeveloperBox
            // 
            this.DeveloperBox.Enabled = false;
            this.DeveloperBox.FormattingEnabled = true;
            this.DeveloperBox.Location = new System.Drawing.Point(619, 303);
            this.DeveloperBox.Name = "DeveloperBox";
            this.DeveloperBox.Size = new System.Drawing.Size(540, 33);
            this.DeveloperBox.TabIndex = 10;
            this.DeveloperBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Developer(s)";
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(30, 303);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(540, 31);
            this.FilterBox.TabIndex = 8;
            this.FilterBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Filter(s)";
            // 
            // GenreBox
            // 
            this.GenreBox.Enabled = false;
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.Location = new System.Drawing.Point(619, 415);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(540, 33);
            this.GenreBox.TabIndex = 14;
            this.GenreBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Genre";
            // 
            // PublisherBox
            // 
            this.PublisherBox.Enabled = false;
            this.PublisherBox.Location = new System.Drawing.Point(30, 415);
            this.PublisherBox.Name = "PublisherBox";
            this.PublisherBox.Size = new System.Drawing.Size(540, 31);
            this.PublisherBox.TabIndex = 12;
            this.PublisherBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Publisher(s)";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(523, 470);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(144, 74);
            this.OKButton.TabIndex = 15;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // RatingBox
            // 
            this.RatingBox.Enabled = false;
            this.RatingBox.Location = new System.Drawing.Point(1091, 187);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(68, 31);
            this.RatingBox.TabIndex = 17;
            this.RatingBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rating";
            // 
            // RatingBar
            // 
            this.RatingBar.Enabled = false;
            this.RatingBar.LargeChange = 1;
            this.RatingBar.Location = new System.Drawing.Point(619, 187);
            this.RatingBar.Name = "RatingBar";
            this.RatingBar.Size = new System.Drawing.Size(466, 90);
            this.RatingBar.TabIndex = 18;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 574);
            this.Controls.Add(this.RatingBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PublisherBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeveloperBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlatformBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RatingBar);
            this.Name = "AdvancedSearch";
            this.Text = "AdvancedSearch";
            ((System.ComponentModel.ISupportInitialize)(this.RatingBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PlatformBox;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeveloperBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GenreBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PublisherBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox RatingBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar RatingBar;
    }
}