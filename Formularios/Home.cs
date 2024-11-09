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
using System.Windows.Forms;

namespace ProyectoBiblioteca
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            NuevoLibro formAgregarLibro = new NuevoLibro();
            formAgregarLibro.Show();
            this.Hide();
        }
    }
}
