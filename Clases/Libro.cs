using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    internal class Libro : Biblioteca
    {
        public string isbn { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string genero { get; set; }
        public string fechaPublicacion { get; set; }
        public double precio { get; set; }
        public int inventario { get; set; }
        public string estado { get; set; }
        public int idEditorial { get; set; }
        public int idAutor { get; set; }
    }
}
