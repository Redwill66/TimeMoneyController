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
    }
}
