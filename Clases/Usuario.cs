using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class Usuario : Biblioteca
    {
        public string nombreUsuario { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public int idRol { get; set; }

        public Usuario(string nombreUsuario, string usuario, string contrasenia, int idRol)
        {
            this.nombreUsuario = nombreUsuario;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.idRol = idRol;
        }

        public Usuario()
        {
            
        }
    }
}
