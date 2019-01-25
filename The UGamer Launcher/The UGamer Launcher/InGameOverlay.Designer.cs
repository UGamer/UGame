namespace The_UGamer_Launcher
{
    partial class InGameOverlay
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
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.currentPlaySessionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameTitleLabel.Font = new System.Drawing.Font("Century Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(366, 79);
            this.gameTitleLabel.TabIndex = 0;
            this.gameTitleLabel.Text = "Game Title";
            // 
            // currentPlaySessionLabel
            // 
            this.currentPlaySessionLabel.AutoSize = true;
            this.currentPlaySessionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlaySessionLabel.Location = new System.Drawing.Point(22, 88);
            this.currentPlaySessionLabel.Name = "currentPlaySessionLabel";
            this.currentPlaySessionLabel.Size = new System.Drawing.Size(245, 20);
            this.currentPlaySessionLabel.TabIndex = 1;
            this.currentPlaySessionLabel.Text = "Current Play Session: 00h:00m:00s";
            // 
            // InGameOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentPlaySessionLabel);
            this.Controls.Add(this.gameTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InGameOverlay";
            this.Text = "InGameOverlay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InGameOverlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitleLabel;
        public System.Windows.Forms.Label currentPlaySessionLabel;
    }
}