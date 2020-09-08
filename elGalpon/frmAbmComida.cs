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
    public partial class frmAbmComida : Form
    {
        public frmAbmComida()
        {
            InitializeComponent();
        }

        private void btnCancelar(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtDescripcion.Clear();
            txtObservacion.Clear();
            this.Close();
        }
    }
}
