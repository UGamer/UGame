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
            this.newsURLBox = new System.Windows.Forms.TextBox();
            this.wikiURLBox = new System.Windows.Forms.TextBox();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.obtainedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labels
            // 
            this.labels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labels.AutoSize = true;
            this.labels.BackColor = System.Drawing.Color.White;
            this.labels.Location = new System.Drawing.Point(14, 12);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(136, 460);
            this.labels.TabIndex = 0;
            this.labels.Text = "Title: \r\n\r\nPlatform: \r\n\r\nStatus:\r\n\r\nRating: \r\n\r\nTime Played:  \r\n\r\nObtained:\r\n\r\nSt" +
    "art Date:\r\n\r\nLast Played:\r\n\r\nLaunch Code:\r\n\r\nNews URL:\r\n\r\nWiki URL:\r\n\r\nNotes/Com" +
    "ments:";
            // 
            // titleBox
            // 
            this.titleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.titleBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.titleBox.Location = new System.Drawing.Point(156, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(620, 26);
            this.titleBox.TabIndex = 1;
            // 
            // platformBox
            // 
            this.platformBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.platformBox.Location = new System.Drawing.Point(156, 52);
            this.platformBox.Name = "platformBox";
            this.platformBox.Size = new System.Drawing.Size(620, 26);
            this.platformBox.TabIndex = 2;
            // 
            // ratingBox
            // 
            this.ratingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingBox.Location = new System.Drawing.Point(156, 126);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(620, 26);
            this.ratingBox.TabIndex = 4;
            // 
            // hoursBox
            // 
            this.hoursBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hoursBox.Location = new System.Drawing.Point(156, 163);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(130, 26);
            this.hoursBox.TabIndex = 5;
            this.hoursBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hoursBox_KeyUp);
            // 
            // endDateBox
            // 
            this.endDateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateBox.Location = new System.Drawing.Point(156, 292);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(620, 26);
            this.endDateBox.TabIndex = 8;
            // 
            // startDateBox
            // 
            this.startDateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateBox.Location = new System.Drawing.Point(156, 249);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(620, 26);
            this.startDateBox.TabIndex = 7;
            // 
            // obtainedBox
            // 
            this.obtainedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obtainedBox.Location = new System.Drawing.Point(156, 208);
            this.obtainedBox.Name = "obtainedBox";
            this.obtainedBox.Size = new System.Drawing.Size(620, 26);
            this.obtainedBox.TabIndex = 6;
            // 
            // launchBox
            // 
            this.launchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.launchBox.Location = new System.Drawing.Point(156, 329);
            this.launchBox.Name = "launchBox";
            this.launchBox.Size = new System.Drawing.Size(620, 26);
            this.launchBox.TabIndex = 9;
            // 
            // notesBox
            // 
            this.notesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesBox.Location = new System.Drawing.Point(156, 452);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(620, 72);
            this.notesBox.TabIndex = 10;
            // 
            // addEntryButton
            // 
            this.addEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addEntryButton.BackColor = System.Drawing.Color.Black;
            this.addEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEntryButton.ForeColor = System.Drawing.Color.White;
            this.addEntryButton.Location = new System.Drawing.Point(16, 543);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(132, 42);
            this.addEntryButton.TabIndex = 11;
            this.addEntryButton.Text = "Add Entry";
            this.addEntryButton.UseVisualStyleBackColor = false;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // editEntry
            // 
            this.editEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editEntry.BackColor = System.Drawing.Color.Black;
            this.editEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEntry.ForeColor = System.Drawing.Color.White;
            this.editEntry.Location = new System.Drawing.Point(156, 543);
            this.editEntry.Name = "editEntry";
            this.editEntry.Size = new System.Drawing.Size(132, 42);
            this.editEntry.TabIndex = 12;
            this.editEntry.Text = "Edit Entry";
            this.editEntry.UseVisualStyleBackColor = false;
            this.editEntry.Click += new System.EventHandler(this.editEntry_Click);
            // 
            // noGameLabel
            // 
            this.noGameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noGameLabel.AutoSize = true;
            this.noGameLabel.Location = new System.Drawing.Point(540, 568);
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
            this.replaceEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.replaceEntry.BackColor = System.Drawing.Color.Black;
            this.replaceEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceEntry.ForeColor = System.Drawing.Color.White;
            this.replaceEntry.Location = new System.Drawing.Point(294, 543);
            this.replaceEntry.Name = "replaceEntry";
            this.replaceEntry.Size = new System.Drawing.Size(132, 42);
            this.replaceEntry.TabIndex = 14;
            this.replaceEntry.Text = "Replace Entry";
            this.replaceEntry.UseVisualStyleBackColor = false;
            this.replaceEntry.Visible = false;
            this.replaceEntry.Click += new System.EventHandler(this.replaceEntry_Click);
            // 
            // originalTitle
            // 
            this.originalTitle.Location = new System.Drawing.Point(18, 477);
            this.originalTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.originalTitle.Name = "originalTitle";
            this.originalTitle.Size = new System.Drawing.Size(24, 26);
            this.originalTitle.TabIndex = 15;
            this.originalTitle.Visible = false;
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteEntryButton.BackColor = System.Drawing.Color.Black;
            this.deleteEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEntryButton.ForeColor = System.Drawing.Color.White;
            this.deleteEntryButton.Location = new System.Drawing.Point(432, 543);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(132, 42);
            this.deleteEntryButton.TabIndex = 16;
            this.deleteEntryButton.Text = "Delete Entry";
            this.deleteEntryButton.UseVisualStyleBackColor = false;
            this.deleteEntryButton.Visible = false;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "hours";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "minutes";
            // 
            // minutesBox
            // 
            this.minutesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.minutesBox.Location = new System.Drawing.Point(352, 163);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(130, 26);
            this.minutesBox.TabIndex = 18;
            this.minutesBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.minutesBox_KeyUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(704, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "seconds";
            // 
            // secondsBox
            // 
            this.secondsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.secondsBox.Location = new System.Drawing.Point(564, 163);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(130, 26);
            this.secondsBox.TabIndex = 20;
            this.secondsBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.secondsBox_KeyUp);
            // 
            // newsURLBox
            // 
            this.newsURLBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newsURLBox.Location = new System.Drawing.Point(156, 366);
            this.newsURLBox.Name = "newsURLBox";
            this.newsURLBox.Size = new System.Drawing.Size(620, 26);
            this.newsURLBox.TabIndex = 22;
            // 
            // wikiURLBox
            // 
            this.wikiURLBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wikiURLBox.Location = new System.Drawing.Point(156, 403);
            this.wikiURLBox.Name = "wikiURLBox";
            this.wikiURLBox.Size = new System.Drawing.Size(620, 26);
            this.wikiURLBox.TabIndex = 23;
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearFieldsButton.BackColor = System.Drawing.Color.Black;
            this.clearFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFieldsButton.ForeColor = System.Drawing.Color.White;
            this.clearFieldsButton.Location = new System.Drawing.Point(16, 495);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(132, 42);
            this.clearFieldsButton.TabIndex = 24;
            this.clearFieldsButton.Text = "Clear Fields";
            this.clearFieldsButton.UseVisualStyleBackColor = false;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // statusBox
            // 
            this.statusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBox.BackColor = System.Drawing.Color.White;
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Completed",
            "Completed (100%)",
            "Don\'t Own",
            "Dropped",
            "Never Started",
            "On Hold",
            "Plan to Play",
            "Playing",
            "Start Over"});
            this.statusBox.Location = new System.Drawing.Point(156, 89);
            this.statusBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(620, 28);
            this.statusBox.TabIndex = 25;
            // 
            // obtainedDatePicker
            // 
            this.obtainedDatePicker.Location = new System.Drawing.Point(156, 208);
            this.obtainedDatePicker.Name = "obtainedDatePicker";
            this.obtainedDatePicker.Size = new System.Drawing.Size(620, 26);
            this.obtainedDatePicker.TabIndex = 26;
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.obtainedDatePicker);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.wikiURLBox);
            this.Controls.Add(this.newsURLBox);
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
        private System.Windows.Forms.TextBox newsURLBox;
        private System.Windows.Forms.TextBox wikiURLBox;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.DateTimePicker obtainedDatePicker;
    }
}