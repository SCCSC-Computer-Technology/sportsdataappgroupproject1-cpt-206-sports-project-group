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

        private void nba_playerstats_2024BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nba_playerstats_2024BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportsProjectDBDataSet);

        }

        private void nba_playerstats_2024BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.nba_playerstats_2024BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportsProjectDBDataSet);

        }

        private void nba_playerstats_2024BindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.nba_playerstats_2024BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportsProjectDBDataSet);

        }

        private void NBAPlayerStats_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.nba_playerstats_2024' table. You can move, or remove it, as needed.
            this.nba_playerstats_2024TableAdapter.Fill(this.sportsProjectDBDataSet.nba_playerstats_2024);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string playerName = textBox1.Text;
            nba_playerstats_2024TableAdapter.FillBySearchPlayer(sportsProjectDBDataSet.nba_playerstats_2024, playerName);
        }

        private void nba_playerstats_2024BindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.nba_playerstats_2024BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportsProjectDBDataSet);

        }

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
                                nba_playerstats_2024TableAdapter.FillByPositonASC(sportsProjectDBDataSet.nba_playerstats_2024);
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
                                nba_playerstats_2024TableAdapter.FillByStealsASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 7:
                                nba_playerstats_2024TableAdapter.FillByBlocksASC(sportsProjectDBDataSet.nba_playerstats_2024);
                                break;
                            case 8:
                                nba_playerstats_2024TableAdapter.FillByTotalPointsASC(sportsProjectDBDataSet.nba_playerstats_2024);
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
                        MessageBox.Show("Please select ASC or DESC to choose sorting method.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select the column you want to sort by.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Create the form and pass the "key" for the help info
            HelpForm helpForm = new HelpForm("NBAPlayerStat");

            // Show the form as a modal dialog (prevents clicking the main form until closed)
            helpForm.ShowDialog();
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
