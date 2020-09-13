using ElGalpon.Base.Cache;
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
using ElGalpon.Models;

namespace elGalpon
{
    public partial class LogAdmin : Form
    {
       // readonly UserBus _userBus;

        public LogAdmin()
        {
            InitializeComponent();
        }

       // public LogAdmin(UserBus userBus)
       // {
       //     _userBus = userBus;
       // }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtUser.TextLength > 2)
            {
                if (txtPass.Text != "")
                {
                    UserBus user = new UserBus();
                    var response = user.Login(txtUser.Text, txtPass.Text);
                    if (response.Ok)
                    {
                        //AbrirFormulario<frmCaja>();
                        //frmCaja frmCaja = new frmCaja();
                        //MessageBox.Show("Bienvenido " + response.Return.LoginName);
                        //frmCaja.Show();
                        //frmCaja.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError(response.GetFullErrorMessage);
                    }
                }
                else msgError("Ingresa contraseña.");
            }
            else msgError("Ingresa usuario.");
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "Contraseña";
            txtPass.UseSystemPasswordChar = false;
            txtPass.Text = "Usuario";
            lblErrorMessage.Visible = false;
            this.Show();
        }

        private void LogAdmin_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
