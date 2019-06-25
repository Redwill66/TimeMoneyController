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
    public partial class frmAddPlatt : Form
    {
        public frmAddPlatt()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
        //    frmAddGame fnp = new frmAddGame();
            Hide();
           // fnp.ShowDialog();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewGameFunk startFunktion = new NewGameFunk();
          
            startFunktion.AddPlatt( txtplatt.Text);
        }

        private void txtplatt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
