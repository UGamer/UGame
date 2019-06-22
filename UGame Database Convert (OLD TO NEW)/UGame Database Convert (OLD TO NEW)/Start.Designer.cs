namespace UGame_Database_Convert__OLD_TO_NEW_
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.OldFileBox = new System.Windows.Forms.TextBox();
            this.OldFileButton = new System.Windows.Forms.Button();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.NewFileBox = new System.Windows.Forms.TextBox();
            this.HelpBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.QuickConvertCheck = new System.Windows.Forms.CheckBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // OldFileBox
            // 
            this.OldFileBox.Location = new System.Drawing.Point(12, 98);
            this.OldFileBox.Name = "OldFileBox";
            this.OldFileBox.Size = new System.Drawing.Size(658, 20);
            this.OldFileBox.TabIndex = 0;
            this.OldFileBox.Text = "E:\\Tools\\UGame Launcher\\Collection.accdb";
            // 
            // OldFileButton
            // 
            this.OldFileButton.Location = new System.Drawing.Point(677, 98);
            this.OldFileButton.Name = "OldFileButton";
            this.OldFileButton.Size = new System.Drawing.Size(75, 20);
            this.OldFileButton.TabIndex = 1;
            this.OldFileButton.Text = "Browse...";
            this.OldFileButton.UseVisualStyleBackColor = true;
            this.OldFileButton.Click += new System.EventHandler(this.OldFileButton_Click);
            // 
            // NewFileButton
            // 
            this.NewFileButton.Location = new System.Drawing.Point(677, 124);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(75, 20);
            this.NewFileButton.TabIndex = 3;
            this.NewFileButton.Text = "Browse...";
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // NewFileBox
            // 
            this.NewFileBox.Location = new System.Drawing.Point(12, 124);
            this.NewFileBox.Name = "NewFileBox";
            this.NewFileBox.Size = new System.Drawing.Size(658, 20);
            this.NewFileBox.TabIndex = 2;
            this.NewFileBox.Text = "E:\\Tools\\UGame\\UGameDB.mdf";
            // 
            // HelpBox
            // 
            this.HelpBox.Location = new System.Drawing.Point(12, 13);
            this.HelpBox.Multiline = true;
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.ReadOnly = true;
            this.HelpBox.Size = new System.Drawing.Size(740, 79);
            this.HelpBox.TabIndex = 4;
            this.HelpBox.Text = resources.GetString("HelpBox.Text");
            this.HelpBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 185);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(740, 79);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // QuickConvertCheck
            // 
            this.QuickConvertCheck.AutoSize = true;
            this.QuickConvertCheck.Location = new System.Drawing.Point(335, 162);
            this.QuickConvertCheck.Name = "QuickConvertCheck";
            this.QuickConvertCheck.Size = new System.Drawing.Size(94, 17);
            this.QuickConvertCheck.TabIndex = 6;
            this.QuickConvertCheck.Text = "Quick Convert";
            this.QuickConvertCheck.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 276);
            this.Controls.Add(this.QuickConvertCheck);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.HelpBox);
            this.Controls.Add(this.NewFileButton);
            this.Controls.Add(this.NewFileBox);
            this.Controls.Add(this.OldFileButton);
            this.Controls.Add(this.OldFileBox);
            this.Name = "Start";
            this.Text = "UGame DB Conversion Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldFileBox;
        private System.Windows.Forms.Button OldFileButton;
        private System.Windows.Forms.Button NewFileButton;
        private System.Windows.Forms.TextBox NewFileBox;
        private System.Windows.Forms.TextBox HelpBox;
        private System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.CheckBox QuickConvertCheck;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}

