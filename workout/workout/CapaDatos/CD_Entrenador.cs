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
        int id_entrenador = 0;
        public int RegistrarEntrenador(Entrenador p_Entrenador)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                CD_Usuario usuarioDatos = new CD_Usuario();
                //Crea el usuario y obtiene su ID
                int id_usuario = usuarioDatos.Registrar(p_Entrenador);
                //Abre la conexion a la base de datos
                conexion.Open();
                //Se define el comando SQL para registrar el usuario
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_ALUMNO", conexion);

                //Pasa los parametros a la consulta
                cmd.Parameters.AddWithValue("horario_disp", p_Entrenador.horario_disp);
                cmd.Parameters.AddWithValue("dias_disp", p_Entrenador.dias_disp);
                cmd.Parameters.AddWithValue("cupo", p_Entrenador.cupo);
                cmd.Parameters.AddWithValue("detalles", p_Entrenador.detalles);
                cmd.Parameters.AddWithValue("id_usuario", id_usuario);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

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
    }
}
