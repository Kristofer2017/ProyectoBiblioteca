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
    public partial class AdministrarEditoriales : Form
    {
        public string idEditorialSeleccionado { get; set; }

        public AdministrarEditoriales()
        {
            InitializeComponent();

            idEditorialSeleccionado = "";
        }
        
        Transacciones t = new Transacciones();

        private void actualizarDGV()
        {
            dgvEditoriales.DataSource = t.consultar("Editorial");
        }

        private void limpiarCampos()
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        private bool editorialSeleccionada()
        {
            return txtID.Text.Length > 0;
        }

        private bool camposLLenos()
        {
            return txtNombre.Text.Length > 0 && txtDireccion.Text.Length > 0;
        }

        private void Editoriales_Load(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (editorialSeleccionada())
            {
                MessageBox.Show("Debes limpiar los campos antes de agregar una nueva editorial");
                return;
            }

            if (!camposLLenos())
            {
                MessageBox.Show("Debes llenar todos los campos");
                return;
            }

            Editorial editorial = new Editorial(
                txtNombre.Text,
                txtDireccion.Text
            );

            if (t.insertar(editorial))
            {
                MessageBox.Show("Editorial agregado exitosamente.");
                actualizarDGV();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el Editorial.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!editorialSeleccionada())
            {
                MessageBox.Show("Debes seleccionar una editorial");
                return;
            }

            if (!camposLLenos())
            {
                MessageBox.Show("Debes llenar todos los campos");
                return;
            }

            Editorial editorial = new Editorial(
                txtNombre.Text,
                txtDireccion.Text
            );

            editorial.id = int.Parse(txtID.Text);

            if (t.modificar(editorial))
            {
                MessageBox.Show("Editorial modificada exitosamente.");
                actualizarDGV();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modificar Editorial.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!editorialSeleccionada())
            {
                MessageBox.Show("Debes seleccionar una editorial");
                return;
            }

            if (t.eliminar("Editorial", "id", txtID.Text))
            {
                MessageBox.Show("Editorial eliminado exitosamente.");
                actualizarDGV();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el editorial.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnSeleccionarEditorial_Click(object sender, EventArgs e)
        {
            if (!editorialSeleccionada())
            {
                MessageBox.Show("Debes seleccionar una editorial");
                return;
            }

            idEditorialSeleccionado = dgvEditoriales.Rows[dgvEditoriales.CurrentRow.Index].Cells["id"].Value.ToString();

            this.Close();
        }

        private void dgvEditoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvEditoriales.Rows[dgvEditoriales.CurrentRow.Index].Cells["id"].Value.ToString();
            txtNombre.Text = dgvEditoriales.Rows[dgvEditoriales.CurrentRow.Index].Cells["nombre_editorial"].Value.ToString();
            txtDireccion.Text = dgvEditoriales.Rows[dgvEditoriales.CurrentRow.Index].Cells["direccion"].Value.ToString();
        }
    }
}
