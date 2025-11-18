using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    internal class Proveedor : Biblioteca
    {
        public string nombreProveedor { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }

        public Proveedor(string nombreProveedor, string telefono, string email, string direccion)
        {
            this.nombreProveedor = nombreProveedor;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
        }

        public Proveedor()
        {
            
        }
    }
}
