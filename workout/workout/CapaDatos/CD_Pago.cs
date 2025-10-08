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
    public class CD_Pago
    {
        public int RegistrarPago(Pago pago)
        {
            int resultado = -1;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO PAGO(importe, id_metodo_pago, id_membresia) " +
                                                "VALUES(@importe, @id_metodo_pago, @id_membresia); SELECT SCOPE_IDENTITY();", conexion);

                cmd.Parameters.AddWithValue("@importe", pago.importe);
                cmd.Parameters.AddWithValue("@id_metodo_pago", pago.id_metodo_pago);
                cmd.Parameters.AddWithValue("@id_membresia", pago.id_membresia);

                object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    resultado = Convert.ToInt32(obj);
                }
            }

            return resultado;
        }

        public DataTable ListarPagos()
        {
            DataTable tablaPagos = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_PAGOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tablaPagos);
            }

            return tablaPagos;
        }

        public DataTable BuscarPagosDni(int p_dni)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_BUSCAR_PAGOS_DNI", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", p_dni);

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla.Rows.Count >= 0 ? tabla : null;
            }
        }
        public Pago ObtenerUltimoPagoPorDni(int p_dni)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_OBTENER_ULTIMO_PAGO_DNI", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", p_dni);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Pago
                    {
                        id_pago = Convert.ToInt32(dr["id_pago"]),
                        importe = Convert.ToDouble(dr["importe"]),
                        id_metodo_pago = Convert.ToInt32(dr["id_metodo_pago"]),
                        id_membresia = Convert.ToInt32(dr["id_membresia"]),
                        fecha_pago = Convert.ToDateTime(dr["fecha_pago"]),
                        fecha_venc = Convert.ToDateTime(dr["fecha_venc"]),
                        id_estado = Convert.ToInt32(dr["id_estado"]),
                        modo_pago = dr["modo_pago"].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public DataTable FiltrarPorFecha(DateTime p_desde, DateTime p_hasta, int p_estado)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_FILTRAR_PAGOS_FECHA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", p_desde);
                cmd.Parameters.AddWithValue("@hasta", p_hasta);
                cmd.Parameters.AddWithValue("@estado", p_estado);
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla.Rows.Count >= 0 ? tabla : null;
            }
        }
    }

}

