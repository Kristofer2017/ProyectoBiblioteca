using ProyectoBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace ProyectoBiblioteca.Formularios
{
    public partial class AdministrarPrestamos : Form
    {
        public AdministrarPrestamos()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();
        public static Prestamo prestamo = new Prestamo();
        public static bool editarPrestamo = false;
        public static int limiteDias { get; set; } = 4;
        public static double tarifaPrestamo { get; set; } = 1.50;
        public static double recargoAdicional { get; set; } = 5;

        private void actualizarDGV() => dgvPrestamos.DataSource = t.consultar("Prestamo");
        private bool hayFilaSeleccionada(DataGridView dgv) => dgv.SelectedRows.Count > 0;

        private void Prestamos_Load(object sender, EventArgs e)
        {
            // Actualizamos DGV
            actualizarDGV();

            // Si nay fila seleccionada, llenamos los detalles del prestamo
            if (hayFilaSeleccionada(dgvPrestamos)) llenarTablaDetalle();

            lblRecordatorio.Text = "Recordatorio:" +
                $"\n- La tarifa de prestamo aplica a partir del dia {limiteDias + 1}." +
                $"\n- La tarifa de prestamo es ${tarifaPrestamo}." +
                $"\n- Recargo por regreso tardío: ${recargoAdicional}.";
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => limpiarTablaDetalle();
        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e) => llenarTablaDetalle();

        private void llenarPrestamo()
        {
            prestamo.id = int.Parse(dgvPrestamos.SelectedRows[0].Cells["id"].Value.ToString());
            prestamo.fechaPrestamo = dgvPrestamos.SelectedRows[0].Cells["fecha_prestamo"].Value.ToString();
            prestamo.fechaDevolucion = dgvPrestamos.SelectedRows[0].Cells["fecha_devolucion"].Value.ToString();
            prestamo.estadoPrestamo = dgvPrestamos.SelectedRows[0].Cells["estado_prestamo"].Value.ToString();
            prestamo.costo = double.Parse(dgvPrestamos.SelectedRows[0].Cells["costo_prestamo"].Value.ToString());
            prestamo.idUsuario = int.Parse(dgvPrestamos.SelectedRows[0].Cells["id_usuario"].Value.ToString());
            prestamo.idLibro = int.Parse(dgvPrestamos.SelectedRows[0].Cells["id_libro"].Value.ToString());
        }

        private void llenarTablaDetalle()
        {
            llenarPrestamo();

            lblFechaPrestamo.Text = DateTime.Parse(prestamo.fechaPrestamo).ToString("d");
            lblFechaDevolucion.Text = DateTime.Parse(prestamo.fechaDevolucion).ToString("d");
            lblTotalPrestamo.Text = "$" + prestamo.costo.ToString();
            lblEstado.Text = prestamo.estadoPrestamo;
            lblUsuario.Text = obtenerNombrePorID("Usuario", prestamo.idUsuario.ToString(), "nombre");
            lblLibro.Text = obtenerNombrePorID("Libro", prestamo.idLibro.ToString(), "titulo");

            activarBotones(true);
        }

        private void limpiarTablaDetalle()
        {
            lblFechaPrestamo.Text = "Selecciona un Prestamo";
            lblFechaDevolucion.Text = "Selecciona un Prestamo";
            lblUsuario.Text = "Selecciona un Prestamo";
            lblLibro.Text = "Selecciona un Prestamo";
            lblTotalPrestamo.Text = "Selecciona un Prestamo";
            lblEstado.Text = "Selecciona un Prestamo";

            activarBotones(false);
        }

        private void activarBotones(bool activar)
        {
            btnDevolver.Enabled = prestamo.estadoPrestamo == "Prestado";
            btnEditarPrestamo.Enabled = activar && prestamo.estadoPrestamo == "Prestado";
            btnEliminar.Enabled = activar;
        }

        // Funcion que regresa el nombre de usuario y titulo de libro a cambio del id
        private string obtenerNombrePorID(string tabla, string id, string campoNombreBD)
        {
            try
            {
                return t.consultar(tabla, "id", id).Rows[0][campoNombreBD].ToString();
            }
            catch (Exception)
            {
                return ""; // Si po rejemplo no se econtro el id, se regresa una cadena vacia
            }
        }

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            using (NuevoPrestamo frmNuevoPrestamo = new NuevoPrestamo())
            {
                DialogResult resultado = frmNuevoPrestamo.ShowDialog();

                if (resultado == DialogResult.OK) actualizarDGV();
            }
        }

        private void btnEditarPrestamo_Click(object sender, EventArgs e)
        {
            if (!hayFilaSeleccionada(dgvPrestamos)) return;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!hayFilaSeleccionada(dgvPrestamos)) return;

            DialogResult result = MessageBox.Show("¿Esta seguro de querer eliminar el prestamo?", "Elmininar Prestamo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (t.eliminar("Prestamo", "id", prestamo.id.ToString()))
                {
                    if (prestamo.estadoPrestamo == "Prestado") devolverAlInventario();
                    limpiarTablaDetalle();
                    actualizarDGV();
                }
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (!hayFilaSeleccionada(dgvPrestamos)) return;

            DialogResult result = MessageBox.Show("¿Desea marcar el libro como devuelto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (verificarRecargoAdicinal())
                {
                    result = MessageBox.Show("¿Desea aplicar el recargo adicional de $5.00 por entrega tardía?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) aplicarRecargo();
                }

                prestamo.estadoPrestamo = "Devuelto";
                prestamo.fechaDevolucion = DateTime.Today.ToString();

                devolverAlInventario();
                t.modificar(prestamo);

                actualizarDGV();
                limpiarTablaDetalle();
            }
        }

        private void aplicarRecargo() => prestamo.costo += 5;
        private bool verificarRecargoAdicinal() => !(DateTime.Parse(prestamo.fechaDevolucion).Date >= DateTime.Today);

        private void devolverAlInventario()
        {
            DataTable libro = t.consultar("Libro", "id", prestamo.idLibro.ToString());
            int inventario = int.Parse(libro.Rows[0]["inventario"].ToString());

            inventario++; // Devolvemos el libro al inventario

            t.actualizarInventario(prestamo.idLibro, inventario);
        }
    }
}
