using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class LibrosUnion : Biblioteca
    {
        public string isbn { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string genero { get; set; }
        public string fechaPublicacion { get; set; }
        public double precio { get; set; }
        public int inventario { get; set; }
        public string estado { get; set; }
        public string editorial { get; set; }
        public string autor { get; set; }

        public LibrosUnion(string isbn, string titulo, string descripcion, string genero, string fechaPublicacion, double precio, int inventario, string estado, string editorial, string autor)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.genero = genero;
            this.fechaPublicacion = fechaPublicacion;
            this.precio = precio;
            this.inventario = inventario;
            this.estado = estado;
            this.editorial = editorial;
            this.autor = autor;
        }

        public LibrosUnion()
        {
            
        }
    }
}
