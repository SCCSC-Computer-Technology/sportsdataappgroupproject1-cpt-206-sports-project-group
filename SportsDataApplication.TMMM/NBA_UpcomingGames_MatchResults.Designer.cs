namespace SportsDataApplication.TMMM
{
    partial class NBA_UpcomingGames_MatchResults
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homeTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBA_Upcoming_GamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsProjectDBDataSet = new SportsDataApplication.TMMM.SportsProjectDBDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTeamSort = new System.Windows.Forms.Button();
            this.comboBoxTeamSort = new System.Windows.Forms.ComboBox();
            this.btnMonthSort = new System.Windows.Forms.Button();
            this.comboBoxMonthSort = new System.Windows.Forms.ComboBox();
            this.nBA_Match_Results_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nBA_Match_Results_DataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBA_Match_Results_DataTableAdapter = new SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters.NBA_Match_Results_DataTableAdapter();
            this.tableAdapterManager = new SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters.TableAdapterManager();
            this.nBA_Upcoming_GamesTableAdapter = new SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters.NBA_Upcoming_GamesTableAdapter();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.comBoxSelectColumn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.toolTipNBAUpcomingAndMatch = new System.Windows.Forms.ToolTip(this.components);
            this.btnFavorite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Upcoming_GamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsProjectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Match_Results_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Match_Results_DataDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "NBA - Upcoming Games";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "NBA - Match Results";
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
            this.dataGridView1.DataSource = this.nBA_Upcoming_GamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 118);
            this.dataGridView1.TabIndex = 6;
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
            // nBA_Upcoming_GamesBindingSource
            // 
            this.nBA_Upcoming_GamesBindingSource.DataMember = "NBA Upcoming Games";
            this.nBA_Upcoming_GamesBindingSource.DataSource = this.sportsProjectDBDataSet;
            // 
            // sportsProjectDBDataSet
            // 
            this.sportsProjectDBDataSet.DataSetName = "SportsProjectDBDataSet";
            this.sportsProjectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(500, 547);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 28);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "&Back";
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.btnBack, "Goes back to the choose database form");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTeamSort
            // 
            this.btnTeamSort.Location = new System.Drawing.Point(486, 41);
            this.btnTeamSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnTeamSort.Name = "btnTeamSort";
            this.btnTeamSort.Size = new System.Drawing.Size(84, 28);
            this.btnTeamSort.TabIndex = 13;
            this.btnTeamSort.Text = "Sort by &Team";
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.btnTeamSort, "Sorts by selected team");
            this.btnTeamSort.UseVisualStyleBackColor = true;
            this.btnTeamSort.Click += new System.EventHandler(this.btnTeamSort_Click);
            // 
            // comboBoxTeamSort
            // 
            this.comboBoxTeamSort.FormattingEnabled = true;
            this.comboBoxTeamSort.Location = new System.Drawing.Point(305, 49);
            this.comboBoxTeamSort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTeamSort.Name = "comboBoxTeamSort";
            this.comboBoxTeamSort.Size = new System.Drawing.Size(177, 21);
            this.comboBoxTeamSort.TabIndex = 12;
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.comboBoxTeamSort, "Select team");
            // 
            // btnMonthSort
            // 
            this.btnMonthSort.Location = new System.Drawing.Point(197, 44);
            this.btnMonthSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonthSort.Name = "btnMonthSort";
            this.btnMonthSort.Size = new System.Drawing.Size(86, 28);
            this.btnMonthSort.TabIndex = 11;
            this.btnMonthSort.Text = "Sort by &Month";
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.btnMonthSort, "Sorts by selecte month");
            this.btnMonthSort.UseVisualStyleBackColor = true;
            this.btnMonthSort.Click += new System.EventHandler(this.btnMonthSort_Click);
            // 
            // comboBoxMonthSort
            // 
            this.comboBoxMonthSort.FormattingEnabled = true;
            this.comboBoxMonthSort.Location = new System.Drawing.Point(16, 52);
            this.comboBoxMonthSort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMonthSort.Name = "comboBoxMonthSort";
            this.comboBoxMonthSort.Size = new System.Drawing.Size(177, 21);
            this.comboBoxMonthSort.TabIndex = 10;
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.comboBoxMonthSort, "Select a month");
            // 
            // nBA_Match_Results_DataBindingSource
            // 
            this.nBA_Match_Results_DataBindingSource.DataMember = "NBA Match Results Data";
            this.nBA_Match_Results_DataBindingSource.DataSource = this.sportsProjectDBDataSet;
            // 
            // nBA_Match_Results_DataDataGridView
            // 
            this.nBA_Match_Results_DataDataGridView.AutoGenerateColumns = false;
            this.nBA_Match_Results_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nBA_Match_Results_DataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.nBA_Match_Results_DataDataGridView.DataSource = this.nBA_Match_Results_DataBindingSource;
            this.nBA_Match_Results_DataDataGridView.Location = new System.Drawing.Point(16, 240);
            this.nBA_Match_Results_DataDataGridView.Name = "nBA_Match_Results_DataDataGridView";
            this.nBA_Match_Results_DataDataGridView.RowHeadersWidth = 51;
            this.nBA_Match_Results_DataDataGridView.Size = new System.Drawing.Size(554, 220);
            this.nBA_Match_Results_DataDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "gameId";
            this.dataGridViewTextBoxColumn1.HeaderText = "gameId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "gameDateTimeEst";
            this.dataGridViewTextBoxColumn2.HeaderText = "gameDateTimeEst";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "hometeamName";
            this.dataGridViewTextBoxColumn3.HeaderText = "hometeamName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "awayteamName";
            this.dataGridViewTextBoxColumn4.HeaderText = "awayteamName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "homeScore";
            this.dataGridViewTextBoxColumn5.HeaderText = "homeScore";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "awayScore";
            this.dataGridViewTextBoxColumn6.HeaderText = "awayScore";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "winner";
            this.dataGridViewTextBoxColumn7.HeaderText = "winner";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "attendance";
            this.dataGridViewTextBoxColumn8.HeaderText = "attendance";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "arenaName";
            this.dataGridViewTextBoxColumn9.HeaderText = "arenaName";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "arenaCity";
            this.dataGridViewTextBoxColumn10.HeaderText = "arenaCity";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "arenaState";
            this.dataGridViewTextBoxColumn11.HeaderText = "arenaState";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "officials";
            this.dataGridViewTextBoxColumn12.HeaderText = "officials";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // nBA_Match_Results_DataTableAdapter
            // 
            this.nBA_Match_Results_DataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Defense_Stats_Normal_SeasonTableAdapter = null;
            this.tableAdapterManager.Defense_Stats_PlayoffsTableAdapter = null;
            this.tableAdapterManager.Kick_Punt_PlayoffsTableAdapter = null;
            this.tableAdapterManager.Kick_Punt_StatsTableAdapter = null;
            this.tableAdapterManager.Kickoff_Normal_SeasonTableAdapter = null;
            this.tableAdapterManager.Kickoff_Stats_PlayoffsTableAdapter = null;
            this.tableAdapterManager.NBA_Eastern_Conference_24_25TableAdapter = null;
            this.tableAdapterManager.NBA_Eastern_Conference_25_26TableAdapter = null;
            this.tableAdapterManager.NBA_Match_Results_DataTableAdapter = this.nBA_Match_Results_DataTableAdapter;
            this.tableAdapterManager.nba_playerstats_2024TableAdapter = null;
            this.tableAdapterManager.NBA_Upcoming_GamesTableAdapter = null;
            this.tableAdapterManager.NBA_Western_Conference_24_25TableAdapter = null;
            this.tableAdapterManager.NBA_Western_Conference_25_26TableAdapter = null;
            this.tableAdapterManager.NFL_AFC_EAST_25TableAdapter = null;
            this.tableAdapterManager.NFL_AFC_NORTH_25TableAdapter = null;
            this.tableAdapterManager.NFL_AFC_SOUTH_25TableAdapter = null;
            this.tableAdapterManager.NFL_AFC_WEST_25TableAdapter = null;
            this.tableAdapterManager.NFL_Match_Results_DataTableAdapter = null;
            this.tableAdapterManager.NFL_NFC_EAST_25TableAdapter = null;
            this.tableAdapterManager.NFL_NFC_NORTH_25TableAdapter = null;
            this.tableAdapterManager.NFL_NFC_SOUTH_25TableAdapter = null;
            this.tableAdapterManager.NFL_NFC_WEST_25TableAdapter = null;
            this.tableAdapterManager.NFL_Upcoming_GamesTableAdapter = null;
            this.tableAdapterManager.Passing_stats_PlayoffTableAdapter = null;
            this.tableAdapterManager.Passing_statsTableAdapter = null;
            this.tableAdapterManager.PlayerStatistics_ImportErrorsTableAdapter = null;
            this.tableAdapterManager.Punting_stats_PlayoffTableAdapter = null;
            this.tableAdapterManager.Punting_statsTableAdapter = null;
            this.tableAdapterManager.Receiving_statsTableAdapter = null;
            this.tableAdapterManager.Recieving_stats_PlayoffsTableAdapter = null;
            this.tableAdapterManager.Rushing_stats_PlayoffTableAdapter = null;
            this.tableAdapterManager.Rushing_statsTableAdapter = null;
            this.tableAdapterManager.Scoring_stats_PlayoffsTableAdapter = null;
            this.tableAdapterManager.Scoring_StatsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nBA_Upcoming_GamesTableAdapter
            // 
            this.nBA_Upcoming_GamesTableAdapter.ClearBeforeFill = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(17, 547);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.Text = "Help (?)";
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.btnHelp, "Opens the help form");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(368, 19);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 24);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "&Search";
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.btnSearch, "Press to search based on selected criteria");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearch.Location = new System.Drawing.Point(183, 23);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(172, 20);
            this.txtBoxSearch.TabIndex = 17;
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.txtBoxSearch, "Enter search criteria");
            // 
            // comBoxSelectColumn
            // 
            this.comBoxSelectColumn.FormattingEnabled = true;
            this.comBoxSelectColumn.Location = new System.Drawing.Point(8, 22);
            this.comBoxSelectColumn.Margin = new System.Windows.Forms.Padding(2);
            this.comBoxSelectColumn.Name = "comBoxSelectColumn";
            this.comBoxSelectColumn.Size = new System.Drawing.Size(171, 21);
            this.comBoxSelectColumn.TabIndex = 18;
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.comBoxSelectColumn, "Select search method");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshTable);
            this.groupBox1.Controls.Add(this.txtBoxSearch);
            this.groupBox1.Controls.Add(this.comBoxSelectColumn);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(17, 466);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(542, 58);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Match Results";
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(440, 19);
            this.btnRefreshTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(84, 24);
            this.btnRefreshTable.TabIndex = 19;
            this.btnRefreshTable.Text = "Refresh Table";
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.btnRefreshTable, "Refreshes the table");
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Location = new System.Drawing.Point(93, 547);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(75, 23);
            this.btnFavorite.TabIndex = 20;
            this.btnFavorite.Text = "&Favorite";
            this.toolTipNBAUpcomingAndMatch.SetToolTip(this.btnFavorite, "Displays favorite team in upcoming matches and match results");
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // NBA_UpcomingGames_MatchResults
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(586, 588);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.nBA_Match_Results_DataDataGridView);
            this.Controls.Add(this.btnTeamSort);
            this.Controls.Add(this.comboBoxTeamSort);
            this.Controls.Add(this.btnMonthSort);
            this.Controls.Add(this.comboBoxMonthSort);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NBA_UpcomingGames_MatchResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA - Upcoming Games / Match Results";
            this.Load += new System.EventHandler(this.NBAUpcomingGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Upcoming_GamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsProjectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Match_Results_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Match_Results_DataDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTeamSort;
        private System.Windows.Forms.ComboBox comboBoxTeamSort;
        private System.Windows.Forms.Button btnMonthSort;
        private System.Windows.Forms.ComboBox comboBoxMonthSort;
        private SportsProjectDBDataSet sportsProjectDBDataSet;
        private System.Windows.Forms.BindingSource nBA_Match_Results_DataBindingSource;
        private SportsProjectDBDataSetTableAdapters.NBA_Match_Results_DataTableAdapter nBA_Match_Results_DataTableAdapter;
        private SportsProjectDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nBA_Match_Results_DataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource nBA_Upcoming_GamesBindingSource;
        private SportsProjectDBDataSetTableAdapters.NBA_Upcoming_GamesTableAdapter nBA_Upcoming_GamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.ComboBox comBoxSelectColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.ToolTip toolTipNBAUpcomingAndMatch;
        private System.Windows.Forms.Button btnFavorite;
    }
}