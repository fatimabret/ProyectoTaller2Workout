using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaDatos;
using workout.CapaEntidad;

namespace workout.CapaNegocio
{
    public class CN_Metodo_Pago
    {
        private CD_Metodo_Pago datos = new CD_Metodo_Pago();

        public List<Metodo_Pago> ListarMetodosPago()
        {
            return datos.ListarMetodosPago();
        }
    }
}
