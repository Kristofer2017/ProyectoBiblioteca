using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class Editorial : Biblioteca
    {
        public string nombreEditorial { get; set; }
        public string direccion { get; set; }

        public Editorial(string nombreEditorial, string direccion)
        {
            this.nombreEditorial = nombreEditorial;
            this.direccion = direccion;
        }

        public Editorial()
        {
            
        }
    }
}
