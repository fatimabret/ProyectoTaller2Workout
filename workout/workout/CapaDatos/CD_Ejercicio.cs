using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaEntidad;

namespace workout.CapaDatos
{
    public class CD_Ejercicio
    {
        public List<Ejercicio> ListarEjercicios()
        {
            List<Ejercicio> lista = new List<Ejercicio>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_EJERCICIOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Ejercicio
                    {
                        /*
                        id_ejercicio = Convert.ToInt32(dr["id_ejercicio"]),
                        descripcion = dr["descripcion"].ToString(),
                        serie = dr["serie"].ToString(),
                        repeticion = dr["repeticion"].ToString(),
                        descanso = dr["descanso"].ToString()
                        */
                    });
                }
            }
            return lista;
        }
    }
}
