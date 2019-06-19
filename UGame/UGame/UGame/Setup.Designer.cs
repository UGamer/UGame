namespace UGame
{
    partial class Setup
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
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.UGameBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ResourceBox = new System.Windows.Forms.TextBox();
            this.ResourceButton = new System.Windows.Forms.Button();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DatabaseBox = new System.Windows.Forms.TextBox();
            this.DiscordCheckBox = new System.Windows.Forms.CheckBox();
            this.ThemeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            this.LogoBox.BackgroundImage = global::UGame.Properties.Resources.new_logo_idea;
            this.LogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoBox.Location = new System.Drawing.Point(129, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(220, 212);
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // UGameBox
            // 
            this.UGameBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UGameBox.Location = new System.Drawing.Point(129, 230);
            this.UGameBox.Multiline = true;
            this.UGameBox.Name = "UGameBox";
            this.UGameBox.Size = new System.Drawing.Size(220, 39);
            this.UGameBox.TabIndex = 1;
            this.UGameBox.Text = "UGame";
            this.UGameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(438, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Black;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(407, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 25);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // ResourceBox
            // 
            this.ResourceBox.Location = new System.Drawing.Point(23, 349);
            this.ResourceBox.Name = "ResourceBox";
            this.ResourceBox.Size = new System.Drawing.Size(350, 20);
            this.ResourceBox.TabIndex = 4;
            // 
            // ResourceButton
            // 
            this.ResourceButton.Location = new System.Drawing.Point(379, 349);
            this.ResourceButton.Name = "ResourceButton";
            this.ResourceButton.Size = new System.Drawing.Size(75, 21);
            this.ResourceButton.TabIndex = 5;
            this.ResourceButton.Text = "Browse";
            this.ResourceButton.UseVisualStyleBackColor = true;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(23, 300);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(431, 20);
            this.UserNameBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "What would you like UGame to refer to you as? (User Name)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose your resource path. (Leave alone if you don\'t have one.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choose your database path. (Leave alone if you don\'t have one.)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DatabaseBox
            // 
            this.DatabaseBox.Location = new System.Drawing.Point(23, 392);
            this.DatabaseBox.Name = "DatabaseBox";
            this.DatabaseBox.Size = new System.Drawing.Size(350, 20);
            this.DatabaseBox.TabIndex = 9;
            // 
            // DiscordCheckBox
            // 
            this.DiscordCheckBox.AutoSize = true;
            this.DiscordCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DiscordCheckBox.ForeColor = System.Drawing.Color.White;
            this.DiscordCheckBox.Location = new System.Drawing.Point(23, 429);
            this.DiscordCheckBox.Name = "DiscordCheckBox";
            this.DiscordCheckBox.Size = new System.Drawing.Size(322, 17);
            this.DiscordCheckBox.TabIndex = 12;
            this.DiscordCheckBox.Text = "Would you like UGame to display a custom status on Discord? ";
            this.DiscordCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThemeButton
            // 
            this.ThemeButton.BackColor = System.Drawing.Color.Black;
            this.ThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeButton.ForeColor = System.Drawing.Color.White;
            this.ThemeButton.Location = new System.Drawing.Point(23, 464);
            this.ThemeButton.Name = "ThemeButton";
            this.ThemeButton.Size = new System.Drawing.Size(431, 44);
            this.ThemeButton.TabIndex = 13;
            this.ThemeButton.Text = "Customize Your Theme";
            this.ThemeButton.UseVisualStyleBackColor = false;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(475, 536);
            this.Controls.Add(this.ThemeButton);
            this.Controls.Add(this.DiscordCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DatabaseBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.ResourceButton);
            this.Controls.Add(this.ResourceBox);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UGameBox);
            this.Controls.Add(this.LogoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setup";
            this.Text = "Setup";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.TextBox UGameBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.TextBox ResourceBox;
        private System.Windows.Forms.Button ResourceButton;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DatabaseBox;
        private System.Windows.Forms.CheckBox DiscordCheckBox;
        private System.Windows.Forms.Button ThemeButton;
    }
}