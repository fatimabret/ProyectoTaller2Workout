using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Alumno : Usuario
    {
        public int id_alumno { get; set; }
        public string detalles { get; set; }
        public string genero { get; set; }
    }
}
