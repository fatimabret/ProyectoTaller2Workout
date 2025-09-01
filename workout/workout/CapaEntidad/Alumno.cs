using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Alumno : Usuario
    {
        private int id_alumno { get; set; }
        private string detalles { get; set; }
        private char genero { get; set; }
        private int id_usuario { get; set; }
    }
}
