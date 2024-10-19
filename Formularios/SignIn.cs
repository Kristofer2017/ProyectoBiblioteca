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

namespace ProyectoBiblioteca
{
    public partial class FSignIn : Form
    {
        public FSignIn()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(
            "Integrated Security=True; Persist Security Info=False; Initial " +
            "Catalog=Biblioteca;" +
            "Data Source=DESKTOP-SJ74ILQ\\SQLEXPRESS"
        );

        

        private void btnSignin_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT " +
                "usuario, contrasenia FROM usuario WHERE " +
                "usuario = @vUser AND contrasenia = @vContra"
            , connection);

            command.Parameters.AddWithValue("@vUser", txtUsuario.Text);
            command.Parameters.AddWithValue("@vContra", txtContra.Text);

            SqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                connection.Close();
                
                Home formInicio = new Home();
                formInicio.Show();

            }
            else
            {
                connection.Close();
                MessageBox.Show("Usuario o contraseña inválidos!");
            }
        }
    }
}
