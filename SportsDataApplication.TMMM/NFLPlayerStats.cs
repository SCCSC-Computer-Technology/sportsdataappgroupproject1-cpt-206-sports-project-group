using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SportsDataApplication.TMMM
{
    public partial class NFLPlayerStats : Form
    {
        public NFLPlayerStats()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // close NFL player stats form
            this.Close();
        }

        private void defense_Stats_Normal_SeasonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.defense_Stats_Normal_SeasonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportsProjectDBDataSet);

        }

        private void NFLPlayerStats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Scoring_stats_Playoffs' table. You can move, or remove it, as needed.
            this.scoring_stats_PlayoffsTableAdapter.Fill(this.sportsProjectDBDataSet.Scoring_stats_Playoffs);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Scoring_Stats' table. You can move, or remove it, as needed.
            this.scoring_StatsTableAdapter.Fill(this.sportsProjectDBDataSet.Scoring_Stats);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Rushing_stats_Playoff' table. You can move, or remove it, as needed.
            this.rushing_stats_PlayoffTableAdapter.Fill(this.sportsProjectDBDataSet.Rushing_stats_Playoff);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Rushing_stats' table. You can move, or remove it, as needed.
            this.rushing_statsTableAdapter.Fill(this.sportsProjectDBDataSet.Rushing_stats);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Recieving_stats_Playoffs' table. You can move, or remove it, as needed.
            this.recieving_stats_PlayoffsTableAdapter.Fill(this.sportsProjectDBDataSet.Recieving_stats_Playoffs);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Receiving_stats' table. You can move, or remove it, as needed.
            this.receiving_statsTableAdapter.Fill(this.sportsProjectDBDataSet.Receiving_stats);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Punting_stats_Playoff' table. You can move, or remove it, as needed.
            this.punting_stats_PlayoffTableAdapter.Fill(this.sportsProjectDBDataSet.Punting_stats_Playoff);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Punting_stats' table. You can move, or remove it, as needed.
            this.punting_statsTableAdapter.Fill(this.sportsProjectDBDataSet.Punting_stats);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Passing_stats_Playoff' table. You can move, or remove it, as needed.
            this.passing_stats_PlayoffTableAdapter.Fill(this.sportsProjectDBDataSet.Passing_stats_Playoff);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Passing_stats' table. You can move, or remove it, as needed.
            this.passing_statsTableAdapter.Fill(this.sportsProjectDBDataSet.Passing_stats);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Kickoff_Stats_Playoffs' table. You can move, or remove it, as needed.
            this.kickoff_Stats_PlayoffsTableAdapter.Fill(this.sportsProjectDBDataSet.Kickoff_Stats_Playoffs);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Kickoff_Normal_Season' table. You can move, or remove it, as needed.
            this.kickoff_Normal_SeasonTableAdapter.Fill(this.sportsProjectDBDataSet.Kickoff_Normal_Season);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet._Kick_Punt_Stats' table. You can move, or remove it, as needed.
            this.kick_Punt_StatsTableAdapter.Fill(this.sportsProjectDBDataSet._Kick_Punt_Stats);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet._Kick_Punt_Playoffs' table. You can move, or remove it, as needed.
            this.kick_Punt_PlayoffsTableAdapter.Fill(this.sportsProjectDBDataSet._Kick_Punt_Playoffs);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Defense_Stats_Playoffs' table. You can move, or remove it, as needed.
            this.defense_Stats_PlayoffsTableAdapter.Fill(this.sportsProjectDBDataSet.Defense_Stats_Playoffs);
            // TODO: This line of code loads data into the 'sportsProjectDBDataSet.Defense_Stats_Normal_Season' table. You can move, or remove it, as needed.
            this.defense_Stats_Normal_SeasonTableAdapter.Fill(this.sportsProjectDBDataSet.Defense_Stats_Normal_Season);

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string dataTable = "";
            if (comboBoxPlayoffSelection.SelectedIndex == 0 && comBoxStatViewOption.SelectedIndex != -1)
            {
                switch (comBoxStatViewOption.SelectedIndex)
                {
                    case 0:
                        dataTable = "[Defense Stats Normal Season]";
                        break;
                    case 1:
                        dataTable = "[Kick/Punt Stats]";
                        break;
                    case 2:
                        dataTable = "[Kickoff Normal Season]";
                        break;
                    case 3:
                        dataTable = "[Passing stats]";
                        break;
                    case 4:
                        dataTable = "[Punting Stats]";
                        break;
                    case 5:
                        dataTable = "[Receiving Stats]";
                        break;
                    case 6:
                        dataTable = "[Rushing Stats]";
                        break;
                    case 7:
                        dataTable = "[Scoring Stats]";
                        break;

                }

                        string query = $"SELECT * FROM {dataTable}";
                        using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.SportsProjectDBConnectionString))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }
                
            }
            else if (comboBoxPlayoffSelection.SelectedIndex == 1 && comBoxStatViewOption.SelectedIndex != -1)
            {
                switch (comBoxStatViewOption.SelectedIndex)
                {
                    case 0:
                        dataTable = "[Defense Stats Playoffs]";
                        break;
                    case 1:
                        dataTable = "[Kick/Punt Playoffs]";
                        break;
                    case 2:
                        dataTable = "[Kickoff Stats Playoffs]";
                        break;
                    case 3:
                        dataTable = "[Passing stats Playoff]";
                        break;
                    case 4:
                        dataTable = "[Punting stats Playoff]";
                        break;
                    case 5:
                        dataTable = "[Receiving stats Playoff]";
                        break;
                    case 6:
                        dataTable = "[Rushing stats Playoff]";
                        break;
                    case 7:
                        dataTable = "[Scoring stats Playoffs]";
                        break;

                }

                        string query = $"SELECT * FROM {dataTable}";
                        using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.SportsProjectDBConnectionString))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }
                
            }
            else
            {
                MessageBox.Show("Please select options from both drop down menus to see stats.");
            }
    
        }
    }
}
