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
    public partial class NBA_UpcomingGames_MatchResults : Form
    {
        public NBA_UpcomingGames_MatchResults()
        {
            InitializeComponent();
        }

        private void NBAUpcomingGames_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.NBA_Match_Results_Data' table. You can move, or remove it, as needed.
            this.nBA_Match_Results_DataTableAdapter.Fill(this.sportsProjectDBDataSet.NBA_Match_Results_Data);
            // Load form data from database
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close Upcoming Games / Match Results form
            this.Close();  
        }
    }
}
