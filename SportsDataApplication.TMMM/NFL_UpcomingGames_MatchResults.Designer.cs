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
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBoxMonthSort = new System.Windows.Forms.ComboBox();
            this.btnMonthSort = new System.Windows.Forms.Button();
            this.btnTeamSort = new System.Windows.Forms.Button();
            this.comboBoxTeamSort = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sign_InDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingNavigator)).BeginInit();
            this.credentialsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Upcoming_GamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.credentialsBindingNavigator.Size = new System.Drawing.Size(812, 27);
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
            // group_Project_1_Sports_DatabaseDataSet
            // 
            // 
            // nFL_Upcoming_GamesBindingSource
            // 
            this.nFL_Upcoming_GamesBindingSource.DataMember = "NFL Upcoming Games";
            // 
            // nFL_Upcoming_GamesTableAdapter
            // 
            // 
            // tableAdapterManager1
            // 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "NFL - Upcoming Games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "NFL - Match Results";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 185);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(708, 596);
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
            this.comboBoxMonthSort.Location = new System.Drawing.Point(26, 562);
            this.comboBoxMonthSort.Name = "comboBoxMonthSort";
            this.comboBoxMonthSort.Size = new System.Drawing.Size(235, 24);
            this.comboBoxMonthSort.TabIndex = 6;
            // 
            // btnMonthSort
            // 
            this.btnMonthSort.Location = new System.Drawing.Point(91, 592);
            this.btnMonthSort.Name = "btnMonthSort";
            this.btnMonthSort.Size = new System.Drawing.Size(114, 35);
            this.btnMonthSort.TabIndex = 7;
            this.btnMonthSort.Text = "Sort by &Month";
            this.btnMonthSort.UseVisualStyleBackColor = true;
            // 
            // btnTeamSort
            // 
            this.btnTeamSort.Location = new System.Drawing.Point(374, 592);
            this.btnTeamSort.Name = "btnTeamSort";
            this.btnTeamSort.Size = new System.Drawing.Size(112, 35);
            this.btnTeamSort.TabIndex = 9;
            this.btnTeamSort.Text = "Sort by &Team";
            this.btnTeamSort.UseVisualStyleBackColor = true;
            // 
            // comboBoxTeamSort
            // 
            this.comboBoxTeamSort.FormattingEnabled = true;
            this.comboBoxTeamSort.Location = new System.Drawing.Point(305, 562);
            this.comboBoxTeamSort.Name = "comboBoxTeamSort";
            this.comboBoxTeamSort.Size = new System.Drawing.Size(235, 24);
            this.comboBoxTeamSort.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 321);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(734, 209);
            this.dataGridView2.TabIndex = 10;
            // 
            // NFL_UpcomingGames_MatchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 643);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnTeamSort);
            this.Controls.Add(this.comboBoxTeamSort);
            this.Controls.Add(this.btnMonthSort);
            this.Controls.Add(this.comboBoxMonthSort);
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
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}