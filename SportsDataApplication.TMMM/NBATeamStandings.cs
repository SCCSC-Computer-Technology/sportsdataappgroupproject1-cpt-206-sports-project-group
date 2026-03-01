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
            // Search for team standings based on user input
            // Using SQL querries
        }
              
        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Open help form and display relevant information about NBA team standings
            HelpForm helpForm = new HelpForm();
            helpForm.ShowHelp("NBA");
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
    }
}
