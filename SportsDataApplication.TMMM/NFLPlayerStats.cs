using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

            //If statement selects Normal season and ensures they chose a stat type. The switch sets the dataTable variable with the Table name.
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

                //This portion creates a new connection, a new adapter, and a new datatable and then fills the datatable with the correct info.
                        string query = $"SELECT * FROM {dataTable}";
                        using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.SportsProjectDBConnectionString))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView1.DataSource = dt;
                            dataGridView1.DataError += dataGridView1_DataError; //negates the throwing of an exception for one of the columns.
                    //These if statements hide the specified columns.         
                    if (dataGridView1.Columns.Contains("SSMA_TimeStamp"))
                            {
                                dataGridView1.Columns["SSMA_TimeStamp"].Visible = false;
                            }
                    if (dataGridView1.Columns.Contains("Awards"))
                    {
                        dataGridView1.Columns["Awards"].Visible = false;
                    }
                    if (dataGridView1.Columns.Contains("#NAME?"))
                    {
                        dataGridView1.Columns["#NAME?"].Visible = false;
                    }
                }
               

            }
            //If statement selects Playoffs and ensures they chose a stat type. The switch sets the dataTable variable with the Table name.
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
                //This portion creates a new connection, a new adapter, and a new datatable and then fills the datatable with the correct info.
                string query = $"SELECT * FROM {dataTable}";
                        using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.SportsProjectDBConnectionString))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView1.DataSource = dt;
                            dataGridView1.DataError += dataGridView1_DataError; //negates the throwing of an exception for one of the columns.
                      //These if statements hide the specified columns
                    if (dataGridView1.Columns.Contains("SSMA_TimeStamp"))
                             {
                                dataGridView1.Columns["SSMA_TimeStamp"].Visible = false;
                             }
                    if (dataGridView1.Columns.Contains("Awards"))
                    {
                        dataGridView1.Columns["Awards"].Visible = false;
                    }
                    if (dataGridView1.Columns.Contains("#NAME?"))
                    {
                        dataGridView1.Columns["#NAME?"].Visible = false;
                    }
                }
                
            }
            else //Displays error message if both combo boxes arent selected.
            {
                MessageBox.Show("Please select options from both drop down menus to see stats.");
            }
    
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnSearchPlayer_Click(object sender, EventArgs e)
        {
            string dataTable = "";
            string playerName = txtBoxSearchPlayer.Text;

            //If statement selects Normal Season and ensures they chose a stat type. The switch sets the dataTable variable with the Table name.
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
                //This if statement specifies that if the Normal Season Scoring Stats are displayed it still allows for search due to the first row not containing column names.
                if (comBoxStatViewOption.SelectedIndex == 7&&comboBoxPlayoffSelection.SelectedIndex==0)
                {
                    string query = $"SELECT * FROM {dataTable} WHERE F2 LIKE @F2";//Sql Statement to search Player Names

                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.SportsProjectDBConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@F2", "%" + playerName + "%"); // playerName is your variable

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);

                                dataGridView1.DataSource = dt;
                                dataGridView1.DataError += dataGridView1_DataError;//negates the throwing of an exception for one of the columns.
                                //These if statements hide the specified columns
                                if (dataGridView1.Columns.Contains("SSMA_TimeStamp"))
                                {
                                    dataGridView1.Columns["SSMA_TimeStamp"].Visible = false;
                                }
                                if (dataGridView1.Columns.Contains("Awards"))
                                {
                                    dataGridView1.Columns["Awards"].Visible = false;
                                }
                                if (dataGridView1.Columns.Contains("#NAME?"))
                                {
                                    dataGridView1.Columns["#NAME?"].Visible = false;
                                }
                            }
                        }
                    }
                }
                else
                {
                    string query = $"SELECT * FROM {dataTable} WHERE Player LIKE @Player";

                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.SportsProjectDBConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Player", "%"+playerName+"%"); // playerName is your variable

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);

                                dataGridView1.DataSource = dt;
                                dataGridView1.DataError += dataGridView1_DataError;//negates the throwing of an exception for one of the columns.
                                //These if statements hide the specified columns
                                if (dataGridView1.Columns.Contains("SSMA_TimeStamp"))
                                {
                                    dataGridView1.Columns["SSMA_TimeStamp"].Visible = false;
                                }
                                if (dataGridView1.Columns.Contains("Awards"))
                                {
                                    dataGridView1.Columns["Awards"].Visible = false;
                                }
                                if (dataGridView1.Columns.Contains("#NAME?"))
                                {
                                    dataGridView1.Columns["#NAME?"].Visible = false;
                                }
                            }
                        }
                    }
                }
            }
            //If statement selects Playoffs and ensures they chose a stat type. The switch sets the dataTable variable with the Table name.
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
               //Search query for players for the playoffs tables.
                    string query = $"SELECT * FROM {dataTable} WHERE Player LIKE @Player";

                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.SportsProjectDBConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Player", "%" + playerName + "%"); // playerName is your variable

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);

                                dataGridView1.DataSource = dt;
                                dataGridView1.DataError += dataGridView1_DataError;//negates the throwing of an exception for one of the columns.
                             //These if statements hide the specified columns
                            if (dataGridView1.Columns.Contains("SSMA_TimeStamp"))
                                {
                                    dataGridView1.Columns["SSMA_TimeStamp"].Visible = false;
                                }
                                if (dataGridView1.Columns.Contains("Awards"))
                                {
                                    dataGridView1.Columns["Awards"].Visible = false;
                                }
                                if (dataGridView1.Columns.Contains("#NAME?"))
                                {
                                    dataGridView1.Columns["#NAME?"].Visible = false;
                                }
                            }
                        }
                    }
                }
            else//Displays error message if both combo boxes arent selected.
            {
                MessageBox.Show("Please select options from both drop down menus to see stats.");
            }
        }
    }
}
