using ElGalpon.Business;
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
    public partial class frmEgresos : Form
    {
        public frmEgresos()
        {
            InitializeComponent();

            //Carga de rubro de GASTOS
            RubrosBus rubros = new RubrosBus();
            var lista = rubros.SelectAllRubrosGastos();
            cmbTipo.Items.Clear();
            cmbTipo.DataSource = lista.Return;
            cmbTipo.ValueMember = "Id";
            cmbTipo.DisplayMember = "Descripcion";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAbmEgresos frm = new frmAbmEgresos();
            frm.ShowDialog();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
