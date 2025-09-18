using System;
using System.Collections;
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
            int id_alumno_registrado = -1;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                // Abre la conexion a la base de datos
                conexion.Open();
                // Se define el comando SQL para registrar el usuario
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_ALUMNO", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Asegúrate de que los parámetros se agreguen en el mismo orden que están en tu SP
                cmd.Parameters.AddWithValue("nombre", p_Alumno.nombre);
                cmd.Parameters.AddWithValue("apellido", p_Alumno.apellido);
                cmd.Parameters.AddWithValue("correo", p_Alumno.correo);
                cmd.Parameters.AddWithValue("detalles", p_Alumno.detalles);
                cmd.Parameters.AddWithValue("genero", p_Alumno.genero);
                cmd.Parameters.AddWithValue("fecha_nac", p_Alumno.fecha_nac);
                cmd.Parameters.AddWithValue("dni", p_Alumno.dni);
                cmd.Parameters.AddWithValue("id_estado", p_Alumno.id_estado);
                cmd.Parameters.AddWithValue("id_entrenador", p_Alumno.id_entrenador);

                // Parámetro para capturar el valor de retorno del SP
                object result = cmd.ExecuteScalar();

                id_alumno_registrado = (result != null && result != DBNull.Value)
                                       ? Convert.ToInt32(result): -1;
            }

            return id_alumno_registrado;
        }
        public int BuscarAlumno(string p_nombre, string p_apellido)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                //Abre la conexion a la base de datos
                conexion.Open();
                //Se define el comando SQL para registrar el usuario
                SqlCommand cmd = new SqlCommand("SP_BUSCAR_ALUMNO", conexion);
                //Pasa los parametros a la consulta
                cmd.Parameters.AddWithValue("nombre", p_nombre);
                cmd.Parameters.AddWithValue("apellido", p_apellido);
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

        public List<Alumno> ListarAlumnos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_ALUMNOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaAlumnos.Add(new Alumno()
                    {
                        id_alumno = Convert.ToInt32(dr["id_alumno"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        dni = Convert.ToInt32(dr["dni"]),
                    });
                }
            }

            return listaAlumnos;
        }
        public DataTable ListarAlumnosPorEntrenador(int idEntrenador)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_ALUMNOS_POR_ENTRENADOR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_entrenador", idEntrenador);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

    }
}
