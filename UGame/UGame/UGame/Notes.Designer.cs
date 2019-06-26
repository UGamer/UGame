namespace UGame
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.NotepadArea = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LoadButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.FileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SavePanel = new System.Windows.Forms.Panel();
            this.ConfirmSaveButton = new System.Windows.Forms.Button();
            this.SaveFileNameBox = new System.Windows.Forms.TextBox();
            this.SaveNameLabel = new System.Windows.Forms.Label();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LockButton = new System.Windows.Forms.Button();
            this.OpacityBar = new System.Windows.Forms.TrackBar();
            this.toolStrip1.SuspendLayout();
            this.SavePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
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
            this.NotepadArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
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
            this.LoadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(37, 22);
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(35, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SavePanel
            // 
            this.SavePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePanel.Controls.Add(this.ConfirmSaveButton);
            this.SavePanel.Controls.Add(this.SaveFileNameBox);
            this.SavePanel.Controls.Add(this.SaveNameLabel);
            this.SavePanel.Location = new System.Drawing.Point(249, 194);
            this.SavePanel.Name = "SavePanel";
            this.SavePanel.Size = new System.Drawing.Size(315, 85);
            this.SavePanel.TabIndex = 3;
            this.SavePanel.Visible = false;
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
            // SaveFileNameBox
            // 
            this.SaveFileNameBox.Location = new System.Drawing.Point(12, 26);
            this.SaveFileNameBox.Name = "SaveFileNameBox";
            this.SaveFileNameBox.Size = new System.Drawing.Size(290, 20);
            this.SaveFileNameBox.TabIndex = 1;
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
            // LoadFileDialog
            // 
            this.LoadFileDialog.Filter = "Text File|*.txt";
            this.LoadFileDialog.InitialDirectory = "Notes";
            // 
            // LockButton
            // 
            this.LockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LockButton.Location = new System.Drawing.Point(761, 2);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(27, 23);
            this.LockButton.TabIndex = 10;
            this.LockButton.UseVisualStyleBackColor = true;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // OpacityBar
            // 
            this.OpacityBar.Location = new System.Drawing.Point(651, 2);
            this.OpacityBar.Maximum = 100;
            this.OpacityBar.Minimum = 10;
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.Size = new System.Drawing.Size(104, 45);
            this.OpacityBar.TabIndex = 11;
            this.OpacityBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.OpacityBar.Value = 100;
            this.OpacityBar.ValueChanged += new System.EventHandler(this.OpacityBar_ValueChanged);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SavePanel);
            this.Controls.Add(this.NotepadArea);
            this.Controls.Add(this.OpacityBar);
            this.Controls.Add(this.LockButton);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notes";
            this.Text = "Notepad";
            this.TopMost = true;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SavePanel.ResumeLayout(false);
            this.SavePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).EndInit();
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
        private System.Windows.Forms.Button LockButton;
        private System.Windows.Forms.TrackBar OpacityBar;
    }
}