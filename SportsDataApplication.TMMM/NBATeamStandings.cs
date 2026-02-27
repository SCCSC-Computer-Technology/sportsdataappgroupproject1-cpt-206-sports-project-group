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
    }
}
