using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TimeMoneyController.frmStart;

namespace TimeMoneyController
{
    public partial class frmRangliste : Form
    {
        public frmRangliste()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStart fnp = new frmStart();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void frmRangliste_Load(object sender, EventArgs e)
        {
            NewGameFunk startFunktion = new NewGameFunk();
            DataTable Grid3 = startFunktion.Grid(LoginInfo.UserEmail);
            dgvRang.DataSource = Grid3;
            lblmaxT.Text= startFunktion.MaXT(LoginInfo.UserEmail) + " Stunden";
            lblAvgT.Text = startFunktion.AvgT(LoginInfo.UserEmail) + " Stunden";
            lblGPSS.Text = startFunktion.BilanzPlayer(LoginInfo.UserEmail) + " Stunden pro Franken";
            lblMaxK.Text = startFunktion.MaXM(LoginInfo.UserEmail) + " Franken";
            lblDA.Text = startFunktion.AvgM(LoginInfo.UserEmail) + " Franken";
            lblAS.Text = startFunktion.CGame(LoginInfo.UserEmail) + " Spieleinträge";
        }

        private void lblmaxT_Click(object sender, EventArgs e)
        {

        }

        private void lblAvgT_Click(object sender, EventArgs e)
        {

        }

        private void lblGPSS_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxK_Click(object sender, EventArgs e)
        {

        }

        private void lblAS_Click(object sender, EventArgs e)
        {

        }
    }
}
