using ProyectoBiblioteca.Clases;
using ProyectoBiblioteca.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace ProyectoBiblioteca
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();
        public event EventHandler Logout;
        private void Home_Load(object sender, EventArgs e) => ActualizarHomeForm();

        public void ActualizarHomeForm()
        {
            tabPrincipal.ItemSize = new Size(0, 1); // Ocultar pestañas del Tab Control

            if (SignIn.usuarioIngreso != null)
            {
                lblTituloBienvenida.Text = $"Bienvenido! {SignIn.usuarioIngreso.nombreUsuario}";

                // Seleccionar la pestaña correcta, en base al usuario que ingresa
                switch (SignIn.usuarioIngreso.idRol)
                {
                    case 1: tabPrincipal.SelectedIndex = 2; break; // Invitado
                    case 2: tabPrincipal.SelectedIndex = 1; break; // Usuario
                    case 3: tabPrincipal.SelectedIndex = 0; break; // Administrador
                }
            }
        }


        // Botones Administrador
        private void btnLibros_Click(object sender, EventArgs e)
        {
            using(AdministrarLibros frmLibro = new AdministrarLibros())
            {
                frmLibro.ShowDialog();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            using (AdministrarUsuarios frmUsuarios = new AdministrarUsuarios())
            {
                frmUsuarios.ShowDialog();
            }
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            using(AdministrarPrestamos prestamos = new AdministrarPrestamos())
            {
                prestamos.ShowDialog();
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            using (AdministrarProveedores frmProveedores = new AdministrarProveedores())
            {
                frmProveedores.ShowDialog();
            }
        }

        private void btnComprasVentas_Click(object sender, EventArgs e)
        {
            using(AdministrarComprasVentas frmComprasVentas =  new AdministrarComprasVentas())
            {
                frmComprasVentas.ShowDialog();
            }
        }

        // Botones de Usuario
        private void btnComprar_Click(object sender, EventArgs e)
        {
            using (UsuarioVenta frmVenta = new UsuarioVenta())
            {
                frmVenta.ShowDialog();
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            using (UsuarioPrestar frmPrestar = new UsuarioPrestar())
            {
                frmPrestar.ShowDialog();
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            using(ReporteLibros reporteLibros = new ReporteLibros())
            {
                reporteLibros.ShowDialog();
            }
        }

        private void btnVerLibros_Click(object sender, EventArgs e)
        {
            using (InvitadoVerLibros frmLibrosInv = new InvitadoVerLibros())
            {
                frmLibrosInv.ShowDialog();
            }
        }

        // Logout y form closing
        private void btnLogout_Click(object sender, EventArgs e)
        {
            SignIn.usuarioIngreso = null;

            Logout?.Invoke(this, EventArgs.Empty);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
