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
    public partial class NBAMatchResults : Form
    {
        public NBAMatchResults()
        {
            InitializeComponent();
        }

        private void nBA_Match_Results_DataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nBA_Match_Results_DataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nBA_NFL_Match_Results_DataDataSet1);

        }

        private void NBAMatchResults_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nBA_NFL_Match_Results_DataDataSet1.NBA_Match_Results_Data' table. You can move, or remove it, as needed.
            this.nBA_Match_Results_DataTableAdapter.Fill(this.nBA_NFL_Match_Results_DataDataSet1.NBA_Match_Results_Data);

        }
    }
}
