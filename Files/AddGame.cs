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
          //  Hide();
            fnp.ShowDialog();
           // Close();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            frmAddGenre fnp = new frmAddGenre();
          //  Hide();
            fnp.ShowDialog();
          //  Close();
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
        string happy;
        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal R;
            decimal P = decimal.Parse(txtPrice.Text);
            int T = int.Parse(txtTime.Text);
            decimal Ti = decimal.Parse(txtTime.Text);
            decimal F = decimal.Parse(lblmulti.Text);
            if (rdohappy.Checked)
            {
                happy = "Gut";
                 R =  Ti/P * F*2;
            }
            else if (rdounhappy.Checked)
            {
                happy = "Schlecht";
                 R = Ti / P * F/2;
            }
            else if (rdososo.Checked)
            {
                happy = "Ok";
                 R = Ti / P * F;
            }
            else
            {
                happy = "Nothing";
                 R = Ti / P * F;
            }
           
            NewGameFunk startFunktion = new NewGameFunk();
            startFunktion.CreateGame(txtName.Text,cboGenre.Text);
            startFunktion.CreateGame2(txtName.Text, cboPlattform.Text);

            startFunktion.CreateGame3(txtName.Text, P, T, LoginInfo.UserEmail, trbPoints.Value, R, chkfin.Checked,happy);
            startFunktion.UpdateBill(LoginInfo.UserEmail);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
