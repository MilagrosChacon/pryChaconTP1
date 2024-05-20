using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryChaconTP1
{
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
        }

        private void btnQuenaken_Click(object sender, EventArgs e)
        {
            frmLocalQuenaken localQuenaken = new frmLocalQuenaken();
            localQuenaken.ShowDialog();
        }
    }
}
