namespace The_UGamer_Launcher
{
    partial class AddLinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLinks));
            this.ChooseAmountButton = new System.Windows.Forms.Button();
            this.ChooseAmountBox = new System.Windows.Forms.TextBox();
            this.ChooseAmountLabel = new System.Windows.Forms.Label();
            this.LinkTitleBox = new System.Windows.Forms.TextBox();
            this.LinkTitleLabel = new System.Windows.Forms.Label();
            this.LinkURLLabel = new System.Windows.Forms.Label();
            this.LinkURLBox = new System.Windows.Forms.TextBox();
            this.LinkAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseAmountButton
            // 
            this.ChooseAmountButton.Location = new System.Drawing.Point(71, 44);
            this.ChooseAmountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChooseAmountButton.Name = "ChooseAmountButton";
            this.ChooseAmountButton.Size = new System.Drawing.Size(50, 21);
            this.ChooseAmountButton.TabIndex = 0;
            this.ChooseAmountButton.Text = "Submit";
            this.ChooseAmountButton.UseVisualStyleBackColor = true;
            this.ChooseAmountButton.Click += new System.EventHandler(this.ChooseAmountButton_Click);
            // 
            // ChooseAmountBox
            // 
            this.ChooseAmountBox.Location = new System.Drawing.Point(62, 23);
            this.ChooseAmountBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChooseAmountBox.Name = "ChooseAmountBox";
            this.ChooseAmountBox.Size = new System.Drawing.Size(68, 20);
            this.ChooseAmountBox.TabIndex = 1;
            // 
            // ChooseAmountLabel
            // 
            this.ChooseAmountLabel.AutoSize = true;
            this.ChooseAmountLabel.Location = new System.Drawing.Point(9, 8);
            this.ChooseAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseAmountLabel.Name = "ChooseAmountLabel";
            this.ChooseAmountLabel.Size = new System.Drawing.Size(198, 13);
            this.ChooseAmountLabel.TabIndex = 2;
            this.ChooseAmountLabel.Text = "Type in how many links you want to use.";
            // 
            // LinkTitleBox
            // 
            this.LinkTitleBox.Location = new System.Drawing.Point(62, 12);
            this.LinkTitleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LinkTitleBox.Name = "LinkTitleBox";
            this.LinkTitleBox.Size = new System.Drawing.Size(399, 20);
            this.LinkTitleBox.TabIndex = 3;
            this.LinkTitleBox.Visible = false;
            // 
            // LinkTitleLabel
            // 
            this.LinkTitleLabel.AutoSize = true;
            this.LinkTitleLabel.Location = new System.Drawing.Point(27, 12);
            this.LinkTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkTitleLabel.Name = "LinkTitleLabel";
            this.LinkTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.LinkTitleLabel.TabIndex = 4;
            this.LinkTitleLabel.Text = "Title:";
            this.LinkTitleLabel.Visible = false;
            // 
            // LinkURLLabel
            // 
            this.LinkURLLabel.AutoSize = true;
            this.LinkURLLabel.Location = new System.Drawing.Point(27, 33);
            this.LinkURLLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkURLLabel.Name = "LinkURLLabel";
            this.LinkURLLabel.Size = new System.Drawing.Size(32, 13);
            this.LinkURLLabel.TabIndex = 6;
            this.LinkURLLabel.Text = "URL:";
            this.LinkURLLabel.Visible = false;
            // 
            // LinkURLBox
            // 
            this.LinkURLBox.Location = new System.Drawing.Point(62, 33);
            this.LinkURLBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LinkURLBox.Name = "LinkURLBox";
            this.LinkURLBox.Size = new System.Drawing.Size(399, 20);
            this.LinkURLBox.TabIndex = 5;
            this.LinkURLBox.Visible = false;
            // 
            // LinkAddButton
            // 
            this.LinkAddButton.Location = new System.Drawing.Point(218, 54);
            this.LinkAddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LinkAddButton.Name = "LinkAddButton";
            this.LinkAddButton.Size = new System.Drawing.Size(50, 21);
            this.LinkAddButton.TabIndex = 7;
            this.LinkAddButton.Text = "Submit";
            this.LinkAddButton.UseVisualStyleBackColor = true;
            this.LinkAddButton.Visible = false;
            this.LinkAddButton.Click += new System.EventHandler(this.LinkAddButton_Click);
            // 
            // AddLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 208);
            this.Controls.Add(this.LinkAddButton);
            this.Controls.Add(this.LinkURLLabel);
            this.Controls.Add(this.LinkURLBox);
            this.Controls.Add(this.LinkTitleLabel);
            this.Controls.Add(this.LinkTitleBox);
            this.Controls.Add(this.ChooseAmountLabel);
            this.Controls.Add(this.ChooseAmountBox);
            this.Controls.Add(this.ChooseAmountButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddLinks";
            this.Text = "Add Links";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseAmountButton;
        private System.Windows.Forms.TextBox ChooseAmountBox;
        private System.Windows.Forms.Label ChooseAmountLabel;
        private System.Windows.Forms.TextBox LinkTitleBox;
        private System.Windows.Forms.Label LinkTitleLabel;
        private System.Windows.Forms.Label LinkURLLabel;
        private System.Windows.Forms.TextBox LinkURLBox;
        private System.Windows.Forms.Button LinkAddButton;
    }
}