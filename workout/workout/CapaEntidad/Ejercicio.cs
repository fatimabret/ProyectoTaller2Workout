using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Ejercicio
    {
        private int id_ejericio { get; set; }
        private string descripcion { get; set; }
        private int serie { get; set; }
        private int repeticiones { get; set; }
        private string descanso { get; set; }
    }
}
