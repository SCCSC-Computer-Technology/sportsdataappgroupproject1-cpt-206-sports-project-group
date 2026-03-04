namespace SportsDataApplication.TMMM
{
    partial class Favorites
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxFavNFLTeam = new System.Windows.Forms.TextBox();
            this.txtBoxFavNBATeam = new System.Windows.Forms.TextBox();
            this.txtBoxFavNFLPlayer = new System.Windows.Forms.TextBox();
            this.txtBoxFavNBAPlayer = new System.Windows.Forms.TextBox();
            this.toolTipFavoritesForm = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(323, 415);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 57);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save Favorites";
            this.toolTipFavoritesForm.SetToolTip(this.btnSave, "Press to save favorites");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(447, 415);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 57);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Back";
            this.toolTipFavoritesForm.SetToolTip(this.btnBack, "Takes you back to choose database form");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "NFL Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "NFL Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(696, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "NBA Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "NBA Player";
            // 
            // txtBoxFavNFLTeam
            // 
            this.txtBoxFavNFLTeam.Location = new System.Drawing.Point(168, 87);
            this.txtBoxFavNFLTeam.Name = "txtBoxFavNFLTeam";
            this.txtBoxFavNFLTeam.Size = new System.Drawing.Size(100, 26);
            this.txtBoxFavNFLTeam.TabIndex = 6;
            this.toolTipFavoritesForm.SetToolTip(this.txtBoxFavNFLTeam, "Enter favorite NFL Team");
            // 
            // txtBoxFavNBATeam
            // 
            this.txtBoxFavNBATeam.Location = new System.Drawing.Point(700, 87);
            this.txtBoxFavNBATeam.Name = "txtBoxFavNBATeam";
            this.txtBoxFavNBATeam.Size = new System.Drawing.Size(100, 26);
            this.txtBoxFavNBATeam.TabIndex = 7;
            this.toolTipFavoritesForm.SetToolTip(this.txtBoxFavNBATeam, "Enter Favorite NBA team");
            // 
            // txtBoxFavNFLPlayer
            // 
            this.txtBoxFavNFLPlayer.Location = new System.Drawing.Point(168, 248);
            this.txtBoxFavNFLPlayer.Name = "txtBoxFavNFLPlayer";
            this.txtBoxFavNFLPlayer.Size = new System.Drawing.Size(100, 26);
            this.txtBoxFavNFLPlayer.TabIndex = 8;
            this.toolTipFavoritesForm.SetToolTip(this.txtBoxFavNFLPlayer, "Enter favorite NFL PLayer");
            // 
            // txtBoxFavNBAPlayer
            // 
            this.txtBoxFavNBAPlayer.Location = new System.Drawing.Point(700, 248);
            this.txtBoxFavNBAPlayer.Name = "txtBoxFavNBAPlayer";
            this.txtBoxFavNBAPlayer.Size = new System.Drawing.Size(100, 26);
            this.txtBoxFavNBAPlayer.TabIndex = 9;
            this.toolTipFavoritesForm.SetToolTip(this.txtBoxFavNBAPlayer, "Enter favorite NBA Player");
            // 
            // Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 481);
            this.Controls.Add(this.txtBoxFavNBAPlayer);
            this.Controls.Add(this.txtBoxFavNFLPlayer);
            this.Controls.Add(this.txtBoxFavNBATeam);
            this.Controls.Add(this.txtBoxFavNFLTeam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Favorites";
            this.Text = "Favorites";
            this.Load += new System.EventHandler(this.Favorites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxFavNFLTeam;
        private System.Windows.Forms.TextBox txtBoxFavNBATeam;
        private System.Windows.Forms.TextBox txtBoxFavNFLPlayer;
        private System.Windows.Forms.TextBox txtBoxFavNBAPlayer;
        private System.Windows.Forms.ToolTip toolTipFavoritesForm;
    }
}