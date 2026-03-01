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
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.NFL_Match_Results_Data' table. You can move, or remove it, as needed.
            this.nFL_Match_Results_DataTableAdapter.Fill(this.sportsProjectDBDataSet.NFL_Match_Results_Data);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search button for Match Results table
            // filter function only works for teamVS and matchDate columns
            string matchResultsSearch = txtBoxSearch.Text.Trim();
            nFL_Match_Results_DataBindingSource.Filter = "teamVS like '%" + matchResultsSearch + "%' OR CONVERT (matchDate, 'System.String') like '%" + matchResultsSearch + "%'";
        }

        private void btnMonthSort_Click(object sender, EventArgs e)
        {
            switch (comboBoxMonthSort.SelectedIndex)
            {
                case 0: this.nFL_Upcoming_GamesTableAdapter.SortbyJanuary(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 1: this.nFL_Upcoming_GamesTableAdapter.SortByFebruary(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 2: this.nFL_Upcoming_GamesTableAdapter.SortBySeptember(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 3: this.nFL_Upcoming_GamesTableAdapter.SortByOctober(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 4: this.nFL_Upcoming_GamesTableAdapter.SortByNovember(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 5: this.nFL_Upcoming_GamesTableAdapter.SortByDecember(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                default:
                    MessageBox.Show("Please select a Month");
                    break;
            }

        }

        private void btnTeamSort_Click(object sender, EventArgs e)
        {
            switch (comboBoxTeamSort.SelectedIndex)
            {
                case 0: this.nFL_Upcoming_GamesTableAdapter.SortByArizonaCardinals(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 1: this.nFL_Upcoming_GamesTableAdapter.SortByAtlantaFalcons(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 2: this.nFL_Upcoming_GamesTableAdapter.SortByBaltimoreRavens(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 3: this.nFL_Upcoming_GamesTableAdapter.SortByBuffaloBills(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 4: this.nFL_Upcoming_GamesTableAdapter.SortByCarolinaPanthers(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 5: this.nFL_Upcoming_GamesTableAdapter.SortByChicagoBears(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 6: this.nFL_Upcoming_GamesTableAdapter.SortByCincinnatiBengals(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 7: this.nFL_Upcoming_GamesTableAdapter.SortByClBr(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // Cleveland Browns
                case 8: this.nFL_Upcoming_GamesTableAdapter.SortByDB(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;   // Dallas Cowboys
                case 9: this.nFL_Upcoming_GamesTableAdapter.SortByDC(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;   // Denver Broncos
                case 10: this.nFL_Upcoming_GamesTableAdapter.SortByDL(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;  // Detroit Lions
                case 11: this.nFL_Upcoming_GamesTableAdapter.SortByGDP(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // Green Bay Packers
                case 12: this.nFL_Upcoming_GamesTableAdapter.SortByHT(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;  // Houston Texans
                case 13: this.nFL_Upcoming_GamesTableAdapter.SortByIC(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;  // Indianapolis Colts
                case 14: this.nFL_Upcoming_GamesTableAdapter.SortByJJ(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;  // Jacksonville Jaguars
                case 15: this.nFL_Upcoming_GamesTableAdapter.SortByKCC(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // Kansas City Chiefs
                case 16: this.nFL_Upcoming_GamesTableAdapter.SortByLVR(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // Las Vegas Raiders
                case 17: this.nFL_Upcoming_GamesTableAdapter.SortByLAC(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // Los Angeles Chargers
                case 18: this.nFL_Upcoming_GamesTableAdapter.SortByLAR(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // Los Angeles Rams
                case 19: this.nFL_Upcoming_GamesTableAdapter.SortByMD(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;  // Miami Dolphins
                case 20: this.nFL_Upcoming_GamesTableAdapter.SortByMV(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;  // Minnesota Vikings
                case 21: this.nFL_Upcoming_GamesTableAdapter.SortByNEP(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // New England Patriots
                case 22: this.nFL_Upcoming_GamesTableAdapter.SortByNOS(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // New Orleans Saints
                case 23: this.nFL_Upcoming_GamesTableAdapter.SortByNYG(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // New York Giants
                case 24: this.nFL_Upcoming_GamesTableAdapter.SortByNYJ(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // New York Jets
                case 25: this.nFL_Upcoming_GamesTableAdapter.SortByPE(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;  // Philadelphia Eagles
                case 26: this.nFL_Upcoming_GamesTableAdapter.SortByPS(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;  // Pittsburgh Steelers
                case 27: this.nFL_Upcoming_GamesTableAdapter.SortBySF49(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // San Francisco 49ers
                case 28: this.nFL_Upcoming_GamesTableAdapter.SortBySeahawks(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;
                case 29: this.nFL_Upcoming_GamesTableAdapter.SortByTBB(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break; // Tampa Bay Buccaneers
                case 30: this.nFL_Upcoming_GamesTableAdapter.SortByTT(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;  // Tennessee Titans
                case 31: this.nFL_Upcoming_GamesTableAdapter.SortByWC(this.sportsProjectDBDataSet.NFL_Upcoming_Games); break;  // Washington Commanders
                default:
                    MessageBox.Show("Please select a Team");
                    break;
            }
        }
    }
}
