﻿using System;
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
    public partial class frmGestionar : Form
    {
        public frmGestionar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCambiarUsuario form = new FrmCambiarUsuario();
            form.ShowDialog();
        }
    }
}
