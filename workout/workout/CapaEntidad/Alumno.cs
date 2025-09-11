using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Alumno
    {
        public int id_alumno { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string correo { get; set; }
        public DateTime fecha_nac { get; set; }
        public int id_estado { get; set; }
        public string detalles { get; set; }
        public string genero { get; set; }
    }
}
