using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Entrenador : Usuario
    {
        public int id_entrenador { get; set; }
        public string horario_disp { get; set; }
        public string dias_disp { get; set; }
        public string detalles { get; set; }
        public int cupo { get; set; }
    }
}
