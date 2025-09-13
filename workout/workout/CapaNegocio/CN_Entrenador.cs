using System;
using System.Collections.Generic;
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
        public int registrarEntrenador(string p_nombre, string p_apellido, int p_dni, string p_correo, string p_contrasena, string p_horario_disp, string p_dias_disp, string p_detalles)
        {
            //Crea un nuevo entrenador y setea los dato
            Entrenador entrenador = new Entrenador(p_nombre, p_apellido, p_dni, p_correo, p_contrasena, p_horario_disp, p_dias_disp, p_detalles);
            
            //Le pasa los datos a la capa de datos
            return entrenadorDatos.RegistrarEntrenador(entrenador); // Retorna el ID del entrenador registrado (simulado)
        }

        public List<Entrenador> listarEntrenadores(List<Alumno> p_alumnos)
        {
            return entrenadorDatos.ListarEntrenadores(p_alumnos);
        }
    }
}
