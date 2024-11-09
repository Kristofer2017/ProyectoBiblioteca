using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    internal class Prestamo : Biblioteca
    {
        public string fechaPrestamo { get; set; }
        public string fechaDevolucion { get; set; }
        public string estadoPrestamo { get; set; }
        public double multa { get; set; }
        public int idUsuario { get; set; }
        public int idLibro { get; set; }
    }
}
