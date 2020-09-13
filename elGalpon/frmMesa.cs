using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElGalpon.Business;

namespace elGalpon
{
    public partial class frmMesa : Form
    {
        public frmMesa()
        {
            InitializeComponent();

            PersonaBus mozos = new PersonaBus();
            var lista = mozos.SelectAllMozos();
            cmbMozos.Items.Clear();
            cmbMozos.DataSource = lista.Return;
            cmbMozos.ValueMember = "Id";
            cmbMozos.DisplayMember = "Denominacion";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuMesas frm = new frmMenuMesas();
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void btnAgregar(object sender, EventArgs e)
        {
            frmAbmComida frm = new frmAbmComida();
            frm.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
