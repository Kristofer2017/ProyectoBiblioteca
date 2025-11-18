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
    public partial class AdministrarProveedores : Form
    {
        public AdministrarProveedores()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();
        Proveedor p = new Proveedor();

        private bool camposLlenos()
        {
            return (
                 txtNombre.Text.Length > 0 &&
                 msktxtTelefono.Text.Length > 0 &&
                 txtEmail.Text.Length > 0 &&
                 richtxtDireccion.Text.Length > 0
                 );
        }

        private bool ProveedorSelecionado()
        {
            return txtId.Text.Length > 0;
        }
        private void actualizarDVG()
        {
            dgvProveedor.DataSource = t.consultar("Proveedor");
        }

        private void AdministrarProveedores_Load(object sender, EventArgs e)
        {
            actualizarDVG();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ProveedorSelecionado())
            {
                MessageBox.Show("Debe limpiar los campos antes de agregar un nuevo Proveedor");
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            if (!msktxtTelefono.MaskFull)
            {
                MessageBox.Show("Por Favor, Completa el numero de celular corectamente");
                msktxtTelefono.Focus();
                return;
            }

            ValidarValor(txtEmail, "email");
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                return;
            }

            Proveedor Prov = new Proveedor(
                txtNombre.Text,
                msktxtTelefono.Text,
                txtEmail.Text,
                richtxtDireccion.Text
            );

            if(t.insertar(Prov))
            {
                MessageBox.Show("Proveedor Agregado con Exito");
                actualizarDVG();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error Al agregar Nuevo Proveedor");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ProveedorSelecionado())
            {
                MessageBox.Show("Debe Seleccionar un Proveedor");
                return;
            }

            ValidarValor(txtEmail, "email");
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                return;
            }

            if (!msktxtTelefono.MaskFull)
            {
                MessageBox.Show("Por Favor, Completa el numero de celulcar corectamente");
                msktxtTelefono.Focus();
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            Proveedor Prov = new Proveedor(
                txtNombre.Text,
                msktxtTelefono.Text,
                txtEmail.Text,
                richtxtDireccion.Text
                );

            Prov.id = int.Parse(txtId.Text);

            if (t.modificar(Prov))
            {
                MessageBox.Show("Proveedor modificado exitosamente.");
                actualizarDVG();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modificar el Proveedor.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            msktxtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            richtxtDireccion.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!ProveedorSelecionado())
            {
                MessageBox.Show("Debe Seleccionar un Proveedor");
                return;
            }

            if (t.eliminar("Proveedor", "id", txtId.Text))
            {
                MessageBox.Show("Proveedor eliminado existosamente.");
                actualizarDVG();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al Eliminar el Proveedor");
            }
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells["id"].Value.ToString();   
            txtNombre.Text = dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells["nombre_proveedor"].Value.ToString();   
            msktxtTelefono.Text = dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells["telefono"].Value.ToString();   
            txtEmail.Text = dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells["email"].Value.ToString();   
            richtxtDireccion.Text = dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells["direccion"].Value.ToString();   
        }

        private bool ValidarCampos()
        {
            if (!camposLlenos())
            {
                MessageBox.Show("Debes llenar todos los campos");
                return false;
            }

            return true; 
        }

        private void ValidarValor(TextBox textBox, string tipo)
        {
            string valor = textBox.Text;

            if (tipo == "email")
            {
                try
                {
                    var mail = new System.Net.Mail.MailAddress(valor);                
                }
                catch (Exception)
                {
                    MessageBox.Show("Correo Electronico No valido");
                    textBox.Text = string.Empty;
                    textBox.Focus();
                }
            }
        }
    }
}
