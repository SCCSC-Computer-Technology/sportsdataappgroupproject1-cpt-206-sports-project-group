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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTeamSort = new System.Windows.Forms.Button();
            this.comboBoxTeamSort = new System.Windows.Forms.ComboBox();
            this.btnMonthSort = new System.Windows.Forms.Button();
            this.comboBoxMonthSort = new System.Windows.Forms.ComboBox();
            this.nBA_Match_Results_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nBA_Match_Results_DataTableAdapter = new SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters.NBA_Match_Results_DataTableAdapter();
            this.tableAdapterManager = new SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters.TableAdapterManager();
            this.sportsProjectDBDataSet = new SportsDataApplication.TMMM.SportsProjectDBDataSet();
            this.nBA_Match_Results_DataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Match_Results_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsProjectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Match_Results_DataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Match_Results_DataDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "NBA - Upcoming Games";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "NBA - Match Results";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(663, 145);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(662, 572);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTeamSort
            // 
            this.btnTeamSort.Location = new System.Drawing.Point(398, 566);
            this.btnTeamSort.Name = "btnTeamSort";
            this.btnTeamSort.Size = new System.Drawing.Size(112, 35);
            this.btnTeamSort.TabIndex = 13;
            this.btnTeamSort.Text = "Sort by &Team";
            this.btnTeamSort.UseVisualStyleBackColor = true;
            // 
            // comboBoxTeamSort
            // 
            this.comboBoxTeamSort.FormattingEnabled = true;
            this.comboBoxTeamSort.Location = new System.Drawing.Point(329, 536);
            this.comboBoxTeamSort.Name = "comboBoxTeamSort";
            this.comboBoxTeamSort.Size = new System.Drawing.Size(235, 24);
            this.comboBoxTeamSort.TabIndex = 12;
            // 
            // btnMonthSort
            // 
            this.btnMonthSort.Location = new System.Drawing.Point(115, 566);
            this.btnMonthSort.Name = "btnMonthSort";
            this.btnMonthSort.Size = new System.Drawing.Size(114, 35);
            this.btnMonthSort.TabIndex = 11;
            this.btnMonthSort.Text = "Sort by &Month";
            this.btnMonthSort.UseVisualStyleBackColor = true;
            // 
            // comboBoxMonthSort
            // 
            this.comboBoxMonthSort.FormattingEnabled = true;
            this.comboBoxMonthSort.Location = new System.Drawing.Point(50, 536);
            this.comboBoxMonthSort.Name = "comboBoxMonthSort";
            this.comboBoxMonthSort.Size = new System.Drawing.Size(235, 24);
            this.comboBoxMonthSort.TabIndex = 10;
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
            // sportsProjectDBDataSet
            // 
            this.sportsProjectDBDataSet.DataSetName = "SportsProjectDBDataSet";
            this.sportsProjectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBA_Match_Results_DataBindingSource1
            // 
            this.nBA_Match_Results_DataBindingSource1.DataMember = "NBA Match Results Data";
            this.nBA_Match_Results_DataBindingSource1.DataSource = this.sportsProjectDBDataSet;
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
            this.nBA_Match_Results_DataDataGridView.DataSource = this.nBA_Match_Results_DataBindingSource1;
            this.nBA_Match_Results_DataDataGridView.Location = new System.Drawing.Point(50, 299);
            this.nBA_Match_Results_DataDataGridView.Name = "nBA_Match_Results_DataDataGridView";
            this.nBA_Match_Results_DataDataGridView.RowHeadersWidth = 51;
            this.nBA_Match_Results_DataDataGridView.RowTemplate.Height = 24;
            this.nBA_Match_Results_DataDataGridView.Size = new System.Drawing.Size(680, 220);
            this.nBA_Match_Results_DataDataGridView.TabIndex = 13;
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
            // NBA_UpcomingGames_MatchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 639);
            this.Controls.Add(this.nBA_Match_Results_DataDataGridView);
            this.Controls.Add(this.btnTeamSort);
            this.Controls.Add(this.comboBoxTeamSort);
            this.Controls.Add(this.btnMonthSort);
            this.Controls.Add(this.comboBoxMonthSort);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "NBA_UpcomingGames_MatchResults";
            this.Text = "NBA - Upcoming Games / Match Results";
            this.Load += new System.EventHandler(this.NBAUpcomingGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Match_Results_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsProjectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Match_Results_DataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBA_Match_Results_DataDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource nBA_Match_Results_DataBindingSource;
        private SportsProjectDBDataSetTableAdapters.NBA_Match_Results_DataTableAdapter nBA_Match_Results_DataTableAdapter;
        private SportsProjectDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SportsProjectDBDataSet sportsProjectDBDataSet;
        private System.Windows.Forms.BindingSource nBA_Match_Results_DataBindingSource1;
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
    }
}