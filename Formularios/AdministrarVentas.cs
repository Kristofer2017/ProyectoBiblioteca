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
    public partial class AdministrarVentas : Form
    {
        public AdministrarVentas()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();

        private void AdministrarVentas_Load(object sender, EventArgs e) => dgvVentas.DataSource = t.consultar("Venta");

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            using(ReporteVentas reporteVentas = new ReporteVentas())
            {
                reporteVentas.ShowDialog();
            }
        }
    }
}
