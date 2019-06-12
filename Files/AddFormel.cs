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
    public partial class frmAddFormel : Form
    {
        public frmAddFormel()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmAddGenre fnp = new frmAddGenre();
            Hide();
            fnp.ShowDialog();
            Close();
        }
    }
}
