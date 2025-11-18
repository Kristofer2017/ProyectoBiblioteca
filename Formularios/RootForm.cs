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
    public partial class RootForm : Form
    {
        private SignIn frmSignIn;
        private Home frmHome;

        public RootForm()
        {
            InitializeComponent();

            // Hacer invisible el MainForm
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.Opacity = 0;

            // Inicializar los formularios
            frmSignIn = new SignIn();
            frmHome = new Home();

            // Suscribir eventos
            frmSignIn.LoginSuccess += OnLoginSuccess;
            frmHome.Logout += OnLogout;

            // Mostrar inicialmente el formulario de SignIn
            ShowSignInForm();
        }

        private void ShowSignInForm()
        {
            frmHome.Hide();
            frmSignIn.LimpiarCampos();
            frmSignIn.Show();
        }

        private void ShowHomeForm()
        {
            frmSignIn.Hide();
            frmHome.ActualizarHomeForm();
            frmHome.Show();
        }

        private void OnLoginSuccess(object sender, EventArgs e)
        {
            ShowHomeForm();
        }

        private void OnLogout(object sender, EventArgs e)
        {
            ShowSignInForm();
        }

        // Manejo del cierre de la aplicacion
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            var result = MessageBox.Show(
                "¿Estás seguro de que deseas salir de la aplicación?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre si selecciona No
            }
            else
            {
                Application.Exit(); // Terminar la aplicación
            }
            
        }
    }
}
