using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Pago
    {
        private int id_pago { get; set; }
        private double total { get; set; }
        private int id_membresia { get; set; }
        private int id_metodo_pago { get; set; }
    }
}
