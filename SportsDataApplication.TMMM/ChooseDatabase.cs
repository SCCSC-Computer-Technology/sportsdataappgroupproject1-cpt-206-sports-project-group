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
            comboBoxDatabase.Items.Add("Match Results");
            comboBoxDatabase.Items.Add("Upcoming Games");
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSport.SelectedIndex == 0)
                {
                    if (comboBoxDatabase.SelectedIndex == 0)
                    {
                        NFLPlayerStats nflPlayerStats = new NFLPlayerStats();
                        nflPlayerStats.ShowDialog();
                    }
                    else if (comboBoxDatabase.SelectedIndex == 1)
                    {
                        NFLTeamStandingsForm1 nflTeamStandingsForm1 = new NFLTeamStandingsForm1();
                        nflTeamStandingsForm1.ShowDialog();
                    }
                    else if (comboBoxDatabase.SelectedIndex == 2)
                    {
                        NFLMatchResults nflMatchResults = new NFLMatchResults();
                        nflMatchResults.ShowDialog();
                    }
                    else if (comboBoxDatabase.SelectedIndex == 3)
                    {
                        NFL_UpcomingGames_MatchResults nflUpcomingGames = new NFL_UpcomingGames_MatchResults();
                        nflUpcomingGames.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please Select a Database Type");
                    }
                }
                else if (comboBoxSport.SelectedIndex == 1)
                {
                    if (comboBoxDatabase.SelectedIndex == 0)
                    {
                        NBAPlayerStats nbaPlayerStats = new NBAPlayerStats();
                        nbaPlayerStats.ShowDialog();
                    }
                    else if (comboBoxDatabase.SelectedIndex == 1)
                    {
                        //BasketBallStats basketBallStats = new BasketBallStats();
                        //basketBallStats.ShowDialog();
                    }
                    else if (comboBoxDatabase.SelectedIndex == 2)
                    {
                        NBAMatchResults nbaMatchResults = new NBAMatchResults();
                        nbaMatchResults.ShowDialog();
                    }
                    else if (comboBoxDatabase.SelectedIndex == 3)
                    {
                        NBA_UpcomingGames_MatchResults nbaUpcomingGames = new NBA_UpcomingGames_MatchResults();
                        nbaUpcomingGames.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please Select a Database Type");
                    }
                }
                else
                {
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
