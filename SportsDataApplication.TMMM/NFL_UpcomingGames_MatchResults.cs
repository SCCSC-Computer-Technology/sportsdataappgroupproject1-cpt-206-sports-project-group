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
    public partial class NFL_UpcomingGames_MatchResults : Form
    {
        public NFL_UpcomingGames_MatchResults()
        {
            InitializeComponent();
        }

        private void NFLUpcomingGames_Load(object sender, EventArgs e)
        {
            // Load form data form database
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close Upcoming Games / Match Results form
            this.Close();
        }
    }
}
