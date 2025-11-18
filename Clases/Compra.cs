using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    internal class Compra : Biblioteca
    {
        public string fechaCompra { get; set; }
        public int cantidadLibros { get; set; }
        public double totalCompra { get; set; }
        public int idProveedor { get; set; }
        public int idLibro { get; set; }

        public Compra(string fechaCompra, int cantidadLibros, double totalCompra, int idProveedor, int idLibro)
        {
            this.fechaCompra = fechaCompra;
            this.cantidadLibros = cantidadLibros;
            this.totalCompra = totalCompra;
            this.idProveedor = idProveedor;
            this.idLibro = idLibro;
        }

        public Compra()
        {
            
        }
    }
}
