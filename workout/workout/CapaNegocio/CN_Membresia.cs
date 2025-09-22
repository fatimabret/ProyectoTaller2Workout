using System;
using System.Collections.Generic;
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
    }
}