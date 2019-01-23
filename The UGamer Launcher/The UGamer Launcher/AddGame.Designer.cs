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
            this.editEntry = new System.Windows.Forms.Button();
            this.noGameLabel = new System.Windows.Forms.Label();
            this.replaceEntry = new System.Windows.Forms.Button();
            this.originalTitle = new System.Windows.Forms.TextBox();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minutesBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secondsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.Location = new System.Drawing.Point(14, 12);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(136, 380);
            this.labels.TabIndex = 0;
            this.labels.Text = "Title: \r\n\r\nPlatform: \r\n\r\nStatus:\r\n\r\nRating: \r\n\r\nTime Played:  \r\n\r\nObtained:\r\n\r\nSt" +
    "art Date:\r\n\r\nEnd Date:\r\n\r\nLaunch Code:\r\n\r\nNotes/Comments:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(156, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(620, 26);
            this.titleBox.TabIndex = 1;
            // 
            // platformBox
            // 
            this.platformBox.Location = new System.Drawing.Point(156, 52);
            this.platformBox.Name = "platformBox";
            this.platformBox.Size = new System.Drawing.Size(620, 26);
            this.platformBox.TabIndex = 2;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(156, 89);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(620, 26);
            this.statusBox.TabIndex = 3;
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(156, 126);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(620, 26);
            this.ratingBox.TabIndex = 4;
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(156, 163);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(130, 26);
            this.hoursBox.TabIndex = 5;
            this.hoursBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hoursBox_KeyDown);
            // 
            // endDateBox
            // 
            this.endDateBox.Location = new System.Drawing.Point(156, 292);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(620, 26);
            this.endDateBox.TabIndex = 8;
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(156, 249);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(620, 26);
            this.startDateBox.TabIndex = 7;
            // 
            // obtainedBox
            // 
            this.obtainedBox.Location = new System.Drawing.Point(156, 208);
            this.obtainedBox.Name = "obtainedBox";
            this.obtainedBox.Size = new System.Drawing.Size(620, 26);
            this.obtainedBox.TabIndex = 6;
            // 
            // launchBox
            // 
            this.launchBox.Location = new System.Drawing.Point(156, 329);
            this.launchBox.Name = "launchBox";
            this.launchBox.Size = new System.Drawing.Size(620, 26);
            this.launchBox.TabIndex = 9;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(156, 368);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(620, 72);
            this.notesBox.TabIndex = 10;
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(16, 457);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(132, 42);
            this.addEntryButton.TabIndex = 11;
            this.addEntryButton.Text = "Add Entry";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // editEntry
            // 
            this.editEntry.Location = new System.Drawing.Point(156, 457);
            this.editEntry.Name = "editEntry";
            this.editEntry.Size = new System.Drawing.Size(132, 42);
            this.editEntry.TabIndex = 12;
            this.editEntry.Text = "Edit Entry";
            this.editEntry.UseVisualStyleBackColor = true;
            this.editEntry.Click += new System.EventHandler(this.editEntry_Click);
            // 
            // noGameLabel
            // 
            this.noGameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noGameLabel.AutoSize = true;
            this.noGameLabel.Location = new System.Drawing.Point(540, 482);
            this.noGameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noGameLabel.Name = "noGameLabel";
            this.noGameLabel.Size = new System.Drawing.Size(240, 20);
            this.noGameLabel.TabIndex = 13;
            this.noGameLabel.Text = "Sorry... that game does not exist.";
            this.noGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.noGameLabel.Visible = false;
            // 
            // replaceEntry
            // 
            this.replaceEntry.Location = new System.Drawing.Point(294, 457);
            this.replaceEntry.Name = "replaceEntry";
            this.replaceEntry.Size = new System.Drawing.Size(132, 42);
            this.replaceEntry.TabIndex = 14;
            this.replaceEntry.Text = "Replace Entry";
            this.replaceEntry.UseVisualStyleBackColor = true;
            this.replaceEntry.Visible = false;
            this.replaceEntry.Click += new System.EventHandler(this.replaceEntry_Click);
            // 
            // originalTitle
            // 
            this.originalTitle.Location = new System.Drawing.Point(20, 398);
            this.originalTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.originalTitle.Name = "originalTitle";
            this.originalTitle.Size = new System.Drawing.Size(24, 26);
            this.originalTitle.TabIndex = 15;
            this.originalTitle.Visible = false;
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Location = new System.Drawing.Point(432, 457);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(132, 42);
            this.deleteEntryButton.TabIndex = 16;
            this.deleteEntryButton.Text = "Delete Entry";
            this.deleteEntryButton.UseVisualStyleBackColor = true;
            this.deleteEntryButton.Visible = false;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "minutes";
            // 
            // minutesBox
            // 
            this.minutesBox.Location = new System.Drawing.Point(352, 163);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(130, 26);
            this.minutesBox.TabIndex = 18;
            this.minutesBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.minutesBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "seconds";
            // 
            // secondsBox
            // 
            this.secondsBox.Location = new System.Drawing.Point(564, 163);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(130, 26);
            this.secondsBox.TabIndex = 20;
            this.secondsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.secondsBox_KeyDown);
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteEntryButton);
            this.Controls.Add(this.originalTitle);
            this.Controls.Add(this.replaceEntry);
            this.Controls.Add(this.noGameLabel);
            this.Controls.Add(this.editEntry);
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
            this.Name = "AddGame";
            this.Text = "Entries";
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
        private System.Windows.Forms.Button editEntry;
        private System.Windows.Forms.Label noGameLabel;
        private System.Windows.Forms.Button replaceEntry;
        private System.Windows.Forms.TextBox originalTitle;
        private System.Windows.Forms.Button deleteEntryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minutesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox secondsBox;
    }
}