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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.table1BindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet = new The_UGamer_Launcher.CollectionDataSet();
            this.driverInstall = new System.Windows.Forms.WebBrowser();
            this.driverWarning = new System.Windows.Forms.TextBox();
            this.gameCountText = new System.Windows.Forms.TextBox();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.noGameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ColumnsToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntriesToolTipButton = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ViewToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.FilterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PlatformFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.RatingFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.TimePlayedFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.neverStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LaunchFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.canLaunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantLaunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamLikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotificationsDGV = new System.Windows.Forms.DataGridView();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notificationsSet = new The_UGamer_Launcher.NotificationsSet();
            this.notificationsTableAdapter1 = new The_UGamer_Launcher.NotificationsSetTableAdapters.NotificationsTableAdapter();
            this.table1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notificationDataSet = new The_UGamer_Launcher.NotificationDataSet();
            this.notificationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notificationsTableAdapter = new The_UGamer_Launcher.NotificationDataSetTableAdapters.NotificationsTableAdapter();
            this.table1TableAdapter = new The_UGamer_Launcher.CollectionDataSetTableAdapters.Table1TableAdapter();
            this.collectionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatabaseContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet4 = new The_UGamer_Launcher.CollectionDataSet4();
            this.table1TableAdapter2 = new The_UGamer_Launcher.CollectionDataSet4TableAdapters.Table1TableAdapter();
            this.collectionDataSet5 = new The_UGamer_Launcher.CollectionDataSet5();
            this.collectionDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PagesButton = new System.Windows.Forms.Button();
            this.WebPageBox = new System.Windows.Forms.ComboBox();
            this.PagesBoxButton = new System.Windows.Forms.Button();
            this.BrowserDock = new System.Windows.Forms.Panel();
            this.SteamDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SteamView = new System.Windows.Forms.Panel();
            this.SteamDetailPanel = new System.Windows.Forms.Panel();
            this.SteamInfoButton = new System.Windows.Forms.Button();
            this.SteamLastPlayedLabel = new System.Windows.Forms.Label();
            this.SteamTimeLabel = new System.Windows.Forms.Label();
            this.SteamTrackButton = new System.Windows.Forms.Button();
            this.SteamPlayButton = new System.Windows.Forms.Button();
            this.SteamGameNameLabel = new System.Windows.Forms.Label();
            this.SteamGameIcon = new System.Windows.Forms.PictureBox();
            this.SteamViewHeaderPanel = new System.Windows.Forms.Panel();
            this.Steam_UserButton = new System.Windows.Forms.Button();
            this.Steam_BrowserButton = new System.Windows.Forms.Button();
            this.Steam_LibraryButton = new System.Windows.Forms.Button();
            this.Steam_EntriesButton = new System.Windows.Forms.Button();
            this.Panel_Pages = new System.Windows.Forms.Panel();
            this.GIFBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationsSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSetBindingSource)).BeginInit();
            this.DatabaseContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SteamDGV)).BeginInit();
            this.SteamView.SuspendLayout();
            this.SteamDetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SteamGameIcon)).BeginInit();
            this.SteamViewHeaderPanel.SuspendLayout();
            this.Panel_Pages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GIFBackground)).BeginInit();
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
            this.dataTable.DataSource = this.table1BindingSource5;
            this.dataTable.Location = new System.Drawing.Point(22, 28);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.Size = new System.Drawing.Size(1291, 513);
            this.dataTable.TabIndex = 9;
            this.dataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellDoubleClick);
            this.dataTable.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataTable_CellMouseUp);
            this.dataTable.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.customSortCompare);
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
            dataGridViewCellStyle1.NullValue = null;
            this.PlayTime.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Last Played";
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
            // table1BindingSource5
            // 
            this.table1BindingSource5.DataMember = "Table1";
            this.table1BindingSource5.DataSource = this.collectionDataSet;
            // 
            // collectionDataSet
            // 
            this.collectionDataSet.DataSetName = "CollectionDataSet";
            this.collectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.addEntryButton.Text = "Notifications";
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripButton,
            this.refreshButton,
            this.toolStripButton2,
            this.ViewToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1333, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColumnsToolStripButton,
            this.EntriesToolTipButton});
            this.EditToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripButton.Image")));
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(40, 22);
            this.EditToolStripButton.Text = "Edit";
            // 
            // ColumnsToolStripButton
            // 
            this.ColumnsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ColumnsToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnToolStripMenuItem,
            this.editColumnToolStripMenuItem,
            this.removeColumnToolStripMenuItem});
            this.ColumnsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ColumnsToolStripButton.Image")));
            this.ColumnsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColumnsToolStripButton.Name = "ColumnsToolStripButton";
            this.ColumnsToolStripButton.Size = new System.Drawing.Size(131, 22);
            this.ColumnsToolStripButton.Text = "Columns...";
            // 
            // addColumnToolStripMenuItem
            // 
            this.addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            this.addColumnToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addColumnToolStripMenuItem.Text = "Add Column";
            // 
            // editColumnToolStripMenuItem
            // 
            this.editColumnToolStripMenuItem.Name = "editColumnToolStripMenuItem";
            this.editColumnToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editColumnToolStripMenuItem.Text = "Edit Column";
            // 
            // removeColumnToolStripMenuItem
            // 
            this.removeColumnToolStripMenuItem.Name = "removeColumnToolStripMenuItem";
            this.removeColumnToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.removeColumnToolStripMenuItem.Text = "Remove Column";
            // 
            // EntriesToolTipButton
            // 
            this.EntriesToolTipButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EntriesToolTipButton.Image = ((System.Drawing.Image)(resources.GetObject("EntriesToolTipButton.Image")));
            this.EntriesToolTipButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EntriesToolTipButton.Name = "EntriesToolTipButton";
            this.EntriesToolTipButton.Size = new System.Drawing.Size(131, 22);
            this.EntriesToolTipButton.Text = "Entries";
            this.EntriesToolTipButton.Click += new System.EventHandler(this.EntriesToolTipButton_Click_1);
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton2.Text = "Settings";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ViewToolStripButton
            // 
            this.ViewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ViewToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterButton,
            this.layoutToolStripMenuItem,
            this.openBrowserToolStripMenuItem,
            this.sortToolStripMenuItem});
            this.ViewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewToolStripButton.Image")));
            this.ViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewToolStripButton.Name = "ViewToolStripButton";
            this.ViewToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.ViewToolStripButton.Text = "View";
            // 
            // FilterButton
            // 
            this.FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FilterButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.PlatformFilter,
            this.StatusFilter,
            this.RatingFilter,
            this.TimePlayedFilter,
            this.LaunchFilter,
            this.CategoriesFilter,
            this.toolStripSeparator1,
            this.SaveFilters});
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(148, 22);
            this.FilterButton.Text = "Filter";
            this.FilterButton.DropDownClosed += new System.EventHandler(this.FilterButton_DropDownClosed);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // PlatformFilter
            // 
            this.PlatformFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PlatformFilter.Name = "PlatformFilter";
            this.PlatformFilter.Size = new System.Drawing.Size(146, 22);
            this.PlatformFilter.Text = "Platform";
            // 
            // StatusFilter
            // 
            this.StatusFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusFilter.Name = "StatusFilter";
            this.StatusFilter.Size = new System.Drawing.Size(146, 22);
            this.StatusFilter.Text = "Status";
            // 
            // RatingFilter
            // 
            this.RatingFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RatingFilter.Name = "RatingFilter";
            this.RatingFilter.Size = new System.Drawing.Size(146, 22);
            this.RatingFilter.Text = "Rating";
            // 
            // TimePlayedFilter
            // 
            this.TimePlayedFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TimePlayedFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neverStartedToolStripMenuItem,
            this.startedToolStripMenuItem});
            this.TimePlayedFilter.Name = "TimePlayedFilter";
            this.TimePlayedFilter.Size = new System.Drawing.Size(146, 22);
            this.TimePlayedFilter.Text = "Time Played";
            // 
            // neverStartedToolStripMenuItem
            // 
            this.neverStartedToolStripMenuItem.Name = "neverStartedToolStripMenuItem";
            this.neverStartedToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.neverStartedToolStripMenuItem.Text = "Never Started";
            this.neverStartedToolStripMenuItem.Click += new System.EventHandler(this.neverStartedToolStripMenuItem_Click);
            // 
            // startedToolStripMenuItem
            // 
            this.startedToolStripMenuItem.Name = "startedToolStripMenuItem";
            this.startedToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.startedToolStripMenuItem.Text = "Started";
            this.startedToolStripMenuItem.Click += new System.EventHandler(this.startedToolStripMenuItem_Click);
            // 
            // LaunchFilter
            // 
            this.LaunchFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LaunchFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canLaunchToolStripMenuItem,
            this.cantLaunchToolStripMenuItem});
            this.LaunchFilter.Name = "LaunchFilter";
            this.LaunchFilter.Size = new System.Drawing.Size(146, 22);
            this.LaunchFilter.Text = "Launch";
            // 
            // canLaunchToolStripMenuItem
            // 
            this.canLaunchToolStripMenuItem.Name = "canLaunchToolStripMenuItem";
            this.canLaunchToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.canLaunchToolStripMenuItem.Text = "Can Launch";
            // 
            // cantLaunchToolStripMenuItem
            // 
            this.cantLaunchToolStripMenuItem.Name = "cantLaunchToolStripMenuItem";
            this.cantLaunchToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cantLaunchToolStripMenuItem.Text = "Can\'t Launch";
            // 
            // CategoriesFilter
            // 
            this.CategoriesFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CategoriesFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoriesBox});
            this.CategoriesFilter.Name = "CategoriesFilter";
            this.CategoriesFilter.Size = new System.Drawing.Size(146, 22);
            this.CategoriesFilter.Text = "Categories";
            // 
            // CategoriesBox
            // 
            this.CategoriesBox.Name = "CategoriesBox";
            this.CategoriesBox.Size = new System.Drawing.Size(180, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // SaveFilters
            // 
            this.SaveFilters.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFilters.Name = "SaveFilters";
            this.SaveFilters.Size = new System.Drawing.Size(146, 22);
            this.SaveFilters.Text = "Save + Apply";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalToolStripMenuItem,
            this.steamLikeToolStripMenuItem});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.originalToolStripMenuItem.Text = "Original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // steamLikeToolStripMenuItem
            // 
            this.steamLikeToolStripMenuItem.Name = "steamLikeToolStripMenuItem";
            this.steamLikeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.steamLikeToolStripMenuItem.Text = "Steam-Like";
            this.steamLikeToolStripMenuItem.Click += new System.EventHandler(this.steamLikeToolStripMenuItem_Click);
            // 
            // openBrowserToolStripMenuItem
            // 
            this.openBrowserToolStripMenuItem.Name = "openBrowserToolStripMenuItem";
            this.openBrowserToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openBrowserToolStripMenuItem.Text = "Open Browser";
            this.openBrowserToolStripMenuItem.Click += new System.EventHandler(this.openBrowserToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playTimeToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // playTimeToolStripMenuItem
            // 
            this.playTimeToolStripMenuItem.Name = "playTimeToolStripMenuItem";
            this.playTimeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.playTimeToolStripMenuItem.Text = "Play Time";
            this.playTimeToolStripMenuItem.Click += new System.EventHandler(this.playTimeToolStripMenuItem_Click);
            // 
            // NotificationsDGV
            // 
            this.NotificationsDGV.AllowUserToAddRows = false;
            this.NotificationsDGV.AllowUserToDeleteRows = false;
            this.NotificationsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationsDGV.AutoGenerateColumns = false;
            this.NotificationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotificationsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateAdded,
            this.notificationTypeDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.gameTitleDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn});
            this.NotificationsDGV.DataSource = this.notificationsBindingSource1;
            this.NotificationsDGV.Location = new System.Drawing.Point(22, 28);
            this.NotificationsDGV.Name = "NotificationsDGV";
            this.NotificationsDGV.ReadOnly = true;
            this.NotificationsDGV.Size = new System.Drawing.Size(1291, 513);
            this.NotificationsDGV.TabIndex = 21;
            this.NotificationsDGV.Visible = false;
            this.NotificationsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotificationsDGV_CellDoubleClick);
            // 
            // DateAdded
            // 
            this.DateAdded.DataPropertyName = "DateAdded";
            this.DateAdded.HeaderText = "DateAdded";
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.ReadOnly = true;
            // 
            // notificationTypeDataGridViewTextBoxColumn
            // 
            this.notificationTypeDataGridViewTextBoxColumn.DataPropertyName = "NotificationType";
            this.notificationTypeDataGridViewTextBoxColumn.HeaderText = "NotificationType";
            this.notificationTypeDataGridViewTextBoxColumn.Name = "notificationTypeDataGridViewTextBoxColumn";
            this.notificationTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameTitleDataGridViewTextBoxColumn
            // 
            this.gameTitleDataGridViewTextBoxColumn.DataPropertyName = "GameTitle";
            this.gameTitleDataGridViewTextBoxColumn.HeaderText = "GameTitle";
            this.gameTitleDataGridViewTextBoxColumn.Name = "gameTitleDataGridViewTextBoxColumn";
            this.gameTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notificationsBindingSource1
            // 
            this.notificationsBindingSource1.DataMember = "Notifications";
            this.notificationsBindingSource1.DataSource = this.notificationsSet;
            // 
            // notificationsSet
            // 
            this.notificationsSet.DataSetName = "NotificationsSet";
            this.notificationsSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notificationsTableAdapter1
            // 
            this.notificationsTableAdapter1.ClearBeforeFill = true;
            // 
            // notificationDataSet
            // 
            this.notificationDataSet.DataSetName = "NotificationDataSet";
            this.notificationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notificationsBindingSource
            // 
            this.notificationsBindingSource.DataMember = "Notifications";
            this.notificationsBindingSource.DataSource = this.notificationDataSet;
            // 
            // notificationsTableAdapter
            // 
            this.notificationsTableAdapter.ClearBeforeFill = true;
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
            // DatabaseContextMenu
            // 
            this.DatabaseContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.DatabaseContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEntryToolStripMenuItem,
            this.hideEntryToolStripMenuItem});
            this.DatabaseContextMenu.Name = "DatabaseContextMenu";
            this.DatabaseContextMenu.Size = new System.Drawing.Size(139, 48);
            // 
            // editEntryToolStripMenuItem
            // 
            this.editEntryToolStripMenuItem.Name = "editEntryToolStripMenuItem";
            this.editEntryToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.editEntryToolStripMenuItem.Text = "Edit Entry...";
            this.editEntryToolStripMenuItem.Click += new System.EventHandler(this.editEntryToolStripMenuItem_Click);
            // 
            // hideEntryToolStripMenuItem
            // 
            this.hideEntryToolStripMenuItem.Name = "hideEntryToolStripMenuItem";
            this.hideEntryToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.hideEntryToolStripMenuItem.Text = "Hide Entry...";
            this.hideEntryToolStripMenuItem.Click += new System.EventHandler(this.hideEntryToolStripMenuItem_Click);
            // 
            // table1BindingSource4
            // 
            this.table1BindingSource4.DataMember = "Table1";
            this.table1BindingSource4.DataSource = this.collectionDataSet4;
            // 
            // collectionDataSet4
            // 
            this.collectionDataSet4.DataSetName = "CollectionDataSet4";
            this.collectionDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter2
            // 
            this.table1TableAdapter2.ClearBeforeFill = true;
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
            // PagesButton
            // 
            this.PagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PagesButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PagesButton.FlatAppearance.BorderSize = 2;
            this.PagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PagesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PagesButton.Location = new System.Drawing.Point(1083, 565);
            this.PagesButton.Margin = new System.Windows.Forms.Padding(2);
            this.PagesButton.Name = "PagesButton";
            this.PagesButton.Size = new System.Drawing.Size(113, 64);
            this.PagesButton.TabIndex = 22;
            this.PagesButton.Text = "Pages";
            this.PagesButton.UseVisualStyleBackColor = false;
            this.PagesButton.Click += new System.EventHandler(this.PagesButton_Click);
            // 
            // WebPageBox
            // 
            this.WebPageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WebPageBox.FormattingEnabled = true;
            this.WebPageBox.Location = new System.Drawing.Point(3, 8);
            this.WebPageBox.Name = "WebPageBox";
            this.WebPageBox.Size = new System.Drawing.Size(473, 21);
            this.WebPageBox.TabIndex = 24;
            this.WebPageBox.Visible = false;
            // 
            // PagesBoxButton
            // 
            this.PagesBoxButton.Location = new System.Drawing.Point(482, 8);
            this.PagesBoxButton.Name = "PagesBoxButton";
            this.PagesBoxButton.Size = new System.Drawing.Size(75, 23);
            this.PagesBoxButton.TabIndex = 25;
            this.PagesBoxButton.Text = "Go";
            this.PagesBoxButton.UseVisualStyleBackColor = true;
            this.PagesBoxButton.Visible = false;
            this.PagesBoxButton.Click += new System.EventHandler(this.PagesBoxButton_Click);
            // 
            // BrowserDock
            // 
            this.BrowserDock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserDock.Location = new System.Drawing.Point(0, 36);
            this.BrowserDock.Name = "BrowserDock";
            this.BrowserDock.Size = new System.Drawing.Size(1291, 477);
            this.BrowserDock.TabIndex = 26;
            // 
            // SteamDGV
            // 
            this.SteamDGV.AllowUserToAddRows = false;
            this.SteamDGV.AllowUserToDeleteRows = false;
            this.SteamDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SteamDGV.AutoGenerateColumns = false;
            this.SteamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SteamDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.SteamDGV.DataSource = this.table1BindingSource5;
            this.SteamDGV.Location = new System.Drawing.Point(0, 42);
            this.SteamDGV.Name = "SteamDGV";
            this.SteamDGV.ReadOnly = true;
            this.SteamDGV.Size = new System.Drawing.Size(262, 471);
            this.SteamDGV.TabIndex = 27;
            this.SteamDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SteamDGV_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 219;
            // 
            // SteamView
            // 
            this.SteamView.Controls.Add(this.SteamDetailPanel);
            this.SteamView.Controls.Add(this.SteamViewHeaderPanel);
            this.SteamView.Controls.Add(this.SteamDGV);
            this.SteamView.Location = new System.Drawing.Point(22, 28);
            this.SteamView.Name = "SteamView";
            this.SteamView.Size = new System.Drawing.Size(1291, 513);
            this.SteamView.TabIndex = 27;
            this.SteamView.Visible = false;
            // 
            // SteamDetailPanel
            // 
            this.SteamDetailPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SteamDetailPanel.Controls.Add(this.SteamInfoButton);
            this.SteamDetailPanel.Controls.Add(this.SteamLastPlayedLabel);
            this.SteamDetailPanel.Controls.Add(this.SteamTimeLabel);
            this.SteamDetailPanel.Controls.Add(this.SteamTrackButton);
            this.SteamDetailPanel.Controls.Add(this.SteamPlayButton);
            this.SteamDetailPanel.Controls.Add(this.SteamGameNameLabel);
            this.SteamDetailPanel.Controls.Add(this.SteamGameIcon);
            this.SteamDetailPanel.Location = new System.Drawing.Point(262, 39);
            this.SteamDetailPanel.Name = "SteamDetailPanel";
            this.SteamDetailPanel.Size = new System.Drawing.Size(1008, 474);
            this.SteamDetailPanel.TabIndex = 30;
            // 
            // SteamInfoButton
            // 
            this.SteamInfoButton.Location = new System.Drawing.Point(961, 18);
            this.SteamInfoButton.Name = "SteamInfoButton";
            this.SteamInfoButton.Size = new System.Drawing.Size(50, 50);
            this.SteamInfoButton.TabIndex = 35;
            this.SteamInfoButton.Text = "button3";
            this.SteamInfoButton.UseVisualStyleBackColor = true;
            // 
            // SteamLastPlayedLabel
            // 
            this.SteamLastPlayedLabel.AutoSize = true;
            this.SteamLastPlayedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteamLastPlayedLabel.Location = new System.Drawing.Point(99, 110);
            this.SteamLastPlayedLabel.Name = "SteamLastPlayedLabel";
            this.SteamLastPlayedLabel.Size = new System.Drawing.Size(46, 18);
            this.SteamLastPlayedLabel.TabIndex = 34;
            this.SteamLastPlayedLabel.Text = "label2";
            // 
            // SteamTimeLabel
            // 
            this.SteamTimeLabel.AutoSize = true;
            this.SteamTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteamTimeLabel.Location = new System.Drawing.Point(99, 80);
            this.SteamTimeLabel.Name = "SteamTimeLabel";
            this.SteamTimeLabel.Size = new System.Drawing.Size(46, 18);
            this.SteamTimeLabel.TabIndex = 33;
            this.SteamTimeLabel.Text = "label1";
            // 
            // SteamTrackButton
            // 
            this.SteamTrackButton.Location = new System.Drawing.Point(18, 108);
            this.SteamTrackButton.Name = "SteamTrackButton";
            this.SteamTrackButton.Size = new System.Drawing.Size(75, 23);
            this.SteamTrackButton.TabIndex = 32;
            this.SteamTrackButton.Text = "🕑 Track";
            this.SteamTrackButton.UseVisualStyleBackColor = true;
            // 
            // SteamPlayButton
            // 
            this.SteamPlayButton.Location = new System.Drawing.Point(18, 79);
            this.SteamPlayButton.Name = "SteamPlayButton";
            this.SteamPlayButton.Size = new System.Drawing.Size(75, 23);
            this.SteamPlayButton.TabIndex = 31;
            this.SteamPlayButton.Text = "► Play";
            this.SteamPlayButton.UseVisualStyleBackColor = true;
            this.SteamPlayButton.Click += new System.EventHandler(this.SteamPlayButton_Click);
            // 
            // SteamGameNameLabel
            // 
            this.SteamGameNameLabel.AutoSize = true;
            this.SteamGameNameLabel.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteamGameNameLabel.Location = new System.Drawing.Point(75, 22);
            this.SteamGameNameLabel.Name = "SteamGameNameLabel";
            this.SteamGameNameLabel.Size = new System.Drawing.Size(131, 46);
            this.SteamGameNameLabel.TabIndex = 30;
            this.SteamGameNameLabel.Text = "label1";
            // 
            // SteamGameIcon
            // 
            this.SteamGameIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SteamGameIcon.Location = new System.Drawing.Point(18, 22);
            this.SteamGameIcon.Name = "SteamGameIcon";
            this.SteamGameIcon.Size = new System.Drawing.Size(50, 50);
            this.SteamGameIcon.TabIndex = 29;
            this.SteamGameIcon.TabStop = false;
            // 
            // SteamViewHeaderPanel
            // 
            this.SteamViewHeaderPanel.Controls.Add(this.Steam_UserButton);
            this.SteamViewHeaderPanel.Controls.Add(this.Steam_BrowserButton);
            this.SteamViewHeaderPanel.Controls.Add(this.Steam_LibraryButton);
            this.SteamViewHeaderPanel.Controls.Add(this.Steam_EntriesButton);
            this.SteamViewHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.SteamViewHeaderPanel.Name = "SteamViewHeaderPanel";
            this.SteamViewHeaderPanel.Size = new System.Drawing.Size(1291, 40);
            this.SteamViewHeaderPanel.TabIndex = 28;
            // 
            // Steam_UserButton
            // 
            this.Steam_UserButton.Location = new System.Drawing.Point(709, 3);
            this.Steam_UserButton.Name = "Steam_UserButton";
            this.Steam_UserButton.Size = new System.Drawing.Size(142, 34);
            this.Steam_UserButton.TabIndex = 3;
            this.Steam_UserButton.Text = "USER";
            this.Steam_UserButton.UseVisualStyleBackColor = true;
            // 
            // Steam_BrowserButton
            // 
            this.Steam_BrowserButton.Location = new System.Drawing.Point(561, 3);
            this.Steam_BrowserButton.Name = "Steam_BrowserButton";
            this.Steam_BrowserButton.Size = new System.Drawing.Size(142, 34);
            this.Steam_BrowserButton.TabIndex = 2;
            this.Steam_BrowserButton.Text = "BROWSER";
            this.Steam_BrowserButton.UseVisualStyleBackColor = true;
            // 
            // Steam_LibraryButton
            // 
            this.Steam_LibraryButton.Location = new System.Drawing.Point(413, 3);
            this.Steam_LibraryButton.Name = "Steam_LibraryButton";
            this.Steam_LibraryButton.Size = new System.Drawing.Size(142, 34);
            this.Steam_LibraryButton.TabIndex = 1;
            this.Steam_LibraryButton.Text = "LIBRARY";
            this.Steam_LibraryButton.UseVisualStyleBackColor = true;
            // 
            // Steam_EntriesButton
            // 
            this.Steam_EntriesButton.Location = new System.Drawing.Point(265, 3);
            this.Steam_EntriesButton.Name = "Steam_EntriesButton";
            this.Steam_EntriesButton.Size = new System.Drawing.Size(142, 34);
            this.Steam_EntriesButton.TabIndex = 0;
            this.Steam_EntriesButton.Text = "ENTRIES";
            this.Steam_EntriesButton.UseVisualStyleBackColor = true;
            // 
            // Panel_Pages
            // 
            this.Panel_Pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Pages.Controls.Add(this.WebPageBox);
            this.Panel_Pages.Controls.Add(this.PagesBoxButton);
            this.Panel_Pages.Controls.Add(this.BrowserDock);
            this.Panel_Pages.Location = new System.Drawing.Point(22, 28);
            this.Panel_Pages.Name = "Panel_Pages";
            this.Panel_Pages.Size = new System.Drawing.Size(1291, 513);
            this.Panel_Pages.TabIndex = 4;
            this.Panel_Pages.Visible = false;
            // 
            // GIFBackground
            // 
            this.GIFBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GIFBackground.Location = new System.Drawing.Point(0, 0);
            this.GIFBackground.Name = "GIFBackground";
            this.GIFBackground.Size = new System.Drawing.Size(1333, 652);
            this.GIFBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GIFBackground.TabIndex = 28;
            this.GIFBackground.TabStop = false;
            this.GIFBackground.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 652);
            this.Controls.Add(this.PagesButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.noGameLabel);
            this.Controls.Add(this.addEntryButton);
            this.Controls.Add(this.gameCountText);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.driverInstall);
            this.Controls.Add(this.Panel_Pages);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.driverWarning);
            this.Controls.Add(this.NotificationsDGV);
            this.Controls.Add(this.GIFBackground);
            this.Controls.Add(this.SteamView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "UGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationsSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSetBindingSource)).EndInit();
            this.DatabaseContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SteamDGV)).EndInit();
            this.SteamView.ResumeLayout(false);
            this.SteamDetailPanel.ResumeLayout(false);
            this.SteamDetailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SteamGameIcon)).EndInit();
            this.SteamViewHeaderPanel.ResumeLayout(false);
            this.Panel_Pages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GIFBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.BindingSource table1BindingSource3;
        private System.Windows.Forms.WebBrowser driverInstall;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox driverWarning;
        private System.Windows.Forms.TextBox gameCountText;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label noGameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.BindingSource table1BindingSource2;
        public CollectionDataSet4 collectionDataSet4;
        private System.Windows.Forms.BindingSource table1BindingSource4;
        private CollectionDataSet4TableAdapters.Table1TableAdapter table1TableAdapter2;
        private CollectionDataSet5 collectionDataSet5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton ViewToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem FilterButton;
        private System.Windows.Forms.ToolStripMenuItem PlatformFilter;
        private System.Windows.Forms.ToolStripMenuItem StatusFilter;
        private System.Windows.Forms.ToolStripMenuItem RatingFilter;
        private System.Windows.Forms.ToolStripMenuItem TimePlayedFilter;
        private System.Windows.Forms.ToolStripMenuItem LaunchFilter;
        private System.Windows.Forms.ToolStripMenuItem SaveFilters;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingSource collectionDataSet5BindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton EditToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ColumnsToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem addColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EntriesToolTipButton;
        private System.Windows.Forms.ToolStripMenuItem CategoriesFilter;
        private System.Windows.Forms.ToolStripComboBox CategoriesBox;
        private System.Windows.Forms.DataGridView NotificationsDGV;
        private NotificationDataSet notificationDataSet;
        private System.Windows.Forms.BindingSource notificationsBindingSource;
        private NotificationDataSetTableAdapters.NotificationsTableAdapter notificationsTableAdapter;
        private NotificationsSet notificationsSet;
        private System.Windows.Forms.BindingSource notificationsBindingSource1;
        private NotificationsSetTableAdapters.NotificationsTableAdapter notificationsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private CollectionDataSet collectionDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource5;
        private CollectionDataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.BindingSource collectionDataSetBindingSource;
        private System.Windows.Forms.ToolStripMenuItem openBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neverStartedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startedToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip DatabaseContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canLaunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantLaunchToolStripMenuItem;
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
        private System.Windows.Forms.Button PagesButton;
        private System.Windows.Forms.ComboBox WebPageBox;
        private System.Windows.Forms.Button PagesBoxButton;
        private System.Windows.Forms.Panel BrowserDock;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playTimeToolStripMenuItem;
        private System.Windows.Forms.DataGridView SteamDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel SteamView;
        private System.Windows.Forms.Panel SteamViewHeaderPanel;
        private System.Windows.Forms.Button Steam_UserButton;
        private System.Windows.Forms.Button Steam_BrowserButton;
        private System.Windows.Forms.Button Steam_LibraryButton;
        private System.Windows.Forms.Button Steam_EntriesButton;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steamLikeToolStripMenuItem;
        private System.Windows.Forms.Panel Panel_Pages;
        private System.Windows.Forms.Panel SteamDetailPanel;
        private System.Windows.Forms.Label SteamLastPlayedLabel;
        private System.Windows.Forms.Label SteamTimeLabel;
        private System.Windows.Forms.Button SteamTrackButton;
        private System.Windows.Forms.Button SteamPlayButton;
        private System.Windows.Forms.Label SteamGameNameLabel;
        private System.Windows.Forms.PictureBox SteamGameIcon;
        private System.Windows.Forms.Button SteamInfoButton;
        private System.Windows.Forms.PictureBox GIFBackground;
    }
}

