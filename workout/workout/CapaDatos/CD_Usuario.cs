using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaEntidad;

namespace workout.CapaDatos
{
    public class CD_Usuario
    {
        public int Registrar(Usuario p_Usuario)
        {

            int idUsuario = 0;
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                //Abre la conexion a la base de datos
                conexion.Open();
                //Se define el comando SQL para registrar el usuario
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR", conexion);
                //Pasa los parametros a la consulta
                cmd.Parameters.AddWithValue("apellido", p_Usuario.apellido);
                cmd.Parameters.AddWithValue("nombre", p_Usuario.nombre);
                cmd.Parameters.AddWithValue("dni", p_Usuario.dni);
                cmd.Parameters.AddWithValue("fecha_nac", p_Usuario.fecha_nac);
                cmd.Parameters.AddWithValue("correo", p_Usuario.correo);
                cmd.Parameters.AddWithValue("contrasena", p_Usuario.contrasena);
                cmd.Parameters.AddWithValue("id_estado", 1);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //Obtiene el id del usuario registrado
                idUsuario = Convert.ToInt32(cmd.ExecuteScalar());
                
            }
            return idUsuario;
        }
    }
}
