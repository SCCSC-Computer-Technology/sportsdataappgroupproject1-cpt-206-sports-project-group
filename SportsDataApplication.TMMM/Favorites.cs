using SportsDataApplication.TMMM.Sign_InDataSetTableAdapters;
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
    public partial class Favorites : Form
    {
        public Favorites()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string nflTeam = txtBoxFavNFLTeam.Text;
                string nflPlayer = txtBoxFavNFLPlayer.Text;
                string nbaTeam = txtBoxFavNBATeam.Text;
                string nbaPlayer = txtBoxFavNBAPlayer.Text;

                var adapter = new userFavsTableAdapter();
                if (!string.IsNullOrWhiteSpace(txtBoxFavNBAPlayer.Text))
                {
                    adapter.UpdateNBAPlayer(txtBoxFavNBAPlayer.Text, Session.Username);
                }

                if (!string.IsNullOrWhiteSpace(txtBoxFavNFLPlayer.Text))
                {
                    adapter.UpdateNFLPlayer(txtBoxFavNFLPlayer.Text, Session.Username);
                }

                if (!string.IsNullOrWhiteSpace(txtBoxFavNBATeam.Text))
                {
                    adapter.UpdateNBATeam(txtBoxFavNBATeam.Text, Session.Username);
                }

                if (!string.IsNullOrWhiteSpace(txtBoxFavNFLTeam.Text))
                {
                    adapter.UpdateNFLTeam(txtBoxFavNFLTeam.Text, Session.Username);
                }
                else
                {
                    adapter.UpdateFavorites(nbaPlayer, nflPlayer, nbaTeam, nflTeam, Session.Username);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }

        private void Favorites_Load(object sender, EventArgs e)
        {
            var adapter = new userFavsTableAdapter();
            int count = (int)adapter.ValidateUser(Session.Username);
            if (count ==0)
            {
                adapter.AddUser(Session.Username);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
