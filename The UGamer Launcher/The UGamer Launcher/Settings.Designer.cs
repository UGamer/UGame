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
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.themesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet4)).BeginInit();
            this.SettingsTabs.SuspendLayout();
            this.ThemesTab.SuspendLayout();
            this.DataTab.SuspendLayout();
            this.InGameTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theme: ";
            // 
            // themeSelect
            // 
            this.themeSelect.DataSource = this.themesBindingSource;
            this.themeSelect.DisplayMember = "ThemeName";
            this.themeSelect.FormattingEnabled = true;
            this.themeSelect.Location = new System.Drawing.Point(55, 6);
            this.themeSelect.Name = "themeSelect";
            this.themeSelect.Size = new System.Drawing.Size(230, 21);
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
            this.themeDetails.Location = new System.Drawing.Point(291, 6);
            this.themeDetails.Name = "themeDetails";
            this.themeDetails.Size = new System.Drawing.Size(24, 21);
            this.themeDetails.TabIndex = 2;
            this.themeDetails.Text = "...";
            this.themeDetails.UseVisualStyleBackColor = true;
            // 
            // saveApply
            // 
            this.saveApply.Location = new System.Drawing.Point(114, 53);
            this.saveApply.Name = "saveApply";
            this.saveApply.Size = new System.Drawing.Size(84, 23);
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
            this.NoChangesLabel.Location = new System.Drawing.Point(71, 37);
            this.NoChangesLabel.Name = "NoChangesLabel";
            this.NoChangesLabel.Size = new System.Drawing.Size(179, 13);
            this.NoChangesLabel.TabIndex = 5;
            this.NoChangesLabel.Text = "There were no changes to be made.";
            this.NoChangesLabel.Visible = false;
            // 
            // SettingsTabs
            // 
            this.SettingsTabs.Controls.Add(this.ThemesTab);
            this.SettingsTabs.Controls.Add(this.DataTab);
            this.SettingsTabs.Controls.Add(this.InGameTab);
            this.SettingsTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTabs.Location = new System.Drawing.Point(0, 0);
            this.SettingsTabs.Name = "SettingsTabs";
            this.SettingsTabs.SelectedIndex = 0;
            this.SettingsTabs.Size = new System.Drawing.Size(337, 170);
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
            this.ThemesTab.Location = new System.Drawing.Point(4, 22);
            this.ThemesTab.Name = "ThemesTab";
            this.ThemesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ThemesTab.Size = new System.Drawing.Size(329, 144);
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
            this.DataTab.Location = new System.Drawing.Point(4, 22);
            this.DataTab.Name = "DataTab";
            this.DataTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataTab.Size = new System.Drawing.Size(329, 146);
            this.DataTab.TabIndex = 1;
            this.DataTab.Text = "Data";
            this.DataTab.UseVisualStyleBackColor = true;
            // 
            // ColumnStatusLabel
            // 
            this.ColumnStatusLabel.AutoSize = true;
            this.ColumnStatusLabel.Location = new System.Drawing.Point(123, 80);
            this.ColumnStatusLabel.Name = "ColumnStatusLabel";
            this.ColumnStatusLabel.Size = new System.Drawing.Size(78, 13);
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
            this.ColumnTableBox.Location = new System.Drawing.Point(44, 6);
            this.ColumnTableBox.Name = "ColumnTableBox";
            this.ColumnTableBox.Size = new System.Drawing.Size(277, 21);
            this.ColumnTableBox.TabIndex = 10;
            // 
            // ColumnTableLabel
            // 
            this.ColumnTableLabel.AutoSize = true;
            this.ColumnTableLabel.Location = new System.Drawing.Point(6, 9);
            this.ColumnTableLabel.Name = "ColumnTableLabel";
            this.ColumnTableLabel.Size = new System.Drawing.Size(34, 13);
            this.ColumnTableLabel.TabIndex = 9;
            this.ColumnTableLabel.Text = "Table";
            // 
            // ColumnTypeBox
            // 
            this.ColumnTypeBox.FormattingEnabled = true;
            this.ColumnTypeBox.Items.AddRange(new object[] {
            "Numeric",
            "Text"});
            this.ColumnTypeBox.Location = new System.Drawing.Point(44, 56);
            this.ColumnTypeBox.Name = "ColumnTypeBox";
            this.ColumnTypeBox.Size = new System.Drawing.Size(277, 21);
            this.ColumnTypeBox.TabIndex = 8;
            // 
            // ColumnRemoveButton
            // 
            this.ColumnRemoveButton.Location = new System.Drawing.Point(245, 99);
            this.ColumnRemoveButton.Name = "ColumnRemoveButton";
            this.ColumnRemoveButton.Size = new System.Drawing.Size(75, 39);
            this.ColumnRemoveButton.TabIndex = 7;
            this.ColumnRemoveButton.Text = "Remove Column";
            this.ColumnRemoveButton.UseVisualStyleBackColor = true;
            // 
            // ColumnEditButton
            // 
            this.ColumnEditButton.Location = new System.Drawing.Point(126, 99);
            this.ColumnEditButton.Name = "ColumnEditButton";
            this.ColumnEditButton.Size = new System.Drawing.Size(75, 39);
            this.ColumnEditButton.TabIndex = 6;
            this.ColumnEditButton.Text = "Edit Column";
            this.ColumnEditButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // ColumnAddButton
            // 
            this.ColumnAddButton.Location = new System.Drawing.Point(8, 99);
            this.ColumnAddButton.Name = "ColumnAddButton";
            this.ColumnAddButton.Size = new System.Drawing.Size(75, 39);
            this.ColumnAddButton.TabIndex = 2;
            this.ColumnAddButton.Text = "Add Column";
            this.ColumnAddButton.UseVisualStyleBackColor = true;
            this.ColumnAddButton.Click += new System.EventHandler(this.ColumnAddButton_Click);
            // 
            // ColumnNameBox
            // 
            this.ColumnNameBox.Location = new System.Drawing.Point(44, 32);
            this.ColumnNameBox.Name = "ColumnNameBox";
            this.ColumnNameBox.Size = new System.Drawing.Size(277, 20);
            this.ColumnNameBox.TabIndex = 1;
            // 
            // InGameTab
            // 
            this.InGameTab.Controls.Add(this.CheckOverlayEnable);
            this.InGameTab.Location = new System.Drawing.Point(4, 22);
            this.InGameTab.Name = "InGameTab";
            this.InGameTab.Padding = new System.Windows.Forms.Padding(3);
            this.InGameTab.Size = new System.Drawing.Size(329, 144);
            this.InGameTab.TabIndex = 2;
            this.InGameTab.Text = "In-Game";
            this.InGameTab.UseVisualStyleBackColor = true;
            // 
            // CheckOverlayEnable
            // 
            this.CheckOverlayEnable.AutoSize = true;
            this.CheckOverlayEnable.Location = new System.Drawing.Point(8, 6);
            this.CheckOverlayEnable.Name = "CheckOverlayEnable";
            this.CheckOverlayEnable.Size = new System.Drawing.Size(84, 17);
            this.CheckOverlayEnable.TabIndex = 0;
            this.CheckOverlayEnable.Text = "Use Overlay";
            this.CheckOverlayEnable.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(118, 172);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(84, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save + Apply";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 202);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SettingsTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}