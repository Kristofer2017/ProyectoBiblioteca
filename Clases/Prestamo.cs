using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class Prestamo : Biblioteca
    {
        public string fechaPrestamo { get; set; }
        public string fechaDevolucion { get; set; }
        public string estadoPrestamo { get; set; }
        public double costo { get; set; }
        public int idUsuario { get; set; }
        public int idLibro { get; set; }

        public Prestamo(string fechaPrestamo, string fechaDevolucion, string estadoPrestamo, double costo, int idUsuario, int idLibro)
        {
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
            this.estadoPrestamo = estadoPrestamo;
            this.costo = costo;
            this.idUsuario = idUsuario;
            this.idLibro = idLibro;
        }

        public Prestamo()
        {
            
        }
    }
}
