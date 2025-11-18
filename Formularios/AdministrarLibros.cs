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
    public partial class AdministrarLibros : Form
    {
        public AdministrarLibros()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();
        public static int idLibro = 0;
        public static int inventario = 0;
        public static double precioLibro = 0;

        private void actualizarDGV()
        {
            dgvLibros.DataSource = t.consultar("Libro");
        }

        private void LibrosAdmin_Load(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private bool libroSeleccionado()
        {
            return txtID.Text.Length > 0;
        }

        private bool camposLlenos()
        {
            return(
                txtIsbn.Text.Length > 0 &&
                txtTitulo.Text.Length > 0 &&
                txtDescripcion.Text.Length > 0 &&
                txtGenero.Text.Length > 0 &&
                txtPrecio.Text.Length > 0 &&
                txtEditorial.Text.Length > 0 &&
                txtAutor.Text.Length > 0
            );
        }

        private void limpiarCampos()
        {
            txtID.Text = string.Empty;
            txtIsbn.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtGenero.Text = string.Empty;
            dtpFechaPublic.Value = DateTime.Now;
            txtPrecio.Text = string.Empty;
            numInvetario.Value = 0;
            txtEstado.Text = string.Empty;
            txtEditorial.Text = string.Empty;
            txtAutor.Text = string.Empty;
            btnComprarLibros.Enabled = false;
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idLibro = int.Parse(dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["id"].Value.ToString());
            txtID.Text = idLibro.ToString();

            precioLibro = double.Parse(dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["precio"].Value.ToString());
            txtPrecio.Text = precioLibro.ToString();

            inventario = int.Parse(dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["inventario"].Value.ToString());
            numInvetario.Value = inventario;

            txtIsbn.Text = dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["isbn"].Value.ToString();
            txtTitulo.Text = dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["titulo"].Value.ToString();
            txtDescripcion.Text = dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["descripcion"].Value.ToString();
            txtGenero.Text = dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["genero"].Value.ToString();
            dtpFechaPublic.Text = dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["fecha_publicacion"].Value.ToString();
            
            
            txtEstado.Text = dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["estado"].Value.ToString();

            string idAutor = dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["id_autor"].Value.ToString();

            txtAutor.Text = nombrePorId(idAutor, "Autor", "nombre_autor");

            string idEditorial = dgvLibros.Rows[dgvLibros.CurrentRow.Index].Cells["id_editorial"].Value.ToString();

            txtEditorial.Text = nombrePorId(idEditorial, "Editorial", "nombre_editorial");

            btnComprarLibros.Enabled = true;
        }

        private string nombrePorId(string id, string tabla, string campoNombreBD)
        {
            try
            {
                return t.consultar(tabla, "id", id).Rows[0][campoNombreBD].ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }

        private int idPorNombre(string nombre, string tabla, string campoNombreBD)
        {
            try
            {
                return int.Parse(t.consultar(tabla, campoNombreBD, nombre).Rows[0]["id"].ToString());
            }
            catch (Exception)
            {
                return -1;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (libroSeleccionado())
            {
                MessageBox.Show("Debes limpiar el libro seleccionado");
                return;
            }

            if (!validarCampos())
            {
                return;
            }

            Libro nuevoLibro = new Libro(
                txtIsbn.Text,
                txtTitulo.Text,
                txtDescripcion.Text,
                txtGenero.Text,
                dtpFechaPublic.Value.Date.ToString("yyyy-MM-dd"),
                double.Parse(txtPrecio.Text),
                idPorNombre(txtEditorial.Text, "Editorial", "nombre_editorial"),
                idPorNombre(txtAutor.Text, "Autor", "nombre_autor")
            );

            if (t.insertar(nuevoLibro))
            {
                MessageBox.Show("Libro agregado exitosamente.");
                actualizarDGV();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el libro.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!libroSeleccionado())
            {
                MessageBox.Show("Debes seleccionar un libro");
                return;
            }

            if (!validarCampos())
            {
                return;
            }

            Libro nuevoLibro = new Libro(
                txtIsbn.Text,
                txtTitulo.Text,
                txtDescripcion.Text,
                txtGenero.Text,
                dtpFechaPublic.Value.Date.ToString("yyyy-MM-dd"),
                double.Parse(txtPrecio.Text),
                idPorNombre(txtEditorial.Text, "Editorial", "nombre_editorial"),
                idPorNombre(txtAutor.Text, "Autor", "nombre_autor")
            );

            nuevoLibro.id = int.Parse(txtID.Text);

            if (t.modificar(nuevoLibro))
            {
                MessageBox.Show("Libro modificado exitosamente.");
                actualizarDGV();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modificar el libro.");
            }
        }

        private bool validarCampos()
        {
            if (!camposLlenos())
            {
                MessageBox.Show("Debes llenar todos los campos");
                return false;
            }

            if (!esDecimalValido(txtPrecio.Text))
            {
                MessageBox.Show("El precio debe ser un valor decimal");
                return false;
            }

            return true;
        }

        private bool esDecimalValido(string decimalPositivo)
        {
            foreach (char caracter in decimalPositivo)
            {
                if (!char.IsDigit(caracter) && caracter != '.')
                {
                    return false;
                }
            }
            return true;
        }

        private void btnSelEditorial_Click(object sender, EventArgs e)
        {
            using (AdministrarEditoriales frmEditoriales = new AdministrarEditoriales())
            {
                frmEditoriales.ShowDialog();

                string nombreEditorial = nombrePorId(frmEditoriales.idEditorialSeleccionado, "Editorial", "nombre_editorial");

                if (txtEditorial.Text == "" || nombreEditorial != "")
                {
                    txtEditorial.Text = nombreEditorial;
                }
            }
        }

        private void btnSelAutor_Click(object sender, EventArgs e)
        {
            using(AdministrarAutores frmAutores = new AdministrarAutores())
            {
                frmAutores.ShowDialog();
                if (txtAutor.Text == string.Empty)
                    txtAutor.Text = nombrePorId(frmAutores.idAutorSeleccionado, "Autor", "nombre_autor");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!libroSeleccionado())
            {
                MessageBox.Show("Debes seleccionar un libro");
                return;
            }

            if (t.eliminar("Libro", "id", txtID.Text))
            {
                MessageBox.Show("Libro eliminado exitosamente.");
                actualizarDGV();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el Libro.");
            }
        }

        private void btnComprarLibros_Click(object sender, EventArgs e)
        {
            using(CompraLibros frmComprar = new CompraLibros())
            {
                frmComprar.ShowDialog();
                actualizarDGV();
                limpiarCampos();
            }
        }
    }
}
