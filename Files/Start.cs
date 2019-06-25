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
           // lblLog.Text = "Willkommen" + " " + LoginInfo.UserEmail;
            if (LoginInfo.UserEmail != null)
            {
                btnLogin.Enabled = false;
                btnRegister.Enabled = false;
                btnUpdate.Enabled = true;
                btnEintrag.Enabled = true;
                btnRang.Enabled = true;
                btnchange.Enabled = true;
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnUpdate.Visible = true;
                btnlogout.Enabled = true;
                btnlogout.Visible = true;
            }

            lbltest.Text = "Willkommen "+LoginInfo.UserEmail;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginInfo.UserEmail = null;
            lblLog.Text = "Willkommen" + " " + LoginInfo.UserEmail;
            btnLogin.Enabled = true;
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
            btnEintrag.Enabled = false;
            btnRang.Enabled = false;
            btnchange.Enabled = false;
            btnLogin.Visible = true;
            btnRegister.Visible = true;
            btnUpdate.Visible = false;
            btnlogout.Enabled = false;
            btnlogout.Visible = false;
        }
    }
}
