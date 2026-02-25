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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.credentialsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.group_Project_1_Sports_DatabaseDataSet = new SportsDataApplication.TMMM.Group_Project_1_Sports_DatabaseDataSet();
            this.nFL_Upcoming_GamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFL_Upcoming_GamesTableAdapter = new SportsDataApplication.TMMM.Group_Project_1_Sports_DatabaseDataSetTableAdapters.NFL_Upcoming_GamesTableAdapter();
            this.tableAdapterManager1 = new SportsDataApplication.TMMM.Group_Project_1_Sports_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.nFL_Upcoming_GamesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sign_InDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingNavigator)).BeginInit();
            this.credentialsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_Project_1_Sports_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Upcoming_GamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Upcoming_GamesDataGridView)).BeginInit();
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
            this.credentialsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.credentialsBindingNavigator.BindingSource = this.credentialsBindingSource;
            this.credentialsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.credentialsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.credentialsBindingNavigatorSaveItem});
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // credentialsBindingNavigatorSaveItem
            // 
            this.credentialsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.credentialsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("credentialsBindingNavigatorSaveItem.Image")));
            this.credentialsBindingNavigatorSaveItem.Name = "credentialsBindingNavigatorSaveItem";
            this.credentialsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.credentialsBindingNavigatorSaveItem.Text = "Save Data";
            this.credentialsBindingNavigatorSaveItem.Click += new System.EventHandler(this.credentialsBindingNavigatorSaveItem_Click);
            // 
            // group_Project_1_Sports_DatabaseDataSet
            // 
            this.group_Project_1_Sports_DatabaseDataSet.DataSetName = "Group_Project_1_Sports_DatabaseDataSet";
            this.group_Project_1_Sports_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nFL_Upcoming_GamesBindingSource
            // 
            this.nFL_Upcoming_GamesBindingSource.DataMember = "NFL Upcoming Games";
            this.nFL_Upcoming_GamesBindingSource.DataSource = this.group_Project_1_Sports_DatabaseDataSet;
            // 
            // nFL_Upcoming_GamesTableAdapter
            // 
            this.nFL_Upcoming_GamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.NFL_Upcoming_GamesTableAdapter = this.nFL_Upcoming_GamesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = SportsDataApplication.TMMM.Group_Project_1_Sports_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nFL_Upcoming_GamesDataGridView
            // 
            this.nFL_Upcoming_GamesDataGridView.AutoGenerateColumns = false;
            this.nFL_Upcoming_GamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nFL_Upcoming_GamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nFL_Upcoming_GamesDataGridView.DataSource = this.nFL_Upcoming_GamesBindingSource;
            this.nFL_Upcoming_GamesDataGridView.Location = new System.Drawing.Point(12, 341);
            this.nFL_Upcoming_GamesDataGridView.Name = "nFL_Upcoming_GamesDataGridView";
            this.nFL_Upcoming_GamesDataGridView.RowHeadersWidth = 51;
            this.nFL_Upcoming_GamesDataGridView.RowTemplate.Height = 24;
            this.nFL_Upcoming_GamesDataGridView.Size = new System.Drawing.Size(557, 220);
            this.nFL_Upcoming_GamesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Home Team";
            this.dataGridViewTextBoxColumn1.HeaderText = "Home Team";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Away Team";
            this.dataGridViewTextBoxColumn2.HeaderText = "Away Team";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Game Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Game Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Game Time";
            this.dataGridViewTextBoxColumn4.HeaderText = "Game Time";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "NFL - Upcoming Games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NFL - Match Results";
            // 
            // NFL_UpcomingGames_MatchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nFL_Upcoming_GamesDataGridView);
            this.Controls.Add(this.credentialsBindingNavigator);
            this.Name = "NFL_UpcomingGames_MatchResults";
            this.Text = "NFLUpcomingGames";
            this.Load += new System.EventHandler(this.NFLUpcomingGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sign_InDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingNavigator)).EndInit();
            this.credentialsBindingNavigator.ResumeLayout(false);
            this.credentialsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_Project_1_Sports_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Upcoming_GamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_Upcoming_GamesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sign_InDataSet sign_InDataSet;
        private System.Windows.Forms.BindingSource credentialsBindingSource;
        private Sign_InDataSetTableAdapters.CredentialsTableAdapter credentialsTableAdapter;
        private Sign_InDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator credentialsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton credentialsBindingNavigatorSaveItem;
        private Group_Project_1_Sports_DatabaseDataSet group_Project_1_Sports_DatabaseDataSet;
        private System.Windows.Forms.BindingSource nFL_Upcoming_GamesBindingSource;
        private Group_Project_1_Sports_DatabaseDataSetTableAdapters.NFL_Upcoming_GamesTableAdapter nFL_Upcoming_GamesTableAdapter;
        private Group_Project_1_Sports_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView nFL_Upcoming_GamesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}