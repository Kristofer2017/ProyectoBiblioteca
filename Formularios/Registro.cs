﻿using ProyectoBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca.Formularios
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();

        private bool camposLlenos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && textBox.Name != "txtId" && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos");
                    return false;
                }
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rol");
                return false;
            }

            return true;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Add("Usuario"); // Combo box: 0 --> BD: 2
            cmbRol.Items.Add("Administrador"); //Combo box: 1 --> BD: 3
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (!camposLlenos())
            {
                return;
            }

            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.nombreUsuario = txtNombre.Text;
            nuevoUsuario.usuario = txtUsuario.Text;
            nuevoUsuario.contrasenia = txtContrasena.Text;
            nuevoUsuario.idRol = cmbRol.SelectedIndex + 2;

            if (t.insertar(nuevoUsuario))
            {
                MessageBox.Show("Usuario registrado con exito");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
