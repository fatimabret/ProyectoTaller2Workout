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
    public class CN_Membresia
    {
        private CD_Membresia membresiaDatos = new CD_Membresia();

        public int RegistrarMembresia(Membresia membresia)
        {
            return membresiaDatos.RegistrarMembresia(membresia);
        }

        public int BuscarMembresiaPorDni(int dni)
        {
            return membresiaDatos.BuscarMembresiaPorDni(dni);
        }

        public Membresia ObtenerMembresiaPorDni(int dni)
        {
            return membresiaDatos.ObtenerMembresiaPorDni(dni);
        }

        public string ObtenerEstadoMembresia(int dni)
        {
            int resultado = membresiaDatos.BuscarMembresiaPorDni(dni);

            if (resultado == -3)
                return "Alumno no encontrado";
            else if (resultado == -2)
                return "VIGENTE";
            else if (resultado == -1)
                return "VENCIDA";
            else
                return "DESCONOCIDO";
        }
        public DataTable ObtenerUltimoPagoPorDni(int dni)
        {
            return membresiaDatos.ObtenerUltimoPagoPorDni(dni);
        }

    }
}