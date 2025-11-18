using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class Autor : Biblioteca
    {
        public string nombreAutor { get; set; }
        public string pais { get; set; }
        public string fechaNacimiento { get; set; }

        public Autor(string nombreAutor, string pais, string fechaNacimiento)
        {
            this.nombreAutor = nombreAutor;
            this.pais = pais;
            this.fechaNacimiento = fechaNacimiento;
        }

        public Autor()
        {
            
        }
    }
}
