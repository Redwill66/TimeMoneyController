using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeMoneyController
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }
        public static class LoginInfo
        {
           
            public static string UserEmail;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister fnp = new frmRegister();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin fnp = new frmLogin();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate fnp = new frmUpdate();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnEintrag_Click(object sender, EventArgs e)
        {
            frmAddGame fnp = new frmAddGame();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnRang_Click(object sender, EventArgs e)
        {
            frmRangliste fnp = new frmRangliste();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            frmSpieleintragveraendern fnp = new frmSpieleintragveraendern();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            Playerfunk PFunktion = new Playerfunk();

            lbltest.Text = "Willkommen "+LoginInfo.UserEmail;
        }
    }
}
