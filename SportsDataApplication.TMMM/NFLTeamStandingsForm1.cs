using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace SportsDataApplication.TMMM
{
    public partial class NFLTeamStandingsForm1 : Form
    {
        public NFLTeamStandingsForm1()
        {
            InitializeComponent();

        }


        // method to update the data grid view with the selected conference/division data
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
                    dgvNFLStandings.DataSource = dt;

                    // bind the result to the data grid view
                    dgvNFLStandings.DataSource = dt;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // close NFL team standings form
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string userSelection = cbConfDiv.SelectedItem.ToString();

            // Determine which file to load based on user selection
            string dataTable = " ";
            // Safeguard against null selection
            if (cbConfDiv.SelectedItem == null)
            {
                MessageBox.Show("Please select a conference/division from the dropdown.");
                return;
            }

            // Map user selection to the corresponding data table
            switch (userSelection)
            {
                case "NFL AFC East":
                    dataTable = "[NFL AFC EAST 25]";
                    break;
                case "NFL AFC North":
                    dataTable = "[NFL AFC NORTH 25]";
                    break;
                case "NFL AFC South":
                    dataTable = "[NFL AFC SOUTH 25]";
                    break;
                case "NFL AFC West":
                    dataTable = "[NFL AFC WEST 25]";
                    break;
                case "NFL NFC East":
                    dataTable = "[NFL NFC EAST 25]";
                    break;
                case "NFL NFC North":
                    dataTable = "[NFL NFC NORTH 25]";
                    break;
                case "NFL NFC South":
                    dataTable = "[NFL NFC SOUTH 25]";
                    break;
                case "NFL NFC West":
                    dataTable = "[NFL NFC WEST 25]";
                    break;
            }

            // Load the selected data into the data grid view
            if (!string.IsNullOrEmpty(dataTable))
            {
                UpdateDataGridView(dataTable);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtbxSearch.Text.Trim();

            // Check if the search keyword is empty
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.");
                return;
            }

            // Get the connection string from the configuration file
            string connString = ConfigurationManager.ConnectionStrings["SportsDataApplication.TMMM.Properties.Settings.SportsProjectDBConnectionString"].ConnectionString;

            // Construct a SQL query that searches for the keyword across all conference/division tables
            string query = $@"
            SELECT [AFC EAST] AS [Team/Division], W, L, T, PCT, PF, PA, [Net Pts], Home, Road, Div, Pct1, Conf, Pct_1, [Non-Conf], strk, [Last 5] FROM [NFL AFC EAST 25] WHERE [AFC East] LIKE @key
            UNION ALL
            SELECT [AFC NORTH], W, L, T, PCT, PF, PA, [Net Pts], Home, Road, Div, Pct1, Conf, Pct_1, [Non-Conf], strk, [Last 5] FROM [NFL AFC NORTH 25] WHERE [AFC North] LIKE @key
            UNION ALL
            SELECT [AFC SOUTH], W, L, T, PCT, PF, PA, [Net Pts], Home, Road, Div, Pct1, Conf, Pct_1, [Non-Conf], strk, [Last 5] FROM [NFL AFC SOUTH 25] WHERE [AFC South] LIKE @key
            UNION ALL
            SELECT [AFC WEST], W, L, T, PCT, PF, PA, [Net Pts], Home, Road, Div, Pct1, Conf, Pct_1, [Non-Conf], strk, [Last 5] FROM [NFL AFC WEST 25] WHERE [AFC West] LIKE @key
            UNION ALL
            SELECT [NFC EAST], W, L, T, PCT, PF, PA, [Net Pts], Home, Road, Div, Pct1, Conf, Pct_1, [Non-Conf], strk, [Last 5] FROM [NFL NFC EAST 25] WHERE [NFC East] LIKE @key
            UNION ALL
            SELECT [NFC NORTH], W, L, T, PCT, PF, PA, [Net Pts], Home, Road, Div, Pct1, Conf, Pct_1, [Non-Conf], strk, [Last 5] FROM [NFL NFC NORTH 25] WHERE [NFC North] LIKE @key
            UNION ALL
            SELECT [NFC SOUTH], W, L, T, PCT, PF, PA, [Net Pts], Home, Road, Div, Pct1, Conf, Pct_1, [Non-Conf], strk, [Last 5] FROM [NFL NFC SOUTH 25] WHERE [NFC South] LIKE @key
            UNION ALL
            SELECT [NFC WEST], W, L, T, PCT, PF, PA, [Net Pts], Home, Road, Div, Pct1, Conf, Pct_1, [Non-Conf], strk, [Last 5] FROM [NFL NFC WEST 25] WHERE [NFC West] LIKE @key";

            try
            {
                // Use parameterized query to prevent SQL injection
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    // Open the connection
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Add the search keyword as a parameter with wildcards for partial matching
                    cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

                    // Execute the query and fill the results into a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    // Create a data table to hold the search results
                    DataTable dt = new DataTable();
                    // Fill the data table with the search results
                    adapter.Fill(dt);

                    // Bind the search results to the data grid view
                    dgvNFLStandings.DataSource = dt;

                    // Check if any results were found
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No results found for '" + keyword + "'.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the search
                MessageBox.Show("Error searching data: " + ex.Message);

            }
        }

        private void dgvNFLStandings_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // It prevents the "Parameter is not valid" pop-up while you scroll.
            e.ThrowException = false;
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            // Check if the user has a division selected in the ComboBox
            if (cbConfDiv.SelectedItem != null)
            {
                // Get the user's selection from the ComboBox
                string userSelection = cbConfDiv.SelectedItem.ToString();
                string dataTable = "";

                // Map the user's selection to the corresponding data table
                switch (userSelection)
                {
                    case "NFL AFC East":
                        dataTable = "[NFL AFC EAST 25]";
                        break;
                    case "NFL AFC North":
                        dataTable = "[NFL AFC NORTH 25]";
                        break;
                    case "NFL AFC South":
                        dataTable = "[NFL AFC SOUTH 25]";
                        break;
                    case "NFL AFC West":
                        dataTable = "[NFL AFC WEST 25]";
                        break;
                    case "NFL NFC East":
                        dataTable = "[NFL NFC EAST 25]";
                        break;
                    case "NFL NFC North":
                        dataTable = "[NFL NFC NORTH 25]";
                        break;
                    case "NFL NFC South":
                        dataTable = "[NFL NFC SOUTH 25]";
                        break;
                    case "NFL NFC West":
                        dataTable = "[NFL NFC WEST 25]";
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
                dgvNFLStandings.DataSource = null;
                txtbxSearch.Clear();
            }
        }
    }
}