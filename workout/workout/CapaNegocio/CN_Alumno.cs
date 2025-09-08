using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workout.CapaEntidad;

namespace workout.CapaNegocio
{
    public class CN_Alumno
    {
        private CD_Alumno alumnoDatos = new CD_Alumno();
        public int registrar(int p_dni,string p_nombre, string p_apellido, DateTime p_fechaNacAlumno,string p_correo,string p_genero,string p_detalles)
        {
            //Crea un nuevo alumno
            Alumno alumno = new Alumno();
            //Setea los datos de la vista
            alumno.id_alumno = p_dni;
            alumno.nombre = p_nombre;
            alumno.apellido = p_apellido;
            alumno.genero = p_genero;
            alumno.correo = p_correo;
            alumno.detalles = p_detalles;
            alumno.fecha_nac = p_fechaNacAlumno;

            //Le pasa los datos a la capa de datos
            return alumnoDatos.RegistrarAlumno(alumno);
        }
    }
}
