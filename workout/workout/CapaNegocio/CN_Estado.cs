using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaDatos;
using workout.CapaEntidad;

namespace workout.CapaNegocio
{
    public class CN_Estado
    {
        // Se crea una instancia de la capa de datos para acceder a los métodos
        private CD_Estado estadoDatos = new CD_Estado();

        // Método para obtener la lista de estados de la capa de datos
        public List<Estado> ListarEstados()
        {
            return estadoDatos.ListarEstados();
        }
    }
}
