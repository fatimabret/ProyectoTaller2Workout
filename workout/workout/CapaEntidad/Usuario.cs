using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Usuario
    {
        private int id_usuario { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private DateTime fecha_nac { get; set; }
        private string correo { get; set; }
        private string contrasenia { get; set; }
        private int id_estado { get; set; }
    }
}
