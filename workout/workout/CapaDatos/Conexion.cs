using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaDatos
{
    public class Conexion
    {
        public static string CadenaConexion = ConfigurationManager.ConnectionStrings["BaseDatos"].ConnectionString();
    }
}
