﻿using PlantillaInicioProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantillaInicioProyecto
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        public MainForm(Usuario usu, LoginForm loginForm)
        {
            InitializeComponent();
            lblUsIngresado.Text = "Usuario ingresado: " + usu.NombreDeUsuario;
            this.loginForm = loginForm;
        }

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM - HH:mm:ss");
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm.Close();
        }
    }
}
