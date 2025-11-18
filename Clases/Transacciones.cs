using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBiblioteca.Clases
{
    internal class Transacciones
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private string[] listaTablas;
        private string convertirFecha(string fecha) => DateTime.Parse(fecha).ToString("yyyy-MM-dd");
        string sql = "";

        public Transacciones()
        {
            conn.ConnectionString = "Integrated Security=True; Persist Security Info=False; Initial Catalog=Biblioteca; Data Source=DESKTOP-KB3LTUH\\SQLEXPRESS; User Id=root;Password=itca2024;";
            listaTablas = new string[] { "Libro", "Autor", "Editorial", "Usuario", "Rol", "Prestamo", "Venta", "Compra", "Proveedor" };
        }

        public bool ejecutarSql(string sql)
        {
            try
            {
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException error)
            {
                MessageBox.Show("ERROR: " + error.Message);
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public DataTable ejecutarConsulta(string sql, string tabla)
        {
            if (!listaTablas.Contains(tabla))
            {
                MessageBox.Show($"Error: La tabla {tabla} no existe.");
                return null;
            }

            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn.ConnectionString);
                adapter.Fill(datos);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return datos;
        }
        //named parameters
        public DataTable consultar(string tabla = "", string campoBusqueda = "", string valorBuscado = "")
        {
            if (tabla == "") // Si no recibimos tabla, consultamos la union de Libro, Editorial y Autor
            {
                tabla = "Libro";
                sql = "SELECT Libro.id,Libro.isbn,Libro.titulo,Libro.genero,Libro.fecha_publicacion,Libro.precio,Libro.inventario,Libro.estado,Libro.descripcion,Editorial.nombre_editorial,Autor.nombre_autor " +
                    "FROM Libro INNER JOIN Autor ON Libro.id_autor = Autor.id INNER JOIN Editorial ON Libro.id_editorial = Editorial.id";
            } 
            else //Sino, consultamos la tabla solicitada
                sql = $"SELECT * FROM {tabla}";

            // Si los criterios de busqueda vienen con datos, se agrega la sentencia de busqueda al SQL
            if (campoBusqueda != "" || valorBuscado != "") sql += $" WHERE {campoBusqueda} LIKE '%{valorBuscado}%'";


            return ejecutarConsulta(sql, tabla);
        }

        public DataTable obtenerPrestamosUsuario(string idUsuario = "", string idLibro = "")
        {
            sql = $"SELECT * FROM Prestamo WHERE id_usuario = {idUsuario} AND id_libro = {idLibro}";

            return ejecutarConsulta(sql, "Prestamo");
        }

        public bool insertar(Biblioteca datos)
        {
            string tabla = datos.GetType().Name;

            sql = $"INSERT INTO {tabla} VALUES ";

            switch (tabla)
            {
                case "Autor":
                    Autor a = (Autor) datos;
                    a.fechaNacimiento = convertirFecha(a.fechaNacimiento);
                    sql += string.Format("('{0}', '{1}', '{2}')",
                        a.nombreAutor, a.pais, a.fechaNacimiento);
                    break;
                case "Editorial":
                    Editorial e = (Editorial) datos;
                    sql += string.Format("('{0}', '{1}')",
                        e.nombreEditorial, e.direccion);
                    break;
                case "Libro":
                    Libro l = (Libro) datos;
                    l.fechaPublicacion = convertirFecha(l.fechaPublicacion);
                    sql += string.Format("('{0}', '{1}', '{2}', '{3}', '{4}', {5}, 0, 'estado', {6}, {7})",
                        l.isbn, l.titulo, l.descripcion, l.genero, l.fechaPublicacion, l.precio, l.idEditorial, l.idAutor);
                    break;
                case "Usuario":
                    Usuario u = (Usuario) datos;
                    sql += string.Format("('{0}', '{1}', '{2}', {3})",
                        u.nombreUsuario, u.usuario, u.contrasenia, u.idRol);
                    break;
                case "Prestamo":
                    Prestamo p = (Prestamo) datos;
                    p.fechaPrestamo = convertirFecha(p.fechaPrestamo);
                    p.fechaDevolucion = convertirFecha(p.fechaDevolucion);
                    sql += string.Format("('{0}', '{1}', '{2}', {3}, {4}, {5})",
                        p.fechaPrestamo, p.fechaDevolucion, p.estadoPrestamo, p.costo, p.idUsuario, p.idLibro);
                    break;
                case "Venta":
                    Venta v = (Venta) datos;
                    v.fechaVenta = convertirFecha(v.fechaVenta);
                    sql += string.Format("('{0}', {1}, {2}, {3}, {4})",
                        v.fechaVenta, v.cantidadLibros, v.totalVenta,v.idUsuario, v.idLibro);
                    break;
                case "Compra":
                    Compra c = (Compra) datos;
                    c.fechaCompra = convertirFecha(c.fechaCompra);
                    sql += string.Format("('{0}', {1}, {2}, {3}, {4})",
                        c.fechaCompra, c.cantidadLibros, c.totalCompra, c.idProveedor, c.idLibro);
                    break;
                case "Proveedor":
                    Proveedor pv = (Proveedor) datos;
                    sql += string.Format("('{0}', '{1}', '{2}', '{3}')",
                        pv.nombreProveedor, pv.telefono, pv.email, pv.direccion);
                    break;
                default:
                    MessageBox.Show($"No se puede insertar en la tabla {tabla}");
                    return false;
            }

            return ejecutarSql(sql);
        }

        public bool modificar(Biblioteca datos)
        {
            string tabla = datos.GetType().Name;

            sql = $"UPDATE {tabla} SET ";

            switch (tabla)
            {
                case "Autor":
                    Autor a = (Autor) datos;
                    a.fechaNacimiento = convertirFecha(a.fechaNacimiento);
                    sql += string.Format("nombre_autor = '{0}', pais = '{1}', fecha_nacimiento = '{2}'",
                        a.nombreAutor, a.pais, a.fechaNacimiento, a.id);
                    break;
                case "Editorial":
                    Editorial e = (Editorial) datos;
                    sql += string.Format("nombre_editorial = '{0}', direccion = '{1}'",
                        e.nombreEditorial, e.direccion);
                    break;
                case "Libro":
                    Libro l = (Libro) datos;
                    l.fechaPublicacion = convertirFecha(l.fechaPublicacion);
                    sql += string.Format("isbn = '{0}', titulo = '{1}', descripcion = '{2}', genero = '{3}', fecha_publicacion = '{4}', " +
                        "precio = {5}, id_editorial = {6}, id_autor = {7}",
                        l.isbn, l.titulo, l.descripcion, l.genero, l.fechaPublicacion, l.precio, l.idEditorial, l.idAutor);
                    break;
                case "Usuario":
                    Usuario u = (Usuario) datos;
                    sql += string.Format("nombre = '{0}', usuario = '{1}', contrasena = '{2}', id_rol = {3}",
                        u.nombreUsuario, u.usuario, u.contrasenia, u.idRol);
                    break;
                case "Prestamo":
                    Prestamo p = (Prestamo) datos;
                    p.fechaPrestamo = convertirFecha(p.fechaPrestamo);
                    p.fechaDevolucion = convertirFecha(p.fechaDevolucion);
                    sql += string.Format("fecha_prestamo = '{0}', fecha_devolucion = '{1}', estado_prestamo = '{2}', " +
                        "costo_prestamo = {3}, id_usuario = {4}, id_libro = {5}",
                        p.fechaPrestamo, p.fechaDevolucion, p.estadoPrestamo, p.costo, p.idUsuario, p.idLibro);
                    break;
                case "Venta":
                    Venta v = (Venta) datos;
                    v.fechaVenta = convertirFecha(v.fechaVenta);
                    sql += string.Format("fecha_venta = '{0}', cantidad_libros = {1}, total_venta = {2}, id_usuario = {3}, id_libro = {4}",
                        v.fechaVenta, v.cantidadLibros, v.totalVenta, v.idUsuario, v.idLibro);
                    break;
                case "Compra":
                    Compra c = (Compra) datos;
                    c.fechaCompra = convertirFecha(c.fechaCompra);
                    sql += string.Format("fecha_compra = '{0}', cantidad_libros = {1}, total_compra = {2}, id_proveedor = {3}, id_libro = {4}",
                        c.fechaCompra, c.cantidadLibros, c.totalCompra, c.idProveedor, c.idLibro);
                    break;
                case "Proveedor":
                    Proveedor pv = (Proveedor) datos;
                    sql += string.Format("nombre_proveedor = '{0}', telefono = '{1}', email = '{2}', direccion = '{3}'",
                        pv.nombreProveedor, pv.telefono, pv.email, pv.direccion);
                    break;
                default:
                    MessageBox.Show($"No se puede modificar la tabla {tabla}");
                    return false;
            }

            sql += $" WHERE id = {datos.id}";

            return ejecutarSql(sql);
        }

        public bool actualizarInventario(int idLibro, int inventario)
        {
            sql = $"UPDATE Libro SET inventario = {inventario} WHERE id = {idLibro}";

            return ejecutarSql(sql);
        }

        public bool eliminar(string tabla, string campoID, string valorID)
        {
            sql = $"DELETE FROM {tabla} WHERE {campoID} = {valorID}";

            return ejecutarSql(sql);
        }

        public Usuario iniciarSesion(string usuario, string contrasena)
        {
            SqlDataReader lector;
            Usuario usuarioEcontrado = null;
            sql = $"SELECT * FROM Usuario WHERE usuario = '{usuario}' AND contrasena = '{contrasena}'";

            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    usuarioEcontrado =  new Usuario();

                    usuarioEcontrado.id = Convert.ToInt32(lector["id"]);
                    usuarioEcontrado.nombreUsuario = lector["nombre"].ToString();
                    usuarioEcontrado.usuario = lector["usuario"].ToString();
                    usuarioEcontrado.contrasenia = lector["contrasena"].ToString();
                    usuarioEcontrado.idRol = Convert.ToInt32(lector["id_rol"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return usuarioEcontrado;
        }
    }
}
