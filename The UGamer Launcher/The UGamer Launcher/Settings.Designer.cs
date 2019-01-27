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
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet4 = new The_UGamer_Launcher.CollectionDataSet4();
            this.table1TableAdapter = new The_UGamer_Launcher.CollectionDataSet4TableAdapters.Table1TableAdapter();
            this.themeDetails = new System.Windows.Forms.Button();
            this.saveApply = new System.Windows.Forms.Button();
            this.collectionDataSet5 = new The_UGamer_Launcher.CollectionDataSet5();
            this.collectionDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themesTableAdapter = new The_UGamer_Launcher.CollectionDataSet5TableAdapters.ThemesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
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
            this.themeSelect.Location = new System.Drawing.Point(65, 10);
            this.themeSelect.Name = "themeSelect";
            this.themeSelect.Size = new System.Drawing.Size(230, 21);
            this.themeSelect.TabIndex = 1;
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
            this.themeDetails.Location = new System.Drawing.Point(301, 10);
            this.themeDetails.Name = "themeDetails";
            this.themeDetails.Size = new System.Drawing.Size(24, 21);
            this.themeDetails.TabIndex = 2;
            this.themeDetails.Text = "...";
            this.themeDetails.UseVisualStyleBackColor = true;
            // 
            // saveApply
            // 
            this.saveApply.Location = new System.Drawing.Point(126, 37);
            this.saveApply.Name = "saveApply";
            this.saveApply.Size = new System.Drawing.Size(84, 23);
            this.saveApply.TabIndex = 4;
            this.saveApply.Text = "Save + Apply";
            this.saveApply.UseVisualStyleBackColor = true;
            this.saveApply.Click += new System.EventHandler(this.saveApply_Click);
            // 
            // collectionDataSet5
            // 
            this.collectionDataSet5.DataSetName = "CollectionDataSet5";
            this.collectionDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collectionDataSet5BindingSource
            // 
            this.collectionDataSet5BindingSource.DataSource = this.collectionDataSet5;
            this.collectionDataSet5BindingSource.Position = 0;
            // 
            // themesBindingSource
            // 
            this.themesBindingSource.DataMember = "Themes";
            this.themesBindingSource.DataSource = this.collectionDataSet5BindingSource;
            // 
            // themesTableAdapter
            // 
            this.themesTableAdapter.ClearBeforeFill = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 71);
            this.Controls.Add(this.saveApply);
            this.Controls.Add(this.themeDetails);
            this.Controls.Add(this.themeSelect);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}