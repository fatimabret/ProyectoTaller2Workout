using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Alumno
    {
        public int id_alumno { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string correo { get; set; }
        public DateTime fecha_nac { get; set; }
        public int id_estado { get; set; }
        public string detalles { get; set; }
        public string genero { get; set; }

        public Alumno(string p_nombre, string p_apellido, int p_dni, DateTime p_fecha_nac, string p_genero, string p_correo,string p_detalles)
        {
            this.nombre = p_nombre;
            this.apellido = p_apellido;
            this.dni = p_dni;
            this.correo = p_correo;
            this.fecha_nac = p_fecha_nac;
            this.id_estado = 1;
            this.detalles = p_detalles;
            this.genero = p_genero;
        }

        public Alumno() { }
    }
}
