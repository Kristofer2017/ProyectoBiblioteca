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
            checkPassword.Checked = false;
        }

        private bool camposVacios()
        {
            return string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContra.Text);
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            using(RegistroInvitado frmInvitado = new RegistroInvitado())
            {
                DialogResult resultado = frmInvitado.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    usuarioIngreso = frmInvitado.nuevoInvitado;

                    LoginSuccess?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Registro frmRegistro = new Registro())
            {
                DialogResult resultado = frmRegistro.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = !checkPassword.Checked;
        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
