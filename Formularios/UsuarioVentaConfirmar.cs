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

namespace ProyectoBiblioteca.Formularios
{
    public partial class UsuarioVentaConfirmar : Form
    {
        public UsuarioVentaConfirmar()
        {
            InitializeComponent();
        }
        
        Transacciones t = new Transacciones();
        LibrosUnion libro = UsuarioVenta.libro;
        private double calcularTotal() => (libro.precio * (int) numCantidadLibros.Value);

        private void ComprarLibro_Load(object sender, EventArgs e)
        {
            lblIsbn.Text = libro.isbn;
            lblNombreLibro.Text = libro.titulo;
            lblAutor.Text = libro.autor;
            lblPrecio.Text = "$" + libro.precio;
            lblInvetario.Text = libro.inventario.ToString();
            lblTotalCompra.Text = "$" + libro.precio;
        }

        private void numCantidadLibros_ValueChanged(object sender, EventArgs e)
        {
            lblTotalCompra.Text = "$" + calcularTotal();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if ((int) numCantidadLibros.Value > libro.inventario)
            {
                MessageBox.Show("No hay suficiente inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Venta venta = new Venta();

                venta.fechaVenta = DateTime.Today.ToString();
                venta.cantidadLibros = (int) numCantidadLibros.Value;
                venta.totalVenta = calcularTotal();
                venta.idLibro = libro.id;
                venta.idUsuario = SignIn.usuarioIngreso.id;

                if (t.insertar(venta))
                {
                    MessageBox.Show("La venta ha sido completada con exito!" +
                        $"\nEl total de su compra es ${venta.totalVenta}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Quitamos las unidades vendidas de nuestro inventario
                    t.actualizarInventario(venta.idLibro, libro.inventario - venta.cantidadLibros);

                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
