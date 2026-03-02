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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }
        // method to enable different help messages for different forms
        public void ShowHelp(string formName)
        {
            //panels need to be hidden
            pnlNBATeamStandings.Visible = false;
            pnlNFLTeamStandings.Visible = false;

            //activate pnl depending on form 
            switch (formName)
            {
                case "NBA":
                    pnlNBATeamStandings.Visible = true;
                    break;
                case "NFL":
                    pnlNFLTeamStandings.Visible = true;
                    break;
                default:
                    MessageBox.Show("No help available for this form.");
                    break;
            }
        }
        private void HelpForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.pro-football-reference.com/") { UseShellExecute = true });
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.footballdb.com/games/previews.html?yr=2025&wk=1&type=reg") { UseShellExecute = true });

        }
    }
}
