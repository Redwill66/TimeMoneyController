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
    public partial class frmAddGame : Form
    {
        public frmAddGame()
        {
            InitializeComponent();
        }

        private void trbPoints_Scroll(object sender, EventArgs e)
        {
            lblPoints.Text = trbPoints.Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStart fnp = new frmStart();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnplatt_Click(object sender, EventArgs e)
        {
            frmAddPlatt fnp = new frmAddPlatt();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            frmAddGenre fnp = new frmAddGenre();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void frmAddGame_Load(object sender, EventArgs e)
        {
            NewGameFunk startFunktion = new NewGameFunk();
            DataTable dt = startFunktion.LoadPlatt();
            cboPlattform.DisplayMember = "Plattform";
            cboPlattform.DataSource = dt;
            DataTable dt2 = startFunktion.LoadGenre(LoginInfo.UserEmail);
            cboGenre.DisplayMember = "Genre";
            cboGenre.DataSource = dt2;
            lblmulti.Text= startFunktion.Multipli(LoginInfo.UserEmail, cboGenre.Text);

        }

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewGameFunk startFunktion = new NewGameFunk();
            lblmulti.Text = startFunktion.Multipli(LoginInfo.UserEmail, cboGenre.Text);
        }
    }
}
