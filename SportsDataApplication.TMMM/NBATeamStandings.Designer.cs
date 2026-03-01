namespace SportsDataApplication.TMMM
{
    partial class NBATeamStandings
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBoxKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbConfDiv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(529, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NBA Team Standings Data";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(410, 379);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 25);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtBoxKeyword
            // 
            this.txtBoxKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxKeyword.Location = new System.Drawing.Point(4, 25);
            this.txtBoxKeyword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxKeyword.Name = "txtBoxKeyword";
            this.txtBoxKeyword.Size = new System.Drawing.Size(141, 20);
            this.txtBoxKeyword.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(149, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshData);
            this.groupBox1.Controls.Add(this.txtBoxKeyword);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(11, 268);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(232, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search This Data";
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Location = new System.Drawing.Point(11, 50);
            this.btnRefreshData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(81, 25);
            this.btnRefreshData.TabIndex = 6;
            this.btnRefreshData.Text = "Re&fresh Data";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(9, 379);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(70, 25);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "&Help (?)";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(492, 379);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbConfDiv);
            this.groupBox2.Location = new System.Drawing.Point(248, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 90);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(222, 52);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conference/ Divison:";
            // 
            // cbConfDiv
            // 
            this.cbConfDiv.FormattingEnabled = true;
            this.cbConfDiv.Items.AddRange(new object[] {
            "NFL AFC East",
            "NFL AFC West",
            "NFL AFC South",
            "NFL AFC North",
            "NFL NFC East",
            "NFL NFC West",
            "NFL NFC South",
            "NFL NFC North"});
            this.cbConfDiv.Location = new System.Drawing.Point(119, 25);
            this.cbConfDiv.Name = "cbConfDiv";
            this.cbConfDiv.Size = new System.Drawing.Size(198, 21);
            this.cbConfDiv.TabIndex = 0;
            // 
            // NBATeamStandings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NBATeamStandings";
            this.Text = "NBA Team Standings - Sports Data Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBoxKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbConfDiv;
    }
}