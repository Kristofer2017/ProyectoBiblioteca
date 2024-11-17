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
    public partial class SignIn : Form
    {
        public event EventHandler LoginSuccess;

        public SignIn()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();
        public static Usuario usuarioIngreso { get; set; }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (camposVacios())
            {
                DialogResult result = MessageBox.Show(
                    "Por favor ingrese su usuario y contraseña",
                    "Campos vacíos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string usuario = txtUsuario.Text;
            string contrasena = txtContra.Text;

            usuarioIngreso = t.iniciarSesion(usuario, contrasena);

            if (usuarioIngreso != null)
            {
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "El Usuario o Contraseña son incorrectos",
                    "Credenciales Incorrectas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void LimpiarCampos()
        {
            txtUsuario.Text = string.Empty;
            txtContra.Text = string.Empty;
        }

        private bool camposVacios()
        {
            return string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContra.Text);
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            using(NombreInvitado frmInvitado = new NombreInvitado())
            {
                frmInvitado.ShowDialog();
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Registro frmRegistro = new Registro())
            {
                frmRegistro.ShowDialog();
            }
        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* Mostrar el cuadro de confirmación
            var result = MessageBox.Show(
                "¿Estás seguro de que deseas salir de la aplicación?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre si el usuario selecciona "No"
            }
            else
            {
                Application.Exit(); // Finaliza la aplicación correctamente
            }*/
        }
    }
}
