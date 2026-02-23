using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsDataApplication.TMMM
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void credentialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.credentialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sign_InDataSet);

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sign_InDataSet.Credentials' table. You can move, or remove it, as needed.
            this.credentialsTableAdapter.Fill(this.sign_InDataSet.Credentials);
            // TODO: This line of code loads data into the 'sign_InDataSet.Credentials' table. You can move, or remove it, as needed.
            this.credentialsTableAdapter.Fill(this.sign_InDataSet.Credentials);
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (userNameTextBox.Text != "")
                {
                    credentialsTableAdapter.CreateUser(userNameTextBox.Text.Trim(), passwordTextBox.Text.Trim());
                    MessageBox.Show("User created successfully. You can now login.");
                }
                else
                {
                    MessageBox.Show("Please enter a username and password.");
                }
            }
            catch
            {
                MessageBox.Show("Please make sure that the username and password are less than 50 characters. If they are then this username is already taken please enter another one.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)credentialsTableAdapter.LoginValidation(userNameTextBox.Text.Trim(), passwordTextBox.Text.Trim());

                if (result == 1)
                {
                    MessageBox.Show("Login Successful.");
                    ChooseDatabase chooseDatabase = new ChooseDatabase();
                    chooseDatabase.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Pleases try again.");
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void credentialsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.credentialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sign_InDataSet);

        }
    }
}
