using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaDatos;

namespace workout.CapaNegocio
{
    internal class CN_Rutina
    {
        private CD_Rutina datosRutina = new CD_Rutina();

        public DataTable ConsultarRutinaPorDni(int dni)
        {
            return datosRutina.ConsultarRutinaPorDni(dni);
        }

        public int registrarRutina(int dni, int idEjercicio, string dia)
        {
            return datosRutina.RegistrarRutina(dni, idEjercicio, dia);
        }
    }
}
