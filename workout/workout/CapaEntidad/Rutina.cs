using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Rutina
    {
        public int Dni { get; set; }
        public string Entrenador { get; set; }
        public string Horario { get; set; }
        public string FechaRutina { get; set; }
        public string Ejercicio { get; set; }
        public int Series { get; set; }
        public int Repeticiones { get; set; }
        public int Descanso { get; set; }
    }
}
