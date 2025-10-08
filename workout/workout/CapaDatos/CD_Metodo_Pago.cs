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
    public class CD_Metodo_Pago
    {
        public List<Metodo_Pago> ListarMetodosPago()
        {
            List<Metodo_Pago> lista = new List<Metodo_Pago>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_metodo_pago, tipo, id_estado FROM METODO_PAGO WHERE id_estado = 1", conexion);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Metodo_Pago
                        {
                            id_metodo_pago = Convert.ToInt32(dr["id_metodo_pago"]),
                            tipo = dr["tipo"].ToString(),
                            id_estado = Convert.ToInt32(dr["id_estado"])
                        });
                    }
                }
            }
            return lista;
        }
        
    }
}
