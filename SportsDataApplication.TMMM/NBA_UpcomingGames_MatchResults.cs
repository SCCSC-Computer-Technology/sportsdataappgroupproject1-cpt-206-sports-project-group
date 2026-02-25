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

        private void nBA_Upcoming_GamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nBA_Upcoming_GamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.group_Project_1_Sports_DatabaseDataSet1);

        }

        private void NBAUpcomingGames_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group_Project_1_Sports_DatabaseDataSet1.NBA_Upcoming_Games' table. You can move, or remove it, as needed.
            this.nBA_Upcoming_GamesTableAdapter.Fill(this.group_Project_1_Sports_DatabaseDataSet1.NBA_Upcoming_Games);

        }
    }
}
