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
    }
}
