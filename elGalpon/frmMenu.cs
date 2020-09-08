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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        //Si no hay nada escrito en el txt vuelvo a poner el texto por defecto
        private void txtBuscarNom_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarNom.Text))
                txtBuscarNom.Text = "Buscar por Nombre";
        }

        //al hacerle click borro el texto por defecto
        private void txtBuscarNom_Enter(object sender, EventArgs e)
        {
            if (txtBuscarNom.Text== "Buscar por Nombre")
                txtBuscarNom.Clear();
        }

        private void btnAgregar(object sender, EventArgs e)
        {
            frmAbmMenu frm = new frmAbmMenu();
            frm.ShowDialog();
        }

        private void txtBuscarNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
