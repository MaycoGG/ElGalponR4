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
    public partial class FrmCambiarUsuario : Form
    {
        public FrmCambiarUsuario()
        {
            InitializeComponent();
        }

        private void FrmCambiarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void btnAceptarUser_Click(object sender, EventArgs e)
        {
            if (txtNewUser.Text != "" && txtNewUser.TextLength > 2)
            {
                if (txtNewPass.Text != "")
                {
                    UserBus user = new UserBus();
                    var response = user.ChangeUserPassword(txtNewUser.Text, txtNewPass.Text);
                    if (response.Ok)
                    {
                        //TODO: Ver funcionamiento necesario
                        this.Hide();
                    }
                    else
                    {
                        msgError(response.GetFullErrorMessage);
                    }
                }
                else msgError("Ingresa nueva contraseña.");
            }
            else msgError("Ingresa nuevo usuario.");
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }
    }
}
