using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaDatos;
using workout.CapaEntidad;

namespace workout.CapaNegocio
{
    public class CN_Pago
    {
        private CD_Pago pagosDatos = new CD_Pago();

        public int RegistrarPago(Pago pago)
        {
            return pagosDatos.RegistrarPago(pago);
        }

        public DataTable listarPagos()
        {
            return pagosDatos.ListarPagos();
        }

        public DataTable buscarPagosDni(int dni)
        {
            return pagosDatos.BuscarPagosDni(dni);
        }
        public Pago obtenerUltimoPagoPorDni(int dni)
        {
            return pagosDatos.ObtenerUltimoPagoPorDni(dni);
        }

        public DataTable filtrarPorFecha(DateTime p_desde, DateTime p_hasta, int p_estado)
        {
           return pagosDatos.FiltrarPorFecha(p_desde, p_hasta, p_estado);
        }
        
    }
}
