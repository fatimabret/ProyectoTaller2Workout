using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Ejercicio
    {
        public int id_ejercicio { get; set; }
        public string descripcion { get; set; }
        public int serie { get; set; }
        public int repeticion { get; set; }
        public int descanso { get; set; }
        public int id_entrenador { get; set; }

        public Ejercicio(string p_descripcion, int p_serie, int p_repeticion, int p_descanso, int p_id_entrenador)
        {
            this.descripcion = p_descripcion;
            this.serie = p_serie;
            this.repeticion = p_repeticion;
            this.descanso = p_descanso;
            this.id_entrenador = p_id_entrenador; 
        }

        public string InfoCompleta
        {
            get { return $"{descripcion} - {serie} series - {repeticion} reps - {descanso} min descanso"; }
        }

        public Ejercicio() 
        { }
    }
}
