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
    public partial class RegistroInvitado : Form
    {
        public event EventHandler LoginSuccess;

        public RegistroInvitado()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();
        public Usuario nuevoInvitado { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txtNombreInvitado.Text == "")
            {
                MessageBox.Show("Ingresa tu nombre por favor!");
            }
            else
            {
                nuevoInvitado = new Usuario(txtNombreInvitado.Text, "", "", 1);

                t.insertar(nuevoInvitado);

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            
        }
    }
}
