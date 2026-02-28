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
        public object AddTeams { get; private set; }

        public NFL_UpcomingGames_MatchResults()
        {
            InitializeComponent();
        }

        private void NFLUpcomingGames_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.NFL_Upcoming_Games' table. You can move, or remove it, as needed.
            this.nFL_Upcoming_GamesTableAdapter.Fill(this.sportsProjectDBDataSet.NFL_Upcoming_Games);
            // Load form data form database

            comboBoxMonthSort.Items.Clear();
            comboBoxTeamSort.Items.Clear();

            AddMonths();
            AddTeamsToBox();
        }

        private void AddTeamsToBox()
        {
            comboBoxTeamSort.Items.Add("Arizona Cardinals");
            comboBoxTeamSort.Items.Add("Atlanta Falcons");
            comboBoxTeamSort.Items.Add("Baltimore Ravens");
            comboBoxTeamSort.Items.Add("Buffalo Bills");
            comboBoxTeamSort.Items.Add("Carolina Panthers");
            comboBoxTeamSort.Items.Add("Chicago Bears");
            comboBoxTeamSort.Items.Add("Cincinnati Bengals");
            comboBoxTeamSort.Items.Add("Cleveland Browns");
            comboBoxTeamSort.Items.Add("Dallas Cowboys");
            comboBoxTeamSort.Items.Add("Denver Broncos");
            comboBoxTeamSort.Items.Add("Detroit Lions");
            comboBoxTeamSort.Items.Add("Green Bay Packers");
            comboBoxTeamSort.Items.Add("Houston Texans");
            comboBoxTeamSort.Items.Add("Indianapolis Colts");
            comboBoxTeamSort.Items.Add("Jacksonville Jaguars");
            comboBoxTeamSort.Items.Add("Kansas City Chiefs");
            comboBoxTeamSort.Items.Add("Las Vegas Raiders");
            comboBoxTeamSort.Items.Add("Los Angeles Chargers");
            comboBoxTeamSort.Items.Add("Los Angeles Rams");
            comboBoxTeamSort.Items.Add("Miami Dolphins");
            comboBoxTeamSort.Items.Add("Minnesota Vikings");
            comboBoxTeamSort.Items.Add("New England Patriots");
            comboBoxTeamSort.Items.Add("New Orleans Saints");
            comboBoxTeamSort.Items.Add("New York Giants");
            comboBoxTeamSort.Items.Add("New York Jets");
            comboBoxTeamSort.Items.Add("Philadelphia Eagles");
            comboBoxTeamSort.Items.Add("Pittsburgh Steelers");
            comboBoxTeamSort.Items.Add("San Francisco 49ers");
            comboBoxTeamSort.Items.Add("Seattle Seahawks");
            comboBoxTeamSort.Items.Add("Tampa Bay Buccaneers");
            comboBoxTeamSort.Items.Add("Tennessee Titans");
            comboBoxTeamSort.Items.Add("Washington Commanders");
        }

        private void AddMonths()
        {
            comboBoxMonthSort.Items.Add("January");
            comboBoxMonthSort.Items.Add("February");
            comboBoxMonthSort.Items.Add("September");
            comboBoxMonthSort.Items.Add("October");
            comboBoxMonthSort.Items.Add("November");
            comboBoxMonthSort.Items.Add("December");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close Upcoming Games / Match Results form
            this.Close();
        }
    }
}
