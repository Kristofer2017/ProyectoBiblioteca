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
    public partial class AdministrarComprasVentas : Form
    {
        public AdministrarComprasVentas()
        {
            InitializeComponent();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            using (AdministrarCompras frmCompras = new AdministrarCompras())
            {
                frmCompras.ShowDialog();
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            using(AdministrarVentas frmVentas = new AdministrarVentas())
            {
                frmVentas.ShowDialog();
            }
        }
    }
}
