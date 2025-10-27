using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using workout.CapaDatos;

namespace workout.CapaNegocio
{
    public class CN_Reportes
    {
        CD_Reportes reportes = new CD_Reportes();

        public DataSet GenerarReporte(DateTime desde, DateTime hasta)
        {
            return reportes.GenerarReporte(desde, hasta);
        }
    }
}
