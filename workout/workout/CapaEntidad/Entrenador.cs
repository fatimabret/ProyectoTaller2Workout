using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Entrenador : Usuario
    {
        private int id_entrenador { get; set; }
        private string horario_disp { get; set; }
        private string dias_disp { get; set; }
        private string detalles { get; set; }
        private int id_usuario { get; set; }
        private int cupo { get; set; }
    }
}
