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

                // Validar si la creación del usuario fue exitosa
                if (id_usuario < 0)
                {
                    return id_usuario; // Retorna -1, -2, etc. según el SP de usuario
                }

                conexion.Open();

                // Se define el comando SQL para registrar el entrenador
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_ENTRENADOR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                cmd.Parameters.AddWithValue("@horario_disp", p_Entrenador.horario_disp);
                cmd.Parameters.AddWithValue("@dias_disp", p_Entrenador.dias_disp);
                cmd.Parameters.AddWithValue("@cupo", p_Entrenador.cupo);
                cmd.Parameters.AddWithValue("@detalles", p_Entrenador.detalles);
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                // Parámetro para capturar el RETURN VALUE del SP
                SqlParameter returnParam = new SqlParameter("@ReturnVal", SqlDbType.Int);
                returnParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(returnParam);

                // Ejecutar el SP
                cmd.ExecuteNonQuery();

                // Leer el valor de retorno
                id_entrenador = (int)returnParam.Value;
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

        public DataTable ListarEntrenadores()
        {
            DataTable tablaEntrenadores = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_ENTRENADORES", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tablaEntrenadores);
            }

            return tablaEntrenadores;
        }

        public void EliminarEntrenador(string nombre, string apellido)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_ENTRENADOR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
