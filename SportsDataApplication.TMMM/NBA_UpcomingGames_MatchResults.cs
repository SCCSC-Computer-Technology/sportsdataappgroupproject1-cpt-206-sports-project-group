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
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.NBA_Upcoming_Games' table. You can move, or remove it, as needed.
            this.nBA_Upcoming_GamesTableAdapter.Fill(this.sportsProjectDBDataSet.NBA_Upcoming_Games);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.NBA_Match_Results_Data' table. You can move, or remove it, as needed.
            this.nBA_Match_Results_DataTableAdapter.Fill(this.sportsProjectDBDataSet.NBA_Match_Results_Data);
            // Load form data from database

            AddMonths();
            AddTeamsToBox();
        }

        private void AddTeamsToBox()
        {
            comboBoxTeamSort.Items.Add("Atlanta Hawks");
            comboBoxTeamSort.Items.Add("Boston Celtics");
            comboBoxTeamSort.Items.Add("Brooklyn Nets");
            comboBoxTeamSort.Items.Add("Chicago Bulls");
            comboBoxTeamSort.Items.Add("Cleveland Cavaliers");
            comboBoxTeamSort.Items.Add("Dallas Mavericks");
            comboBoxTeamSort.Items.Add("Denver Nuggets");
            comboBoxTeamSort.Items.Add("Detroit Pistons");
            comboBoxTeamSort.Items.Add("Golden State Warriors");
            comboBoxTeamSort.Items.Add("Houston Rockets");
            comboBoxTeamSort.Items.Add("Indiana Pacers");
            comboBoxTeamSort.Items.Add("LA Clippers");
            comboBoxTeamSort.Items.Add("Los Angeles Lakers");
            comboBoxTeamSort.Items.Add("Memphis Grizzlies");
            comboBoxTeamSort.Items.Add("Miami Heat");
            comboBoxTeamSort.Items.Add("Milwaukee Bucks");
            comboBoxTeamSort.Items.Add("Minnesota Timberwolves");
            comboBoxTeamSort.Items.Add("New Orleans Pelicans");
            comboBoxTeamSort.Items.Add("New York Knicks");
            comboBoxTeamSort.Items.Add("Oklahoma City Thunder");
            comboBoxTeamSort.Items.Add("Orlando Magic");
            comboBoxTeamSort.Items.Add("Philadelphia 76ers");
            comboBoxTeamSort.Items.Add("Phoenix Suns");
            comboBoxTeamSort.Items.Add("Portland Trail Blazers");
            comboBoxTeamSort.Items.Add("Sacramento Kings");
            comboBoxTeamSort.Items.Add("San Antonio Spurs");
            comboBoxTeamSort.Items.Add("Toronto Raptors");
            comboBoxTeamSort.Items.Add("Utah Jazz");
            comboBoxTeamSort.Items.Add("Washington Wizards");
        }

        private void AddMonths()
        {
            comboBoxMonthSort.Items.Add("January");
            comboBoxMonthSort.Items.Add("February");
            comboBoxMonthSort.Items.Add("March");
            comboBoxMonthSort.Items.Add("April");
            comboBoxMonthSort.Items.Add("October");
            comboBoxMonthSort.Items.Add("November");
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close Upcoming Games / Match Results form
            this.Close();  
        }

        private void nBA_Match_Results_DataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nBA_Match_Results_DataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportsProjectDBDataSet);

        }
    }
}
