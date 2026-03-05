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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFavNFLTeam = new System.Windows.Forms.TextBox();
            this.txtNFLPlayer = new System.Windows.Forms.TextBox();
            this.txtFavNBATeam = new System.Windows.Forms.TextBox();
            this.txtFavNBAPlayer = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favorite NFL Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Favorite NBA Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Favorite NFL Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Favorite NBA Player";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please Select Your Favorites:";
            // 
            // txtFavNFLTeam
            // 
            this.txtFavNFLTeam.Location = new System.Drawing.Point(28, 86);
            this.txtFavNFLTeam.Name = "txtFavNFLTeam";
            this.txtFavNFLTeam.Size = new System.Drawing.Size(123, 20);
            this.txtFavNFLTeam.TabIndex = 5;
            // 
            // txtNFLPlayer
            // 
            this.txtNFLPlayer.Location = new System.Drawing.Point(28, 204);
            this.txtNFLPlayer.Name = "txtNFLPlayer";
            this.txtNFLPlayer.Size = new System.Drawing.Size(123, 20);
            this.txtNFLPlayer.TabIndex = 6;
            // 
            // txtFavNBATeam
            // 
            this.txtFavNBATeam.Location = new System.Drawing.Point(236, 86);
            this.txtFavNBATeam.Name = "txtFavNBATeam";
            this.txtFavNBATeam.Size = new System.Drawing.Size(123, 20);
            this.txtFavNBATeam.TabIndex = 7;
            // 
            // txtFavNBAPlayer
            // 
            this.txtFavNBAPlayer.Location = new System.Drawing.Point(236, 204);
            this.txtFavNBAPlayer.Name = "txtFavNBAPlayer";
            this.txtFavNBAPlayer.Size = new System.Drawing.Size(123, 20);
            this.txtFavNBAPlayer.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Sa&ve";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(158, 261);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 31);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "B&ack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(262, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 31);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 320);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFavNBAPlayer);
            this.Controls.Add(this.txtFavNBATeam);
            this.Controls.Add(this.txtNFLPlayer);
            this.Controls.Add(this.txtFavNFLTeam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Favorites";
            this.Text = "Favorites";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFavNFLTeam;
        private System.Windows.Forms.TextBox txtNFLPlayer;
        private System.Windows.Forms.TextBox txtFavNBATeam;
        private System.Windows.Forms.TextBox txtFavNBAPlayer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}