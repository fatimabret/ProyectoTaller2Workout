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
                //Abre la conexion a la base de datos
                conexion.Open();
                //Se define el comando SQL para registrar el usuario
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_USUARIO", conexion);
                //Pasa los parametros a la consulta
                cmd.Parameters.AddWithValue("apellido", p_Usuario.apellido);
                cmd.Parameters.AddWithValue("nombre", p_Usuario.nombre);
                cmd.Parameters.AddWithValue("dni", p_Usuario.dni);
                cmd.Parameters.AddWithValue("correo", p_Usuario.correo);
                cmd.Parameters.AddWithValue("contrasena", p_Usuario.contrasena);
                cmd.Parameters.AddWithValue("id_estado", p_Usuario.id_estado);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // Parámetro para capturar el RETURN
                SqlParameter returnValue = cmd.Parameters.Add("ReturnValue", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;

                // Ejecutar el SP
                cmd.ExecuteNonQuery();

                // Lee el valor devuelto por la BD
                id_usuario = (int)returnValue.Value;

            }
            return id_usuario;
        }

        public Usuario IniciarSesion(string p_correo, string p_contrasena)
        {
            Usuario usuario = null;
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    //Abre la conexion a la base de datos
                    conexion.Open();
                    //Se define el comando SQL para iniciar sesion
                    SqlCommand cmd = new SqlCommand("SP_INICIAR_SESION", conexion);
                    //Pasa los parametros a la consulta
                    cmd.Parameters.AddWithValue("correo", p_correo);
                    cmd.Parameters.AddWithValue("contrasena", p_contrasena);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // Ejecutar el SP y obtener el resultado
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Si se encuentra un usuario con las credenciales proporcionadas, crear el objeto Usuario
                            usuario = new Usuario(
                                reader["nombre"].ToString(),
                                reader["apellido"].ToString(),
                                Convert.ToInt32(reader["dni"]),
                                reader["correo"].ToString(),
                                reader["contrasena"].ToString(),
                                Convert.ToInt32(reader["id_rol"])
                            )
                            {
                                id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                id_estado = Convert.ToInt32(reader["id_estado"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores (puedes registrar el error o mostrar un mensaje)
                    Console.WriteLine("Error al iniciar sesión: " + ex.Message);
                }
            }
            return usuario; // Retorna el objeto Usuario o null si no se encontró
        }
    }
}
