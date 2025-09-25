using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Pago
    {
        public int id_pago { get; set; }
        public double importe { get; set; }
        public int id_membresia { get; set; }
        public int id_metodo_pago { get; set; }
        public DateTime fecha_pago { get; set; }
        public DateTime fecha_venc { get; set; }
        public int id_estado { get; set; }
        public string modo_pago { get; set; }
    }

}
