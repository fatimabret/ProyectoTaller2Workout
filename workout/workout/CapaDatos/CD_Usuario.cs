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

        public int IniciarSesion(string p_correo, string p_contrasena)
        {
            int id_rol = 0; // 0 = no encontrado o sin rol asignado

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("SP_INICIAR_SESION", conexion))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@correo", p_correo);
                    cmd.Parameters.AddWithValue("@contrasena", p_contrasena);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Solo devolvemos el id_rol
                            id_rol = Convert.ToInt32(reader["id_rol"]);
                        }
                    }
                }
            }

            return id_rol; // Devuelve el rol del usuario, o si no existe
        }

        /*  Estas modificaciones son para retornar id_usuario e id_rol,
         *  pero complican el manejo en la capa de negocio y presentación
         *  
         *  public (int idUsuario, int idRol) IniciarSesion(string correo, string contrasena)
         *  {
         *      using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
         *      {
         *          conexion.Open();
         *          SqlCommand cmd = new SqlCommand("SP_INICIAR_SESION", conexion);
         *          cmd.CommandType = CommandType.StoredProcedure;
         *          cmd.Parameters.AddWithValue("@correo", correo);
         *          cmd.Parameters.AddWithValue("@contrasena", contrasena);
         *          SqlDataReader dr = cmd.ExecuteReader();
         *          if (dr.Read())
         *          {
         *              return (Convert.ToInt32(dr["id_usuario"]), Convert.ToInt32(dr["id_rol"]));
         *          }
         *          else
         *          {
         *              return (-1, -1);
         *          }
         *      }
         *  }
         */
    }
}

