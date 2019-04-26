namespace The_UGamer_Launcher
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.themeSelect = new System.Windows.Forms.ComboBox();
            this.themesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet5 = new The_UGamer_Launcher.CollectionDataSet5();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet4 = new The_UGamer_Launcher.CollectionDataSet4();
            this.table1TableAdapter = new The_UGamer_Launcher.CollectionDataSet4TableAdapters.Table1TableAdapter();
            this.themeDetails = new System.Windows.Forms.Button();
            this.saveApply = new System.Windows.Forms.Button();
            this.themesTableAdapter = new The_UGamer_Launcher.CollectionDataSet5TableAdapters.ThemesTableAdapter();
            this.NoChangesLabel = new System.Windows.Forms.Label();
            this.SettingsTabs = new System.Windows.Forms.TabControl();
            this.ThemesTab = new System.Windows.Forms.TabPage();
            this.DataTab = new System.Windows.Forms.TabPage();
            this.ColumnStatusLabel = new System.Windows.Forms.Label();
            this.ColumnTableBox = new System.Windows.Forms.ComboBox();
            this.ColumnTableLabel = new System.Windows.Forms.Label();
            this.ColumnTypeBox = new System.Windows.Forms.ComboBox();
            this.ColumnRemoveButton = new System.Windows.Forms.Button();
            this.ColumnEditButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnAddButton = new System.Windows.Forms.Button();
            this.ColumnNameBox = new System.Windows.Forms.TextBox();
            this.InGameTab = new System.Windows.Forms.TabPage();
            this.CheckOverlayEnable = new System.Windows.Forms.CheckBox();
            this.DirectoriesTab = new System.Windows.Forms.TabPage();
            this.UserDataButton = new System.Windows.Forms.Button();
            this.UserDataBox = new System.Windows.Forms.TextBox();
            this.UserDataLabel = new System.Windows.Forms.Label();
            this.ScreenshotButton = new System.Windows.Forms.Button();
            this.ScreenshotBox = new System.Windows.Forms.TextBox();
            this.ScreenshotLabel = new System.Windows.Forms.Label();
            this.ResourcesButton = new System.Windows.Forms.Button();
            this.ResourcesBox = new System.Windows.Forms.TextBox();
            this.ResourcesLabel = new System.Windows.Forms.Label();
            this.PagesButton = new System.Windows.Forms.Button();
            this.PagesBox = new System.Windows.Forms.TextBox();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.NotesButton = new System.Windows.Forms.Button();
            this.NotesBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FolderBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.themesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet4)).BeginInit();
            this.SettingsTabs.SuspendLayout();
            this.ThemesTab.SuspendLayout();
            this.DataTab.SuspendLayout();
            this.InGameTab.SuspendLayout();
            this.DirectoriesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theme: ";
            // 
            // themeSelect
            // 
            this.themeSelect.FormattingEnabled = true;
            this.themeSelect.Location = new System.Drawing.Point(82, 9);
            this.themeSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.themeSelect.Name = "themeSelect";
            this.themeSelect.Size = new System.Drawing.Size(343, 28);
            this.themeSelect.TabIndex = 1;
            // 
            // themesBindingSource
            // 
            this.themesBindingSource.DataMember = "Themes";
            this.themesBindingSource.DataSource = this.collectionDataSet5BindingSource;
            // 
            // collectionDataSet5BindingSource
            // 
            this.collectionDataSet5BindingSource.DataSource = this.collectionDataSet5;
            this.collectionDataSet5BindingSource.Position = 0;
            // 
            // collectionDataSet5
            // 
            this.collectionDataSet5.DataSetName = "CollectionDataSet5";
            this.collectionDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.collectionDataSet4;
            // 
            // collectionDataSet4
            // 
            this.collectionDataSet4.DataSetName = "CollectionDataSet4";
            this.collectionDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // themeDetails
            // 
            this.themeDetails.Location = new System.Drawing.Point(436, 9);
            this.themeDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.themeDetails.Name = "themeDetails";
            this.themeDetails.Size = new System.Drawing.Size(36, 32);
            this.themeDetails.TabIndex = 2;
            this.themeDetails.Text = "...";
            this.themeDetails.UseVisualStyleBackColor = true;
            // 
            // saveApply
            // 
            this.saveApply.Location = new System.Drawing.Point(171, 82);
            this.saveApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveApply.Name = "saveApply";
            this.saveApply.Size = new System.Drawing.Size(126, 35);
            this.saveApply.TabIndex = 4;
            this.saveApply.Text = "Save + Apply";
            this.saveApply.UseVisualStyleBackColor = true;
            this.saveApply.Click += new System.EventHandler(this.saveApply_Click);
            // 
            // themesTableAdapter
            // 
            this.themesTableAdapter.ClearBeforeFill = true;
            // 
            // NoChangesLabel
            // 
            this.NoChangesLabel.AutoSize = true;
            this.NoChangesLabel.Location = new System.Drawing.Point(106, 57);
            this.NoChangesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoChangesLabel.Name = "NoChangesLabel";
            this.NoChangesLabel.Size = new System.Drawing.Size(263, 20);
            this.NoChangesLabel.TabIndex = 5;
            this.NoChangesLabel.Text = "There were no changes to be made.";
            this.NoChangesLabel.Visible = false;
            // 
            // SettingsTabs
            // 
            this.SettingsTabs.Controls.Add(this.ThemesTab);
            this.SettingsTabs.Controls.Add(this.DataTab);
            this.SettingsTabs.Controls.Add(this.InGameTab);
            this.SettingsTabs.Controls.Add(this.DirectoriesTab);
            this.SettingsTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTabs.Location = new System.Drawing.Point(0, 0);
            this.SettingsTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsTabs.Name = "SettingsTabs";
            this.SettingsTabs.SelectedIndex = 0;
            this.SettingsTabs.Size = new System.Drawing.Size(506, 262);
            this.SettingsTabs.TabIndex = 6;
            // 
            // ThemesTab
            // 
            this.ThemesTab.BackColor = System.Drawing.Color.Transparent;
            this.ThemesTab.Controls.Add(this.NoChangesLabel);
            this.ThemesTab.Controls.Add(this.themeSelect);
            this.ThemesTab.Controls.Add(this.saveApply);
            this.ThemesTab.Controls.Add(this.label1);
            this.ThemesTab.Controls.Add(this.themeDetails);
            this.ThemesTab.Location = new System.Drawing.Point(4, 29);
            this.ThemesTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThemesTab.Name = "ThemesTab";
            this.ThemesTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThemesTab.Size = new System.Drawing.Size(498, 229);
            this.ThemesTab.TabIndex = 0;
            this.ThemesTab.Text = "Themes";
            // 
            // DataTab
            // 
            this.DataTab.Controls.Add(this.ColumnStatusLabel);
            this.DataTab.Controls.Add(this.ColumnTableBox);
            this.DataTab.Controls.Add(this.ColumnTableLabel);
            this.DataTab.Controls.Add(this.ColumnTypeBox);
            this.DataTab.Controls.Add(this.ColumnRemoveButton);
            this.DataTab.Controls.Add(this.ColumnEditButton);
            this.DataTab.Controls.Add(this.label3);
            this.DataTab.Controls.Add(this.label2);
            this.DataTab.Controls.Add(this.ColumnAddButton);
            this.DataTab.Controls.Add(this.ColumnNameBox);
            this.DataTab.Location = new System.Drawing.Point(4, 29);
            this.DataTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataTab.Name = "DataTab";
            this.DataTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataTab.Size = new System.Drawing.Size(498, 229);
            this.DataTab.TabIndex = 1;
            this.DataTab.Text = "Data";
            this.DataTab.UseVisualStyleBackColor = true;
            // 
            // ColumnStatusLabel
            // 
            this.ColumnStatusLabel.AutoSize = true;
            this.ColumnStatusLabel.Location = new System.Drawing.Point(184, 123);
            this.ColumnStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColumnStatusLabel.Name = "ColumnStatusLabel";
            this.ColumnStatusLabel.Size = new System.Drawing.Size(116, 20);
            this.ColumnStatusLabel.TabIndex = 11;
            this.ColumnStatusLabel.Text = "Column added.";
            this.ColumnStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ColumnStatusLabel.Visible = false;
            // 
            // ColumnTableBox
            // 
            this.ColumnTableBox.FormattingEnabled = true;
            this.ColumnTableBox.Items.AddRange(new object[] {
            "Games",
            "Platforms"});
            this.ColumnTableBox.Location = new System.Drawing.Point(66, 9);
            this.ColumnTableBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColumnTableBox.Name = "ColumnTableBox";
            this.ColumnTableBox.Size = new System.Drawing.Size(414, 28);
            this.ColumnTableBox.TabIndex = 10;
            // 
            // ColumnTableLabel
            // 
            this.ColumnTableLabel.AutoSize = true;
            this.ColumnTableLabel.Location = new System.Drawing.Point(9, 14);
            this.ColumnTableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColumnTableLabel.Name = "ColumnTableLabel";
            this.ColumnTableLabel.Size = new System.Drawing.Size(48, 20);
            this.ColumnTableLabel.TabIndex = 9;
            this.ColumnTableLabel.Text = "Table";
            // 
            // ColumnTypeBox
            // 
            this.ColumnTypeBox.FormattingEnabled = true;
            this.ColumnTypeBox.Items.AddRange(new object[] {
            "Numeric",
            "Text"});
            this.ColumnTypeBox.Location = new System.Drawing.Point(66, 86);
            this.ColumnTypeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColumnTypeBox.Name = "ColumnTypeBox";
            this.ColumnTypeBox.Size = new System.Drawing.Size(414, 28);
            this.ColumnTypeBox.TabIndex = 8;
            // 
            // ColumnRemoveButton
            // 
            this.ColumnRemoveButton.Location = new System.Drawing.Point(368, 152);
            this.ColumnRemoveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColumnRemoveButton.Name = "ColumnRemoveButton";
            this.ColumnRemoveButton.Size = new System.Drawing.Size(112, 60);
            this.ColumnRemoveButton.TabIndex = 7;
            this.ColumnRemoveButton.Text = "Remove Column";
            this.ColumnRemoveButton.UseVisualStyleBackColor = true;
            // 
            // ColumnEditButton
            // 
            this.ColumnEditButton.Location = new System.Drawing.Point(189, 152);
            this.ColumnEditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColumnEditButton.Name = "ColumnEditButton";
            this.ColumnEditButton.Size = new System.Drawing.Size(112, 60);
            this.ColumnEditButton.TabIndex = 6;
            this.ColumnEditButton.Text = "Edit Column";
            this.ColumnEditButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // ColumnAddButton
            // 
            this.ColumnAddButton.Location = new System.Drawing.Point(12, 152);
            this.ColumnAddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColumnAddButton.Name = "ColumnAddButton";
            this.ColumnAddButton.Size = new System.Drawing.Size(112, 60);
            this.ColumnAddButton.TabIndex = 2;
            this.ColumnAddButton.Text = "Add Column";
            this.ColumnAddButton.UseVisualStyleBackColor = true;
            this.ColumnAddButton.Click += new System.EventHandler(this.ColumnAddButton_Click);
            // 
            // ColumnNameBox
            // 
            this.ColumnNameBox.Location = new System.Drawing.Point(66, 49);
            this.ColumnNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColumnNameBox.Name = "ColumnNameBox";
            this.ColumnNameBox.Size = new System.Drawing.Size(414, 26);
            this.ColumnNameBox.TabIndex = 1;
            // 
            // InGameTab
            // 
            this.InGameTab.Controls.Add(this.CheckOverlayEnable);
            this.InGameTab.Location = new System.Drawing.Point(4, 29);
            this.InGameTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InGameTab.Name = "InGameTab";
            this.InGameTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InGameTab.Size = new System.Drawing.Size(498, 229);
            this.InGameTab.TabIndex = 2;
            this.InGameTab.Text = "In-Game";
            this.InGameTab.UseVisualStyleBackColor = true;
            // 
            // CheckOverlayEnable
            // 
            this.CheckOverlayEnable.AutoSize = true;
            this.CheckOverlayEnable.Location = new System.Drawing.Point(12, 9);
            this.CheckOverlayEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckOverlayEnable.Name = "CheckOverlayEnable";
            this.CheckOverlayEnable.Size = new System.Drawing.Size(120, 24);
            this.CheckOverlayEnable.TabIndex = 0;
            this.CheckOverlayEnable.Text = "Use Overlay";
            this.CheckOverlayEnable.UseVisualStyleBackColor = true;
            // 
            // DirectoriesTab
            // 
            this.DirectoriesTab.Controls.Add(this.UserDataButton);
            this.DirectoriesTab.Controls.Add(this.UserDataBox);
            this.DirectoriesTab.Controls.Add(this.UserDataLabel);
            this.DirectoriesTab.Controls.Add(this.ScreenshotButton);
            this.DirectoriesTab.Controls.Add(this.ScreenshotBox);
            this.DirectoriesTab.Controls.Add(this.ScreenshotLabel);
            this.DirectoriesTab.Controls.Add(this.ResourcesButton);
            this.DirectoriesTab.Controls.Add(this.ResourcesBox);
            this.DirectoriesTab.Controls.Add(this.ResourcesLabel);
            this.DirectoriesTab.Controls.Add(this.PagesButton);
            this.DirectoriesTab.Controls.Add(this.PagesBox);
            this.DirectoriesTab.Controls.Add(this.PagesLabel);
            this.DirectoriesTab.Controls.Add(this.NotesButton);
            this.DirectoriesTab.Controls.Add(this.NotesBox);
            this.DirectoriesTab.Controls.Add(this.NotesLabel);
            this.DirectoriesTab.Location = new System.Drawing.Point(4, 29);
            this.DirectoriesTab.Name = "DirectoriesTab";
            this.DirectoriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.DirectoriesTab.Size = new System.Drawing.Size(498, 229);
            this.DirectoriesTab.TabIndex = 3;
            this.DirectoriesTab.Text = "Directories";
            this.DirectoriesTab.UseVisualStyleBackColor = true;
            // 
            // UserDataButton
            // 
            this.UserDataButton.Location = new System.Drawing.Point(425, 163);
            this.UserDataButton.Name = "UserDataButton";
            this.UserDataButton.Size = new System.Drawing.Size(65, 26);
            this.UserDataButton.TabIndex = 14;
            this.UserDataButton.Tag = "User Data";
            this.UserDataButton.Text = "...";
            this.UserDataButton.UseVisualStyleBackColor = true;
            // 
            // UserDataBox
            // 
            this.UserDataBox.Location = new System.Drawing.Point(116, 163);
            this.UserDataBox.Name = "UserDataBox";
            this.UserDataBox.Size = new System.Drawing.Size(314, 26);
            this.UserDataBox.TabIndex = 13;
            // 
            // UserDataLabel
            // 
            this.UserDataLabel.AutoSize = true;
            this.UserDataLabel.Location = new System.Drawing.Point(7, 163);
            this.UserDataLabel.Name = "UserDataLabel";
            this.UserDataLabel.Size = new System.Drawing.Size(86, 20);
            this.UserDataLabel.TabIndex = 12;
            this.UserDataLabel.Text = "User Data:";
            // 
            // ScreenshotButton
            // 
            this.ScreenshotButton.Location = new System.Drawing.Point(425, 131);
            this.ScreenshotButton.Name = "ScreenshotButton";
            this.ScreenshotButton.Size = new System.Drawing.Size(65, 26);
            this.ScreenshotButton.TabIndex = 11;
            this.ScreenshotButton.Tag = "Screenshots";
            this.ScreenshotButton.Text = "...";
            this.ScreenshotButton.UseVisualStyleBackColor = true;
            // 
            // ScreenshotBox
            // 
            this.ScreenshotBox.Location = new System.Drawing.Point(116, 131);
            this.ScreenshotBox.Name = "ScreenshotBox";
            this.ScreenshotBox.Size = new System.Drawing.Size(314, 26);
            this.ScreenshotBox.TabIndex = 10;
            // 
            // ScreenshotLabel
            // 
            this.ScreenshotLabel.AutoSize = true;
            this.ScreenshotLabel.Location = new System.Drawing.Point(7, 131);
            this.ScreenshotLabel.Name = "ScreenshotLabel";
            this.ScreenshotLabel.Size = new System.Drawing.Size(103, 20);
            this.ScreenshotLabel.TabIndex = 9;
            this.ScreenshotLabel.Text = "Screenshots:";
            // 
            // ResourcesButton
            // 
            this.ResourcesButton.Location = new System.Drawing.Point(425, 99);
            this.ResourcesButton.Name = "ResourcesButton";
            this.ResourcesButton.Size = new System.Drawing.Size(65, 26);
            this.ResourcesButton.TabIndex = 8;
            this.ResourcesButton.Tag = "Resources";
            this.ResourcesButton.Text = "...";
            this.ResourcesButton.UseVisualStyleBackColor = true;
            // 
            // ResourcesBox
            // 
            this.ResourcesBox.Location = new System.Drawing.Point(116, 99);
            this.ResourcesBox.Name = "ResourcesBox";
            this.ResourcesBox.Size = new System.Drawing.Size(314, 26);
            this.ResourcesBox.TabIndex = 7;
            // 
            // ResourcesLabel
            // 
            this.ResourcesLabel.AutoSize = true;
            this.ResourcesLabel.Location = new System.Drawing.Point(7, 99);
            this.ResourcesLabel.Name = "ResourcesLabel";
            this.ResourcesLabel.Size = new System.Drawing.Size(90, 20);
            this.ResourcesLabel.TabIndex = 6;
            this.ResourcesLabel.Text = "Resources:";
            // 
            // PagesButton
            // 
            this.PagesButton.Location = new System.Drawing.Point(425, 67);
            this.PagesButton.Name = "PagesButton";
            this.PagesButton.Size = new System.Drawing.Size(65, 26);
            this.PagesButton.TabIndex = 5;
            this.PagesButton.Tag = "Pages";
            this.PagesButton.Text = "...";
            this.PagesButton.UseVisualStyleBackColor = true;
            // 
            // PagesBox
            // 
            this.PagesBox.Location = new System.Drawing.Point(116, 67);
            this.PagesBox.Name = "PagesBox";
            this.PagesBox.Size = new System.Drawing.Size(314, 26);
            this.PagesBox.TabIndex = 4;
            // 
            // PagesLabel
            // 
            this.PagesLabel.AutoSize = true;
            this.PagesLabel.Location = new System.Drawing.Point(7, 67);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(58, 20);
            this.PagesLabel.TabIndex = 3;
            this.PagesLabel.Text = "Pages:";
            // 
            // NotesButton
            // 
            this.NotesButton.Location = new System.Drawing.Point(425, 35);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Size = new System.Drawing.Size(65, 26);
            this.NotesButton.TabIndex = 2;
            this.NotesButton.Tag = "Notes";
            this.NotesButton.Text = "...";
            this.NotesButton.UseVisualStyleBackColor = true;
            // 
            // NotesBox
            // 
            this.NotesBox.Location = new System.Drawing.Point(116, 35);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(314, 26);
            this.NotesBox.TabIndex = 1;
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(7, 35);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(55, 20);
            this.NotesLabel.TabIndex = 0;
            this.NotesLabel.Text = "Notes:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(177, 265);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(126, 35);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save + Apply";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 311);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SettingsTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.themesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet4)).EndInit();
            this.SettingsTabs.ResumeLayout(false);
            this.ThemesTab.ResumeLayout(false);
            this.ThemesTab.PerformLayout();
            this.DataTab.ResumeLayout(false);
            this.DataTab.PerformLayout();
            this.InGameTab.ResumeLayout(false);
            this.InGameTab.PerformLayout();
            this.DirectoriesTab.ResumeLayout(false);
            this.DirectoriesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox themeSelect;
        private CollectionDataSet4 collectionDataSet4;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private CollectionDataSet4TableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.Button themeDetails;
        private System.Windows.Forms.Button saveApply;
        private System.Windows.Forms.BindingSource collectionDataSet5BindingSource;
        private CollectionDataSet5 collectionDataSet5;
        private System.Windows.Forms.BindingSource themesBindingSource;
        private CollectionDataSet5TableAdapters.ThemesTableAdapter themesTableAdapter;
        private System.Windows.Forms.Label NoChangesLabel;
        private System.Windows.Forms.TabControl SettingsTabs;
        private System.Windows.Forms.TabPage ThemesTab;
        private System.Windows.Forms.TabPage DataTab;
        private System.Windows.Forms.Button ColumnRemoveButton;
        private System.Windows.Forms.Button ColumnEditButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ColumnAddButton;
        private System.Windows.Forms.ComboBox ColumnTypeBox;
        private System.Windows.Forms.TextBox ColumnNameBox;
        private System.Windows.Forms.ComboBox ColumnTableBox;
        private System.Windows.Forms.Label ColumnTableLabel;
        private System.Windows.Forms.Label ColumnStatusLabel;
        private System.Windows.Forms.TabPage InGameTab;
        private System.Windows.Forms.CheckBox CheckOverlayEnable;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TabPage DirectoriesTab;
        private System.Windows.Forms.Button UserDataButton;
        private System.Windows.Forms.TextBox UserDataBox;
        private System.Windows.Forms.Label UserDataLabel;
        private System.Windows.Forms.Button ScreenshotButton;
        private System.Windows.Forms.TextBox ScreenshotBox;
        private System.Windows.Forms.Label ScreenshotLabel;
        private System.Windows.Forms.Button ResourcesButton;
        private System.Windows.Forms.TextBox ResourcesBox;
        private System.Windows.Forms.Label ResourcesLabel;
        private System.Windows.Forms.Button PagesButton;
        private System.Windows.Forms.TextBox PagesBox;
        private System.Windows.Forms.Label PagesLabel;
        private System.Windows.Forms.Button NotesButton;
        private System.Windows.Forms.TextBox NotesBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowseDialog;
    }
}