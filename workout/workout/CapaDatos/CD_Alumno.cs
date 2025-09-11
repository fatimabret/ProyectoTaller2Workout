using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaDatos;

namespace workout.CapaEntidad
{
    public class CD_Alumno
    {
        int id_alumno = 0;
        public int RegistrarAlumno(Alumno p_Alumno)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                //Abre la conexion a la base de datos
                conexion.Open();
                //Se define el comando SQL para registrar el usuario
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_ALUMNO", conexion);
                
                //Pasa los parametros a la consulta
                cmd.Parameters.AddWithValue("nombre", p_Alumno.nombre);
                cmd.Parameters.AddWithValue("apellido", p_Alumno.apellido);
                cmd.Parameters.AddWithValue("dni", p_Alumno.dni);
                cmd.Parameters.AddWithValue("correo", p_Alumno.correo); 
                cmd.Parameters.AddWithValue("fecha_nac", p_Alumno.fecha_nac);
                cmd.Parameters.AddWithValue("detalles", p_Alumno.detalles);
                cmd.Parameters.AddWithValue("genero", p_Alumno.genero);
                cmd.Parameters.AddWithValue("id_estado", p_Alumno.id_estado);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Parámetro para capturar el RETURN
                SqlParameter returnValue = cmd.Parameters.Add("ReturnValue", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;

                // Ejecutar el SP
                cmd.ExecuteNonQuery();

                // Lee el valor devuelto por la BD
                id_alumno = (int)returnValue.Value;
            }
            return id_alumno;
        }
    }
}
