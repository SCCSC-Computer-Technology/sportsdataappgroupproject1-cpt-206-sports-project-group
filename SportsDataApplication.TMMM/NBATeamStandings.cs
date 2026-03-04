using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsDataApplication.TMMM
{
    public partial class NBATeamStandings : Form
    {
        public NBATeamStandings()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close NBA team standings form
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search keyword from the text box and trim any leading/trailing whitespace
            string keyword = txtBoxKeyword.Text.Trim();
            if (string.IsNullOrEmpty(keyword)) return;

            // Create a DataTable to hold the search results with appropriate columns
            DataTable searchResults = new DataTable();
            searchResults.Columns.Add("Source");
            searchResults.Columns.Add("Team/Player");
            searchResults.Columns.Add("Details");

            try
            {
                //connection string to the database, make sure this matches the name in your app.config file
                string connName = "SportsDataApplication.TMMM.Properties.Settings.SportsProjectDBConnectionString";
                string connString = ConfigurationManager.ConnectionStrings[connName].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    // Construct a SQL query that searches for the keyword in the TeamName column across all four tables, using UNION ALL to combine results
                    string query = @"
                    SELECT 'NBA Eastern 24-25' AS Source, [Eastern Conference] AS [Team/Player], CONCAT('W: ', Win, ', L: ', Loss) AS Details 
                    FROM [NBA Eastern Conference 24-25] WHERE [Eastern Conference] LIKE @Keyword
                    UNION ALL
                    SELECT 'NBA Eastern 25-26' AS Source, TEAM AS [Team/Player], CONCAT('W: ', WIN, ', L: ', LOSS) AS Details 
                    FROM [NBA Eastern Conference 25-26] WHERE TEAM LIKE @Keyword
                    UNION ALL
                    SELECT 'NBA Western 24-25' AS Source, Team AS [Team/Player], CONCAT('W: ', W, ', L: ', L) AS Details 
                    FROM [NBA Western Conference 24-25] WHERE Team LIKE @Keyword
                    UNION ALL
                    SELECT 'NBA Western 25-26' AS Source, TEAM AS [Team/Player], CONCAT('W: ', WIN, ', L: ', LOSS) AS Details 
                    FROM [NBA Western Conference 25-26] WHERE TEAM LIKE @Keyword";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Wildcards (%) are added here to the parameter value
                        command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                searchResults.Rows.Add(reader["Source"], reader["Team/Player"], reader["Details"]);
                            }
                        }
                    }
                }

                // Bind the results to your DataGridView
                dgvNBAStandings.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                // This will catch the 'Login failed' or 'Permission denied' errors if the DB is locked
                MessageBox.Show("Could not access the database.\n\nDetails: " + ex.Message);
            }

        }
              
        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Open help form and display relevant information about NBA team standings
            // Create the form and pass the "key" for the help info
            HelpForm helpForm = new HelpForm("NBATeamStanding");

            // Show the form as a modal dialog (prevents clicking the main form until closed)
            helpForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }
        private void UpdateDataGridView(string dataTable)
        {
            // Get the connection string from the configuration file
            string connString = ConfigurationManager.ConnectionStrings["SportsDataApplication.TMMM.Properties.Settings.SportsProjectDBConnectionString"].ConnectionString;
            try
            {
                // Open a connection to the database and execute a query to retrieve the data for the selected conference/division
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // Open the connection
                    connection.Open();
                    // Construct a SQL query to select all data from the specified data table
                    string query = $"SELECT * FROM {dataTable}";
                    //  Execute the query and fill the results into a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    //  Create a data table to hold the results
                    DataTable dt = new DataTable();
                    // Fill the data table with the results of the query
                    adapter.Fill(dt);
                    // Bind the data table to the data grid view to display the results
                    dgvNBAStandings.DataSource = dt;

                    // bind the result to the data grid view
                    dgvNBAStandings.DataSource = dt;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            // Check if the user has a division selected in the ComboBox
            if (cbConfDiv.SelectedItem != null)
            {
                // Get the user's selection from the ComboBox
                string userSelection = cbConfDiv.SelectedItem.ToString();
                string dataTable = " ";

                // Map the user's selection to the corresponding data table
                switch (userSelection)
                {
                    case "Eastern Conference 24-25":
                        dataTable = "[NBA Eastern Conference 24-25]";
                        break;
                    case "Eastern Conference 25-26":
                        dataTable = "[NBA Eastern Conference 25-26]";
                        break;
                    case "Western Conference 24-25":
                        dataTable = "[NBA Western Conference 24-25]";
                        break;
                    case "Western Conference 25-26":
                        dataTable = "[NBA Western Conference 25-26]";
                        break;
                    
                }

                if (!string.IsNullOrEmpty(dataTable))
                {
                    // This pulls fresh data from your SQL .mdf file
                    UpdateDataGridView(dataTable);
                }
            }
            else
            {
                // If nothing is selected, clear the grid and the search box
                dgvNBAStandings.DataSource = null;
                txtBoxKeyword.Clear();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (cbConfDiv.SelectedItem == null)
            {
                MessageBox.Show("Please select a conference/division from the dropdown.");
                return;
            }
            string userSelection = cbConfDiv.SelectedItem.ToString();

            // Determine which file to load based on user selection
            string dataTable = " ";
            // Safeguard against null selection
           

            // Map user selection to the corresponding data table
            switch (userSelection)
            {
                case "Eastern Conference 24-25":
                    dataTable = "[NBA Eastern Conference 24-25]";
                    break;
                case "Eastern Conference 25-26":
                    dataTable = "[NBA Eastern Conference 25-26]";
                    break;
                case "Western Conference 24-25":
                    dataTable = "[NBA Western Conference 24-25]";
                    break;
                case "Western Conference 25-26":
                    dataTable = "[NBA Western Conference 25-26]";
                    break;
                
            }

            // Load the selected data into the data grid view
            if (!string.IsNullOrEmpty(dataTable))
            {
                UpdateDataGridView(dataTable);
            }
        
    }

        private void btnFav_Click(object sender, EventArgs e)
        {
            string keyword = CurrentUser.FavoriteNBATeam; // Assuming you have a property in your CurrentUser class for the favorite NBA team
            if (string.IsNullOrEmpty(keyword)) return;

            // Create a DataTable to hold the search results with appropriate columns
            DataTable searchResults = new DataTable();
            searchResults.Columns.Add("Source");
            searchResults.Columns.Add("Team/Player");
            searchResults.Columns.Add("Details");

            try
            {
                //connection string to the database, make sure this matches the name in your app.config file
                string connName = "SportsDataApplication.TMMM.Properties.Settings.SportsProjectDBConnectionString";
                string connString = ConfigurationManager.ConnectionStrings[connName].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    // Construct a SQL query that searches for the keyword in the TeamName column across all four tables, using UNION ALL to combine results
                    string query = @"
                    SELECT 'NBA Eastern 24-25' AS Source, [Eastern Conference] AS [Team/Player], CONCAT('W: ', Win, ', L: ', Loss) AS Details 
                    FROM [NBA Eastern Conference 24-25] WHERE [Eastern Conference] LIKE @Keyword
                    UNION ALL
                    SELECT 'NBA Eastern 25-26' AS Source, TEAM AS [Team/Player], CONCAT('W: ', WIN, ', L: ', LOSS) AS Details 
                    FROM [NBA Eastern Conference 25-26] WHERE TEAM LIKE @Keyword
                    UNION ALL
                    SELECT 'NBA Western 24-25' AS Source, Team AS [Team/Player], CONCAT('W: ', W, ', L: ', L) AS Details 
                    FROM [NBA Western Conference 24-25] WHERE Team LIKE @Keyword
                    UNION ALL
                    SELECT 'NBA Western 25-26' AS Source, TEAM AS [Team/Player], CONCAT('W: ', WIN, ', L: ', LOSS) AS Details 
                    FROM [NBA Western Conference 25-26] WHERE TEAM LIKE @Keyword";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Wildcards (%) are added here to the parameter value
                        command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                searchResults.Rows.Add(reader["Source"], reader["Team/Player"], reader["Details"]);
                            }
                        }
                    }
                }

                // Bind the results to your DataGridView
                dgvNBAStandings.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                // This will catch the 'Login failed' or 'Permission denied' errors if the DB is locked
                MessageBox.Show("Could not access the database.\n\nDetails: " + ex.Message);
            }
        }
    }
}
