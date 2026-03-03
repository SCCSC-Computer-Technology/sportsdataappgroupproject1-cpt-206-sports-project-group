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
            nba_playerstats_2024DataGridView.DataError += dataGridView1_DataError;
        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string playerName=textBox1.Text;
            nba_playerstats_2024TableAdapter.FillBySearchPlayer(sportsProjectDBDataSet.nba_playerstats_2024, playerName);
        }
        // hi :)
    }
}
