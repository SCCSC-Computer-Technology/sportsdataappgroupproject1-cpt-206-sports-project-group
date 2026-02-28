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
    public partial class ChooseDatabase : Form
    {
        public ChooseDatabase()
        {
            InitializeComponent();
        }

        private void ChooseDatabase_Load(object sender, EventArgs e)
        {
            comboBoxSport.Items.Add("Football (NFL)");
            comboBoxSport.Items.Add("Basketball (NBA)");

            comboBoxDatabase.Items.Add("Player Stats");
            comboBoxDatabase.Items.Add("Team Standings");
            comboBoxDatabase.Items.Add("Match Results & Upcoming Games");
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSport.SelectedIndex == 0) // Football (NFL) selection
                {
                    if (comboBoxDatabase.SelectedIndex == 0)
                    {
                        // Open NFL Player Stats form
                        NFLPlayerStats nflPlayerStats = new NFLPlayerStats();
                        nflPlayerStats.ShowDialog();
                    }
                    else if (comboBoxDatabase.SelectedIndex == 1)
                    {
                        // Open NFL Team Standings form
                        NFLTeamStandingsForm1 nflTeamStandingsForm1 = new NFLTeamStandingsForm1();
                        nflTeamStandingsForm1.ShowDialog();
                    }
                    else if (comboBoxDatabase.SelectedIndex == 2)
                    {
                        // Open NFL Upcoming Games and Match Results form
                        NFL_UpcomingGames_MatchResults nflMatchUpcoming = new NFL_UpcomingGames_MatchResults();
                        nflMatchUpcoming.ShowDialog();
                    }
                    else
                    {
                        // Error is no database type is selected
                        MessageBox.Show("Please Select a Database Type");
                    }
                }
                else if (comboBoxSport.SelectedIndex == 1) // Basketball (NBA) selection
                {
                    if (comboBoxDatabase.SelectedIndex == 0)
                    {
                        // Open NBA Player Stats form
                        NBAPlayerStats nbaPlayerStats = new NBAPlayerStats();
                        nbaPlayerStats.ShowDialog();
                    }
                    else if (comboBoxDatabase.SelectedIndex == 1)
                    {
                        // Open NBA Team Standings form
                        NBATeamStandings nBATeamStandings = new NBATeamStandings();
                        nBATeamStandings.ShowDialog();
                    }
                    else if (comboBoxDatabase.SelectedIndex == 2)
                    {
                        // Open NBA Upcoming Games and Match Results form
                        NBA_UpcomingGames_MatchResults nbaTeamStandings = new NBA_UpcomingGames_MatchResults();
                        nbaTeamStandings.ShowDialog();
                    }
                    else
                    {
                        // Error displayed if user does not select a database type
                        MessageBox.Show("Please Select a Database Type");
                    }
                }
                else
                {
                    // Error displayed if user does not select a sport
                    MessageBox.Show("Please Select a Sport");
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
    
        }
    }
}
