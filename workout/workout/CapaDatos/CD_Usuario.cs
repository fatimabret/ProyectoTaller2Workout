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
    public class CD_Usuario
    {
        int id_usuario = 0;
        public int Registrar(Usuario p_Usuario)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_USUARIO", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Parámetros de entrada
                cmd.Parameters.AddWithValue("@apellido", p_Usuario.apellido);
                cmd.Parameters.AddWithValue("@nombre", p_Usuario.nombre);
                cmd.Parameters.AddWithValue("@dni", p_Usuario.dni);
                cmd.Parameters.AddWithValue("@correo", p_Usuario.correo);
                cmd.Parameters.AddWithValue("@contrasena", p_Usuario.contrasena);
                cmd.Parameters.AddWithValue("@id_estado", p_Usuario.id_estado);
                cmd.Parameters.AddWithValue("@id_rol", p_Usuario.id_rol);

                // Parámetro para capturar RETURN VALUE
                SqlParameter returnParam = new SqlParameter("@ReturnVal", SqlDbType.Int);
                returnParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(returnParam);

                // Ejecutar SP
                cmd.ExecuteNonQuery();

                // Leer el valor de retorno
                id_usuario = (int)returnParam.Value;
            }

            return id_usuario;
        }

        public (int idUsuario, int idRol) IniciarSesion(string correo, string contrasena)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_INICIAR_SESION", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return (
                        Convert.ToInt32(dr["id_usuario"]),
                        Convert.ToInt32(dr["id_rol"])
                    );
                }
                else
                {
                    return (-1, -1); // Devuelve el rol del usuario, o -1 si no existe
                }
            }
        }

        public DataTable BuscarUsuarioDni(int dni)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_BUSCAR_USUARIO_DNI", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ListarUsuarios(int p_id_Usuario)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_USUARIOS", conexion);
                cmd.Parameters.AddWithValue("@id_usuario", p_id_Usuario);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void ActivarUsuario(string nombre, string apellido)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_ACTIVAR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarUsuario(string nombre, string apellido)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.ExecuteNonQuery();
            }
        }
        public DataRow ObtenerUsuario(string nombre, string apellido)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_OBTENER_USUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        public void ModificarUsuario(int id_usuario, string nombre, string apellido, int dni, string correo)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_USUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.ExecuteNonQuery();
            }
        }


    }
}

