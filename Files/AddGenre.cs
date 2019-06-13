using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TimeMoneyController.frmStart;

namespace TimeMoneyController
{
    public partial class frmAddGenre : Form
    {
        public frmAddGenre()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmAddGame fnp = new frmAddGame();
            Hide();
            fnp.ShowDialog();
            Close();
        }
      

        private void btnmulti_Click(object sender, EventArgs e)
        {
            frmAddFormel fnp = new frmAddFormel();
            Hide();
            fnp.ShowDialog();
            Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            NewGameFunk startFunktion = new NewGameFunk();
            decimal V = decimal.Parse(lblmulti.Text);
            startFunktion.CreateFormel(V,txtGenre.Text, LoginInfo.UserEmail);
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtMoney.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtMoney.Text = txtMoney.Text.Remove(txtMoney.Text.Length - 1);
            }
            if (txtMoney.Text !=""&& txtTime.Text !=""&& txtMoney.Text != "0" && txtTime.Text != "0")
            {
                decimal d = decimal.Parse(txtMoney.Text);
                decimal c = decimal.Parse(txtTime.Text);
                decimal M = d / c;
                lblmulti.Text = M.ToString();
            }

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTime.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtTime.Text = txtTime.Text.Remove(txtTime.Text.Length - 1);
            }
            if (txtMoney.Text != "" && txtTime.Text != "" && txtMoney.Text != "0" && txtTime.Text != "0")
            {
                decimal d = decimal.Parse(txtMoney.Text);
                decimal c = decimal.Parse(txtTime.Text);
                decimal M = d / c;
                lblmulti.Text = M.ToString();
            }

        }
    }
}
