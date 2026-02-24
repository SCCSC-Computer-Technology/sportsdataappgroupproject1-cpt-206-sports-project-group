namespace SportsDataApplication.TMMM
{
    partial class ChooseDatabase
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.comboBoxSport = new System.Windows.Forms.ComboBox();
            this.comboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(60, 7);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(410, 26);

            this.lblWelcome.Location = new System.Drawing.Point(80, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(529, 32);
 
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Sports Statics Database!";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(112, 51);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(295, 20);
            this.lblInstruction.Location = new System.Drawing.Point(149, 63);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(364, 25);
 
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Please Select the Sport you want to view";
            // 
            // comboBoxSport
            // 
            this.comboBoxSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSport.FormattingEnabled = true;
            this.comboBoxSport.Location = new System.Drawing.Point(116, 84);
            this.comboBoxSport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSport.Name = "comboBoxSport";
            this.comboBoxSport.Size = new System.Drawing.Size(270, 28);

            this.comboBoxSport.Location = new System.Drawing.Point(154, 104);
            this.comboBoxSport.Name = "comboBoxSport";
            this.comboBoxSport.Size = new System.Drawing.Size(359, 33);
 
            this.comboBoxSport.TabIndex = 2;
            // 
            // comboBoxDatabase
            // 
            this.comboBoxDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDatabase.FormattingEnabled = true;
            this.comboBoxDatabase.Location = new System.Drawing.Point(116, 214);
            this.comboBoxDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDatabase.Name = "comboBoxDatabase";
            this.comboBoxDatabase.Size = new System.Drawing.Size(270, 28);

            this.comboBoxDatabase.Location = new System.Drawing.Point(154, 263);
            this.comboBoxDatabase.Name = "comboBoxDatabase";
            this.comboBoxDatabase.Size = new System.Drawing.Size(359, 33);

            this.comboBoxDatabase.TabIndex = 4;
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.Location = new System.Drawing.Point(134, 180);
            this.lblInstruction2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(245, 20);

            this.lblInstruction2.Location = new System.Drawing.Point(179, 222);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(303, 25);
            this.lblInstruction2.TabIndex = 3;
            this.lblInstruction2.Text = "Please Select the Database Type";
            // 
            // btnDatabase
            // 
            this.btnDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatabase.Location = new System.Drawing.Point(116, 258);
            this.btnDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(104, 51);

            this.btnDatabase.Location = new System.Drawing.Point(154, 317);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(108, 63);
            this.btnDatabase.TabIndex = 5;
            this.btnDatabase.Text = "&Open Database";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2.Location = new System.Drawing.Point(304, 258);
            this.btnExit2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(81, 51);
            this.btnExit2.TabIndex = 6;
            this.btnExit2.Text = "E&xit";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // ChooseDatabase
            // 
            this.AcceptButton = this.btnDatabase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit2;
            this.ClientSize = new System.Drawing.Size(495, 311);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.comboBoxDatabase);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.comboBoxSport);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChooseDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Database";
            this.Load += new System.EventHandler(this.ChooseDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.ComboBox comboBoxSport;
        private System.Windows.Forms.ComboBox comboBoxDatabase;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.Button btnExit2;
    }
}