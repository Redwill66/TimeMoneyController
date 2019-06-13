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
    public partial class frmLogin : Form
    {
        public frmLogin()
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
        bool isUserExisted = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(txtEmail.Text.Trim());
            if (!isValid)
            {
               // lblsucess.Text = "Ihr Email entspricht keiner bekannten Email Art";
            }
            else if (txtpass != null && txtEmail != null)
            {
                Playerfunk startFunktion = new Playerfunk();
                isUserExisted = startFunktion.Login(txtEmail.Text, txtpass.Text);
                if (isUserExisted == true)
                {

                    LoginInfo.UserEmail = txtEmail.Text;
                 // startFunktion.LoadDays(LoginInfo.UserEmail);
                //   lblsucess.Text = "Login Erfolgreich, Willkommen " + LoginInfo.UserEmail;
                }
                else
                {
                   // lblsucess.Text = "Login fehlgeschlagen, User existiert nicht oder ihr Passwort ist Falsch";
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
