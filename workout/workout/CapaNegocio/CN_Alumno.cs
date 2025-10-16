using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaEntidad;

namespace workout.CapaNegocio
{
    public class CN_Alumno
    {
        private CD_Alumno alumnoDatos = new CD_Alumno();
        public int registrar(string p_nombre, string p_apellido, int p_dni, DateTime p_fecha_nac,string p_genero, string p_correo, string p_detalles, int p_id_entrenador)
        {
            //Crea un nuevo alumno y setea los datos
            Alumno alumno = new Alumno(p_nombre,p_apellido,p_dni,p_fecha_nac,p_genero,p_correo,p_detalles,p_id_entrenador);
            //Le pasa los datos a la capa de datos
            return alumnoDatos.RegistrarAlumno(alumno);
        }

        public int buscarAlumno(string p_nombre, string p_apellido)
        {
            return alumnoDatos.BuscarAlumno(p_nombre, p_apellido);
        }

        public DataTable buscarAlumnoDni(int p_dni)
        {
            return alumnoDatos.BuscarAlumnoDni(p_dni);
        }

        public DataTable listarAlumnos()
        {
            return alumnoDatos.ListarAlumnos();
        }

        public DataTable listarAlumnosPorEntrenador(int idEntrenador)
        {
            return alumnoDatos.ListarAlumnosPorEntrenador(idEntrenador);
        }
        public void modificarAlumno(int p_id_alumno,string p_detalles,string p_genero,int p_estado,int p_entrenador)
        {
            alumnoDatos.ModificarAlumno(p_id_alumno,p_detalles,p_genero,p_estado,p_entrenador);
        }
        public void eliminarAlumno(string p_nombre, string p_apellido)
        {
            alumnoDatos.EliminarAlumno(p_nombre, p_apellido);
        }

        public void activarAlumno(string p_nombre, string p_apellido)
        {
            alumnoDatos.ActivarAlumno(p_nombre, p_apellido);
        }
        public DataRow obtenerAlumno(string nombre, string apellido)
        {
            return alumnoDatos.ObtenerAlumno(nombre, apellido);
        }

        public DataTable ListarAlumnosConCuotaVencida()
        {
            return alumnoDatos.ObtenerAlumnosConCuotaVencida();
        }
    }
}
