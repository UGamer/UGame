namespace The_UGamer_Launcher
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.NotepadArea = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LoadButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.FileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SavePanel = new System.Windows.Forms.Panel();
            this.SaveNameLabel = new System.Windows.Forms.Label();
            this.SaveFileNameBox = new System.Windows.Forms.TextBox();
            this.ConfirmSaveButton = new System.Windows.Forms.Button();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SavePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotepadArea
            // 
            this.NotepadArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotepadArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotepadArea.Location = new System.Drawing.Point(12, 28);
            this.NotepadArea.Multiline = true;
            this.NotepadArea.Name = "NotepadArea";
            this.NotepadArea.Size = new System.Drawing.Size(775, 410);
            this.NotepadArea.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadButton,
            this.SaveButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LoadButton
            // 
            this.LoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadButton.Image")));
            this.LoadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(37, 22);
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(35, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SavePanel
            // 
            this.SavePanel.Controls.Add(this.ConfirmSaveButton);
            this.SavePanel.Controls.Add(this.SaveFileNameBox);
            this.SavePanel.Controls.Add(this.SaveNameLabel);
            this.SavePanel.Location = new System.Drawing.Point(249, 194);
            this.SavePanel.Name = "SavePanel";
            this.SavePanel.Size = new System.Drawing.Size(315, 85);
            this.SavePanel.TabIndex = 3;
            this.SavePanel.Visible = false;
            // 
            // SaveNameLabel
            // 
            this.SaveNameLabel.AutoSize = true;
            this.SaveNameLabel.Location = new System.Drawing.Point(71, 10);
            this.SaveNameLabel.Name = "SaveNameLabel";
            this.SaveNameLabel.Size = new System.Drawing.Size(175, 13);
            this.SaveNameLabel.TabIndex = 0;
            this.SaveNameLabel.Text = "What would you like to call this file?";
            // 
            // SaveFileNameBox
            // 
            this.SaveFileNameBox.Location = new System.Drawing.Point(12, 26);
            this.SaveFileNameBox.Name = "SaveFileNameBox";
            this.SaveFileNameBox.Size = new System.Drawing.Size(290, 20);
            this.SaveFileNameBox.TabIndex = 1;
            // 
            // ConfirmSaveButton
            // 
            this.ConfirmSaveButton.Location = new System.Drawing.Point(119, 52);
            this.ConfirmSaveButton.Name = "ConfirmSaveButton";
            this.ConfirmSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmSaveButton.TabIndex = 2;
            this.ConfirmSaveButton.Text = "Confirm";
            this.ConfirmSaveButton.UseVisualStyleBackColor = true;
            this.ConfirmSaveButton.Click += new System.EventHandler(this.ConfirmSaveButton_Click);
            // 
            // LoadFileDialog
            // 
            this.LoadFileDialog.Filter = "Text File|*.txt";
            this.LoadFileDialog.InitialDirectory = "Notes";
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SavePanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NotepadArea);
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.TopMost = true;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SavePanel.ResumeLayout(false);
            this.SavePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NotepadArea;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LoadButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.FolderBrowserDialog FileDialog;
        private System.Windows.Forms.Panel SavePanel;
        private System.Windows.Forms.Button ConfirmSaveButton;
        private System.Windows.Forms.TextBox SaveFileNameBox;
        private System.Windows.Forms.Label SaveNameLabel;
        private System.Windows.Forms.OpenFileDialog LoadFileDialog;
    }
}