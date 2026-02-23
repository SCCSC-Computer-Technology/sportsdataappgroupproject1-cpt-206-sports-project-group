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
    public partial class NFLMatchResults : Form
    {
        public NFLMatchResults()
        {
            InitializeComponent();
        }

        private void nFL_Match_Results_DataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nFL_Match_Results_DataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nBA_NFL_Match_Results_DataDataSet);

        }

        private void NFLMatchResults_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nBA_NFL_Match_Results_DataDataSet.NFL_Match_Results_Data' table. You can move, or remove it, as needed.
            this.nFL_Match_Results_DataTableAdapter.Fill(this.nBA_NFL_Match_Results_DataDataSet.NFL_Match_Results_Data);

        }
    }
}
