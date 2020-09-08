using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elGalpon
{
    public partial class frmAbmReserva : Form
    {
        public frmAbmReserva()
        {
            InitializeComponent();
        }

        private void btnCancelar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
