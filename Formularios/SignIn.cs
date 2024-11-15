using ProyectoBiblioteca.Clases;
using ProyectoBiblioteca.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBiblioteca
{
    public partial class FSignIn : Form
    {
        public FSignIn()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();
        public static Usuario usuarioIngreso { get; set; }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (camposVacios())
            {
                MessageBox.Show("Debe ingresar usuario y contraseña");
                return;
            }

            string usuario = txtUsuario.Text;
            string contrasena = txtContra.Text;

            usuarioIngreso = t.iniciarSesion(usuario, contrasena);

            if (usuarioIngreso != null)
            {
                Home formInicio = new Home();
                formInicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválidos!");
            }
        }

        private bool camposVacios()
        {
            return string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContra.Text);
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            NombreInvitado frmInvitado = new NombreInvitado();
            frmInvitado.ShowDialog();
        }

        private void FSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea salir de la aplicación?",
                "Confirmar cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro frmRegistro = new Registro();
            frmRegistro.ShowDialog();
        }
    }
}
