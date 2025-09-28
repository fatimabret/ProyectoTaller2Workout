using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                conexion.Open();

                // Se define el comando SQL para registrar el entrenador
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_ENTRENADOR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                cmd.Parameters.AddWithValue("@nombre", p_Entrenador.nombre);
                cmd.Parameters.AddWithValue("@apellido", p_Entrenador.apellido);
                cmd.Parameters.AddWithValue("@dni", p_Entrenador.dni);
                cmd.Parameters.AddWithValue("@correo", p_Entrenador.correo);
                cmd.Parameters.AddWithValue("@contrasena", p_Entrenador.contrasena);
                cmd.Parameters.AddWithValue("@id_rol", p_Entrenador.id_rol);
                cmd.Parameters.AddWithValue("@id_estado", p_Entrenador.id_estado);
                cmd.Parameters.AddWithValue("@horario_disp", p_Entrenador.horario_disp);
                cmd.Parameters.AddWithValue("@dias_disp", p_Entrenador.dias_disp);
                cmd.Parameters.AddWithValue("@cupo", p_Entrenador.cupo);
                cmd.Parameters.AddWithValue("@detalles", p_Entrenador.detalles);

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
        public DataTable ListarEntrenadoresConInfoCompleta()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_LIST_ENTRENADOR", conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(tabla);
            }
            return tabla;
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

        public void ActivarEntrenador(string nombre, string apellido)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_ACTIVAR_ENTRENADOR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.ExecuteNonQuery();
            }
        }

        public int BuscarEntrenador(string nombre, string apellido)
        {
            int id_entrenador = -1;
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_BUSCAR_ENTRENADOR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    id_entrenador = Convert.ToInt32(result);
                }
                MessageBox.Show("ID Entrenador encontrado: " + id_entrenador); // Línea de depuración
            }
            return id_entrenador;
        }

        public DataTable BuscarEntrenadorDni(int p_dni)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_BUSCAR_ENTRENADOR_DNI", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", p_dni);

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla.Rows.Count >= 0 ? tabla : null;
            }
        }

        public void ModificarEntrenador(int id_entrenador, int p_cupo, string horario_disp, string dias_disp, string detalles)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_ENTRENADOR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_entrenador", id_entrenador);
                cmd.Parameters.AddWithValue("@cupo", p_cupo);
                cmd.Parameters.AddWithValue("@horario_disp", horario_disp);
                cmd.Parameters.AddWithValue("@dias_disp", dias_disp);
                cmd.Parameters.AddWithValue("@detalles", detalles);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
