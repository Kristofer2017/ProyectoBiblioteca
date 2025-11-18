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
    public partial class AdministrarCompras : Form
    {
        public AdministrarCompras()
        {
            InitializeComponent();
        }
        Transacciones t = new Transacciones();

        private void AdministrarCompras_Load(object sender, EventArgs e) => dgvCompras.DataSource = t.consultar("Compra");

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            using (ReporteCompras reporteCompras = new ReporteCompras())
            {
                reporteCompras.ShowDialog();
            }
        }
    }
}
