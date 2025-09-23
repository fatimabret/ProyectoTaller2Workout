using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using workout.CapaDatos;
using workout.CapaEntidad;

namespace workout.CapaNegocio
{
    public class CN_Entrenador
    {
        CD_Entrenador entrenadorDatos = new CD_Entrenador();
        
        public int RegistrarEntrenador(string p_nombre, string p_apellido, int p_dni, string p_correo,
                                       string p_contrasena, string p_horario_disp, string p_dias_disp,
                                       string p_detalles)
        { 

            // Crea un nuevo entrenador y setea los datos
            Entrenador entrenador = new Entrenador
            {
                nombre = p_nombre,
                apellido = p_apellido,
                dni = p_dni,
                correo = p_correo,
                contrasena = p_contrasena,
                horario_disp = p_horario_disp,
                dias_disp = p_dias_disp,
                detalles = p_detalles,
                id_rol = 3, // Rol de entrenador,
                cupo = 15, // Cupo inicial
            };

            // Le pasa los datos a la capa de datos
            return entrenadorDatos.RegistrarEntrenador(entrenador); // Retorna el ID del entrenador registrado
        }
        public int ObtenerIdEntrenadorPorUsuario(int id_usuario)
        {
            return entrenadorDatos.ObtenerIdEntrenadorPorUsuario(id_usuario);
        }

        public Entrenador ObtenerEntrenadorPorAlumno(int id_alumno)
        {
            return entrenadorDatos.ObtenerEntrenadorPorAlumno(id_alumno);
        }

        public DataTable ListarAlumnosPorEntrenador(int id_entrenador)
        {
            return entrenadorDatos.ListarAlumnosPorEntrenador(id_entrenador);
        }
        public DataTable ListarEntrenadores()
        {
            return entrenadorDatos.ListarEntrenadores();
        }
        public DataTable ListarEntrenadoresConInfoCompleta()
        {
            return entrenadorDatos.ListarEntrenadoresConInfoCompleta();
        }

        public void eliminarEntrenador(string nombre, string apellido)
        {
            entrenadorDatos.EliminarEntrenador(nombre, apellido);
        }

        public int buscarEntrenador(string nombre, string apellido)
        {
            return entrenadorDatos.BuscarEntrenador(nombre, apellido);
        }
    }
}
