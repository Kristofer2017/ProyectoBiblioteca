using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class Venta : Biblioteca
    {
        public string fechaVenta { get; set; }
        public int cantidadLibros { get; set; }
        public double totalVenta { get; set; }
        public int idUsuario { get; set; }
        public int idLibro { get; set; }

        public Venta(string fechaVenta, int cantidadLibros, double totalVenta, int idUsuario, int idLibro)
        {
            this.fechaVenta = fechaVenta;
            this.cantidadLibros = cantidadLibros;
            this.totalVenta = totalVenta;
            this.idUsuario = idUsuario;
            this.idLibro = idLibro;
        }

        public Venta()
        {
            
        }
    }
}
