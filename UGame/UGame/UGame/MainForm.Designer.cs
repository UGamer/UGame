namespace UGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GamesTabs = new System.Windows.Forms.TabControl();
            this.GamesListTab = new System.Windows.Forms.TabPage();
            this.GamesDGV = new System.Windows.Forms.DataGridView();
            this.GamesEntriesTab = new System.Windows.Forms.TabPage();
            this.LockPlatformButton = new System.Windows.Forms.Button();
            this.LockTitleButton = new System.Windows.Forms.Button();
            this.BgBox = new System.Windows.Forms.PictureBox();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.DetailsBox = new System.Windows.Forms.PictureBox();
            this.SearchDatabaseButton = new System.Windows.Forms.Button();
            this.OverlayCheck = new System.Windows.Forms.CheckBox();
            this.BlurCheck = new System.Windows.Forms.CheckBox();
            this.FiltersBox = new System.Windows.Forms.TextBox();
            this.URLButton = new System.Windows.Forms.Button();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PlayerCountBox = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.ReleaseDateCheck = new System.Windows.Forms.CheckBox();
            this.ReleaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PublishersBox = new System.Windows.Forms.TextBox();
            this.DevelopersBox = new System.Windows.Forms.TextBox();
            this.GameDescBox = new System.Windows.Forms.TextBox();
            this.NotesBox = new System.Windows.Forms.TextBox();
            this.LastPlayedCheck = new System.Windows.Forms.CheckBox();
            this.LastPlayedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateCheck = new System.Windows.Forms.CheckBox();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ObtainedCheck = new System.Windows.Forms.CheckBox();
            this.ObtainedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddTimeButton = new System.Windows.Forms.Button();
            this.TimeSecondsLabel = new System.Windows.Forms.Label();
            this.TimeSecondsBox = new System.Windows.Forms.TextBox();
            this.TimeMinutesLabel = new System.Windows.Forms.Label();
            this.TimeMinutesBox = new System.Windows.Forms.TextBox();
            this.TimeHoursLabel = new System.Windows.Forms.Label();
            this.TimeHoursBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.RatingBox = new System.Windows.Forms.TextBox();
            this.RatingBar = new System.Windows.Forms.TrackBar();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.PlatformBox = new System.Windows.Forms.ComboBox();
            this.EntryLabels2 = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.EntryLabels = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PictureContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearPictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalPictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabasePictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.InternetPictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.GamesDGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditEntryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameTabsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseTabButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GamesTabs.SuspendLayout();
            this.GamesListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamesDGV)).BeginInit();
            this.GamesEntriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingBar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.PictureContextMenu.SuspendLayout();
            this.GamesDGVContextMenu.SuspendLayout();
            this.GameTabsContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabs.Controls.Add(this.tabPage1);
            this.MainTabs.Controls.Add(this.tabPage2);
            this.MainTabs.Controls.Add(this.tabPage3);
            this.MainTabs.Location = new System.Drawing.Point(0, 28);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(1061, 589);
            this.MainTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GamesTabs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1053, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Games";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GamesTabs
            // 
            this.GamesTabs.Controls.Add(this.GamesListTab);
            this.GamesTabs.Controls.Add(this.GamesEntriesTab);
            this.GamesTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesTabs.Location = new System.Drawing.Point(3, 3);
            this.GamesTabs.Name = "GamesTabs";
            this.GamesTabs.SelectedIndex = 0;
            this.GamesTabs.Size = new System.Drawing.Size(1047, 557);
            this.GamesTabs.TabIndex = 0;
            this.GamesTabs.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.GamesTabs_ControlRemoved);
            this.GamesTabs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GamesTabs_MouseUp);
            // 
            // GamesListTab
            // 
            this.GamesListTab.Controls.Add(this.GamesDGV);
            this.GamesListTab.Location = new System.Drawing.Point(4, 22);
            this.GamesListTab.Name = "GamesListTab";
            this.GamesListTab.Padding = new System.Windows.Forms.Padding(3);
            this.GamesListTab.Size = new System.Drawing.Size(1039, 531);
            this.GamesListTab.TabIndex = 0;
            this.GamesListTab.Text = "[LIST]";
            this.GamesListTab.UseVisualStyleBackColor = true;
            // 
            // GamesDGV
            // 
            this.GamesDGV.AllowUserToAddRows = false;
            this.GamesDGV.AllowUserToDeleteRows = false;
            this.GamesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GamesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesDGV.Location = new System.Drawing.Point(3, 3);
            this.GamesDGV.Name = "GamesDGV";
            this.GamesDGV.ReadOnly = true;
            this.GamesDGV.RowHeadersVisible = false;
            this.GamesDGV.Size = new System.Drawing.Size(1033, 525);
            this.GamesDGV.TabIndex = 0;
            this.GamesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GamesDGV_CellClick);
            this.GamesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GamesDGV_CellDoubleClick);
            this.GamesDGV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GamesDGV_CellMouseUp);
            this.GamesDGV.Sorted += new System.EventHandler(this.GamesDGV_Sorted);
            this.GamesDGV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            // 
            // GamesEntriesTab
            // 
            this.GamesEntriesTab.Controls.Add(this.LockPlatformButton);
            this.GamesEntriesTab.Controls.Add(this.LockTitleButton);
            this.GamesEntriesTab.Controls.Add(this.BgBox);
            this.GamesEntriesTab.Controls.Add(this.IconBox);
            this.GamesEntriesTab.Controls.Add(this.DetailsBox);
            this.GamesEntriesTab.Controls.Add(this.SearchDatabaseButton);
            this.GamesEntriesTab.Controls.Add(this.OverlayCheck);
            this.GamesEntriesTab.Controls.Add(this.BlurCheck);
            this.GamesEntriesTab.Controls.Add(this.FiltersBox);
            this.GamesEntriesTab.Controls.Add(this.URLButton);
            this.GamesEntriesTab.Controls.Add(this.LaunchButton);
            this.GamesEntriesTab.Controls.Add(this.PriceBox);
            this.GamesEntriesTab.Controls.Add(this.PlayerCountBox);
            this.GamesEntriesTab.Controls.Add(this.GenreBox);
            this.GamesEntriesTab.Controls.Add(this.ReleaseDateCheck);
            this.GamesEntriesTab.Controls.Add(this.ReleaseDatePicker);
            this.GamesEntriesTab.Controls.Add(this.PublishersBox);
            this.GamesEntriesTab.Controls.Add(this.DevelopersBox);
            this.GamesEntriesTab.Controls.Add(this.GameDescBox);
            this.GamesEntriesTab.Controls.Add(this.NotesBox);
            this.GamesEntriesTab.Controls.Add(this.LastPlayedCheck);
            this.GamesEntriesTab.Controls.Add(this.LastPlayedDatePicker);
            this.GamesEntriesTab.Controls.Add(this.StartDateCheck);
            this.GamesEntriesTab.Controls.Add(this.StartDatePicker);
            this.GamesEntriesTab.Controls.Add(this.ObtainedCheck);
            this.GamesEntriesTab.Controls.Add(this.ObtainedDatePicker);
            this.GamesEntriesTab.Controls.Add(this.AddTimeButton);
            this.GamesEntriesTab.Controls.Add(this.TimeSecondsLabel);
            this.GamesEntriesTab.Controls.Add(this.TimeSecondsBox);
            this.GamesEntriesTab.Controls.Add(this.TimeMinutesLabel);
            this.GamesEntriesTab.Controls.Add(this.TimeMinutesBox);
            this.GamesEntriesTab.Controls.Add(this.TimeHoursLabel);
            this.GamesEntriesTab.Controls.Add(this.TimeHoursBox);
            this.GamesEntriesTab.Controls.Add(this.RatingLabel);
            this.GamesEntriesTab.Controls.Add(this.RatingBox);
            this.GamesEntriesTab.Controls.Add(this.RatingBar);
            this.GamesEntriesTab.Controls.Add(this.StatusBox);
            this.GamesEntriesTab.Controls.Add(this.PlatformBox);
            this.GamesEntriesTab.Controls.Add(this.EntryLabels2);
            this.GamesEntriesTab.Controls.Add(this.TitleBox);
            this.GamesEntriesTab.Controls.Add(this.EntryLabels);
            this.GamesEntriesTab.Controls.Add(this.ClearButton);
            this.GamesEntriesTab.Controls.Add(this.DeleteButton);
            this.GamesEntriesTab.Controls.Add(this.ReplaceButton);
            this.GamesEntriesTab.Controls.Add(this.EditButton);
            this.GamesEntriesTab.Controls.Add(this.AddButton);
            this.GamesEntriesTab.Location = new System.Drawing.Point(4, 22);
            this.GamesEntriesTab.Name = "GamesEntriesTab";
            this.GamesEntriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.GamesEntriesTab.Size = new System.Drawing.Size(1039, 531);
            this.GamesEntriesTab.TabIndex = 1;
            this.GamesEntriesTab.Text = "[ENTRIES]";
            this.GamesEntriesTab.UseVisualStyleBackColor = true;
            // 
            // LockPlatformButton
            // 
            this.LockPlatformButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LockPlatformButton.Location = new System.Drawing.Point(236, 37);
            this.LockPlatformButton.Name = "LockPlatformButton";
            this.LockPlatformButton.Size = new System.Drawing.Size(20, 20);
            this.LockPlatformButton.TabIndex = 45;
            this.LockPlatformButton.UseVisualStyleBackColor = true;
            this.LockPlatformButton.Click += new System.EventHandler(this.LockPlatformButton_Click);
            // 
            // LockTitleButton
            // 
            this.LockTitleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LockTitleButton.Location = new System.Drawing.Point(236, 5);
            this.LockTitleButton.Name = "LockTitleButton";
            this.LockTitleButton.Size = new System.Drawing.Size(20, 20);
            this.LockTitleButton.TabIndex = 44;
            this.LockTitleButton.UseVisualStyleBackColor = true;
            this.LockTitleButton.Click += new System.EventHandler(this.LockTitleButton_Click);
            // 
            // BgBox
            // 
            this.BgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BgBox.Location = new System.Drawing.Point(890, 417);
            this.BgBox.Name = "BgBox";
            this.BgBox.Size = new System.Drawing.Size(143, 104);
            this.BgBox.TabIndex = 43;
            this.BgBox.TabStop = false;
            this.BgBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BgBox_MouseUp);
            // 
            // IconBox
            // 
            this.IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconBox.Location = new System.Drawing.Point(890, 268);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(143, 143);
            this.IconBox.TabIndex = 42;
            this.IconBox.TabStop = false;
            this.IconBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IconBox_MouseUp);
            // 
            // DetailsBox
            // 
            this.DetailsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DetailsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailsBox.Location = new System.Drawing.Point(631, 268);
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(253, 253);
            this.DetailsBox.TabIndex = 41;
            this.DetailsBox.TabStop = false;
            this.DetailsBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DetailsBox_MouseUp);
            // 
            // SearchDatabaseButton
            // 
            this.SearchDatabaseButton.Location = new System.Drawing.Point(7, 423);
            this.SearchDatabaseButton.Name = "SearchDatabaseButton";
            this.SearchDatabaseButton.Size = new System.Drawing.Size(146, 44);
            this.SearchDatabaseButton.TabIndex = 40;
            this.SearchDatabaseButton.Text = "SEARCH DATABASE";
            this.SearchDatabaseButton.UseVisualStyleBackColor = true;
            this.SearchDatabaseButton.Click += new System.EventHandler(this.SearchDatabaseButton_Click);
            // 
            // OverlayCheck
            // 
            this.OverlayCheck.AutoSize = true;
            this.OverlayCheck.Checked = true;
            this.OverlayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OverlayCheck.Location = new System.Drawing.Point(724, 248);
            this.OverlayCheck.Name = "OverlayCheck";
            this.OverlayCheck.Size = new System.Drawing.Size(15, 14);
            this.OverlayCheck.TabIndex = 39;
            this.OverlayCheck.UseVisualStyleBackColor = true;
            // 
            // BlurCheck
            // 
            this.BlurCheck.AutoSize = true;
            this.BlurCheck.Checked = true;
            this.BlurCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlurCheck.Location = new System.Drawing.Point(724, 210);
            this.BlurCheck.Name = "BlurCheck";
            this.BlurCheck.Size = new System.Drawing.Size(15, 14);
            this.BlurCheck.TabIndex = 38;
            this.BlurCheck.UseVisualStyleBackColor = true;
            // 
            // FiltersBox
            // 
            this.FiltersBox.Location = new System.Drawing.Point(724, 165);
            this.FiltersBox.Name = "FiltersBox";
            this.FiltersBox.Size = new System.Drawing.Size(309, 20);
            this.FiltersBox.TabIndex = 37;
            // 
            // URLButton
            // 
            this.URLButton.Location = new System.Drawing.Point(724, 132);
            this.URLButton.Name = "URLButton";
            this.URLButton.Size = new System.Drawing.Size(309, 23);
            this.URLButton.TabIndex = 36;
            this.URLButton.Text = "Show Table";
            this.URLButton.UseVisualStyleBackColor = true;
            this.URLButton.Click += new System.EventHandler(this.URLButton_Click);
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(724, 100);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(309, 23);
            this.LaunchButton.TabIndex = 35;
            this.LaunchButton.Text = "Show Table";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(266, 501);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(347, 20);
            this.PriceBox.TabIndex = 34;
            // 
            // PlayerCountBox
            // 
            this.PlayerCountBox.Location = new System.Drawing.Point(266, 469);
            this.PlayerCountBox.Name = "PlayerCountBox";
            this.PlayerCountBox.Size = new System.Drawing.Size(347, 20);
            this.PlayerCountBox.TabIndex = 33;
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(266, 437);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(347, 20);
            this.GenreBox.TabIndex = 32;
            // 
            // ReleaseDateCheck
            // 
            this.ReleaseDateCheck.AutoSize = true;
            this.ReleaseDateCheck.Checked = true;
            this.ReleaseDateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReleaseDateCheck.Location = new System.Drawing.Point(266, 408);
            this.ReleaseDateCheck.Name = "ReleaseDateCheck";
            this.ReleaseDateCheck.Size = new System.Drawing.Size(56, 17);
            this.ReleaseDateCheck.TabIndex = 31;
            this.ReleaseDateCheck.Text = "Ignore";
            this.ReleaseDateCheck.UseVisualStyleBackColor = true;
            // 
            // ReleaseDatePicker
            // 
            this.ReleaseDatePicker.Location = new System.Drawing.Point(326, 406);
            this.ReleaseDatePicker.Name = "ReleaseDatePicker";
            this.ReleaseDatePicker.Size = new System.Drawing.Size(287, 20);
            this.ReleaseDatePicker.TabIndex = 30;
            // 
            // PublishersBox
            // 
            this.PublishersBox.Location = new System.Drawing.Point(266, 374);
            this.PublishersBox.Name = "PublishersBox";
            this.PublishersBox.Size = new System.Drawing.Size(347, 20);
            this.PublishersBox.TabIndex = 29;
            // 
            // DevelopersBox
            // 
            this.DevelopersBox.Location = new System.Drawing.Point(266, 342);
            this.DevelopersBox.Name = "DevelopersBox";
            this.DevelopersBox.Size = new System.Drawing.Size(347, 20);
            this.DevelopersBox.TabIndex = 28;
            // 
            // GameDescBox
            // 
            this.GameDescBox.Location = new System.Drawing.Point(724, 7);
            this.GameDescBox.Multiline = true;
            this.GameDescBox.Name = "GameDescBox";
            this.GameDescBox.Size = new System.Drawing.Size(309, 70);
            this.GameDescBox.TabIndex = 27;
            // 
            // NotesBox
            // 
            this.NotesBox.Location = new System.Drawing.Point(266, 264);
            this.NotesBox.Multiline = true;
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(347, 70);
            this.NotesBox.TabIndex = 26;
            // 
            // LastPlayedCheck
            // 
            this.LastPlayedCheck.AutoSize = true;
            this.LastPlayedCheck.Checked = true;
            this.LastPlayedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LastPlayedCheck.Location = new System.Drawing.Point(267, 231);
            this.LastPlayedCheck.Name = "LastPlayedCheck";
            this.LastPlayedCheck.Size = new System.Drawing.Size(56, 17);
            this.LastPlayedCheck.TabIndex = 25;
            this.LastPlayedCheck.Text = "Ignore";
            this.LastPlayedCheck.UseVisualStyleBackColor = true;
            // 
            // LastPlayedDatePicker
            // 
            this.LastPlayedDatePicker.Location = new System.Drawing.Point(327, 229);
            this.LastPlayedDatePicker.Name = "LastPlayedDatePicker";
            this.LastPlayedDatePicker.Size = new System.Drawing.Size(287, 20);
            this.LastPlayedDatePicker.TabIndex = 24;
            // 
            // StartDateCheck
            // 
            this.StartDateCheck.AutoSize = true;
            this.StartDateCheck.Checked = true;
            this.StartDateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StartDateCheck.Location = new System.Drawing.Point(267, 199);
            this.StartDateCheck.Name = "StartDateCheck";
            this.StartDateCheck.Size = new System.Drawing.Size(56, 17);
            this.StartDateCheck.TabIndex = 23;
            this.StartDateCheck.Text = "Ignore";
            this.StartDateCheck.UseVisualStyleBackColor = true;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(327, 197);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(287, 20);
            this.StartDatePicker.TabIndex = 22;
            // 
            // ObtainedCheck
            // 
            this.ObtainedCheck.AutoSize = true;
            this.ObtainedCheck.Checked = true;
            this.ObtainedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ObtainedCheck.Location = new System.Drawing.Point(267, 167);
            this.ObtainedCheck.Name = "ObtainedCheck";
            this.ObtainedCheck.Size = new System.Drawing.Size(56, 17);
            this.ObtainedCheck.TabIndex = 21;
            this.ObtainedCheck.Text = "Ignore";
            this.ObtainedCheck.UseVisualStyleBackColor = true;
            // 
            // ObtainedDatePicker
            // 
            this.ObtainedDatePicker.Location = new System.Drawing.Point(327, 165);
            this.ObtainedDatePicker.Name = "ObtainedDatePicker";
            this.ObtainedDatePicker.Size = new System.Drawing.Size(287, 20);
            this.ObtainedDatePicker.TabIndex = 20;
            // 
            // AddTimeButton
            // 
            this.AddTimeButton.Location = new System.Drawing.Point(580, 133);
            this.AddTimeButton.Name = "AddTimeButton";
            this.AddTimeButton.Size = new System.Drawing.Size(34, 22);
            this.AddTimeButton.TabIndex = 19;
            this.AddTimeButton.Text = "+";
            this.AddTimeButton.UseVisualStyleBackColor = true;
            this.AddTimeButton.Click += new System.EventHandler(this.AddTimeButton_Click);
            // 
            // TimeSecondsLabel
            // 
            this.TimeSecondsLabel.AutoSize = true;
            this.TimeSecondsLabel.Location = new System.Drawing.Point(526, 137);
            this.TimeSecondsLabel.Name = "TimeSecondsLabel";
            this.TimeSecondsLabel.Size = new System.Drawing.Size(47, 13);
            this.TimeSecondsLabel.TabIndex = 18;
            this.TimeSecondsLabel.Text = "seconds";
            // 
            // TimeSecondsBox
            // 
            this.TimeSecondsBox.Location = new System.Drawing.Point(469, 133);
            this.TimeSecondsBox.Name = "TimeSecondsBox";
            this.TimeSecondsBox.Size = new System.Drawing.Size(54, 20);
            this.TimeSecondsBox.TabIndex = 17;
            // 
            // TimeMinutesLabel
            // 
            this.TimeMinutesLabel.AutoSize = true;
            this.TimeMinutesLabel.Location = new System.Drawing.Point(420, 137);
            this.TimeMinutesLabel.Name = "TimeMinutesLabel";
            this.TimeMinutesLabel.Size = new System.Drawing.Size(43, 13);
            this.TimeMinutesLabel.TabIndex = 16;
            this.TimeMinutesLabel.Text = "minutes";
            // 
            // TimeMinutesBox
            // 
            this.TimeMinutesBox.Location = new System.Drawing.Point(363, 133);
            this.TimeMinutesBox.Name = "TimeMinutesBox";
            this.TimeMinutesBox.Size = new System.Drawing.Size(54, 20);
            this.TimeMinutesBox.TabIndex = 15;
            // 
            // TimeHoursLabel
            // 
            this.TimeHoursLabel.AutoSize = true;
            this.TimeHoursLabel.Location = new System.Drawing.Point(324, 137);
            this.TimeHoursLabel.Name = "TimeHoursLabel";
            this.TimeHoursLabel.Size = new System.Drawing.Size(33, 13);
            this.TimeHoursLabel.TabIndex = 14;
            this.TimeHoursLabel.Text = "hours";
            // 
            // TimeHoursBox
            // 
            this.TimeHoursBox.Location = new System.Drawing.Point(267, 133);
            this.TimeHoursBox.Name = "TimeHoursBox";
            this.TimeHoursBox.Size = new System.Drawing.Size(54, 20);
            this.TimeHoursBox.TabIndex = 13;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(556, 104);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(63, 13);
            this.RatingLabel.TabIndex = 12;
            this.RatingLabel.Text = "0 = Unrated";
            // 
            // RatingBox
            // 
            this.RatingBox.Location = new System.Drawing.Point(515, 101);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.ReadOnly = true;
            this.RatingBox.Size = new System.Drawing.Size(35, 20);
            this.RatingBox.TabIndex = 11;
            this.RatingBox.Text = "0";
            this.RatingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RatingBar
            // 
            this.RatingBar.BackColor = System.Drawing.Color.White;
            this.RatingBar.LargeChange = 1;
            this.RatingBar.Location = new System.Drawing.Point(267, 101);
            this.RatingBar.Name = "RatingBar";
            this.RatingBar.Size = new System.Drawing.Size(241, 45);
            this.RatingBar.TabIndex = 10;
            this.RatingBar.ValueChanged += new System.EventHandler(this.RatingBar_ValueChanged);
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(267, 69);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(347, 21);
            this.StatusBox.TabIndex = 9;
            // 
            // PlatformBox
            // 
            this.PlatformBox.FormattingEnabled = true;
            this.PlatformBox.Location = new System.Drawing.Point(267, 37);
            this.PlatformBox.Name = "PlatformBox";
            this.PlatformBox.Size = new System.Drawing.Size(347, 21);
            this.PlatformBox.TabIndex = 8;
            // 
            // EntryLabels2
            // 
            this.EntryLabels2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntryLabels2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryLabels2.Location = new System.Drawing.Point(631, 7);
            this.EntryLabels2.Multiline = true;
            this.EntryLabels2.Name = "EntryLabels2";
            this.EntryLabels2.Size = new System.Drawing.Size(100, 521);
            this.EntryLabels2.TabIndex = 7;
            this.EntryLabels2.Text = "Game Description: \r\n\r\n\r\n\r\n\r\nLaunch Codes: \r\n\r\nURLs: \r\n\r\nFilters: \r\n\r\nBlur Backgro" +
    "und?: \r\n\r\nUse Overlay?: ";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(267, 5);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(347, 20);
            this.TitleBox.TabIndex = 6;
            // 
            // EntryLabels
            // 
            this.EntryLabels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntryLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryLabels.Location = new System.Drawing.Point(160, 7);
            this.EntryLabels.Multiline = true;
            this.EntryLabels.Name = "EntryLabels";
            this.EntryLabels.Size = new System.Drawing.Size(100, 521);
            this.EntryLabels.TabIndex = 5;
            this.EntryLabels.Text = resources.GetString("EntryLabels.Text");
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(7, 473);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(146, 44);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "CLEAR FIELDS";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(7, 157);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(146, 44);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(7, 107);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(146, 44);
            this.ReplaceButton.TabIndex = 2;
            this.ReplaceButton.Text = "APPLY CHANGES";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Visible = false;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(7, 57);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(146, 44);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(7, 7);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(146, 44);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1053, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consoles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(229, 557);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1053, 563);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notifications";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1061, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PictureContextMenu
            // 
            this.PictureContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearPictureButton,
            this.LocalPictureButton,
            this.DatabasePictureButton,
            this.InternetPictureButton});
            this.PictureContextMenu.Name = "PictureContextMenu";
            this.PictureContextMenu.Size = new System.Drawing.Size(155, 92);
            // 
            // ClearPictureButton
            // 
            this.ClearPictureButton.Name = "ClearPictureButton";
            this.ClearPictureButton.Size = new System.Drawing.Size(154, 22);
            this.ClearPictureButton.Text = "Clear Picture";
            // 
            // LocalPictureButton
            // 
            this.LocalPictureButton.Name = "LocalPictureButton";
            this.LocalPictureButton.Size = new System.Drawing.Size(154, 22);
            this.LocalPictureButton.Text = "From Local File";
            this.LocalPictureButton.Click += new System.EventHandler(this.LocalPictureButton_Click);
            // 
            // DatabasePictureButton
            // 
            this.DatabasePictureButton.Name = "DatabasePictureButton";
            this.DatabasePictureButton.Size = new System.Drawing.Size(154, 22);
            this.DatabasePictureButton.Text = "From Database";
            this.DatabasePictureButton.Click += new System.EventHandler(this.DatabasePictureButton_Click);
            // 
            // InternetPictureButton
            // 
            this.InternetPictureButton.Name = "InternetPictureButton";
            this.InternetPictureButton.Size = new System.Drawing.Size(154, 22);
            this.InternetPictureButton.Text = "From Internet";
            this.InternetPictureButton.Click += new System.EventHandler(this.InternetPictureButton_Click);
            // 
            // PictureDialog
            // 
            this.PictureDialog.FileName = "openFileDialog1";
            this.PictureDialog.Filter = "Image Files(*.PNG;*.JPG;*.JPEG;*.GIF)|*.PNG;*.JPG;*.JPEG;*.GIF";
            // 
            // GamesDGVContextMenu
            // 
            this.GamesDGVContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditEntryButton,
            this.deleteEntryToolStripMenuItem});
            this.GamesDGVContextMenu.Name = "GamesDGVContextMenu";
            this.GamesDGVContextMenu.Size = new System.Drawing.Size(138, 48);
            // 
            // EditEntryButton
            // 
            this.EditEntryButton.Name = "EditEntryButton";
            this.EditEntryButton.Size = new System.Drawing.Size(137, 22);
            this.EditEntryButton.Text = "Edit Entry";
            this.EditEntryButton.Click += new System.EventHandler(this.EditEntryButton_Click);
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deleteEntryToolStripMenuItem.Text = "Delete Entry";
            // 
            // GameTabsContextMenu
            // 
            this.GameTabsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseTabButton});
            this.GameTabsContextMenu.Name = "GameTabsContextMenu";
            this.GameTabsContextMenu.Size = new System.Drawing.Size(126, 26);
            // 
            // CloseTabButton
            // 
            this.CloseTabButton.Name = "CloseTabButton";
            this.CloseTabButton.Size = new System.Drawing.Size(125, 22);
            this.CloseTabButton.Text = "Close Tab";
            this.CloseTabButton.Click += new System.EventHandler(this.CloseTabButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 617);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainTabs);
            this.Name = "MainForm";
            this.Text = "UGame";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.MainTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.GamesTabs.ResumeLayout(false);
            this.GamesListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GamesDGV)).EndInit();
            this.GamesEntriesTab.ResumeLayout(false);
            this.GamesEntriesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingBar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.PictureContextMenu.ResumeLayout(false);
            this.GamesDGVContextMenu.ResumeLayout(false);
            this.GameTabsContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl GamesTabs;
        private System.Windows.Forms.TabPage GamesListTab;
        public System.Windows.Forms.DataGridView GamesDGV;
        private System.Windows.Forms.TabPage GamesEntriesTab;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox EntryLabels;
        private System.Windows.Forms.Button ClearButton;
        public System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox RatingBox;
        private System.Windows.Forms.TrackBar RatingBar;
        private System.Windows.Forms.ComboBox StatusBox;
        public System.Windows.Forms.ComboBox PlatformBox;
        private System.Windows.Forms.TextBox EntryLabels2;
        public System.Windows.Forms.TextBox PublishersBox;
        public System.Windows.Forms.TextBox DevelopersBox;
        public System.Windows.Forms.TextBox GameDescBox;
        private System.Windows.Forms.TextBox NotesBox;
        private System.Windows.Forms.CheckBox LastPlayedCheck;
        private System.Windows.Forms.DateTimePicker LastPlayedDatePicker;
        private System.Windows.Forms.CheckBox StartDateCheck;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.CheckBox ObtainedCheck;
        private System.Windows.Forms.DateTimePicker ObtainedDatePicker;
        private System.Windows.Forms.Button AddTimeButton;
        private System.Windows.Forms.Label TimeSecondsLabel;
        public System.Windows.Forms.TextBox TimeSecondsBox;
        private System.Windows.Forms.Label TimeMinutesLabel;
        public System.Windows.Forms.TextBox TimeMinutesBox;
        private System.Windows.Forms.Label TimeHoursLabel;
        public System.Windows.Forms.TextBox TimeHoursBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.CheckBox OverlayCheck;
        private System.Windows.Forms.CheckBox BlurCheck;
        private System.Windows.Forms.TextBox FiltersBox;
        private System.Windows.Forms.Button URLButton;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox PlayerCountBox;
        public System.Windows.Forms.TextBox GenreBox;
        public System.Windows.Forms.CheckBox ReleaseDateCheck;
        public System.Windows.Forms.DateTimePicker ReleaseDatePicker;
        private System.Windows.Forms.Button SearchDatabaseButton;
        private System.Windows.Forms.PictureBox BgBox;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.PictureBox DetailsBox;
        private System.Windows.Forms.ContextMenuStrip PictureContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearPictureButton;
        private System.Windows.Forms.ToolStripMenuItem LocalPictureButton;
        private System.Windows.Forms.ToolStripMenuItem DatabasePictureButton;
        private System.Windows.Forms.ToolStripMenuItem InternetPictureButton;
        private System.Windows.Forms.OpenFileDialog PictureDialog;
        private System.Windows.Forms.ContextMenuStrip GamesDGVContextMenu;
        private System.Windows.Forms.ToolStripMenuItem EditEntryButton;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
        private System.Windows.Forms.Button LockPlatformButton;
        private System.Windows.Forms.Button LockTitleButton;
        private System.Windows.Forms.ContextMenuStrip GameTabsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseTabButton;
    }
}

