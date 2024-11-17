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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProyectoBiblioteca
{
    public partial class Home : Form
    {
        public event EventHandler Logout;

        public Home()
        {
            InitializeComponent();
        }
        
        Transacciones t = new Transacciones();

        private void Home_Load(object sender, EventArgs e)
        {
            if (SignIn.usuarioIngreso != null)
            {
                // Titulo, ocultar tabs y selecionar ventana del rol
                lblTituloBienvenida.Text += SignIn.usuarioIngreso.nombreUsuario;

                tabPrincipal.ItemSize = new Size(0, 1);

                switch (SignIn.usuarioIngreso.idRol)
                {
                    case 1: tabPrincipal.SelectedIndex = 2; break;
                    case 2: tabPrincipal.SelectedIndex = 1; break;
                    case 3: tabPrincipal.SelectedIndex = 0; break;
                }
            }

            actualizarDGVs();

            lblErrorMsj.Text = string.Empty;
            /*
            lblDescripcion.Text = string.Format(
                "\nISBN: {0}" +
                "\nNombre del libro: {1}" +
                "\nAutor: {2}" +
                "\nEditorial: {3}" +
                "\nGenero: {4}" +
                "\nFecha Publicación: {5}" +
                "\nDescripción: {6}" +
                "\nPrecio: {7}");
            */
        }

        private void actualizarDGVs()
        {
            dgvLibrosUsuarios.DataSource = t.consultarLibrosUsuarios();
            dgvLibrosInvitados.DataSource = t.consultarLibrosUsuarios();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            using(LibrosAdmin frmLibro = new LibrosAdmin())
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
            using(Prestamos prestamos = new Prestamos())
            {
                prestamos.ShowDialog();
            }
        }

        

        private void btnCompras_Click(object sender, EventArgs e)
        {

        }

        private void dgvLibrosUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvLibrosUsuarios.Rows[dgvLibrosUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Borramos el usuario que inicio sesion
            SignIn.usuarioIngreso = null;

            Logout?.Invoke(this, EventArgs.Empty);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
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
