using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    internal class Autor : Biblioteca
    {
        public string nombreAutor { get; set; }
        public string pais { get; set; }
        public string fechaNacimiento { get; set; }
    }
}
