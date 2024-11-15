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
        public string[] listaTablas { get; set; }
        string sql = "";

        public Transacciones()
        {
            conn.ConnectionString = "Integrated Security=True; Persist Security Info=False; Initial Catalog=Biblioteca; Data Source=DESKTOP-SJ74ILQ\\SQLEXPRESS; User Id=biblioteca;Password=clave123;";
            listaTablas = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(Biblioteca))).Select(t => t.Name).ToArray();
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

        public DataTable consultar(string tabla)
        {
            if (!listaTablas.Contains(tabla))
            {
                MessageBox.Show($"Error: La tabla {tabla} no existe.");
                return null;
            }

            this.sql = $"SELECT * FROM {tabla}";

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

        public DataTable consultarLibrosUsuarios()
        {
            sql = "SELECT Libro.id, Libro.isbn, Libro.titulo, Libro.genero, Libro.fecha_publicacion, Libro.precio, Libro.estado, Editorial.nombre_editorial, Autor.nombre_autor from Libro, Editorial, Autor Where Libro.id_editorial = Editorial.id AND Libro.id_autor = Autor.id";

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

        public bool insertar(Biblioteca datos)
        {
            string tabla = datos.GetType().Name;

            sql = $"INSERT INTO {tabla} VALUES ";

            switch (tabla)
            {
                case "Autor":
                    Autor a = (Autor) datos;
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
                    sql += string.Format("('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, 'estado', {7}, {8})",
                        l.isbn, l.titulo, l.descripcion, l.genero, l.fechaPublicacion, l.precio, l.inventario, l.idEditorial, l.idAutor);
                    break;
                case "Usuario":
                    Usuario u = (Usuario) datos;
                    sql += string.Format("('{0}', '{1}', '{2}', {3})",
                        u.nombreUsuario, u.usuario, u.contrasenia, u.idRol);
                    break;
                case "Prestamo":
                    Prestamo p = (Prestamo) datos;
                    sql += string.Format("('{0}', '{1}', '{2}', {3}, {4}, {5})",
                        p.fechaPrestamo, p.fechaDevolucion, p.estadoPrestamo, p.multa, p.idUsuario, p.idLibro);
                    break;
                case "Compra":
                    Compra c = (Compra) datos;
                    sql += string.Format("({0}, {1}, {2}, {3})",
                        c.fechaCompra, c.montoCompra, c.idUsuario, c.idLibro);
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
                    sql += string.Format("isbn = '{0}', titulo = '{1}', descripcion = '{2}', genero = '{3}', fecha_publicacion = '{4}', " +
                        "precio = {5}, inventario = {6}, id_editorial = {7}, id_autor = {8}",
                        l.isbn, l.titulo, l.descripcion, l.genero, l.fechaPublicacion, l.precio, l.inventario, l.idEditorial, l.idAutor);
                    break;
                case "Usuario":
                    Usuario u = (Usuario) datos;
                    sql += string.Format("nombre = '{0}', usuario = '{1}', contrasena = '{2}', id_rol = {3}",
                        u.nombreUsuario, u.usuario, u.contrasenia, u.idRol);
                    break;
                case "Prestamo":
                    Prestamo p = (Prestamo) datos;
                    sql += string.Format("fecha_prestamo = '{0}', fecha_devolucion = '{1}', estado_prestamo = '{2}', " +
                        "multa = {3}, id_usuario = {4}, id_libro = {5}",
                        p.fechaPrestamo, p.fechaDevolucion, p.estadoPrestamo, p.multa, p.idUsuario, p.idLibro);
                    break;
                case "Compra":
                    Compra c = (Compra) datos;
                    sql += string.Format("fecha_compra = '{0}', monto = {1}, id_usuario = {2}, id_libro = {3}",
                        c.fechaCompra, c.montoCompra, c.idUsuario, c.idLibro);
                    break;
                default:
                    MessageBox.Show($"No se puede modificar la tabla {tabla}");
                    return false;
            }

            sql += $" WHERE id = {datos.id}";

            MessageBox.Show("YOUR SQL REQUEST->>> " + sql);

            return ejecutarSql(sql);
        }

        public bool eliminar(string tabla, string campoID, string valorID)
        {
            sql = $"DELETE FROM {tabla} WHERE {campoID} = {valorID}";

            return ejecutarSql(sql);
        }

        public Usuario iniciarSesion(string usuario, string contrasena)
        {
            sql = $"SELECT * FROM usuario WHERE usuario = '{usuario}' AND contrasena = '{contrasena}'";
            SqlDataReader lector;
            Usuario usuarioEcontrado = null;

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
