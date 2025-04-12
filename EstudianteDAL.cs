using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class EstudianteDAL
    {
        public static int AgregarEstudiante(Estudiante estudiante)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "insert into Estudiante (nombre,carnet,email) values('" + estudiante.Nombre + "', '" + estudiante.Carnet + "','" + estudiante.Seccion + "')";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Estudiante> ObtenerEstudiantes()
        {
            List<Estudiante> lista = new List<Estudiante>();
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from Estudiante";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Estudiante estudiante = new Estudiante();
                    estudiante.Nombre = reader["nombre"].ToString();
                    estudiante.Carnet = Convert.ToInt32(reader["carnet"]);
                    estudiante.Seccion = Convert.ToInt32(reader["seccion"]);
                    estudiante.Correo = reader["email"].ToString();
                    lista.Add(estudiante);
                }
            }
            return lista;
        }
    }
}
