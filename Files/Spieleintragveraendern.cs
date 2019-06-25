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
    public partial class frmSpieleintragveraendern : Form
    {
        public frmSpieleintragveraendern()
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
        bool vor= false;
        bool vor2 = false;
        private void txtName_TextChanged(object sender, EventArgs e)
        {
          
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
                R = Ti / P * F * 2;
            }
            else if (rdounhappy.Checked)
            {
                happy = "Schlecht";
                R = Ti / P * F / 2;
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
            startFunktion.UpdateEi(txtName.Text, P, T, LoginInfo.UserEmail, trbPoints.Value, R, chkfin.Checked, happy);
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            NewGameFunk startFunktion = new NewGameFunk();
            vor = startFunktion.GameCheck(txtName.Text);
            vor2 = startFunktion.GameCheck2(txtName.Text,LoginInfo.UserEmail);
            if (vor == true)
            {
                if (vor2 == true)
                {
                    txtName.BackColor = Color.Green;
                    vor = false;
                    vor2 = false;
                }
                else
                {
                    txtName.BackColor = Color.Yellow;
                    vor = false;
                }
               
            }
           else
            {
                txtName.BackColor = Color.Red;
            }
        }

        private void frmSpieleintragveraendern_Load(object sender, EventArgs e)
        {
            NewGameFunk startFunktion = new NewGameFunk();
         

            DataTable dt2 = startFunktion.LoadGenre(LoginInfo.UserEmail);
            cboGenre.DisplayMember = "Genre";
            cboGenre.DataSource = dt2;
            lblmulti.Text = startFunktion.Multipli(LoginInfo.UserEmail, cboGenre.Text);
        }

        private void lblhelp1_Click(object sender, EventArgs e)
        {

        }

     

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewGameFunk startFunktion = new NewGameFunk();
            lblmulti.Text = startFunktion.Multipli(LoginInfo.UserEmail, cboGenre.Text);
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {

        }

        private void lblGenre_Click(object sender, EventArgs e)
        {

        }

        private void lblFormel_Click(object sender, EventArgs e)
        {

        }

        private void trbPoints_Scroll_1(object sender, EventArgs e)
        {
            lblPoints.Text = trbPoints.Value.ToString();
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
