using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    internal class Compra : Biblioteca
    {
        public DateTime fechaCompra { get; set; }
        public double montoCompra { get; set; }
        public int idUsuario { get; set; }
        public int idLibro { get; set; }
    }
}
