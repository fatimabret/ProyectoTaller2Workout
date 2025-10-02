using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaDatos;

namespace workout.CapaEntidad
{
    public class CD_Alumno
    {
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

                //(result != null && result != DBNull.Value)
                id_alumno_registrado = Convert.ToInt32(result);
            }

            return id_alumno_registrado;
        }
        public int BuscarAlumno(string p_nombre, string p_apellido)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("SP_BUSCAR_ALUMNO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", p_nombre);
                cmd.Parameters.AddWithValue("@apellido", p_apellido);

                
                int id_alumno = Convert.ToInt32(cmd.ExecuteScalar());

                return id_alumno;
            }
        }
        public DataTable ListarAlumnos()
        {
            DataTable tablaAlumnos = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_ALUMNOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tablaAlumnos);
            }

            return tablaAlumnos;
        }
        public DataTable ListarAlumnosPorEntrenador(int idEntrenador)
        {
            DataTable tablaAlumnos = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_ALUMNOS_POR_ENTRENADOR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_entrenador", idEntrenador);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tablaAlumnos);
            }

            return tablaAlumnos;
        }
        public int ModificarAlumno(int p_id_alumno,string p_detalles, string p_genero, int p_estado, int p_entrenador)
        {
            int resultado = -1;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_ALUMNO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_alumno", p_id_alumno);
                cmd.Parameters.AddWithValue("@detalles", p_detalles);
                cmd.Parameters.AddWithValue("@genero", p_genero);
                cmd.Parameters.AddWithValue("@id_estado",p_estado);
                cmd.Parameters.AddWithValue("@id_entrenador", p_entrenador);

                SqlParameter returnParameter = cmd.Parameters.Add("ReturnValue", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();
                resultado = (int)returnParameter.Value;
            }

            return resultado;
        }
        public void EliminarAlumno(string nombre, string apellido)
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

        public void ActivarAlumno(string nombre, string apellido)
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

        public DataRow ObtenerAlumno(string nombre, string apellido)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_OBTENER_ALUMNO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla.Rows.Count > 0 ? tabla.Rows[0] : null;
            }
        }

        public DataTable BuscarAlumnoDni(int p_dni)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_BUSCAR_ALUMNO_DNI", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", p_dni);

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla.Rows.Count >= 0 ? tabla : null;
            }
        }

    }
}
