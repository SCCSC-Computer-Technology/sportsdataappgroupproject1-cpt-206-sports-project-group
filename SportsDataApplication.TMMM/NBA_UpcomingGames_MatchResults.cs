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
            AddSearchColumns_MatchResults();
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

        private void AddSearchColumns_MatchResults()
        {
            comBoxSelectColumn.Items.Add("Specify Search Column");
            comBoxSelectColumn.Items.Add("hometeamName");
            comBoxSelectColumn.Items.Add("awayteamName");
            comBoxSelectColumn.Items.Add("winner");
            comBoxSelectColumn.Items.Add("arenaCity");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search button for Match Results table
            try
            {
                if (comBoxSelectColumn.SelectedItem == null)
                {
                    MessageBox.Show("Please select a column to search.");
                    return;
                }

                // set text box input to variable / selected column to variable / create filter string
                string matchResultsSearch = txtBoxSearch.Text.Trim();
                string selectedColumn = comBoxSelectColumn.SelectedItem.ToString();

                // filter string to filter the data source
                // handles special characters by converting to string

                /*
                 * Searchable columns only = hometeamName, awayteamName, winner, arenaCity
                 */

                string columnFilter = "CONVERT(" + selectedColumn + ", 'System.String') LIKE '%" + matchResultsSearch + "%'";

                // condition depending on if the search box is empty or not
                if (string.IsNullOrEmpty(matchResultsSearch))
                {
                    // remove the filter if the search box is empty
                    nBA_Match_Results_DataBindingSource.RemoveFilter();
                }
                else
                {
                    // apply the filter to the data source
                    nBA_Match_Results_DataBindingSource.Filter = columnFilter;
                }
            }
            catch
            {
                // Error if user enters invalid characters
                MessageBox.Show("An Error Occurred. Please specify a column to filter from the dropdown.");
            }
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            // refresh table button
            this.nBA_Match_Results_DataTableAdapter.Fill(this.sportsProjectDBDataSet.NBA_Match_Results_Data);
            txtBoxSearch.Clear();
            btnSearch_Click(btnSearch, EventArgs.Empty); // click event
            comBoxSelectColumn.SelectedIndex = 0;
        }
        private void btnMonthSort_Click(object sender, EventArgs e)
        {
            switch (comboBoxMonthSort.SelectedIndex)
            {
                case 0: this.nBA_Upcoming_GamesTableAdapter.SortByJanuary(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break;
                case 1: this.nBA_Upcoming_GamesTableAdapter.SortByFebruary(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break;
                case 2: this.nBA_Upcoming_GamesTableAdapter.SortByMarch(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break;
                case 3: this.nBA_Upcoming_GamesTableAdapter.SortByApril(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break;
                case 4: this.nBA_Upcoming_GamesTableAdapter.SortByOctober(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break;
                case 5: this.nBA_Upcoming_GamesTableAdapter.SortByNovember(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break;
                default:
                    MessageBox.Show("Please select a Month");
                    break;

            }

        }

        private void btnTeamSort_Click(object sender, EventArgs e)
        {
            switch (comboBoxTeamSort.SelectedIndex)
            {
                case 0: this.nBA_Upcoming_GamesTableAdapter.SortByAH(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Atlanta Hawks
                case 1: this.nBA_Upcoming_GamesTableAdapter.SortByBN(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Boston Celtics
                case 2: this.nBA_Upcoming_GamesTableAdapter.SortByBC(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Brooklyn Nets
                case 3: this.nBA_Upcoming_GamesTableAdapter.SortByCH(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Chicago Bulls
                case 4: this.nBA_Upcoming_GamesTableAdapter.SortByCC(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Cleveland Cavaliers
                case 5: this.nBA_Upcoming_GamesTableAdapter.SortByDM(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Dallas Mavericks
                case 6: this.nBA_Upcoming_GamesTableAdapter.SortByDN(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Denver Nuggets
                case 7: this.nBA_Upcoming_GamesTableAdapter.SortByDP(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Detroit Pistons
                case 8: this.nBA_Upcoming_GamesTableAdapter.SortByGSW(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Golden State Warriors
                case 9: this.nBA_Upcoming_GamesTableAdapter.SortByHR(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Houston Rockets
                case 10: this.nBA_Upcoming_GamesTableAdapter.SortByIP(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Indiana Pacers
                case 11: this.nBA_Upcoming_GamesTableAdapter.SortByLAC(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // LA Clippers
                case 12: this.nBA_Upcoming_GamesTableAdapter.SortByLAL(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Los Angeles Lakers
                case 13: this.nBA_Upcoming_GamesTableAdapter.SortByMG(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Memphis Grizzlies
                case 14: this.nBA_Upcoming_GamesTableAdapter.SortByMH(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Miami Heat
                case 15: this.nBA_Upcoming_GamesTableAdapter.SortByMB(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Milwaukee Bucks
                case 16: this.nBA_Upcoming_GamesTableAdapter.SortByMT(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Minnesota Timberwolves
                case 17: this.nBA_Upcoming_GamesTableAdapter.SortByNOP(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // New Orleans Pelicans
                case 18: this.nBA_Upcoming_GamesTableAdapter.SortByNYK(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // New York Knicks
                case 19: this.nBA_Upcoming_GamesTableAdapter.SortByOCT(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Oklahoma City Thunder
                case 20: this.nBA_Upcoming_GamesTableAdapter.SortByOM(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Orlando Magic
                case 21: this.nBA_Upcoming_GamesTableAdapter.SortByP76(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Philadelphia 76ers
                case 22: this.nBA_Upcoming_GamesTableAdapter.SortByPS(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Phoenix Suns
                case 23: this.nBA_Upcoming_GamesTableAdapter.SortByPTB(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Portland Trail Blazers
                case 24: this.nBA_Upcoming_GamesTableAdapter.SortBySK(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Sacramento Kings
                case 25: this.nBA_Upcoming_GamesTableAdapter.SortBySAS(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // San Antonio Spurs
                case 26: this.nBA_Upcoming_GamesTableAdapter.SortByTR(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Toronto Raptors
                case 27: this.nBA_Upcoming_GamesTableAdapter.SortByUJ(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Utah Jazz
                case 28: this.nBA_Upcoming_GamesTableAdapter.SortByWW(this.sportsProjectDBDataSet.NBA_Upcoming_Games); break; // Washington Wizards

                default:
                    MessageBox.Show("Please select a Team");
                    break;
            }
        }
    }
}
