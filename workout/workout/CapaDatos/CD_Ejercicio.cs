using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaEntidad;
using workout.CapaNegocio;

namespace workout.CapaDatos
{
    public class CD_Ejercicio
    {
        /*
        public int GetId_ejercicio()
        {
            return id_ejercicio;
        }
        */

        public int RegistrarEjercicio(Ejercicio p_Ejercicio)
        {
            int id_ejercicio_registrado = -1;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                // Abre la conexion a la base de datos
                conexion.Open();
                // Se define el comando SQL para registrar el usuario
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_EJERCICIO", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("descripcion", p_Ejercicio.descripcion);
                cmd.Parameters.AddWithValue("serie", p_Ejercicio.serie);
                cmd.Parameters.AddWithValue("repeticion", p_Ejercicio.repeticion);
                cmd.Parameters.AddWithValue("descanso", p_Ejercicio.descanso);
                cmd.Parameters.AddWithValue("id_entrenador", p_Ejercicio.id_entrenador);

                // Parámetro para capturar el valor de retorno del SP
                object result = cmd.ExecuteScalar();

                id_ejercicio_registrado = (result != null && result != DBNull.Value)
                                       ? Convert.ToInt32(result) : -1;
            }

            return id_ejercicio_registrado;
        }
        public List<Ejercicio> ListarEjercicios(int id_entrenador)
        {
            List<Ejercicio> lista = new List<Ejercicio>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_EJERCICIOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_entrenador", id_entrenador);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Ejercicio
                    {
                        id_ejercicio = Convert.ToInt32(dr["id_ejercicio"]),
                        descripcion = dr["descripcion"].ToString(),
                        serie = Convert.ToInt32(dr["serie"]),
                        repeticion = Convert.ToInt32(dr["repeticiones"]),
                        descanso = Convert.ToInt32(dr["descanso"]),
                        id_entrenador = id_entrenador
                    });
                }
            }
            return lista;
        }
    }
}
