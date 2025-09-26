using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaDatos;
using workout.CapaEntidad;

namespace workout.CapaNegocio
{
    internal class CN_Ejercicio
    {
        CD_Ejercicio ejercicioDatos = new CD_Ejercicio();

        public List<Ejercicio> ListarEjercicios(int id_entrenador)
        {
            return ejercicioDatos.ListarEjercicios(id_entrenador);
        }
        public int RegistrarEjercicio(Ejercicio ejercicio)
        {
            return ejercicioDatos.RegistrarEjercicio(ejercicio);
        }
    }
}
