using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaDatos;
using workout.CapaEntidad;  

namespace workout.CapaEntidad
{
    public class CD_Alumno
    {
        private CD_Usuario usuario = new CD_Usuario();
        public int RegistrarAlumno(Alumno p_Alumno)
        {
            //Crea el usuario asociado antes de registrar el alumno
            int idUsuario = usuario.Registrar(p_Alumno);

            int idAlumno = 0;
            
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                //Abre la conexion a la base de datos
                conexion.Open();
                //Se define el comando SQL para registrar el usuario
                SqlCommand cmd = new SqlCommand("SP_REGISTRARALUMNO", conexion);
                
                //Pasa los parametros a la consulta
                cmd.Parameters.AddWithValue("detalles", p_Alumno.detalles);
                cmd.Parameters.AddWithValue("genero", p_Alumno.genero);
                cmd.Parameters.AddWithValue("correo", p_Alumno.correo);
                cmd.Parameters.AddWithValue("idUsuario", idUsuario);
                //cmd.Parameters.AddWithValue("id_estado", p_Alumno.id_estado);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //Obtiene el id del alumno registrado
                idAlumno = Convert.ToInt32(cmd.ExecuteScalar());
                
            }
            return idAlumno;
        }
    }
}
