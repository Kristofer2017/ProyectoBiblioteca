using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    internal class Conexion
    {
        public static SqlConnection obtenerConexion()
        {
            SqlConnection connection = new SqlConnection(
                "Integrated Security=True; Persist Security Info=False; Initial " +
                "Catalog=Biblioteca;" +
                "Data Source=DESKTOP-SJ74ILQ\\SQLEXPRESS"
            );

            connection.Open();

            return connection;
        }

    }
}
