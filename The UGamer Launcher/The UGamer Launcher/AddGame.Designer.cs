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
            this.labels.Location = new System.Drawing.Point(13, 13);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(136, 380);
            this.labels.TabIndex = 0;
            this.labels.Text = "Title: \r\n\r\nPlatform: \r\n\r\nStatus:\r\n\r\nRating: \r\n\r\nHours:  \r\n\r\nObtained:\r\n\r\nStart Da" +
    "te:\r\n\r\nEnd Date:\r\n\r\nLaunch Code:\r\n\r\nNotes/Comments:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(156, 13);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(621, 26);
            this.titleBox.TabIndex = 1;
            // 
            // platformBox
            // 
            this.platformBox.Location = new System.Drawing.Point(156, 45);
            this.platformBox.Name = "platformBox";
            this.platformBox.Size = new System.Drawing.Size(621, 26);
            this.platformBox.TabIndex = 2;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(156, 90);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(621, 26);
            this.statusBox.TabIndex = 3;
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(155, 131);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(621, 26);
            this.ratingBox.TabIndex = 4;
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(155, 172);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(621, 26);
            this.hoursBox.TabIndex = 5;
            // 
            // endDateBox
            // 
            this.endDateBox.Location = new System.Drawing.Point(156, 286);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(621, 26);
            this.endDateBox.TabIndex = 8;
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(156, 245);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(621, 26);
            this.startDateBox.TabIndex = 7;
            // 
            // obtainedBox
            // 
            this.obtainedBox.Location = new System.Drawing.Point(156, 213);
            this.obtainedBox.Name = "obtainedBox";
            this.obtainedBox.Size = new System.Drawing.Size(621, 26);
            this.obtainedBox.TabIndex = 6;
            // 
            // launchBox
            // 
            this.launchBox.Location = new System.Drawing.Point(155, 329);
            this.launchBox.Name = "launchBox";
            this.launchBox.Size = new System.Drawing.Size(621, 26);
            this.launchBox.TabIndex = 9;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(156, 367);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(621, 71);
            this.notesBox.TabIndex = 10;
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(17, 397);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(132, 41);
            this.addEntryButton.TabIndex = 11;
            this.addEntryButton.Text = "Add Entry";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
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