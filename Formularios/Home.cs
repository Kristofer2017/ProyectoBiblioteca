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

namespace ProyectoBiblioteca
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();


        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            Prestamos prestamos = new Prestamos();
            prestamos.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AdministrarUsuarios frmUsuarios = new AdministrarUsuarios();
            frmUsuarios.Show();
            this.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void actualizarDGVs()
        {
            dgvLibrosUsuarios.DataSource = t.consultarLibrosUsuarios();
            dgvLibrosInvitados.DataSource = t.consultarLibrosUsuarios();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label3.Select();

            if (FSignIn.usuarioIngreso != null)
            {
                lblTituloBienvenida.Text += FSignIn.usuarioIngreso.nombreUsuario;

                tabPrincipal.ItemSize = new Size(0, 1);

                tabPrincipal.SelectedIndex = 1;

                switch (FSignIn.usuarioIngreso.idRol)
                {
                    case 1:
                        tabPrincipal.SelectedIndex = 2;
                        break;
                    case 2:
                        tabPrincipal.SelectedIndex = 1;
                        break;
                    case 3:
                        tabPrincipal.SelectedIndex = 0;
                        break;
                }
            }
            
            actualizarDGVs();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FSignIn.usuarioIngreso = null;

            FSignIn fSignIn = new FSignIn();
            fSignIn.Show();
            this.Hide();
        }

        private void dgvLibrosUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLibrosUsuarios.Rows[dgvLibrosUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
        }
    }
}
