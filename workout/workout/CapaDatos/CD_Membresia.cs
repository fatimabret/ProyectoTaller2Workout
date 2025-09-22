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
        public Membresia ObtenerMembresiaPorDni(int dni)
        {
            Membresia membresia = null;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("SP_OBTENER_MEMBRESIA_POR_DNI", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        membresia = new Membresia
                        {
                            id_membresia = Convert.ToInt32(dr["id_membresia"]),
                            fecha_pago = Convert.ToDateTime(dr["fecha_pago"]),
                            fecha_venc = Convert.ToDateTime(dr["fecha_venc"]),
                            monto = Convert.ToDouble(dr["monto"]),
                            id_alumno = dni,
                            id_estado = dr["Estado"].ToString() == "VIGENTE" ? 1 : 0
                        };
                    }
                }
            }

            return membresia;
        }

    }
}
