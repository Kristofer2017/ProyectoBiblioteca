using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    internal class Usuario : Biblioteca
    {
        public string nombreUsuario { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public int idRol { get; set; }
    }
}
