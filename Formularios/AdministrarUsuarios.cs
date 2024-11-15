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
using TextBox = System.Windows.Forms.TextBox;

namespace ProyectoBiblioteca.Formularios
{
    public partial class AdministrarUsuarios : Form
    {
        public AdministrarUsuarios()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();
        Usuario u = new Usuario();
        private int id_usuario;

        private void actualizarDVG()
        {
            dgvUsuarios.DataSource = t.consultar("Usuario");
        }

        private bool camposLlenos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && textBox.Name != "txtId" && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos");
                    return false;
                }
            }

            if (cmbRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rol");
                return false;
            }

            return true;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[1].Value.ToString();
            txtUsuario.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[2].Value.ToString();
            txtContrasena.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[3].Value.ToString();

            // Le restamos 1 porque el combobox tiene indexs de 0, 1 y 2 y los ids de rol son 1, 2 y 3
            cmbRoles.SelectedIndex = int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[4].Value.ToString()) - 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!camposLlenos())
            {
                return;
            }
            
            
            Usuario u = new Usuario();

            u.nombreUsuario = txtNombre.Text;
            u.usuario = txtUsuario.Text;
            u.contrasenia = txtContrasena.Text;
            u.idRol = cmbRoles.SelectedIndex + 1;


            if (t.insertar(u))
            {
                MessageBox.Show("Usuario agregado exitosamente.");
                actualizarDVG();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario.");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!camposLlenos())
            {
                return;
            }


            Usuario u = new Usuario();

            u.id = int.Parse(txtId.Text);
            u.nombreUsuario = txtNombre.Text;
            u.usuario = txtUsuario.Text;
            u.contrasenia = txtContrasena.Text;
            u.idRol = cmbRoles.SelectedIndex + 1;


            if (t.modificar(u))
            {
                MessageBox.Show("Usuario modificado exitosamente.");
                actualizarDVG();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modificar el usuario.");
            }
        }

        private void limpiarCampos()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            cmbRoles.SelectedIndex = -1;
        }

        private void AdministrarUsuarios_Load_1(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '●';
            actualizarDVG();

            // Llenando dropdown/combobox con roles
            cmbRoles.Items.Add("Invitado");
            cmbRoles.Items.Add("Usuario");
            cmbRoles.Items.Add("Administrador");
        }

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            t.eliminar("Usuario", "id", txtId.Text);

            actualizarDVG();
            limpiarCampos();
        }



        

        

        private void AdministrarUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Al usar la funcion hide del home, no se cierra este formulario
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
