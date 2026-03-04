using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SportsDataApplication.TMMM
{

    public partial class Favorites : Form
    {
        public Favorites()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Your connection string (still using your exact path for now)
            string connectionString = @"Data Source=(LocalDB)\v17.0;AttachDbFilename=C:\Users\jessj\OneDrive\Documents\GitHub\sportsdataappgroupproject1-cpt-206-sports-project-group\SportsDataApplication.TMMM\Sign In.mdf;Integrated Security=True;Connect Timeout=30";

            // 2. The precise SQL INSERT statement matching your table screenshot
            // I noticed you have a 'userName' column! I included it here.
            string query = "INSERT INTO userFavs (userName, favNFLTeam, favNBATeam, favNFLPlayer, favNBAPlayer) " +
                           "VALUES (@userName, @nflTeam, @nbaTeam, @nflPlayer, @nbaPlayer)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 3. Bind the parameters securely
                    // NOTE: If you have a variable holding the logged-in user's name, use it here. 
                    // For testing purposes right now, I am just hardcoding "TestUser".
                    command.Parameters.AddWithValue("@userName", CurrentUser.UserName);

                    // Make sure these txt... variable names match the (Name) property of your text boxes in Visual Studio!
                    command.Parameters.AddWithValue("@nflTeam", txtFavNFLTeam.Text);
                    command.Parameters.AddWithValue("@nbaTeam", txtFavNBATeam.Text);
                    command.Parameters.AddWithValue("@nflPlayer", txtNFLPlayer.Text);
                    command.Parameters.AddWithValue("@nbaPlayer", txtFavNBAPlayer.Text);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Your favorites have been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CurrentUser.LoadAllUserFavorites();
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

}
