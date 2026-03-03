using SportsDataApplication.TMMM.SportsProjectDBDataSetTableAdapters;
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
    public partial class NBAPlayerStats : Form
    {
        public NBAPlayerStats()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // close NBA player stats form
            this.Close();
        }

        private void NBAPlayerStats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.nba_playerstats_2024' table. You can move, or remove it, as needed.
            this.nba_playerstats_2024TableAdapter.Fill(this.sportsProjectDBDataSet.nba_playerstats_2024);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string playerName=textBox1.Text;
            nba_playerstats_2024TableAdapter.FillBySearchPlayer(sportsProjectDBDataSet.nba_playerstats_2024, playerName);
        }

        // Uses combo boxes and switches to sort the dataGridView.
        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSort.SelectedIndex != -1)
                {
                    if (comboBoxSortType.SelectedIndex == 0)
                    {
                        switch (comboBoxSort.SelectedIndex)
                        {
                            case 0:
                                nba_playerstats_2024TableAdapter.FillByTeamASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 1:
                                nba_playerstats_2024TableAdapter.FillByPositionASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 2:
                                nba_playerstats_2024TableAdapter.FillByThreePointASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 3:
                                nba_playerstats_2024TableAdapter.FillByTwoPointASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 4:
                                nba_playerstats_2024TableAdapter.FillByTotalReboundsASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 5:
                                nba_playerstats_2024TableAdapter.FillByAssistASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 6:
                                nba_playerstats_2024TableAdapter.FillByStealASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 7:
                                nba_playerstats_2024TableAdapter.FillByBlockASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 8:
                                nba_playerstats_2024TableAdapter.FillByPointsASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                        }
                    }
                    else if (comboBoxSortType.SelectedIndex == 1)
                    {
                        switch (comboBoxSort.SelectedIndex)
                        {
                            case 0:
                                nba_playerstats_2024TableAdapter.FillByTeamDESC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 1:
                                nba_playerstats_2024TableAdapter.FillByPositionDESC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 2:
                                nba_playerstats_2024TableAdapter.FillByThreePointDESC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 3:
                                nba_playerstats_2024TableAdapter.FillByTwoPointsDESC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 4:
                                nba_playerstats_2024TableAdapter.FillByTotalReboundsDESC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 5:
                                nba_playerstats_2024TableAdapter.FillByAssistDESC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 6:
                                nba_playerstats_2024TableAdapter.FillByStealsDESC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 7:
                                nba_playerstats_2024TableAdapter.FillByBlocksDESC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 8:
                                nba_playerstats_2024TableAdapter.FillByTotalPointsDESC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                        }
                    }
                    else
                    {
                        //Message that shows if they didnt select a sorting method
                        MessageBox.Show("Please select ASC or DESC to choose sorting method.");
                    }
                }
                else
                {
                    //Message that shows if they didnt select a column to sort by
                    MessageBox.Show("Please select the column you want to sort by.");
                }
            }
            catch
            {
                MessageBox.Show("There was and error please try again.");
            }
        }
    }
}
