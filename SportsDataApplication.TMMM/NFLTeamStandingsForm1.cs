using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
// using NFLTeamStandingData; // This links to your class library

namespace SportsDataApplication.TMMM
{
    public partial class NFLTeamStandingsForm1 : Form
    {
        public NFLTeamStandingsForm1()
        {
            InitializeComponent();

            // This ensures data loads even if the login form isn't ready
            //LoadNFLData();
        }

        /*private void LoadNFLData()
        {
            try
            {
                // Finds the DB in the same folder as the .exe
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;
                string dbPath = Path.Combine(executablePath, "NFL-NBA-Team-Standings.accdb");

                // Initialize the manager from your library
                 NFLStandingsManager manager = new NFLStandingsManager(dbPath);

                // Fills the grid with the specific table name
                dataGridView1.DataSource = manager.GetTableData("NFL_Standings");

                // Makes it look professional
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sync Error: " + ex.Message);
            }
        }*/

        private void NFLTeamStandingsForm1_Load(object sender, EventArgs e)
        {

        }

        private void NFLTeamStandingsForm1_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}