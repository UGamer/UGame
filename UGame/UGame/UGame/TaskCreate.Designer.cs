namespace UGame
{
    partial class TaskCreate
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
            this.components = new System.ComponentModel.Container();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.TaskBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PictureContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearPictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalPictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.InternetPictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.PictureContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageBox.Location = new System.Drawing.Point(13, 13);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(130, 130);
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            this.ImageBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageBox_MouseUp);
            // 
            // TaskBox
            // 
            this.TaskBox.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskBox.Location = new System.Drawing.Point(149, 48);
            this.TaskBox.Name = "TaskBox";
            this.TaskBox.Size = new System.Drawing.Size(515, 47);
            this.TaskBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(149, 101);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PictureContextMenu
            // 
            this.PictureContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearPictureButton,
            this.LocalPictureButton,
            this.InternetPictureButton});
            this.PictureContextMenu.Name = "PictureContextMenu";
            this.PictureContextMenu.Size = new System.Drawing.Size(155, 70);
            // 
            // ClearPictureButton
            // 
            this.ClearPictureButton.Name = "ClearPictureButton";
            this.ClearPictureButton.Size = new System.Drawing.Size(180, 22);
            this.ClearPictureButton.Text = "Clear Picture";
            this.ClearPictureButton.Click += new System.EventHandler(this.ClearPictureButton_Click);
            // 
            // LocalPictureButton
            // 
            this.LocalPictureButton.Name = "LocalPictureButton";
            this.LocalPictureButton.Size = new System.Drawing.Size(180, 22);
            this.LocalPictureButton.Text = "From Local File";
            this.LocalPictureButton.Click += new System.EventHandler(this.LocalPictureButton_Click);
            // 
            // InternetPictureButton
            // 
            this.InternetPictureButton.Name = "InternetPictureButton";
            this.InternetPictureButton.Size = new System.Drawing.Size(180, 22);
            this.InternetPictureButton.Text = "From Internet";
            this.InternetPictureButton.Click += new System.EventHandler(this.InternetPictureButton_Click);
            // 
            // PictureDialog
            // 
            this.PictureDialog.FileName = "openFileDialog1";
            this.PictureDialog.Filter = "Image Files(*.PNG;*.JPG;*.JPEG;*.GIF)|*.PNG;*.JPG;*.JPEG;*.GIF";
            // 
            // TaskCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 160);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TaskBox);
            this.Controls.Add(this.ImageBox);
            this.Name = "TaskCreate";
            this.Text = "TaskCreate";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.PictureContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.TextBox TaskBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ContextMenuStrip PictureContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearPictureButton;
        private System.Windows.Forms.ToolStripMenuItem LocalPictureButton;
        private System.Windows.Forms.ToolStripMenuItem InternetPictureButton;
        private System.Windows.Forms.OpenFileDialog PictureDialog;
    }
}