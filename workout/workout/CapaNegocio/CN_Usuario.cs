using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaEntidad;
using workout.CapaDatos;
using System.Data;

namespace workout.CapaNegocio
{
    public class CN_Usuario
    {
        public CD_Usuario usuarioDatos = new CD_Usuario();
        public int registrarUsuario(Usuario p_usuario)
        {
            return usuarioDatos.Registrar(p_usuario); // Retorna el ID del usuario registrado 
        }

        public (int idUsuario, int idRol) iniciarSesion(string correo, string contrasena)
        {
            return usuarioDatos.IniciarSesion(correo, contrasena);
        }

        public DataTable buscarUsuarioDni(int dni)
        {
            return usuarioDatos.BuscarUsuarioDni(dni);
        }

        public DataTable listarUsuarios(int p_id_Usuario)
        {
            return usuarioDatos.ListarUsuarios(p_id_Usuario);
        }

        public void activarUsuario(string nombre, string apellido)
        {
            usuarioDatos.ActivarUsuario(nombre, apellido);
        }

        public void eliminarUsuario(string nombre, string apellido)
        {
            usuarioDatos.EliminarUsuario(nombre, apellido);

        }
        public DataRow ObtenerUsuario(string nombre, string apellido)
        {
            CD_Usuario datos = new CD_Usuario();
            return datos.ObtenerUsuario(nombre, apellido);
        }

        public void ModificarUsuario(int id_usuario, string nombre, string apellido, int dni, string correo)
        {
            CD_Usuario datos = new CD_Usuario();
            datos.ModificarUsuario(id_usuario, nombre, apellido, dni, correo);
        }


    }
}
