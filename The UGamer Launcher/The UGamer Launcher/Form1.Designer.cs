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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtainedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.launchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet3 = new The_UGamer_Launcher.CollectionDataSet3();
            this.driverInstall = new System.Windows.Forms.WebBrowser();
            this.driverWarning = new System.Windows.Forms.TextBox();
            this.gameCountText = new System.Windows.Forms.TextBox();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.table1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSetFinal = new The_UGamer_Launcher.CollectionDataSetFinal();
            this.table1TableAdapter3 = new The_UGamer_Launcher.CollectionDataSetFinalTableAdapters.Table1TableAdapter();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.noGameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSetFinal2 = new The_UGamer_Launcher.CollectionDataSetFinal2();
            this.table1TableAdapter = new The_UGamer_Launcher.CollectionDataSetFinal2TableAdapters.Table1TableAdapter();
            this.table1TableAdapter1 = new The_UGamer_Launcher.CollectionDataSet3TableAdapters.Table1TableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSetFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSetFinal2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTable.AutoGenerateColumns = false;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.PlayTime,
            this.obtainedDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.notesCommentsDataGridViewTextBoxColumn,
            this.launchDataGridViewTextBoxColumn});
            this.dataTable.DataSource = this.table1BindingSource2;
            this.dataTable.Location = new System.Drawing.Point(22, 28);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.Size = new System.Drawing.Size(1291, 513);
            this.dataTable.TabIndex = 9;
            this.dataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellDoubleClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 219;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 90;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingDataGridViewTextBoxColumn.Width = 70;
            // 
            // PlayTime
            // 
            this.PlayTime.DataPropertyName = "PlayTime";
            this.PlayTime.HeaderText = "Time Played";
            this.PlayTime.Name = "PlayTime";
            this.PlayTime.ReadOnly = true;
            // 
            // obtainedDataGridViewTextBoxColumn
            // 
            this.obtainedDataGridViewTextBoxColumn.DataPropertyName = "Obtained";
            this.obtainedDataGridViewTextBoxColumn.HeaderText = "Obtained";
            this.obtainedDataGridViewTextBoxColumn.Name = "obtainedDataGridViewTextBoxColumn";
            this.obtainedDataGridViewTextBoxColumn.ReadOnly = true;
            this.obtainedDataGridViewTextBoxColumn.Width = 80;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // notesCommentsDataGridViewTextBoxColumn
            // 
            this.notesCommentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesCommentsDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesCommentsDataGridViewTextBoxColumn.HeaderText = "Notes/Comments";
            this.notesCommentsDataGridViewTextBoxColumn.Name = "notesCommentsDataGridViewTextBoxColumn";
            this.notesCommentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // launchDataGridViewTextBoxColumn
            // 
            this.launchDataGridViewTextBoxColumn.DataPropertyName = "Launch";
            this.launchDataGridViewTextBoxColumn.HeaderText = "Launch";
            this.launchDataGridViewTextBoxColumn.Name = "launchDataGridViewTextBoxColumn";
            this.launchDataGridViewTextBoxColumn.ReadOnly = true;
            this.launchDataGridViewTextBoxColumn.Visible = false;
            // 
            // table1BindingSource2
            // 
            this.table1BindingSource2.DataMember = "Table1";
            this.table1BindingSource2.DataSource = this.collectionDataSet3;
            // 
            // collectionDataSet3
            // 
            this.collectionDataSet3.DataSetName = "CollectionDataSet3";
            this.collectionDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverInstall
            // 
            this.driverInstall.Location = new System.Drawing.Point(617, 354);
            this.driverInstall.MinimumSize = new System.Drawing.Size(20, 20);
            this.driverInstall.Name = "driverInstall";
            this.driverInstall.Size = new System.Drawing.Size(68, 64);
            this.driverInstall.TabIndex = 11;
            this.driverInstall.Visible = false;
            // 
            // driverWarning
            // 
            this.driverWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driverWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverWarning.Location = new System.Drawing.Point(22, 28);
            this.driverWarning.Multiline = true;
            this.driverWarning.Name = "driverWarning";
            this.driverWarning.ReadOnly = true;
            this.driverWarning.Size = new System.Drawing.Size(1291, 513);
            this.driverWarning.TabIndex = 13;
            this.driverWarning.Text = "You don\'t have the correct drivers to display the database! \r\n\r\nOpen the driver i" +
    "nstallation from Microsoft and then restart the launcher.";
            this.driverWarning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.driverWarning.Visible = false;
            // 
            // gameCountText
            // 
            this.gameCountText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gameCountText.Location = new System.Drawing.Point(559, 549);
            this.gameCountText.Name = "gameCountText";
            this.gameCountText.ReadOnly = true;
            this.gameCountText.Size = new System.Drawing.Size(175, 20);
            this.gameCountText.TabIndex = 14;
            this.gameCountText.Text = "Total Games";
            this.gameCountText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addEntryButton
            // 
            this.addEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addEntryButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addEntryButton.FlatAppearance.BorderSize = 2;
            this.addEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEntryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addEntryButton.Location = new System.Drawing.Point(1200, 565);
            this.addEntryButton.Margin = new System.Windows.Forms.Padding(2);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(113, 64);
            this.addEntryButton.TabIndex = 15;
            this.addEntryButton.Text = "Entries";
            this.addEntryButton.UseVisualStyleBackColor = false;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(22, 559);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(188, 70);
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // table1BindingSource3
            // 
            this.table1BindingSource3.DataMember = "Table1";
            this.table1BindingSource3.DataSource = this.collectionDataSetFinal;
            // 
            // collectionDataSetFinal
            // 
            this.collectionDataSetFinal.DataSetName = "CollectionDataSetFinal";
            this.collectionDataSetFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter3
            // 
            this.table1TableAdapter3.ClearBeforeFill = true;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.collectionDataSetFinal;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // noGameLabel
            // 
            this.noGameLabel.AutoSize = true;
            this.noGameLabel.Location = new System.Drawing.Point(556, 598);
            this.noGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noGameLabel.Name = "noGameLabel";
            this.noGameLabel.Size = new System.Drawing.Size(189, 13);
            this.noGameLabel.TabIndex = 17;
            this.noGameLabel.Text = "Sorry, it seems that game doesn\'t exist.";
            this.noGameLabel.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchButton.Location = new System.Drawing.Point(855, 574);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(24, 22);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "🔍";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Sonic"});
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.Location = new System.Drawing.Point(439, 575);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(419, 20);
            this.searchBox.TabIndex = 19;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table1";
            this.table1BindingSource1.DataSource = this.collectionDataSetFinal2;
            // 
            // collectionDataSetFinal2
            // 
            this.collectionDataSetFinal2.DataSetName = "CollectionDataSetFinal2";
            this.collectionDataSetFinal2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // table1TableAdapter1
            // 
            this.table1TableAdapter1.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1333, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(50, 22);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 652);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.noGameLabel);
            this.Controls.Add(this.addEntryButton);
            this.Controls.Add(this.gameCountText);
            this.Controls.Add(this.driverInstall);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.driverWarning);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "UGame Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSetFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSetFinal2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataTable;
        public CollectionDataSetFinal collectionDataSetFinal;
        private System.Windows.Forms.BindingSource table1BindingSource3;
        private CollectionDataSetFinalTableAdapters.Table1TableAdapter table1TableAdapter3;
        private System.Windows.Forms.WebBrowser driverInstall;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox driverWarning;
        private System.Windows.Forms.TextBox gameCountText;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.BindingSource table1BindingSource;
        public CollectionDataSetFinal2 collectionDataSetFinal2;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private CollectionDataSetFinal2TableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label noGameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        public CollectionDataSet3 collectionDataSet3;
        private System.Windows.Forms.BindingSource table1BindingSource2;
        public CollectionDataSet3TableAdapters.Table1TableAdapter table1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn obtainedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn launchDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton refreshButton;
    }
}

