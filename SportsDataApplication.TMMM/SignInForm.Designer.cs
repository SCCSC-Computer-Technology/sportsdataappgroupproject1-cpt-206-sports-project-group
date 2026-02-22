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
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.sign_InDataSet = new SportsDataApplication.TMMM.Sign_InDataSet();
            this.credentialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.credentialsTableAdapter = new SportsDataApplication.TMMM.Sign_InDataSetTableAdapters.CredentialsTableAdapter();
            this.tableAdapterManager = new SportsDataApplication.TMMM.Sign_InDataSetTableAdapters.TableAdapterManager();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sign_InDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(222, 306);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 48);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(303, 306);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 48);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(216, 167);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 5;
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialsBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(285, 164);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(216, 193);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialsBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(285, 190);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 8;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateUser);
            this.Margin = new System.Windows.Forms.Padding(2);
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

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnLogin;
        private Sign_InDataSet sign_InDataSet;
        private System.Windows.Forms.BindingSource credentialsBindingSource;
        private Sign_InDataSetTableAdapters.CredentialsTableAdapter credentialsTableAdapter;
        private Sign_InDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}

