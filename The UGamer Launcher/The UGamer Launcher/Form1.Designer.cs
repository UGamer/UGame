namespace The_UGamer_Launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.launcherButton = new System.Windows.Forms.Button();
            this.collectionButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // launcherButton
            // 
            this.launcherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.launcherButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.launcherButton.FlatAppearance.BorderSize = 2;
            this.launcherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launcherButton.ForeColor = System.Drawing.SystemColors.Control;
            this.launcherButton.Location = new System.Drawing.Point(1182, 533);
            this.launcherButton.Margin = new System.Windows.Forms.Padding(2);
            this.launcherButton.Name = "launcherButton";
            this.launcherButton.Size = new System.Drawing.Size(113, 64);
            this.launcherButton.TabIndex = 0;
            this.launcherButton.Text = "Launcher";
            this.launcherButton.UseVisualStyleBackColor = false;
            this.launcherButton.Click += new System.EventHandler(this.launcherButto);
            // 
            // collectionButton
            // 
            this.collectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.collectionButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.collectionButton.FlatAppearance.BorderSize = 2;
            this.collectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collectionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.collectionButton.Location = new System.Drawing.Point(1182, 533);
            this.collectionButton.Margin = new System.Windows.Forms.Padding(2);
            this.collectionButton.Name = "collectionButton";
            this.collectionButton.Size = new System.Drawing.Size(113, 64);
            this.collectionButton.TabIndex = 1;
            this.collectionButton.Text = "Collection";
            this.collectionButton.UseVisualStyleBackColor = false;
            this.collectionButton.Click += new System.EventHandler(this.collectionButto);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(12, 533);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(188, 70);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1282, 515);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("https://ugamer.github.io/Library/launcher/launcher.html", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 615);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.collectionButton);
            this.Controls.Add(this.launcherButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "UGame Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button launcherButton;
        private System.Windows.Forms.Button collectionButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

