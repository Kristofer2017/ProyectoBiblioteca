using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBiblioteca.Clases;

namespace ProyectoBiblioteca
{
    public partial class NuevoLibro : Form
    {
        public NuevoLibro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*
            using (SqlConnection conn = Conexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO libros " +
                    "(Nombre, Apellido, Direccion, Fecha_Nacimiento, Id) " +
                    "values('{0}', '{1}', '{2}', '{3}','{4}')",
                    )
                , conn);

                Comando.ExecuteNonQuery();
            }
            */

        }
    }
}
