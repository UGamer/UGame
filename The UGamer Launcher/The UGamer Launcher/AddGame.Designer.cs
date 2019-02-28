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
            this.linksBox = new System.Windows.Forms.TextBox();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.obtainedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.IgnoreObtained = new System.Windows.Forms.CheckBox();
            this.IgnoreStart = new System.Windows.Forms.CheckBox();
            this.IgnoreEnd = new System.Windows.Forms.CheckBox();
            this.AddGameButton = new System.Windows.Forms.Button();
            this.AddLinksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labels
            // 
            this.labels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labels.AutoSize = true;
            this.labels.BackColor = System.Drawing.Color.White;
            this.labels.Location = new System.Drawing.Point(9, 8);
            this.labels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(92, 273);
            this.labels.TabIndex = 0;
            this.labels.Text = "Title: \r\n\r\nPlatform: \r\n\r\nStatus:\r\n\r\nRating: \r\n\r\nTime Played:  \r\n\r\nObtained:\r\n\r\nSt" +
    "art Date:\r\n\r\nLast Played:\r\n\r\nLaunch Code:\r\n\r\nURLs:\r\n\r\nNotes/Comments:";
            // 
            // titleBox
            // 
            this.titleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.titleBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.titleBox.Location = new System.Drawing.Point(104, 8);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(415, 20);
            this.titleBox.TabIndex = 1;
            // 
            // platformBox
            // 
            this.platformBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.platformBox.Location = new System.Drawing.Point(104, 34);
            this.platformBox.Margin = new System.Windows.Forms.Padding(2);
            this.platformBox.Name = "platformBox";
            this.platformBox.Size = new System.Drawing.Size(415, 20);
            this.platformBox.TabIndex = 2;
            // 
            // ratingBox
            // 
            this.ratingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingBox.Location = new System.Drawing.Point(104, 82);
            this.ratingBox.Margin = new System.Windows.Forms.Padding(2);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(415, 20);
            this.ratingBox.TabIndex = 4;
            // 
            // hoursBox
            // 
            this.hoursBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hoursBox.Location = new System.Drawing.Point(104, 106);
            this.hoursBox.Margin = new System.Windows.Forms.Padding(2);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(88, 20);
            this.hoursBox.TabIndex = 5;
            this.hoursBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hoursBox_KeyUp);
            // 
            // launchBox
            // 
            this.launchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.launchBox.Location = new System.Drawing.Point(104, 214);
            this.launchBox.Margin = new System.Windows.Forms.Padding(2);
            this.launchBox.Name = "launchBox";
            this.launchBox.Size = new System.Drawing.Size(391, 20);
            this.launchBox.TabIndex = 9;
            // 
            // notesBox
            // 
            this.notesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesBox.Location = new System.Drawing.Point(104, 262);
            this.notesBox.Margin = new System.Windows.Forms.Padding(2);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(415, 48);
            this.notesBox.TabIndex = 10;
            // 
            // addEntryButton
            // 
            this.addEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addEntryButton.BackColor = System.Drawing.Color.Black;
            this.addEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEntryButton.ForeColor = System.Drawing.Color.White;
            this.addEntryButton.Location = new System.Drawing.Point(11, 316);
            this.addEntryButton.Margin = new System.Windows.Forms.Padding(2);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(88, 27);
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
            this.editEntry.Location = new System.Drawing.Point(104, 316);
            this.editEntry.Margin = new System.Windows.Forms.Padding(2);
            this.editEntry.Name = "editEntry";
            this.editEntry.Size = new System.Drawing.Size(88, 27);
            this.editEntry.TabIndex = 12;
            this.editEntry.Text = "Edit Entry";
            this.editEntry.UseVisualStyleBackColor = false;
            this.editEntry.Click += new System.EventHandler(this.editEntry_Click);
            // 
            // noGameLabel
            // 
            this.noGameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noGameLabel.AutoSize = true;
            this.noGameLabel.Location = new System.Drawing.Point(360, 332);
            this.noGameLabel.Name = "noGameLabel";
            this.noGameLabel.Size = new System.Drawing.Size(161, 13);
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
            this.replaceEntry.Location = new System.Drawing.Point(196, 316);
            this.replaceEntry.Margin = new System.Windows.Forms.Padding(2);
            this.replaceEntry.Name = "replaceEntry";
            this.replaceEntry.Size = new System.Drawing.Size(88, 27);
            this.replaceEntry.TabIndex = 14;
            this.replaceEntry.Text = "Replace Entry";
            this.replaceEntry.UseVisualStyleBackColor = false;
            this.replaceEntry.Visible = false;
            this.replaceEntry.Click += new System.EventHandler(this.replaceEntry_Click);
            // 
            // originalTitle
            // 
            this.originalTitle.Location = new System.Drawing.Point(12, 310);
            this.originalTitle.Name = "originalTitle";
            this.originalTitle.Size = new System.Drawing.Size(17, 20);
            this.originalTitle.TabIndex = 15;
            this.originalTitle.Visible = false;
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteEntryButton.BackColor = System.Drawing.Color.Black;
            this.deleteEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEntryButton.ForeColor = System.Drawing.Color.White;
            this.deleteEntryButton.Location = new System.Drawing.Point(288, 316);
            this.deleteEntryButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(88, 27);
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
            this.label1.Location = new System.Drawing.Point(197, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "hours";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(328, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "minutes";
            // 
            // minutesBox
            // 
            this.minutesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.minutesBox.Location = new System.Drawing.Point(235, 106);
            this.minutesBox.Margin = new System.Windows.Forms.Padding(2);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(88, 20);
            this.minutesBox.TabIndex = 18;
            this.minutesBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.minutesBox_KeyUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(469, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "seconds";
            // 
            // secondsBox
            // 
            this.secondsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.secondsBox.Location = new System.Drawing.Point(376, 106);
            this.secondsBox.Margin = new System.Windows.Forms.Padding(2);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(88, 20);
            this.secondsBox.TabIndex = 20;
            this.secondsBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.secondsBox_KeyUp);
            // 
            // linksBox
            // 
            this.linksBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linksBox.Location = new System.Drawing.Point(104, 238);
            this.linksBox.Margin = new System.Windows.Forms.Padding(2);
            this.linksBox.Name = "linksBox";
            this.linksBox.Size = new System.Drawing.Size(390, 20);
            this.linksBox.TabIndex = 22;
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearFieldsButton.BackColor = System.Drawing.Color.Black;
            this.clearFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFieldsButton.ForeColor = System.Drawing.Color.White;
            this.clearFieldsButton.Location = new System.Drawing.Point(11, 285);
            this.clearFieldsButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(88, 27);
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
            this.statusBox.Location = new System.Drawing.Point(104, 58);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(415, 21);
            this.statusBox.TabIndex = 25;
            // 
            // obtainedDatePicker
            // 
            this.obtainedDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obtainedDatePicker.CustomFormat = "u";
            this.obtainedDatePicker.Location = new System.Drawing.Point(165, 135);
            this.obtainedDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.obtainedDatePicker.Name = "obtainedDatePicker";
            this.obtainedDatePicker.Size = new System.Drawing.Size(354, 20);
            this.obtainedDatePicker.TabIndex = 26;
            this.obtainedDatePicker.Value = new System.DateTime(2019, 2, 15, 0, 0, 0, 0);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.CustomFormat = "u";
            this.startDatePicker.Location = new System.Drawing.Point(165, 162);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(354, 20);
            this.startDatePicker.TabIndex = 27;
            this.startDatePicker.Value = new System.DateTime(2019, 2, 15, 0, 0, 0, 0);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.CustomFormat = "u";
            this.endDatePicker.Location = new System.Drawing.Point(165, 190);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(354, 20);
            this.endDatePicker.TabIndex = 28;
            this.endDatePicker.Value = new System.DateTime(2019, 2, 15, 0, 0, 0, 0);
            // 
            // IgnoreObtained
            // 
            this.IgnoreObtained.AutoSize = true;
            this.IgnoreObtained.BackColor = System.Drawing.Color.White;
            this.IgnoreObtained.Location = new System.Drawing.Point(104, 135);
            this.IgnoreObtained.Name = "IgnoreObtained";
            this.IgnoreObtained.Size = new System.Drawing.Size(56, 17);
            this.IgnoreObtained.TabIndex = 29;
            this.IgnoreObtained.Text = "Ignore";
            this.IgnoreObtained.UseVisualStyleBackColor = false;
            // 
            // IgnoreStart
            // 
            this.IgnoreStart.AutoSize = true;
            this.IgnoreStart.BackColor = System.Drawing.Color.White;
            this.IgnoreStart.Location = new System.Drawing.Point(105, 162);
            this.IgnoreStart.Name = "IgnoreStart";
            this.IgnoreStart.Size = new System.Drawing.Size(56, 17);
            this.IgnoreStart.TabIndex = 30;
            this.IgnoreStart.Text = "Ignore";
            this.IgnoreStart.UseVisualStyleBackColor = false;
            // 
            // IgnoreEnd
            // 
            this.IgnoreEnd.AutoSize = true;
            this.IgnoreEnd.BackColor = System.Drawing.Color.White;
            this.IgnoreEnd.Location = new System.Drawing.Point(104, 190);
            this.IgnoreEnd.Name = "IgnoreEnd";
            this.IgnoreEnd.Size = new System.Drawing.Size(56, 17);
            this.IgnoreEnd.TabIndex = 31;
            this.IgnoreEnd.Text = "Ignore";
            this.IgnoreEnd.UseVisualStyleBackColor = false;
            // 
            // AddGameButton
            // 
            this.AddGameButton.Location = new System.Drawing.Point(499, 214);
            this.AddGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddGameButton.Name = "AddGameButton";
            this.AddGameButton.Size = new System.Drawing.Size(21, 20);
            this.AddGameButton.TabIndex = 32;
            this.AddGameButton.Text = "+";
            this.AddGameButton.UseVisualStyleBackColor = true;
            this.AddGameButton.Click += new System.EventHandler(this.AddGameButton_Click);
            // 
            // AddLinksButton
            // 
            this.AddLinksButton.Location = new System.Drawing.Point(499, 238);
            this.AddLinksButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddLinksButton.Name = "AddLinksButton";
            this.AddLinksButton.Size = new System.Drawing.Size(21, 20);
            this.AddLinksButton.TabIndex = 35;
            this.AddLinksButton.Text = "+";
            this.AddLinksButton.UseVisualStyleBackColor = true;
            this.AddLinksButton.Click += new System.EventHandler(this.AddLinksButton_Click);
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 354);
            this.Controls.Add(this.AddLinksButton);
            this.Controls.Add(this.AddGameButton);
            this.Controls.Add(this.IgnoreEnd);
            this.Controls.Add(this.IgnoreStart);
            this.Controls.Add(this.IgnoreObtained);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.obtainedDatePicker);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.linksBox);
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
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.platformBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.labels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox linksBox;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.DateTimePicker obtainedDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.CheckBox IgnoreObtained;
        private System.Windows.Forms.CheckBox IgnoreStart;
        private System.Windows.Forms.CheckBox IgnoreEnd;
        private System.Windows.Forms.Button AddGameButton;
        private System.Windows.Forms.Button AddLinksButton;
    }
}