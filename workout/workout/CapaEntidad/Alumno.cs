using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Alumno
    {
        private int dni { get; set; }
        private string apellido { get; set; }
        private string nombre { get; set; }
        private DateTime fecha_nac { get; set; }
        private string detalles { get; set; }
        private string correo { get; set; }
        private char genero { get; set; }
    }
}
