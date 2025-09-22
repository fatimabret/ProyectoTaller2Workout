using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using workout.CapaEntidad;

namespace workout.CapaDatos
{
    public class CD_Membresia
    {
        public int RegistrarMembresia(Membresia pMembresia)
        {
            int resultado = -1;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_MEMBRESIA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", pMembresia.dni_alumno);
                cmd.Parameters.AddWithValue("@id_metodo_pago", pMembresia.id_metodo_pago);

                SqlParameter returnParameter = cmd.Parameters.Add("ReturnValue", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                resultado = (int)returnParameter.Value;
            }

            return resultado;
        }

        public int BuscarMembresiaPorDni(int dni)
        {
            int resultado = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("SP_BUSCAR_MEMBRESIA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);

                SqlParameter returnParameter = cmd.Parameters.Add("ReturnValue", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                resultado = (int)returnParameter.Value;
            }

            return resultado;
        }
    }
}
