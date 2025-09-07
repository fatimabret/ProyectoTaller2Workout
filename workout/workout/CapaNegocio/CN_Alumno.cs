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
        public int registrar(int p_dni,string p_nombre, string p_apellido,string p_genero,string p_detalles)
        {
            Alumno alumno = new Alumno();
            alumno.dn
            return alumnoDatos.RegistrarAlumno(alumno);
        }
    }
}
