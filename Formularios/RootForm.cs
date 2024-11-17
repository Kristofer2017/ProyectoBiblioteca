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
            // Mostrar el cuadro de confirmación
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
                // Cierra cualquier formulario hijo si está abierto o oculto
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm != this)
                    {
                        openForm.Close();
                    }
                }

                Application.Exit(); // Finaliza la aplicación correctamente
            }
        }
    }
}
