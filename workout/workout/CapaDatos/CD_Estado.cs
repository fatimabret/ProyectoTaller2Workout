using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaEntidad;

namespace workout.CapaDatos
{
    public class CD_Estado
    {
        // Obtiene una lista de todos los estados de la base de datos
        public List<Estado> ListarEstados()
        {
            List<Estado> lista = new List<Estado>();

            try
            {
                // Ensures the connection is properly disposed of.
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Se define el comando SQL para obtener los estados
                    string query = "SELECT id_estado, tipo, descripcion FROM ESTADO";
                    // Ensures the command is properly disposed of.
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        // Opens the database connection.
                        conexion.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        // Reads the results and adds them to the list.
                        while (dr.Read())
                        {
                            lista.Add(new Estado()
                            {
                                id_estado = Convert.ToInt32(dr["id_estado"]),
                                descripcion = dr["descripcion"].ToString()
                            });
                        }
                        dr.Close();
                    }
                }
            }
            catch (Exception)
            {
                // In case of error, simply returns an empty list.
                lista = new List<Estado>();
            }

            return lista;
        }
    }
}
