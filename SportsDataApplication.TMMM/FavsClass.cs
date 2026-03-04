using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportsDataApplication.TMMM
{
    public static class CurrentUser
    {
        // Storing the logged-in user's name (Hardcoded for testing right now)
        public static string UserName { get; set; } = "TestUser";

        // The four favorite variables
        public static string FavoriteNFLTeam { get; set; }
        public static string FavoriteNBATeam { get; set; }
        public static string FavoriteNFLPlayer { get; set; }
        public static string FavoriteNBAPlayer { get; set; }

        // This method is now safely INSIDE the CurrentUser class
        // and marked as public static so your Main Menu can call it!
        public static void LoadAllUserFavorites()
        {
            // Your current connection string
            string connectionString = @"Data Source=(LocalDB)\v17.0;AttachDbFilename=C:\Users\jessj\OneDrive\Documents\GitHub\sportsdataappgroupproject1-cpt-206-sports-project-group\SportsDataApplication.TMMM\Sign In.mdf;Integrated Security=True;Connect Timeout=30";

            // We select ALL four columns for the current user
            string query = "SELECT favNFLTeam, favNBATeam, favNFLPlayer, favNBAPlayer FROM userFavs WHERE userName = @userName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Pass in the username from our static class
                    command.Parameters.AddWithValue("@userName", CurrentUser.UserName);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // If we found their saved row
                            {
                                // Check each column to make sure it isn't NULL before saving it to memory
                                if (reader["favNFLTeam"] != DBNull.Value)
                                    CurrentUser.FavoriteNFLTeam = reader["favNFLTeam"].ToString();

                                if (reader["favNBATeam"] != DBNull.Value)
                                    CurrentUser.FavoriteNBATeam = reader["favNBATeam"].ToString();

                                if (reader["favNFLPlayer"] != DBNull.Value)
                                    CurrentUser.FavoriteNFLPlayer = reader["favNFLPlayer"].ToString();

                                if (reader["favNBAPlayer"] != DBNull.Value)
                                    CurrentUser.FavoriteNBAPlayer = reader["favNBAPlayer"].ToString();
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error loading favorites from database: " + ex.Message);
                    }
                }
            }
        }
    }

    internal class FavsClass
    {
    }
}