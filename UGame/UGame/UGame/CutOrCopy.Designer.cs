namespace UGame
{
    partial class CutOrCopy
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
            this.QuestionPicture = new System.Windows.Forms.PictureBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.CutButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionPicture
            // 
            this.QuestionPicture.Image = global::UGame.Properties.Resources.question;
            this.QuestionPicture.Location = new System.Drawing.Point(13, 13);
            this.QuestionPicture.Name = "QuestionPicture";
            this.QuestionPicture.Size = new System.Drawing.Size(64, 64);
            this.QuestionPicture.TabIndex = 0;
            this.QuestionPicture.TabStop = false;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(84, 13);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(250, 13);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Would you like to copy the selected file, or move it?";
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(87, 54);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // CutButton
            // 
            this.CutButton.Location = new System.Drawing.Point(168, 54);
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(75, 23);
            this.CutButton.TabIndex = 3;
            this.CutButton.Text = "Cut/Move";
            this.CutButton.UseVisualStyleBackColor = true;
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(249, 54);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CutOrCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 95);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CutButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.QuestionPicture);
            this.Name = "CutOrCopy";
            this.Text = "Copy or Move?";
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QuestionPicture;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button CutButton;
        private System.Windows.Forms.Button CancelButton;
    }
}