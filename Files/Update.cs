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

namespace TimeMoneyController
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(txtEmail.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email.");
            }
            Regex regex2 = new Regex(@"(?=^[^\s]{6,}$)(?=.*\d)(?=.*[a-zA-Z])");
            bool isValid2 = regex2.IsMatch(txtPassw.Text.Trim());
            if (!isValid2)
            {
                MessageBox.Show("Invalid Password.");
            }
            else if (txtPassw.Text != txtPasswwie.Text)
            {
                MessageBox.Show("Ungleiches Passwort");

            }
            else if (isValid2 && isValid  && txtPasswwie.Text != null && txtPassw.Text != null && txtEmail.Text != null && txtSurname.Text != null && txtName.Text != null)
            {
                Playerfunk startFunktion = new Playerfunk();
             //   startFunktion.Update(txtName.Text, txtSurname.Text, LoginInfo.UserEmail, txtEmail.Text, txtPassw.Text, txtMon.Text, txtDie.Text, txtMit.Text, txtDon.Text, txtFri.Text, txtPensum.Text);
           //     lblsucess.Text = "User erfolgreich bearbeitet";
             //   LoginInfo.UserEmail = txtEmail.Text;
            }
            else
            {
                MessageBox.Show("Bitte füllen sie die Felder aus oder geben sie ein anderes Email oder Passwort");
            }
        }
    }
}
