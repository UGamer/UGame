namespace UGame
{
    partial class AddTime
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
            this.TimeSecondsLabel = new System.Windows.Forms.Label();
            this.TimeSecondsBox = new System.Windows.Forms.TextBox();
            this.TimeMinutesLabel = new System.Windows.Forms.Label();
            this.TimeMinutesBox = new System.Windows.Forms.TextBox();
            this.TimeHoursLabel = new System.Windows.Forms.Label();
            this.TimeHoursBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewSecondsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewMinutesBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewHoursBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeSecondsLabel
            // 
            this.TimeSecondsLabel.AutoSize = true;
            this.TimeSecondsLabel.Location = new System.Drawing.Point(271, 16);
            this.TimeSecondsLabel.Name = "TimeSecondsLabel";
            this.TimeSecondsLabel.Size = new System.Drawing.Size(47, 13);
            this.TimeSecondsLabel.TabIndex = 24;
            this.TimeSecondsLabel.Text = "seconds";
            // 
            // TimeSecondsBox
            // 
            this.TimeSecondsBox.Enabled = false;
            this.TimeSecondsBox.Location = new System.Drawing.Point(214, 12);
            this.TimeSecondsBox.Name = "TimeSecondsBox";
            this.TimeSecondsBox.Size = new System.Drawing.Size(54, 20);
            this.TimeSecondsBox.TabIndex = 23;
            // 
            // TimeMinutesLabel
            // 
            this.TimeMinutesLabel.AutoSize = true;
            this.TimeMinutesLabel.Location = new System.Drawing.Point(165, 16);
            this.TimeMinutesLabel.Name = "TimeMinutesLabel";
            this.TimeMinutesLabel.Size = new System.Drawing.Size(43, 13);
            this.TimeMinutesLabel.TabIndex = 22;
            this.TimeMinutesLabel.Text = "minutes";
            // 
            // TimeMinutesBox
            // 
            this.TimeMinutesBox.Enabled = false;
            this.TimeMinutesBox.Location = new System.Drawing.Point(108, 12);
            this.TimeMinutesBox.Name = "TimeMinutesBox";
            this.TimeMinutesBox.Size = new System.Drawing.Size(54, 20);
            this.TimeMinutesBox.TabIndex = 21;
            // 
            // TimeHoursLabel
            // 
            this.TimeHoursLabel.AutoSize = true;
            this.TimeHoursLabel.Location = new System.Drawing.Point(69, 16);
            this.TimeHoursLabel.Name = "TimeHoursLabel";
            this.TimeHoursLabel.Size = new System.Drawing.Size(33, 13);
            this.TimeHoursLabel.TabIndex = 20;
            this.TimeHoursLabel.Text = "hours";
            // 
            // TimeHoursBox
            // 
            this.TimeHoursBox.Enabled = false;
            this.TimeHoursBox.Location = new System.Drawing.Point(12, 12);
            this.TimeHoursBox.Name = "TimeHoursBox";
            this.TimeHoursBox.Size = new System.Drawing.Size(54, 20);
            this.TimeHoursBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "seconds";
            // 
            // NewSecondsBox
            // 
            this.NewSecondsBox.Location = new System.Drawing.Point(215, 54);
            this.NewSecondsBox.Name = "NewSecondsBox";
            this.NewSecondsBox.Size = new System.Drawing.Size(54, 20);
            this.NewSecondsBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "minutes";
            // 
            // NewMinutesBox
            // 
            this.NewMinutesBox.Location = new System.Drawing.Point(109, 54);
            this.NewMinutesBox.Name = "NewMinutesBox";
            this.NewMinutesBox.Size = new System.Drawing.Size(54, 20);
            this.NewMinutesBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "hours";
            // 
            // NewHoursBox
            // 
            this.NewHoursBox.Location = new System.Drawing.Point(13, 54);
            this.NewHoursBox.Name = "NewHoursBox";
            this.NewHoursBox.Size = new System.Drawing.Size(54, 20);
            this.NewHoursBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "+";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(125, 84);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 32;
            this.AddButton.Text = "Add Time";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 120);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewSecondsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewMinutesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewHoursBox);
            this.Controls.Add(this.TimeSecondsLabel);
            this.Controls.Add(this.TimeSecondsBox);
            this.Controls.Add(this.TimeMinutesLabel);
            this.Controls.Add(this.TimeMinutesBox);
            this.Controls.Add(this.TimeHoursLabel);
            this.Controls.Add(this.TimeHoursBox);
            this.Name = "AddTime";
            this.Text = "AddTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeSecondsLabel;
        private System.Windows.Forms.TextBox TimeSecondsBox;
        private System.Windows.Forms.Label TimeMinutesLabel;
        private System.Windows.Forms.TextBox TimeMinutesBox;
        private System.Windows.Forms.Label TimeHoursLabel;
        private System.Windows.Forms.TextBox TimeHoursBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewSecondsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewMinutesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewHoursBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
    }
}