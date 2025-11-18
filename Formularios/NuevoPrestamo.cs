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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBiblioteca.Formularios
{
    public partial class NuevoPrestamo : Form
    {
        public NuevoPrestamo()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();
        Libro libro = new Libro();
        Usuario usuario = new Usuario();

        private bool eventosDeshabilitados = false;
        private bool hayFilaSeleccionada(DataGridView dgv) => dgv.SelectedRows.Count > 0;
        private bool fechasInvertidas(DateTime startDate, DateTime endDate) => startDate.Date > endDate.Date;
        private int diferenciaFechas(DateTime fecha1, DateTime fecha2) => (fecha1.Date - fecha2.Date).Days;
        private int obtenerDias(NumericUpDown num) => (int)num.Value;

        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            actualizarDGV();
            actualizarResumenPrestamo();
        }

        private void actualizarDGV()
        {
            dgvUsuario.DataSource = t.consultar("Usuario");
            dgvLibro.DataSource = t.consultar("Libro");
        }

        private void llenarVariables()
        {
            // Libro

        }
        //modificar
        //cambiar los date time pickers (resumen y numeric up down se actualizan automatiacamente)
        //seleccionar en el date time picker el autor y la contrasenia que vienen de prestamo



        public void actualizarResumenPrestamo()
        {
            if (!hayFilaSeleccionada(dgvUsuario)) return;

            lblUsuario.Text = dgvUsuario.SelectedRows[0].Cells[1].Value.ToString();
            lblLibro.Text = dgvLibro.SelectedRows[0].Cells[2].Value.ToString();

            lblFechaPrestamo.Text = dtpFechaPrestamo.Value.ToString("d");
            lblFechaDevolucion.Text = dtpFechaDevolucion.Value.ToString("d");
            lblTarifa.Text = "$" + calcularTarifa(dtpFechaPrestamo.Value, dtpFechaDevolucion.Value).ToString();
        }



        private double calcularTarifa(DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            int diasPrestado = diferenciaFechas(fechaDevolucion, fechaPrestamo);

            if (diasPrestado <= AdministrarPrestamos.limiteDias)
            {
                return 0;
            }
            else
            {
                return (diasPrestado - AdministrarPrestamos.limiteDias) * AdministrarPrestamos.tarifaPrestamo;
            }
        }

        private void checkHabilitarDias_CheckedChanged(object sender, EventArgs e)
        {
            // Habilitamos campo numero y deshabilitamos fecha
            numCantidadDias.Enabled = checkHabilitarDias.Checked;
            dtpFechaDevolucion.Enabled = !checkHabilitarDias.Checked;

            // Limpiamos los valores del prestamo
            limpiarSinActivarEventos();

            actualizarResumenPrestamo();
        }

        private void limpiarSinActivarEventos()
        {
            eventosDeshabilitados = true; // Desactiva eventos

            dtpFechaPrestamo.Value = DateTime.Now;
            dtpFechaDevolucion.Value = DateTime.Now;
            numCantidadDias.Value = 0;

            eventosDeshabilitados = false; // Reactiva eventos
        }

        private void actualizaNumericDias()
        {
            eventosDeshabilitados = true;
            numCantidadDias.Value = diferenciaFechas(dtpFechaDevolucion.Value, dtpFechaPrestamo.Value);
            eventosDeshabilitados = false;
        }

        private void numCantidadDias_ValueChanged(object sender, EventArgs e)
        {
            if (eventosDeshabilitados) return;

            dtpFechaDevolucion.Value = DateTime.Today.AddDays(obtenerDias(numCantidadDias));

            actualizarResumenPrestamo();
        }

        private void dtpFechaPrestamo_ValueChanged(object sender, EventArgs e) => eventoCambioDeFechas();
        private void dtpFechaDevolucion_ValueChanged(object sender, EventArgs e) => eventoCambioDeFechas();

        private void eventoCambioDeFechas()
        {
            if (eventosDeshabilitados) return;

            if (fechasInvertidas(dtpFechaPrestamo.Value, dtpFechaDevolucion.Value))
            {
                MessageBox.Show("Las fechas están invertidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarSinActivarEventos();
            }
            else actualizaNumericDias();

            actualizarResumenPrestamo();
        }



        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizarResumenPrestamo();
        }

        private void dgvLibro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizarResumenPrestamo();
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            if (!validarPrestamo()) return;

            Prestamo prestamo = new Prestamo();

            prestamo.fechaPrestamo = dtpFechaPrestamo.Value.Date.ToString("yyyy-MM-dd");
            prestamo.fechaDevolucion = dtpFechaDevolucion.Value.Date.ToString("yyyy-MM-dd");
            prestamo.estadoPrestamo = "Prestado";
            prestamo.costo = calcularTarifa(dtpFechaPrestamo.Value, dtpFechaDevolucion.Value);
            prestamo.idUsuario = int.Parse(dgvUsuario.SelectedRows[0].Cells[0].Value.ToString());
            prestamo.idLibro = int.Parse(dgvLibro.SelectedRows[0].Cells[0].Value.ToString());

            if (t.insertar(prestamo))
            {
                MessageBox.Show("El prestamo fue agregado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;

                quitarDelInventario(prestamo);

                this.Close();
            }
            else
            {
                MessageBox.Show("Error! no se pudo agregar el prestamo");
            }
        }

        private bool validarPrestamo()
        {
            // Hayan filas seccionadas para usuario y prestamo
            if (!hayFilaSeleccionada(dgvLibro) || !hayFilaSeleccionada(dgvUsuario))
            {
                MessageBox.Show("Debe seleccionar un usuario y un libro");
                return false;
            }

            // Se quiera prestar por 0 dias
            if (obtenerDias(numCantidadDias) == 0)
            {
                MessageBox.Show("Debe prestarse por al menos un día");
                return false;
            }

            // No haya inventario del libro
            if (int.Parse(dgvLibro.SelectedRows[0].Cells["inventario"].Value.ToString()) == 0)
            {
                MessageBox.Show("No existe inventario disponible del libro seleccionado");
                return false;
            }

            // No haya un prestamo ACTIVO (estatus "prestado") del mismo usuario al mismo libro
            string idUsuario = dgvUsuario.SelectedRows[0].Cells["id"].Value.ToString();
            string idLibro = dgvLibro.SelectedRows[0].Cells["id"].Value.ToString();

            DataTable prestamosUsuario = t.obtenerPrestamosUsuario(idUsuario, idLibro);

            if (prestamosUsuario != null)
            {
                // Si encuentra el estado de Prestado en la columna de estado_prestamo, el resultado es verdadero
                bool prestamoActivo = prestamosUsuario.AsEnumerable().Any(row => row.Field<string>("estado_prestamo") == "Prestado");

                if (prestamoActivo)
                {
                    MessageBox.Show("Ya existe un prestamo activo de ese usuario a ese libro");
                    return false;
                }
            }

            return true; // Si logro pasar todas las validaciones
        }

        private void quitarDelInventario(Prestamo prestamo)
        {
            // Obtenemos inventario de la data grid view de libro
            int inventario = int.Parse(dgvLibro.SelectedRows[0].Cells["inventario"].Value.ToString());

            inventario--; // Restamos el libro que se presta

            t.actualizarInventario(prestamo.idLibro, inventario); // Actualizamos inventario
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) this.Close(); 
        }
    }
}
