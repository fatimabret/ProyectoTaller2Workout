using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Membresia
    {
        public int id_membresia { get; set; }
        public DateTime fecha_pago { get; set; }
        public DateTime fecha_venc { get; set; }
        public double monto { get; set; }
        public int id_alumno { get; set; }
        public int id_estado { get; set; }
        public int dni_alumno { get; set; }
        public int id_metodo_pago { get; set; }
    }
}
