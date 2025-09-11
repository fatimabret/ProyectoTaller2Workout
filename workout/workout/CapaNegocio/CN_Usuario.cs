using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaEntidad;
using workout.CapaDatos;

namespace workout.CapaNegocio
{
    public class CN_Usuario
    {
        public CD_Usuario usuarioDatos = new CD_Usuario();
        public int registrarUsuario(Usuario p_usuario)
        {
            return usuarioDatos.Registrar(p_usuario); // Retorna el ID del usuario registrado 
        }
    }
}
