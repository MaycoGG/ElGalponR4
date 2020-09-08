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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmCaja frm = new frmCaja();
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
        Boolean local = true;
        private void btnLocal_Click(object sender, EventArgs e)
        {
            local = !local;
            if (local)
                btnLocal.BackColor=Color.FromArgb(54, 52, 53);
            else
                btnLocal.BackColor = Color.FromArgb(167, 156, 150);
        }
        Boolean pedido = true;
        private void btnPedido_Click(object sender, EventArgs e)
        {
            pedido = !pedido;
            if (pedido)
                btnPedido.BackColor = Color.FromArgb(54, 52, 53);
            else
                btnPedido.BackColor = Color.FromArgb(167, 156, 150);
        }

        
        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducto.Text))
                txtProducto.Text = "Producto";
        }

        private void txtProducto_Enter(object sender, EventArgs e)
        {
            if (txtProducto.Text == "Producto")
                txtProducto.Clear();
        }
       
    }
}
