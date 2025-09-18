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
    public class CD_Entrenador
    {
        
        public int RegistrarEntrenador(Entrenador p_Entrenador)
        {
            int id_entrenador = 0;
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                CD_Usuario usuarioDatos = new CD_Usuario();

                // Crea el usuario y obtiene su ID
                int id_usuario = usuarioDatos.Registrar(p_Entrenador);

                conexion.Open();

                //Se define el comando SQL para registrar el usuario
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_ENTRENADOR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@horario_disp", p_Entrenador.horario_disp);
                cmd.Parameters.AddWithValue("@dias_disp", p_Entrenador.dias_disp);
                cmd.Parameters.AddWithValue("@cupo", p_Entrenador.cupo);
                cmd.Parameters.AddWithValue("@detalles", p_Entrenador.detalles);
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                // Parámetro para capturar el RETURN
                SqlParameter returnValue = cmd.Parameters.Add("ReturnValue", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;

                // Ejecutar el SP
                cmd.ExecuteNonQuery();

                // Lee el valor devuelto por la BD
                id_entrenador = (int)returnValue.Value;
            }

            return id_entrenador;
        }
        public Entrenador ObtenerEntrenadorPorAlumno(int id_alumno)
        {
            Entrenador entrenador = null;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_ENTRENADOR_POR_ALUMNO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_alumno", id_alumno);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    entrenador = new Entrenador()
                    {
                        id_entrenador = Convert.ToInt32(dr["id_entrenador"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString()
                    };
                }
            }

            return entrenador;
        }

        public int ObtenerIdEntrenadorPorUsuario(int id_usuario)
        {
            int id_entrenador = -1;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_OBTENER_ID_ENTRENADOR_POR_USUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    id_entrenador = Convert.ToInt32(result);
                }
            }

            return id_entrenador;
        }

        public DataTable ListarAlumnosPorEntrenador(int id_entrenador)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_ALUMNOS_POR_ENTRENADOR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_entrenador", id_entrenador);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        public List<Entrenador> ListarEntrenadores()
        {
            List<Entrenador> lista = new List<Entrenador>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_ENTRENADORES", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entrenador
                    {
                        id_entrenador = Convert.ToInt32(dr["id_entrenador"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        horario_disp = dr["horario_disp"].ToString(),
                        dias_disp = dr["dias_disp"].ToString()
                    });
                }
            }

            return lista;
        }

    }
}
