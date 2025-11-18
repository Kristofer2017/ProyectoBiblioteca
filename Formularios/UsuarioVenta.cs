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
    public partial class UsuarioVenta : Form
    {
        public UsuarioVenta()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();
        public static LibrosUnion libro = new LibrosUnion();

        string[] criteriosBusqueda = new string[] { "ID", "ISBN", "Titulo", "Autor", "Editorial" };

        private void actualizarDGV() => dgvLibrosUnion.DataSource = t.consultar();
        private bool hayFilaSeleccionada() => dgvLibrosUnion.SelectedRows.Count > 0;
        private void activarBotones(bool activar) => btnComprar.Enabled = activar && libro.estado == "Disponible";
        private void dgvLibrosUnion_CellClick(object sender, DataGridViewCellEventArgs e) => llenarTablaDetalle();

        private void UsuarioCompra_Load(object sender, EventArgs e)
        {
            actualizarDGV();
            if (hayFilaSeleccionada()) llenarTablaDetalle();
            cmbOpcionBusqueda.DataSource = criteriosBusqueda;
            cmbOpcionBusqueda.SelectedIndex = 2;
        }

        private void llenarLibro()
        {
            libro.id = int.Parse(dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["id"].Value.ToString());
            libro.isbn = dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["isbn"].Value.ToString();
            libro.titulo = dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["titulo"].Value.ToString();
            libro.descripcion = dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["descripcion"].Value.ToString();
            libro.genero = dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["genero"].Value.ToString();
            libro.fechaPublicacion = dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["fecha_publicacion"].Value.ToString();
            libro.precio = double.Parse(dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["precio"].Value.ToString());
            libro.inventario = int.Parse(dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["inventario"].Value.ToString());
            libro.estado = dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["estado"].Value.ToString();
            libro.editorial = dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["nombre_editorial"].Value.ToString();
            libro.autor = dgvLibrosUnion.Rows[dgvLibrosUnion.CurrentRow.Index].Cells["nombre_autor"].Value.ToString();
        }
        
        private void llenarTablaDetalle()
        {
            llenarLibro();

            lblIsbn.Text = libro.isbn;
            lblTitulo.Text = libro.titulo;
            lblAutor.Text = libro.autor;
            lblEditorial.Text = libro.editorial;
            lblGenero.Text = libro.genero;
            lblFechaPublicacion.Text = libro.fechaPublicacion;
            lblPrecio.Text = "$" + libro.precio;
            lblDescripcion.Text = "Descripción: " + libro.descripcion;
            lblEstado.Text = libro.estado;

            if (libro.estado == "Disponible")
            {
                activarBotones(true);
                lblEstado.ForeColor = Color.Green;
            }
            else
            {
                activarBotones(false);
                lblEstado.ForeColor = Color.Red;
            }
        }

        private void limpiarTablaDetalle()
        {
            lblIsbn.Text = "Selecciona un libro...";
            lblTitulo.Text = "Selecciona un libro...";
            lblAutor.Text = "Selecciona un libro...";
            lblEditorial.Text = "Selecciona un libro...";
            lblGenero.Text = "Selecciona un libro...";
            lblFechaPublicacion.Text = "Selecciona un libro...";
            lblPrecio.Text = "Selecciona un libro...";
            lblDescripcion.Text = "Descripción";
            lblEstado.Text = "Estado";
            lblEstado.ForeColor = Color.Black;

            activarBotones(false);
        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbOpcionBusqueda.SelectedIndex == -1) return;

            string criterio = cmbOpcionBusqueda.SelectedItem.ToString().ToLower();
            string valor = txtBarraBusqueda.Text.ToLower();

            if (valor == "") actualizarDGV();
            else dgvLibrosUnion.DataSource = buscarLibro(criterio, valor);

            if (hayFilaSeleccionada()) llenarTablaDetalle();
            else limpiarTablaDetalle();
        }

        private DataTable buscarLibro(string criterio, string valor)
        {
            DataTable datosEncontrados = null;

            // Criterios de busqueda: "ID", "ISBN", "Titulo", "Autor", "Editorial"
            if (criterio == "id" || criterio == "isbn" || criterio == "titulo")
                datosEncontrados = t.consultar(campoBusqueda: $"Libro.{criterio}", valorBuscado: valor);

            if (criterio == "autor")
                datosEncontrados = t.consultar(campoBusqueda: "Autor.nombre_autor", valorBuscado: valor);

            if (criterio == "editorial")
                datosEncontrados = t.consultar(campoBusqueda: "Editorial.nombre_editorial", valorBuscado: valor);

            return datosEncontrados;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            using (UsuarioVentaConfirmar frmConfirmarVenta = new UsuarioVentaConfirmar())
            {
                frmConfirmarVenta.ShowDialog();
                actualizarDGV();
                if (hayFilaSeleccionada()) llenarTablaDetalle();
            }
        }
    }
}
