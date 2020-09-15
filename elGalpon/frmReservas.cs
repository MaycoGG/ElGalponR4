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
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();

            
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            //Carga de grilla con reservas
            ReservasBus reservasBus = new ReservasBus();
            var reservas = reservasBus.SelectAllReservas();
            //setGridParameters();
            dgvReservas.DataSource = reservas.Return;
            
            //dgvReservas.Rows[0].Cells[0].Value = "Juan Perez";
            //dgvReservas.Rows[0].Cells[1].Value = "10/10/2020";
            //dgvReservas.Rows[0].Cells[2].Value = "20:00";
            //dgvReservas.Rows[0].Cells[3].Value = "4";
            //dgvReservas.Rows[0].Cells[4].Value = "Mesa 2";
            //dgvReservas.Rows[0].Cells[5].Value = "Frente al tv";

            //dgvReservas.Rows.Add("Juan Perez", "19/12/2018", "21:00", "5", "Mesa 3", "Tu vieja");

            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dgvReservas.Columns.Add(btn);
            //btn.Text = "Boton";
            //btn.Name = "";
            //btn.UseColumnTextForButtonValue = true;
            //dgvReservas.ClearSelection();
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
                dgvReservas.ClearSelection();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            frmAbmReserva frm = new frmAbmReserva();
            frm.ShowDialog();
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Carga de grilla con reservas
            ReservasBus reservasBus = new ReservasBus();
            var reservas = reservasBus.SelectReservasByFecha(DateTime.Parse(dtpFecha.Text));
            setGridParameters();
            dgvReservas.DataSource = reservas.Return;
        }

        public void setGridParameters()
        {
            dgvReservas.Columns[0].Name = "Id";
            dgvReservas.Columns[0].HeaderText = "Id";
            dgvReservas.Columns[0].DataPropertyName = "Id";
            dgvReservas.Columns[0].Visible = false;

            dgvReservas.Columns[1].HeaderText = "Fecha";
            dgvReservas.Columns[1].Name = "Fecha";
            dgvReservas.Columns[1].DataPropertyName = "Fecha";

            dgvReservas.Columns[2].HeaderText = "Desde";
            dgvReservas.Columns[2].Name = "HoraDesde";
            dgvReservas.Columns[2].DataPropertyName = "HoraDesde";

            dgvReservas.Columns[3].HeaderText = "Hasta";
            dgvReservas.Columns[3].Name = "HoraHasta";
            dgvReservas.Columns[3].DataPropertyName = "HoraHasta";

            dgvReservas.Columns[4].HeaderText = "Mesa";
            dgvReservas.Columns[4].Name = "IdMesa";
            dgvReservas.Columns[4].DataPropertyName = "IdMesa";

            dgvReservas.Columns[5].HeaderText = "Nombre";
            dgvReservas.Columns[5].Name = "Nombre";
            dgvReservas.Columns[5].DataPropertyName = "Nombre";
            dgvReservas.Columns[5].Visible = false;

            dgvReservas.Columns[6].HeaderText = "Apellido";
            dgvReservas.Columns[6].Name = "Apellido";
            dgvReservas.Columns[6].DataPropertyName = "Apellido";
            dgvReservas.Columns[6].Visible = false;

            dgvReservas.Columns[7].HeaderText = "Personas";
            dgvReservas.Columns[7].Name = "CantidadPersonas";
            dgvReservas.Columns[7].DataPropertyName = "CantidadPersonas";

            dgvReservas.Columns[8].HeaderText = "Obs.";
            dgvReservas.Columns[8].Name = "Observaciones";
            dgvReservas.Columns[8].DataPropertyName = "Observaciones";

            dgvReservas.Columns[9].HeaderText = "Estado";
            dgvReservas.Columns[9].Name = "Estado";
            dgvReservas.Columns[9].DataPropertyName = "Estado";

            dgvReservas.Columns[10].HeaderText = "Denominacion";
            dgvReservas.Columns[10].Name = "Denominacion";
            dgvReservas.Columns[10].DataPropertyName = "Denominacion";
            dgvReservas.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
