using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Entrenador
    {
        private int id_entrenador { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int dni { get; set; }
        private DateTime fecha_nac { get; set; }
        private string horario_disp { get; set; }
        private string dias_disp { get; set; }
        private string detalles { get; set; }

    }
}
