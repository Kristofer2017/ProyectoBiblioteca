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
    public partial class NuevoPrestamo : Form
    {
        public NuevoPrestamo()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();

        private void actualizarDGV()
        {
            dgvUsuario.DataSource = t.consultar("Usuario");
            dgvLibro.DataSource = t.consultar("Libro");
        }

        private double calcularTarifa(DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            int diasPrestados = (fechaDevolucion.Date - fechaPrestamo.Date).Days;

            return (diasPrestados <= 5) ? 0 : (diasPrestados - 5) * 1;
        }

        public void actualizarResumenPrestamo()
        {
            lblUsuario.Text = dgvUsuario.SelectedRows[0].Cells[1].Value.ToString();
            lblLibro.Text = dgvLibro.SelectedRows[0].Cells[2].Value.ToString();
            lblFechaPrestamo.Text = dtpFechaPrestamo.Text;
            lblFechaDevolucion.Text = dtpFechaDevolucion.Text;
            lblTarifa.Text = "$" + calcularTarifa(dtpFechaPrestamo.Value, dtpFechaDevolucion.Value).ToString();
        }

        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            actualizarDGV();
            actualizarResumenPrestamo();
        }

        private void cbxCantidadDias_CheckedChanged(object sender, EventArgs e)
        {
            nudCantidadDias.Enabled = cbxCantidadDias.Checked;
            nudCantidadDias.Value = 0;
            dtpFechaDevolucion.Enabled = !cbxCantidadDias.Checked;
        }

        private void dtpFechaPrestamo_ValueChanged(object sender, EventArgs e)
        {
            actualizarResumenPrestamo();
        }

        private void dtpFechaDevolucion_ValueChanged(object sender, EventArgs e)
        {
            actualizarResumenPrestamo();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizarResumenPrestamo();
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();

            prestamo.fechaPrestamo = dtpFechaPrestamo.Value.Date.ToString("yyyy-MM-dd");
            prestamo.fechaDevolucion = dtpFechaDevolucion.Value.Date.ToString("yyyy-MM-dd");
            prestamo.estadoPrestamo = "Prestado";
            prestamo.multa = calcularTarifa(dtpFechaPrestamo.Value, dtpFechaDevolucion.Value);
            prestamo.idUsuario = int.Parse(dgvUsuario.SelectedRows[0].Cells[0].Value.ToString());
            prestamo.idLibro = int.Parse(dgvLibro.SelectedRows[0].Cells[0].Value.ToString());

            if (t.insertar(prestamo))
            {
                MessageBox.Show("Los datos fueron insertados con exito!");
            }
            else
            {
                MessageBox.Show("Error! datos no insertados");
            }
        }
    }
}
