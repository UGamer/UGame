namespace The_UGamer_Launcher
{
    partial class AddGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGame));
            this.labels = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.platformBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.endDateBox = new System.Windows.Forms.TextBox();
            this.startDateBox = new System.Windows.Forms.TextBox();
            this.obtainedBox = new System.Windows.Forms.TextBox();
            this.launchBox = new System.Windows.Forms.TextBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.Location = new System.Drawing.Point(9, 8);
            this.labels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(92, 247);
            this.labels.TabIndex = 0;
            this.labels.Text = "Title: \r\n\r\nPlatform: \r\n\r\nStatus:\r\n\r\nRating: \r\n\r\nHours:  \r\n\r\nObtained:\r\n\r\nStart Da" +
    "te:\r\n\r\nEnd Date:\r\n\r\nLaunch Code:\r\n\r\nNotes/Comments:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(104, 8);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(415, 20);
            this.titleBox.TabIndex = 1;
            // 
            // platformBox
            // 
            this.platformBox.Location = new System.Drawing.Point(104, 34);
            this.platformBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.platformBox.Name = "platformBox";
            this.platformBox.Size = new System.Drawing.Size(415, 20);
            this.platformBox.TabIndex = 2;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(104, 58);
            this.statusBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(415, 20);
            this.statusBox.TabIndex = 3;
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(104, 82);
            this.ratingBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(415, 20);
            this.ratingBox.TabIndex = 4;
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(104, 106);
            this.hoursBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(415, 20);
            this.hoursBox.TabIndex = 5;
            // 
            // endDateBox
            // 
            this.endDateBox.Location = new System.Drawing.Point(104, 190);
            this.endDateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(415, 20);
            this.endDateBox.TabIndex = 8;
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(104, 162);
            this.startDateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(415, 20);
            this.startDateBox.TabIndex = 7;
            // 
            // obtainedBox
            // 
            this.obtainedBox.Location = new System.Drawing.Point(104, 135);
            this.obtainedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.obtainedBox.Name = "obtainedBox";
            this.obtainedBox.Size = new System.Drawing.Size(415, 20);
            this.obtainedBox.TabIndex = 6;
            // 
            // launchBox
            // 
            this.launchBox.Location = new System.Drawing.Point(104, 214);
            this.launchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.launchBox.Name = "launchBox";
            this.launchBox.Size = new System.Drawing.Size(415, 20);
            this.launchBox.TabIndex = 9;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(104, 239);
            this.notesBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(415, 48);
            this.notesBox.TabIndex = 10;
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(11, 258);
            this.addEntryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(88, 27);
            this.addEntryButton.TabIndex = 11;
            this.addEntryButton.Text = "Add Entry";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.addEntryButton);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.launchBox);
            this.Controls.Add(this.endDateBox);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.obtainedBox);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.platformBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.labels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddGame";
            this.Text = "Add an entry...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox platformBox;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.TextBox endDateBox;
        private System.Windows.Forms.TextBox startDateBox;
        private System.Windows.Forms.TextBox obtainedBox;
        private System.Windows.Forms.TextBox launchBox;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Button addEntryButton;
    }
}