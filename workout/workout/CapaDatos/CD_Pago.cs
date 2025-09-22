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
    }
}

