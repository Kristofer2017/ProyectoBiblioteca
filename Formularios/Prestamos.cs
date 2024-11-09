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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();

        private void actualizarDGV()
        {
            dgvPrestamos.DataSource = t.consultar("Prestamo");
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            NuevoPrestamo frmNuevoPrestamo = new NuevoPrestamo();
            frmNuevoPrestamo.ShowDialog();

            actualizarDGV();
        }
    }
}
