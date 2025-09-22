using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaDatos;
using workout.CapaEntidad;

namespace workout.CapaNegocio
{
    public class CN_Pago
    {
        private CD_Pago datos = new CD_Pago();

        public int RegistrarPago(Pago pago)
        {
            return datos.RegistrarPago(pago);
        }
    }
}
