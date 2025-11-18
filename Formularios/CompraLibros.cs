using ProyectoBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca.Formularios
{
    public partial class CompraLibros : Form
    {
        public CompraLibros()
        {
            InitializeComponent();
        }

        Transacciones t = new Transacciones();

        private void CompraLibros_Load(object sender, EventArgs e)
        {
            DataTable tablaProveedores = t.consultar("Proveedor");

            string[] listaProveedores = tablaProveedores.AsEnumerable()
                                      .Select(row => row.Field<string>("nombre_proveedor"))
                                      .ToArray();
            cmbProveedores.DataSource = listaProveedores;
            cmbProveedores.SelectedIndex = 0;
        }

        private int idPorNombre(string nombre, string tabla, string campoNombreBD)
        {
            try
            {
                return int.Parse(t.consultar(tabla, campoNombreBD, nombre).Rows[0]["id"].ToString());
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();

            compra.fechaCompra = DateTime.Today.ToString();
            compra.cantidadLibros = (int) numInvetario.Value;
            compra.totalCompra = AdministrarLibros.precioLibro * (int)numInvetario.Value;
            compra.idLibro = AdministrarLibros.idLibro;
            compra.idProveedor = idPorNombre(cmbProveedores.SelectedItem.ToString(), "Proveedor", "nombre_proveedor");

            if (t.insertar(compra))
            {
                MessageBox.Show("La compra ha sido realizada con exito!" +
                    $"\nEl total de su compra es ${compra.totalCompra}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Quitamos las unidades vendidas de nuestro inventario
                t.actualizarInventario(compra.idLibro, AdministrarLibros.inventario + compra.cantidadLibros);

                this.Close();
            }
        }
    }
}
