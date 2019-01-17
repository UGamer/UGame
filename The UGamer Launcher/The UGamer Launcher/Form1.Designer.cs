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
            this.detailButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet = new The_UGamer_Launcher.CollectionDataSet();
            this.table1TableAdapter = new The_UGamer_Launcher.CollectionDataSetTableAdapters.Table1TableAdapter();
            this.collectionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet1 = new The_UGamer_Launcher.CollectionDataSet1();
            this.table1TableAdapter1 = new The_UGamer_Launcher.CollectionDataSet1TableAdapters.Table1TableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtainedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.launchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSetFinal = new The_UGamer_Launcher.CollectionDataSetFinal();
            this.table1TableAdapter3 = new The_UGamer_Launcher.CollectionDataSetFinalTableAdapters.Table1TableAdapter();
            this.table1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet2 = new The_UGamer_Launcher.CollectionDataSet2();
            this.table1TableAdapter2 = new The_UGamer_Launcher.CollectionDataSet2TableAdapters.Table1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSetFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // detailButton
            // 
            this.detailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.detailButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.detailButton.FlatAppearance.BorderSize = 2;
            this.detailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailButton.ForeColor = System.Drawing.SystemColors.Control;
            this.detailButton.Location = new System.Drawing.Point(1200, 549);
            this.detailButton.Margin = new System.Windows.Forms.Padding(2);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(113, 64);
            this.detailButton.TabIndex = 1;
            this.detailButton.Text = "Details";
            this.detailButton.UseVisualStyleBackColor = false;
            this.detailButton.Click += new System.EventHandler(this.detailButton_Click_1);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(12, 549);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(188, 70);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.collectionDataSet;
            // 
            // collectionDataSet
            // 
            this.collectionDataSet.DataSetName = "CollectionDataSet";
            this.collectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // collectionDataSetBindingSource
            // 
            this.collectionDataSetBindingSource.DataSource = this.collectionDataSet;
            this.collectionDataSetBindingSource.Position = 0;
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table1";
            this.table1BindingSource1.DataSource = this.collectionDataSet1;
            // 
            // collectionDataSet1
            // 
            this.collectionDataSet1.DataSetName = "CollectionDataSet1";
            this.collectionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter1
            // 
            this.table1TableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1333, 25);
            this.fillByToolStrip.TabIndex = 8;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_2);
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AutoGenerateColumns = false;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.obtainedDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.notesCommentsDataGridViewTextBoxColumn,
            this.launchDataGridViewTextBoxColumn});
            this.dataTable.DataSource = this.table1BindingSource3;
            this.dataTable.Location = new System.Drawing.Point(22, 28);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.Size = new System.Drawing.Size(1291, 500);
            this.dataTable.TabIndex = 9;
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
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursDataGridViewTextBoxColumn.Width = 70;
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
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "Start Date";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "End Date";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // notesCommentsDataGridViewTextBoxColumn
            // 
            this.notesCommentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesCommentsDataGridViewTextBoxColumn.DataPropertyName = "Notes/Comments";
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
            // table1BindingSource2
            // 
            this.table1BindingSource2.DataMember = "Table1";
            this.table1BindingSource2.DataSource = this.collectionDataSet2;
            // 
            // collectionDataSet2
            // 
            this.collectionDataSet2.DataSetName = "CollectionDataSet2";
            this.collectionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter2
            // 
            this.table1TableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 639);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.detailButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "UGame Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSetFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button detailButton;
        private System.Windows.Forms.PictureBox logo;
        public CollectionDataSet collectionDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private CollectionDataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.BindingSource collectionDataSetBindingSource;
        private CollectionDataSet1 collectionDataSet1;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private CollectionDataSet1TableAdapters.Table1TableAdapter table1TableAdapter1;
        private CollectionDataSet2 collectionDataSet2;
        private System.Windows.Forms.BindingSource table1BindingSource2;
        private CollectionDataSet2TableAdapters.Table1TableAdapter table1TableAdapter2;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dataTable;
        public CollectionDataSetFinal collectionDataSetFinal;
        private System.Windows.Forms.BindingSource table1BindingSource3;
        private CollectionDataSetFinalTableAdapters.Table1TableAdapter table1TableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obtainedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn launchDataGridViewTextBoxColumn;
    }
}

