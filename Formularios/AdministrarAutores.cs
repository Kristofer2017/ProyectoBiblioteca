using ProyectoBiblioteca.Clases;
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
    public partial class AdministrarAutores : Form
    {
        public string idAutorSeleccionado { get; set; }

        public AdministrarAutores()
        {
            InitializeComponent();

            idAutorSeleccionado = "";
        }

        Transacciones t = new Transacciones();

        private void actualizarDGV()
        {
            dgvAutores.DataSource = t.consultar("Autor");
        }

        private void limpiarCampos()
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPais.Text = string.Empty;
            dtpFechaNac.Value =  DateTime.Now;
        }

        private bool libroSeleccionado()
        {
            return txtID.Text.Length > 0;
        }

        private bool camposLLenos()
        {
            return txtNombre.Text.Length > 0 && txtPais.Text.Length > 0;
        }

        private void Autores_Load(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (libroSeleccionado())
            {
                MessageBox.Show("Debes limpiar los campos antes de agregar un nuevo Autor");
                return;
            }

            if (!camposLLenos())
            {
                MessageBox.Show("Debes llenar todos los campos");
                return;
            }

            Autor autor = new Autor(
                txtNombre.Text,
                txtPais.Text,
                dtpFechaNac.Value.Date.ToString("yyyy-MM-dd")
            );

            if (t.insertar(autor))
            {
                MessageBox.Show("Autor agregado exitosamente.");
                actualizarDGV();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el Autor.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!libroSeleccionado())
            {
                MessageBox.Show("Debes seleccionar un autor");
                return;
            }

            if (!camposLLenos())
            {
                MessageBox.Show("Debes llenar todos los campos");
                return;
            }

            Autor autor = new Autor(
                txtNombre.Text,
                txtPais.Text,
                dtpFechaNac.Value.Date.ToString("yyyy-MM-dd")
            );

            autor.id = int.Parse(txtID.Text);

            if (t.modificar(autor))
            {
                MessageBox.Show("Autor modificado exitosamente.");
                actualizarDGV();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modificar el Autor.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!libroSeleccionado())
            {
                MessageBox.Show("Debes seleccionar un autor");
                return;
            }

            if (t.eliminar("Autor", "id", txtID.Text))
            {
                MessageBox.Show("Autor eliminado exitosamente.");
                actualizarDGV();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el Autor.");
            }

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvAutores.Rows[dgvAutores.CurrentRow.Index].Cells["id"].Value.ToString();
            txtNombre.Text = dgvAutores.Rows[dgvAutores.CurrentRow.Index].Cells["nombre_autor"].Value.ToString();
            txtPais.Text = dgvAutores.Rows[dgvAutores.CurrentRow.Index].Cells["pais"].Value.ToString();
            dtpFechaNac.Text = dgvAutores.Rows[dgvAutores.CurrentRow.Index].Cells["fecha_nacimiento"].Value.ToString();
        }

        private void btnSeleccionarAutor_Click(object sender, EventArgs e)
        {
            if (!libroSeleccionado())
            {
                MessageBox.Show("Debes seleccionar un autor");
                return;
            }

            idAutorSeleccionado =dgvAutores.Rows[dgvAutores.CurrentRow.Index].Cells["id"].Value.ToString();

            this.Close();
        }
    }
}
