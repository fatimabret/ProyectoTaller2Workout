using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace workout.CapaDatos
{
    public class CD_Reportes
    {
        private string cadena = "Data Source=DESKTOP-80HNL37;Initial Catalog=workout;Integrated Security=True;";

        public DataSet GenerarReporte(DateTime desde, DateTime hasta)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("SP_REPORTE_ESTADISTICA", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@desde", desde);
                    cmd.Parameters.AddWithValue("@hasta", hasta);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar reporte: " + ex.Message);
            }

            return ds;
        }

    }
}

