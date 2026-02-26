using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccessClassLibrary; // Database class library

namespace SportsDataApplication.TMMM
{
    public partial class NFL_UpcomingGames_MatchResults : Form
    {
        public NFL_UpcomingGames_MatchResults()
        {
            InitializeComponent();
        }

        private void credentialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.credentialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sign_InDataSet);

        }

        private void NFLUpcomingGames_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group_Project_1_Sports_DatabaseDataSet.NFL_Upcoming_Games' table. You can move, or remove it, as needed.
            this.nFL_Upcoming_GamesTableAdapter.Fill(this.group_Project_1_Sports_DatabaseDataSet.NFL_Upcoming_Games);
            // TODO: This line of code loads data into the 'sign_InDataSet.Credentials' table. You can move, or remove it, as needed.
            this.credentialsTableAdapter.Fill(this.sign_InDataSet.Credentials);

        }
    }
}
