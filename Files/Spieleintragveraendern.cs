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
    }
}
