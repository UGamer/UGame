namespace UGame
{
    partial class LaunchChoice
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
            this.LaunchBox = new System.Windows.Forms.ComboBox();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaunchBox
            // 
            this.LaunchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LaunchBox.FormattingEnabled = true;
            this.LaunchBox.Location = new System.Drawing.Point(13, 13);
            this.LaunchBox.Name = "LaunchBox";
            this.LaunchBox.Size = new System.Drawing.Size(259, 21);
            this.LaunchBox.TabIndex = 0;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(102, 40);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(75, 23);
            this.LaunchButton.TabIndex = 1;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // LaunchChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.LaunchBox);
            this.Name = "LaunchChoice";
            this.Text = "Launch Choice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox LaunchBox;
        private System.Windows.Forms.Button LaunchButton;
    }
}