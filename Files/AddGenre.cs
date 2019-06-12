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
    }
}
