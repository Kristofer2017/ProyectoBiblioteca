using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca.Clases
{
    internal class Transacciones
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql = "";
        public string[] listaTablas { get; set; }

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

        public bool insertar(Biblioteca datos)
        {
            string tabla = datos.GetType().Name;

            if (!listaTablas.Contains(tabla))
            {
                MessageBox.Show($"Error: La tabla {tabla} no existe.");
                return false;
            }

            switch (tabla)
            {
                case "Autor":
                    Autor a = (Autor) datos;
                    sql = string.Format("INSERT INTO {0} VALUES ('{1}', '{2}', '{3}')",
                        tabla, a.nombreAutor, a.pais, a.fechaNacimiento);
                    break;
                case "Editorial":
                    Editorial e = (Editorial) datos;
                    sql = string.Format("INSERT INTO {0} VALUES ('{1}', '{2}')",
                        tabla, e.nombreEditorial, e.direccion);
                    break;
                case "Libro":
                    Libro l = (Libro) datos;
                    sql = string.Format("INSERT INTO {0} VALUES ('{1}', '{2}', '{3}', '{4}', '{5}', {6}, {7}, '{8}', {9}, {10})",
                        tabla, l.isbn, l.titulo, l.descripcion, l.genero, l.fechaPublicacion, l.precio, l.inventario, l.estado, l.idEditorial, l.idAutor);
                    break;
                case "Rol":
                    Rol r = (Rol) datos;
                    sql = string.Format("INSERT INTO {0} VALUES ('{1}')", tabla, r.rolUsuario);
                    break;
                case "Usuario":
                    Usuario u = (Usuario) datos;
                    sql = string.Format("INSERT INTO {0} VALUES ('{1}', '{2}', '{3}', {4})",
                        tabla, u.nombreUsuario, u.usuario, u.contrasenia, u.idRol);
                    break;
                case "Prestamo":
                    Prestamo p = (Prestamo) datos;
                    sql = string.Format("INSERT INTO {0} VALUES ('{1}', '{2}', '{3}', {4}, {5}, {6})",
                        tabla, p.fechaPrestamo, p.fechaDevolucion, p.estadoPrestamo, p.multa, p.idUsuario, p.idLibro);
                    break;
                case "Compra":
                    Compra c = (Compra)datos;
                    sql = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4})",
                        tabla, c.fechaCompra, c.montoCompra, c.idUsuario, c.idLibro);
                    break;
            }

            MessageBox.Show("YOUR SQL REQUEST->>> " + sql);

            return ejecutarSql(sql);
        }

        public bool modificar(object objDatos, string tabla)
        {

            return ejecutarSql(sql);
        }

        public bool eliminar(string tabla, string campoID, string valorID)
        {
            sql = $"DELETE FROM {tabla} WHERE {campoID} = {valorID}";

            return ejecutarSql(sql);
        }
    }
}
