namespace SportsDataApplication.TMMM
{
    partial class SignInForm
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
<<<<<<< Updated upstream
=======
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            this.sign_InDataSet = new SportsDataApplication.TMMM.Sign_InDataSet();
            this.credentialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.credentialsTableAdapter = new SportsDataApplication.TMMM.Sign_InDataSetTableAdapters.CredentialsTableAdapter();
            this.tableAdapterManager = new SportsDataApplication.TMMM.Sign_InDataSetTableAdapters.TableAdapterManager();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
<<<<<<< Updated upstream
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
=======
>>>>>>> Stashed changes
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sign_InDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
<<<<<<< Updated upstream
=======
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(211, 309);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(86, 45);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(303, 309);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 45);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
>>>>>>> Stashed changes
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
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
<<<<<<< Updated upstream
            userNameLabel.Location = new System.Drawing.Point(216, 163);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 3;
=======
            userNameLabel.Location = new System.Drawing.Point(216, 167);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 5;
>>>>>>> Stashed changes
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialsBindingSource, "UserName", true));
<<<<<<< Updated upstream
            this.userNameTextBox.Location = new System.Drawing.Point(285, 160);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 4;
=======
            this.userNameTextBox.Location = new System.Drawing.Point(285, 164);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 6;
>>>>>>> Stashed changes
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
<<<<<<< Updated upstream
            passwordLabel.Location = new System.Drawing.Point(216, 189);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 5;
=======
            passwordLabel.Location = new System.Drawing.Point(216, 193);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 7;
>>>>>>> Stashed changes
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialsBindingSource, "Password", true));
<<<<<<< Updated upstream
            this.passwordTextBox.Location = new System.Drawing.Point(285, 186);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(215, 307);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(82, 47);
            this.btnCreateUser.TabIndex = 7;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(303, 307);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 47);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
=======
            this.passwordTextBox.Location = new System.Drawing.Point(285, 190);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 8;
>>>>>>> Stashed changes
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateUser);
=======
            this.ClientSize = new System.Drawing.Size(600, 374);
>>>>>>> Stashed changes
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
<<<<<<< Updated upstream
=======
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateUser);
>>>>>>> Stashed changes
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In - Sports Data Application";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sign_InDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< Updated upstream
=======
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnLogin;
>>>>>>> Stashed changes
        private Sign_InDataSet sign_InDataSet;
        private System.Windows.Forms.BindingSource credentialsBindingSource;
        private Sign_InDataSetTableAdapters.CredentialsTableAdapter credentialsTableAdapter;
        private Sign_InDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
<<<<<<< Updated upstream
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnLogin;
=======
>>>>>>> Stashed changes
    }
}

