using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaDatos
{
    public class CD_Rutina
    {
        public DataTable ConsultarRutinaPorDni(int dni)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_CONSULTAR_RUTINA_ALUMNO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
        }
        public int RegistrarRutina(int dni, int idEjercicio, string dia)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_RUTINA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@id_ejercicio", idEjercicio);
                cmd.Parameters.AddWithValue("@dia", dia);

                return cmd.ExecuteNonQuery(); // devuelve 1 si se insertó bien
            }
        }
    }
}
