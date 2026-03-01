namespace SportsDataApplication.TMMM
{
    partial class NFL_UpcomingGames_MatchResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NFL_UpcomingGames_MatchResults));
            this.sign_InDataSet = new SportsDataApplication.TMMM.Sign_InDataSet();
            this.credentialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.credentialsTableAdapter = new SportsDataApplication.TMMM.Sign_InDataSetTableAdapters.CredentialsTableAdapter();
            this.tableAdapterManager = new SportsDataApplication.TMMM.Sign_InDataSetTableAdapters.TableAdapterManager();
            this.credentialsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nFL_Upcoming_GamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homeTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFL_Upcoming_GamesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sportsProjectDBDataSet = new SportsDataApplication.TMMM.SportsProjectDBDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBoxMonthSort = new System.Windows.Forms.ComboBox();
            this.btnMonthSort = new System.Windows.Forms.Button();
            this.btnTeamSort = new System.Windows.Forms.Button();
            this.comboBoxTeamSort = new System.Windows.Forms.ComboBox();
            this.nFL_Upcoming_GamesTableAdapter = new SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters.NFL_Upcoming_GamesTableAdapter();
            this.tableAdapterManager1 = new SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters.TableAdapterManager();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.nFL_Match_Results_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFL_Match_Results_DataTableAdapter = new SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters.NFL_Match_Results_DataTableAdapter();
            this.nFL_Match_Results_DataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sign_InDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingNavigator)).BeginInit();
            this.credentialsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Upcoming_GamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Upcoming_GamesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsProjectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Match_Results_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Match_Results_DataDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sign_InDataSet
            // 
            this.sign_InDataSet.DataSetName = "Sign_InDataSet";
            this.sign_InDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // credentialsBindingSource
            // 
            this.credentialsBindingSource.DataMember = "Credentials";
            this.credentialsBindingSource.DataSource = this.sign_InDataSet;
            // 
            // credentialsTableAdapter
            // 
            this.credentialsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CredentialsTableAdapter = this.credentialsTableAdapter;
            this.tableAdapterManager.UpdateOrder = SportsDataApplication.TMMM.Sign_InDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // credentialsBindingNavigator
            // 
            this.credentialsBindingNavigator.AddNewItem = null;
            this.credentialsBindingNavigator.BindingSource = this.credentialsBindingSource;
            this.credentialsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.credentialsBindingNavigator.DeleteItem = null;
            this.credentialsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.credentialsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.credentialsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.credentialsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.credentialsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.credentialsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.credentialsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.credentialsBindingNavigator.Name = "credentialsBindingNavigator";
            this.credentialsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.credentialsBindingNavigator.Size = new System.Drawing.Size(790, 27);
            this.credentialsBindingNavigator.TabIndex = 0;
            this.credentialsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // nFL_Upcoming_GamesBindingSource
            // 
            this.nFL_Upcoming_GamesBindingSource.DataMember = "NFL Upcoming Games";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "NFL - Upcoming Games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NFL - Match Results";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.homeTeamDataGridViewTextBoxColumn,
            this.awayTeamDataGridViewTextBoxColumn,
            this.gameDateDataGridViewTextBoxColumn,
            this.gameTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nFL_Upcoming_GamesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 185);
            this.dataGridView1.TabIndex = 4;
            // 
            // homeTeamDataGridViewTextBoxColumn
            // 
            this.homeTeamDataGridViewTextBoxColumn.DataPropertyName = "Home Team";
            this.homeTeamDataGridViewTextBoxColumn.HeaderText = "Home Team";
            this.homeTeamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homeTeamDataGridViewTextBoxColumn.Name = "homeTeamDataGridViewTextBoxColumn";
            this.homeTeamDataGridViewTextBoxColumn.Width = 125;
            // 
            // awayTeamDataGridViewTextBoxColumn
            // 
            this.awayTeamDataGridViewTextBoxColumn.DataPropertyName = "Away Team";
            this.awayTeamDataGridViewTextBoxColumn.HeaderText = "Away Team";
            this.awayTeamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.awayTeamDataGridViewTextBoxColumn.Name = "awayTeamDataGridViewTextBoxColumn";
            this.awayTeamDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameDateDataGridViewTextBoxColumn
            // 
            this.gameDateDataGridViewTextBoxColumn.DataPropertyName = "Game Date";
            this.gameDateDataGridViewTextBoxColumn.HeaderText = "Game Date";
            this.gameDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameDateDataGridViewTextBoxColumn.Name = "gameDateDataGridViewTextBoxColumn";
            this.gameDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameTimeDataGridViewTextBoxColumn
            // 
            this.gameTimeDataGridViewTextBoxColumn.DataPropertyName = "Game Time";
            this.gameTimeDataGridViewTextBoxColumn.HeaderText = "Game Time";
            this.gameTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameTimeDataGridViewTextBoxColumn.Name = "gameTimeDataGridViewTextBoxColumn";
            this.gameTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nFL_Upcoming_GamesBindingSource1
            // 
            this.nFL_Upcoming_GamesBindingSource1.DataMember = "NFL Upcoming Games";
            this.nFL_Upcoming_GamesBindingSource1.DataSource = this.sportsProjectDBDataSet;
            // 
            // sportsProjectDBDataSet
            // 
            this.sportsProjectDBDataSet.DataSetName = "SportsProjectDBDataSet";
            this.sportsProjectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(668, 672);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 35);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBoxMonthSort
            // 
            this.comboBoxMonthSort.FormattingEnabled = true;
            this.comboBoxMonthSort.Location = new System.Drawing.Point(26, 98);
            this.comboBoxMonthSort.Name = "comboBoxMonthSort";
            this.comboBoxMonthSort.Size = new System.Drawing.Size(235, 24);
            this.comboBoxMonthSort.TabIndex = 6;
            // 
            // btnMonthSort
            // 
            this.btnMonthSort.Location = new System.Drawing.Point(267, 92);
            this.btnMonthSort.Name = "btnMonthSort";
            this.btnMonthSort.Size = new System.Drawing.Size(114, 35);
            this.btnMonthSort.TabIndex = 7;
            this.btnMonthSort.Text = "Sort by &Month";
            this.btnMonthSort.UseVisualStyleBackColor = true;
            this.btnMonthSort.Click += new System.EventHandler(this.btnMonthSort_Click);
            // 
            // btnTeamSort
            // 
            this.btnTeamSort.Location = new System.Drawing.Point(648, 92);
            this.btnTeamSort.Name = "btnTeamSort";
            this.btnTeamSort.Size = new System.Drawing.Size(112, 35);
            this.btnTeamSort.TabIndex = 9;
            this.btnTeamSort.Text = "Sort by &Team";
            this.btnTeamSort.UseVisualStyleBackColor = true;
            this.btnTeamSort.Click += new System.EventHandler(this.btnTeamSort_Click);
            // 
            // comboBoxTeamSort
            // 
            this.comboBoxTeamSort.FormattingEnabled = true;
            this.comboBoxTeamSort.Location = new System.Drawing.Point(407, 98);
            this.comboBoxTeamSort.Name = "comboBoxTeamSort";
            this.comboBoxTeamSort.Size = new System.Drawing.Size(235, 24);
            this.comboBoxTeamSort.TabIndex = 8;
            // 
            // nFL_Upcoming_GamesTableAdapter
            // 
            this.nFL_Upcoming_GamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Defense_Stats_Normal_SeasonTableAdapter = null;
            this.tableAdapterManager1.Defense_Stats_PlayoffsTableAdapter = null;
            this.tableAdapterManager1.Kick_Punt_PlayoffsTableAdapter = null;
            this.tableAdapterManager1.Kick_Punt_StatsTableAdapter = null;
            this.tableAdapterManager1.Kickoff_Normal_SeasonTableAdapter = null;
            this.tableAdapterManager1.Kickoff_Stats_PlayoffsTableAdapter = null;
            this.tableAdapterManager1.NBA_Eastern_Conference_24_25TableAdapter = null;
            this.tableAdapterManager1.NBA_Eastern_Conference_25_26TableAdapter = null;
            this.tableAdapterManager1.NBA_Match_Results_DataTableAdapter = null;
            this.tableAdapterManager1.nba_playerstats_2024TableAdapter = null;
            this.tableAdapterManager1.NBA_Upcoming_GamesTableAdapter = null;
            this.tableAdapterManager1.NBA_Western_Conference_24_25TableAdapter = null;
            this.tableAdapterManager1.NBA_Western_Conference_25_26TableAdapter = null;
            this.tableAdapterManager1.NFL_AFC_EAST_25TableAdapter = null;
            this.tableAdapterManager1.NFL_AFC_NORTH_25TableAdapter = null;
            this.tableAdapterManager1.NFL_AFC_SOUTH_25TableAdapter = null;
            this.tableAdapterManager1.NFL_AFC_WEST_25TableAdapter = null;
            this.tableAdapterManager1.NFL_Match_Results_DataTableAdapter = null;
            this.tableAdapterManager1.NFL_NFC_EAST_25TableAdapter = null;
            this.tableAdapterManager1.NFL_NFC_NORTH_25TableAdapter = null;
            this.tableAdapterManager1.NFL_NFC_SOUTH_25TableAdapter = null;
            this.tableAdapterManager1.NFL_NFC_WEST_25TableAdapter = null;
            this.tableAdapterManager1.NFL_Upcoming_GamesTableAdapter = this.nFL_Upcoming_GamesTableAdapter;
            this.tableAdapterManager1.Passing_stats_PlayoffTableAdapter = null;
            this.tableAdapterManager1.Passing_statsTableAdapter = null;
            this.tableAdapterManager1.PlayerStatistics_ImportErrorsTableAdapter = null;
            this.tableAdapterManager1.Punting_stats_PlayoffTableAdapter = null;
            this.tableAdapterManager1.Punting_statsTableAdapter = null;
            this.tableAdapterManager1.Receiving_statsTableAdapter = null;
            this.tableAdapterManager1.Recieving_stats_PlayoffsTableAdapter = null;
            this.tableAdapterManager1.Rushing_stats_PlayoffTableAdapter = null;
            this.tableAdapterManager1.Rushing_statsTableAdapter = null;
            this.tableAdapterManager1.Scoring_stats_PlayoffsTableAdapter = null;
            this.tableAdapterManager1.Scoring_StatsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearch.Location = new System.Drawing.Point(25, 389);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(236, 22);
            this.txtBoxSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(267, 385);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 31);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Help (?)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sort by &Team";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(407, 389);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(235, 24);
            this.comboBox4.TabIndex = 20;
            // 
            // nFL_Match_Results_DataBindingSource
            // 
            this.nFL_Match_Results_DataBindingSource.DataMember = "NFL Match Results Data";
            this.nFL_Match_Results_DataBindingSource.DataSource = this.sportsProjectDBDataSet;
            // 
            // nFL_Match_Results_DataTableAdapter
            // 
            this.nFL_Match_Results_DataTableAdapter.ClearBeforeFill = true;
            // 
            // nFL_Match_Results_DataDataGridView
            // 
            this.nFL_Match_Results_DataDataGridView.AutoGenerateColumns = false;
            this.nFL_Match_Results_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nFL_Match_Results_DataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.nFL_Match_Results_DataDataGridView.DataSource = this.nFL_Match_Results_DataBindingSource;
            this.nFL_Match_Results_DataDataGridView.Location = new System.Drawing.Point(26, 422);
            this.nFL_Match_Results_DataDataGridView.Name = "nFL_Match_Results_DataDataGridView";
            this.nFL_Match_Results_DataDataGridView.RowHeadersWidth = 51;
            this.nFL_Match_Results_DataDataGridView.RowTemplate.Height = 24;
            this.nFL_Match_Results_DataDataGridView.Size = new System.Drawing.Size(734, 220);
            this.nFL_Match_Results_DataDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "rowID";
            this.dataGridViewTextBoxColumn1.HeaderText = "rowID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "score";
            this.dataGridViewTextBoxColumn2.HeaderText = "score";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ptsWinningTeam";
            this.dataGridViewTextBoxColumn3.HeaderText = "ptsWinningTeam";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ptsLosingTeam";
            this.dataGridViewTextBoxColumn4.HeaderText = "ptsLosingTeam";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "totalPointsScored";
            this.dataGridViewTextBoxColumn5.HeaderText = "totalPointsScored";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pointsDifferential";
            this.dataGridViewTextBoxColumn6.HeaderText = "pointsDifferential";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn7.HeaderText = "count";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "matchDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "matchDate";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "teamVS";
            this.dataGridViewTextBoxColumn9.HeaderText = "teamVS";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // NFL_UpcomingGames_MatchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 728);
            this.Controls.Add(this.nFL_Match_Results_DataDataGridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxTeamSort);
            this.Controls.Add(this.btnMonthSort);
            this.Controls.Add(this.btnTeamSort);
            this.Controls.Add(this.comboBoxMonthSort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.credentialsBindingNavigator);
            this.Name = "NFL_UpcomingGames_MatchResults";
            this.Text = "NFL - Upcoming Games / Match Results";
            this.Load += new System.EventHandler(this.NFLUpcomingGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sign_InDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingNavigator)).EndInit();
            this.credentialsBindingNavigator.ResumeLayout(false);
            this.credentialsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Upcoming_GamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Upcoming_GamesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsProjectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Match_Results_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Match_Results_DataDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sign_InDataSet sign_InDataSet;
        private System.Windows.Forms.BindingSource credentialsBindingSource;
        private Sign_InDataSetTableAdapters.CredentialsTableAdapter credentialsTableAdapter;
        private Sign_InDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator credentialsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource nFL_Upcoming_GamesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboBoxMonthSort;
        private System.Windows.Forms.Button btnMonthSort;
        private System.Windows.Forms.Button btnTeamSort;
        private System.Windows.Forms.ComboBox comboBoxTeamSort;
        private SportsProjectDBDataSet sportsProjectDBDataSet;
        private System.Windows.Forms.BindingSource nFL_Upcoming_GamesBindingSource1;
        private SportsProjectDBDataSetTableAdapters.NFL_Upcoming_GamesTableAdapter nFL_Upcoming_GamesTableAdapter;
        private SportsProjectDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource nFL_Match_Results_DataBindingSource;
        private SportsProjectDBDataSetTableAdapters.NFL_Match_Results_DataTableAdapter nFL_Match_Results_DataTableAdapter;
        private System.Windows.Forms.DataGridView nFL_Match_Results_DataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}