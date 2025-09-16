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

        public int iniciarSesion(string p_correo,string p_contrasena)
        {
            Usuario usuario = new Usuario("","",0,p_correo,p_contrasena,0);
            return usuarioDatos.IniciarSesion(usuario.correo,usuario.contrasena);
        }

        /* Nuevo método que retorna una tupla con idUsuario e idRol
         * public (int idUsuario, int idRol) iniciarSesion(string correo, string contrasena)
         * {
         *      return usuarioDatos.IniciarSesion(correo, contrasena);
         * }
         */
    }
}
